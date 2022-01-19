using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

//PixelsToImage (below)
using System.Drawing; //Bitmap/Rectangle
using System.Drawing.Imaging; //PixelFormat
using System.Runtime.InteropServices; //Marshal

namespace Etrian_Odyssey_IV_test
{
    static class Bits { //Mainly used for getting/setting of datatypes, and some parsing of strings.
        public static byte[] openFile(string filename) {
            try {
                return System.IO.File.ReadAllBytes(filename);
                //path = filename;
            } catch {
                return null;
            }
        }
		static public byte[] openFilePart(string filename, int addr, int size)
		{
			byte[] data = new byte[size];
			using (FileStream a = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
			{ //'StreamReader '(
				a.Seek(addr, SeekOrigin.Begin);
				a.Read(data, 0, size);
				//a.Close()
			}
			return data;
		}
		static public byte[] saveFilePart(string filename, int addr, int size, byte[] data)
		{
			//byte[] data = new byte[size];
			using (FileStream a = new FileStream(filename, FileMode.Open, FileAccess.Write, FileShare.ReadWrite))
			{ //'StreamReader '(
				a.Seek(addr, SeekOrigin.Begin);
				a.Write(data, 0, size);
				//a.Close()
			}
			return data;
		}
		public static void saveFile(string filename, byte[] buffer) {
            System.IO.File.WriteAllBytes(filename, buffer);
            //path = filename;
        }
        static public int getInt16(byte[] buffer, int pos) { //(int addr)
            return buffer[pos++] | (buffer[pos] << 8);
        }
        static public int getInt16(byte[] buffer, uint pos) { //(int addr)
            return buffer[pos++] | (buffer[pos] << 8);
        }
        static public void setInt16(byte[] buffer, int pos, int value) { //(int addr)
            buffer[pos++] = (byte)value;
            buffer[pos++] = (byte)(value >> 8);
        }
        static public int getInt32(byte[] buffer, int pos) { //(int addr)
            return buffer[pos++] | (buffer[pos++] << 8) | buffer[pos++] << 16 | (buffer[pos] << 24);
        }
        static public void setInt32(byte[] buffer, int pos, int value) { //(int addr)
            buffer[pos++] = (byte)value;
            buffer[pos++] = (byte)(value >> 8);
            buffer[pos++] = (byte)(value >> 16);
            buffer[pos++] = (byte)(value >> 24);
        }
        static public uint getUInt32(byte[] buffer, int pos) { //(int addr)
            return unchecked((uint)(buffer[pos++] | (buffer[pos++] << 8) | buffer[pos++] << 16 | (buffer[pos] << 24)));
        }
		static public int getBits(byte[] buf, int addr, int numOfBits)
		{
			int value = 0;
			for (int i = 0; i < numOfBits; i += 8)
			{
				value |= buf[addr++] << i;
			}
			return value;
		}
		static public void setBits(byte[] buf, int addr, int numOfBits, int value)
		{
			for (int j = 0; j < numOfBits; j += 8)
			{
				buf[addr + (j >> 3)] = (byte)value;
				value >>= 8;
			}
		}
		//String functions!
		public static string getString(byte[] buffer, int pos, int length) {
            System.Text.StringBuilder strbuild = new System.Text.StringBuilder(16);
            while (length-- > 0) {
                strbuild.Append((char)buffer[pos++]);
            }
            return strbuild.ToString();
        }
		public static string getTextLong(byte[] txt, int index)
		{
            listWords(txt);
            //textBox1.Text = test.decompStr(test.rom, listBox2.SelectedIndex, 1);
            int srcEntry = index; byte p = 0, n = 0;
			//while ((Bits.getInt32(txt, srcEntry) != 0) || (srcEntry == 0)) {
			StringBuilder str = new StringBuilder(0x200);
			int srcPos = 0xC300 + Bits.getInt32(txt, srcEntry * 4);
			do
			{
				n = txt[srcPos++];
				if (n != 0)
				{
					if (n < 32 || n > 0x7E)
					{ //~
						str.Append('[' + (n.ToString()) + ']');
                        //Commands 17, 18, 19, 20, 26, and 29 may have args that use 1 and 3 = Skip these.
                        if ((n == 1 || n == 3) && (p < 17 || p > 20) && p != 26 && p != 29) 
						{
							str.Append("\r\n");
							//n = 0;
						}
						//   if argument2
						//   { str+='['+string(n)+']'; }
						//   if argument3 && (n==1 || n==3) && (p<17 || p>20) && p!=26 && p!=29
						//   { n=0 }
					}
					else { str.Append((char)n); }
				}
				p = n;
			} while (n != 0); //Change to while < textArray?-- No, go through offset list instead.
			return str.ToString();
		}
		//public static byte[] convertStrToRaw() { //Horrible at naming functions. :(
		//	return null;
		//}
		public static byte[] textToBytes(string[] items)
		{
			//Fix this to be similar to Dark Dawn's method? (Similar pointer list, but nothing on the 0xC300.)
			byte[] bytes = new byte[0x80000];
			int a = 0;
			int b = 0;
			for (int i = 0; i < items.Count(); i++)
			{
				bytes[a++] = (byte)b;
				bytes[a++] = (byte)(b >> 8);
				bytes[a++] = (byte)(b >> 16);
				bytes[a++] = (byte)(b >> 24);
				for (int j = 0; j < items[i].Count(); j++)
				{
					bytes[0xC300 + b++] = (byte)items[i][j];
					//if ((byte)items[i][j] != 0) { MessageBox.Show(((byte)items[i][j]).ToString("x8")); }
				}
				bytes[b++] = 0;
			}
			return bytes;
		}
		public static List<int> numList(int range)
		{
			List<int> entries = new List<int>();
			for (int i = 0; i < range; i++)
			{
				entries.Add(i); //= i;
			}
			return entries;
		}
		public static List<int> numList(int start, int range)
		{
			List<int> entries = new List<int>();
			for (int i = 0; i < range; i++)
			{
				entries.Add(start + i); //= i;
			}
			return entries;
		}
		public static string getTextShort(byte[] txt, int index)//, string str2show = "") //Returns one-liners for lists/etc.
		{
			byte p = 0, n = 0;
			//int ind = sortList[index];
			StringBuilder str = new StringBuilder(0x200);
			//str.Append((index).ToString().PadLeft(5, ' ') + "|");
			if (index < 0)
				return ""; //Blank string in case -1 should be used!
			int srcPos = Bits.getInt32(txt, index << 2);
			//int srcPos = 0xC300 + Bits.getInt32(txt, index << 2);
			if (Bits.getInt32(txt, 0) == 0)
				srcPos += 0xC300;
			//if (str2show != "")
			//{
			//	int i = 0;
			//}
			do
			{
				n = txt[srcPos++];
				if (n != 0)
				{
					if (n < 32 || n > 0x7E)
					{ //~
						str.Append('[' + (n.ToString()) + ']');
                        //Commands 17, 18, 19, 20, 26, and 29 may have args that use 1 and 3 = Skip these.
                        if ((n == 1 || n == 3) && (p < 17 || p > 20) && p != 26 && p != 29) { n = 0; }
						//   if argument2
						//   { str+='['+string(n)+']'; }
						//   if argument3 && (n==1 || n==3) && (p<17 || p>20) && p!=26 && p!=29
						//   { n=0 }
					}
					else { str.Append((char)n); }
				}
				p = n;
			} while (n != 0); //Change to while < textArray?-- No, go through offset list instead.
			return str.ToString();
		}
        static int qq = 0;
        public static void listWords(byte[] txt)
        {
            //if (qq == 1)
                return;
            qq++;//Console.Write("YYYY");
            byte p = 0, n = 0;
            //int ind = sortList[index];
            int limit = 15000;
            string[] words = new string[limit];
            int[] freq = new int[limit];
            int wordCount = 0;
            StringBuilder str = new StringBuilder(0x200);
            //str.Append((index).ToString().PadLeft(5, ' ') + "|");
            for (int index = 0; index < 12461; index++)
            {
                int srcPos = Bits.getInt32(txt, index << 2);
                //int srcPos = 0xC300 + Bits.getInt32(txt, index << 2);
                if (Bits.getInt32(txt, 0) == 0)
                    srcPos += 0xC300;
                do
                {
                    n = txt[srcPos++];
                    if ((n > 0x40) && (n != 0xDF))
                    {
                        n |= 0x20;
                    }
                    //if (((n|0x20) < 0x61 || (n|0x20) > 0x7A) && (n != 0x27)) //if (n < 32 || n > 0x7E || n == 0x20)
                    if ((n == 0x27)
                        || (n >= 0x61 && n <= 0x7A)
                        || (n >= 0xDF)
                        )
                    {
                        str.Append((char)n);
                    }
                    else
                    {
                        //add word to list
                        if (str.Length > 0)
                        {
                            string str2 = str.ToString();
                            str.Clear();
                            if (wordCount == limit) { break; }
                            int i = 0;
                            for (; i < wordCount; i++)
                            {
                                if (words[i] == str2)
                                {
                                    freq[i]++; break;
                                }
                            }
                            if (i == wordCount)
                            {
                                words[i] = str2;
                                freq[i]++;
                                wordCount++;
                            }
                        }

                    }
                        //else { str.Append((char)(n|0x20)); }
                    //}
                    //p = n;
                } while (n != 0);
            }
            for (int i = 0; i < wordCount; i++)
            {
                words[i] = (i+1).ToString() + "\t" + words[i] + "\t" + freq[i];
            }
            //System.IO.File.WriteAllLines(@"C:\Users\tmttb\OneDrive\Desktop\gswordsitalian.txt", words);
        }

		public static string getText2(byte[] buffer, int index) //int address) //Dark Dawn
		{
			System.Text.StringBuilder strbuild = new StringBuilder(0x200);
			//int addr2 = Bits.getInt32(buffer, address) + 0x220B80;
			int addr2 = Bits.getInt32(buffer, 0x220B80 + index * 4) + 0x220B80;
			int length = 2000; int pos = addr2 & 0xFFFFFF;
			//MessageBox.Show(addr2.ToString("x8"));
			while (length-- > 0)
			{
				int c = Bits.getInt16(buffer, pos); pos += 2;
				if (c == 0)
					break;
				if ((c < 0x100) && (c > 0xF))
					strbuild.Append((char)c);
				else
					strbuild.Append("[" + c.ToString("X4") + "]");
			}
			return strbuild.ToString();
		}
		public static List<int> getTextMatches(byte[] txt, String str, List<int> items) //, int[] matchList)
		{
			//String str = textBox2.Text;
			byte[] bytes = new byte[0x200];
			int a = 0, b = 0;
			while (a < str.Length)
			{ //Turn text to raw string. (Convert the [#]'s.)
				if (str[a] == '[')
				{
					int num = 0;
					//while (str[++a] != ']')
					while ((++a < str.Length) && (str[a] != ']'))
					{
						num = (num * 10) + (byte)(str[a]) - 0x30;
					}
					a++;
					bytes[b++] = (byte)num;
				}
				else if (((byte)str[a] == 13) && ((byte)str[a + 1] == 10)) { a += 2; }
				else { bytes[b++] = (byte)str[a++]; }
			}
			//b++; //B/c 00 character at end.
            List<int> matchList = new List<int>();
			for (int i = 0; i < items.Count(); i++) // (true)//(Bits.getInt32(txt, srcEntry) != 0) || (srcEntry == 0))
			{
                int srcEntry = items[i] * 4;
                if ((srcEntry < 0) || (srcEntry > 12460 * 4)) // Entries of -1 Should be skipped unless not searching.
                {
                    if (bytes[0] == 0) { matchList.Add(i); }
                    continue;
                }
                int srcPos = 0xC300 + Bits.getInt32(txt, srcEntry);// * 4);
                int n = 0;//int n = txt[srcPos++];
				while (true)
				{	
                    if (bytes[n] == 0) { matchList.Add(i); break; } //add this entry.
                    if (txt[srcPos + n] == 0) { break; }; //Match not found in text.
                    if (txt[srcPos + n] == bytes[n]) { n++; continue; }
                    //Not case sensitive check:
                    if (((txt[srcPos + n] & 0xDF) >= 0x41) && (((txt[srcPos + n] & 0xDF) <= 0x5A))) //Letters-only
                        if ((txt[srcPos + n] ^ 0x20) == bytes[n]) { n++; continue; } //Not case-sensitive
                    srcPos++; n = 0; //Character not matched.
				}
			}
			return matchList;
		}
		public static List<int> getTextMatches2(byte[] txt, String str, List<int> items) //, int[] matchList)
		{
			//String str = textBox2.Text;
			byte[] bytes = new byte[0x200];
			int a = 0, b = 0;
			while (a < str.Length)
			{ //Turn text to raw string. (Convert the [#]'s.)
				if (str[a] == '[')
				{
					int num = 0;
					while (str[++a] != ']')
					{
						int n = str[a];
						if ((n >= 0x41) && (n <= 0x46))
							num = (num * 16) + 10 + (n - 0x41);
						else if ((n >= 0x61) && (n <= 0x66))
							num = (num * 16) + 10 + (n - 0x61);
						else
							num = (num * 16) + (byte)(str[a]) - 0x30;
					}
					a++;
					bytes[b++] = (byte)num;
				}
				else if (((byte)str[a] == 13) && ((byte)str[a + 1] == 10))
				{
					a += 2;
				}
				else
				{
					bytes[b++] = (byte)str[a++];
				}
			}
            //b++; //B/c 00 character at end.
            List<int> matchList = new List<int>();
            for (int i = 0; i < items.Count(); i++) // (true)//(Bits.getInt32(txt, srcEntry) != 0) || (srcEntry == 0))
            {
                int srcEntry = items[i] * 4;
                if ((srcEntry < 0) || (srcEntry > 12460 * 4)) // Entries of -1 Should be skipped unless not searching.
                {
                    if (bytes[0] == 0) { matchList.Add(i); }
                    continue;
                }
                int srcPos = Bits.getInt32(txt, 0x220B80 + srcEntry) + 0x220B80;
                int n = 0;//int n = txt[srcPos++];
                while (true)
                {
                    if (bytes[n] == 0) { matchList.Add(i); break; } //add this entry.
                    if (txt[srcPos + n] == 0) { break; }; //Match not found in text.
                    if (txt[srcPos + n] == bytes[n]) { n++; continue; }
                    //Not case sensitive check:
                    if (((txt[srcPos + n] & 0xDF) >= 0x41) && (((txt[srcPos + n] & 0xDF) <= 0x5A))) //Letters-only
                        if ((txt[srcPos + n] ^ 0x20) == bytes[n]) { n++; continue; } //Not case-sensitive
                    srcPos++; n = 0; //Character not matched.
                }
            }
			return matchList;
		}

        //Only needed to display zoomed in Palette bitmap,
        public static Bitmap PixelsToImage(int[] array, int width, int height, int zoom)
        {
            if (zoom <= 0) { return new Bitmap(1, 1); }
            int[] array2 = new int[width * height * zoom * zoom];
            //for (int i = 0; i < (width * height); i++) {
            int i = 0;
            for (int yt = 0; yt < (height * zoom) * (width * zoom); yt += (width * zoom) * zoom)
            {
                for (int xt = yt; xt < yt + (width * zoom); xt += zoom)
                {
                    int palt = array[i++];
                    for (int y = xt; y < xt + (width * zoom) * zoom; y += (width * zoom))
                    {
                        for (int x = y; x < y + zoom; x++)
                        {
                            array2[x] = palt;
                        }
                    }
                }
            }
            return PixelsToImage(array2, width * zoom, height * zoom);
        }
        public static Bitmap PixelsToImage(int[] array, int width, int height)
        {
            Bitmap bitmap = new Bitmap(width, height, PixelFormat.Format32bppRgb);
            Rectangle rect = new Rectangle(0, 0, bitmap.Width, bitmap.Height);
            BitmapData bitmapData = bitmap.LockBits(rect, ImageLockMode.ReadWrite, bitmap.PixelFormat);
            IntPtr pNative = bitmapData.Scan0;
            Marshal.Copy(array, 0, pNative, width * height);
            bitmap.UnlockBits(bitmapData);
            return bitmap;
        }
    }
}
