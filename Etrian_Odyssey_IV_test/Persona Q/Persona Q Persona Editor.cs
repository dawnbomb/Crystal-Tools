using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using Microsoft.Win32;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace Etrian_Odyssey_IV_test
{
    public partial class FormQPersonaEditor : Form
    {
        String treeloaded = "No";
        byte[] personadata_array; //This starts the array, the name after is what i name this array?
        byte[] subpersonadata_array; //This starts the array, the name after is what i name this array?
        public FormQPersonaEditor()
        {
            InitializeComponent();

            //setting up stuff for Main Persona Loading
            string personadata_path = Properties.Settings.Default.PQRomFS + "\\battle\\table\\datpersonaformat.tbl"; //This defines the path as a string, so i can refer to it by this string/name instead of the full path every time
            int personadata_length = (int)(new FileInfo(personadata_path).Length);   //The leagth of the array?
            personadata_array = File.ReadAllBytes(personadata_path);  //loads an array with whatever is in the path

            //setting up stuff for Sub Persona Loading
            string subpersonadata_path = Properties.Settings.Default.PQRomFS + "\\battle\\table\\datsubpersonagrowth.tbl"; //This defines the path as a string, so i can refer to it by this string/name instead of the full path every time
            int subpersonadata_length = (int)(new FileInfo(subpersonadata_path).Length);   //The leagth of the array?
            subpersonadata_array = File.ReadAllBytes(subpersonadata_path);  //loads an array with whatever is in the path


            //Add the EO1 enemy list to the in editor list of enemy names
            enemyTree.Nodes.Add("BLANK");
            enemyTree.Nodes.Add("RESERVE");
            enemyTree.Nodes.Add("Slime");
            enemyTree.Nodes.Add("Ame-no-Uzume");
            enemyTree.Nodes.Add("Legion");
            enemyTree.Nodes.Add("Ose");
            enemyTree.Nodes.Add("Black Frost");
            enemyTree.Nodes.Add("Decarabia");
            enemyTree.Nodes.Add("Shiki-Ouji");
            enemyTree.Nodes.Add("Loki");
            enemyTree.Nodes.Add("Agathion");
            enemyTree.Nodes.Add("Orobas");
            enemyTree.Nodes.Add("Jack Frost");
            enemyTree.Nodes.Add("Hua Po");
            enemyTree.Nodes.Add("Pyro Jack");
            enemyTree.Nodes.Add("Dis");
            enemyTree.Nodes.Add("Rangda");
            enemyTree.Nodes.Add("Jinn");
            enemyTree.Nodes.Add("Surt");
            enemyTree.Nodes.Add("Mada");
            enemyTree.Nodes.Add("Koropokkur");
            enemyTree.Nodes.Add("Sarasvati");
            enemyTree.Nodes.Add("High Pixie");
            enemyTree.Nodes.Add("Ganga");
            enemyTree.Nodes.Add("Parvati");
            enemyTree.Nodes.Add("Kikuri-Hime");
            enemyTree.Nodes.Add("Hariti");
            enemyTree.Nodes.Add("Tzitzimitl");
            enemyTree.Nodes.Add("Scathach");
            enemyTree.Nodes.Add("Yaksini");
            enemyTree.Nodes.Add("Titania");
            enemyTree.Nodes.Add("Gorgon");
            enemyTree.Nodes.Add("Gabriel");
            enemyTree.Nodes.Add("Skadi");
            enemyTree.Nodes.Add("Mother Harlot");
            enemyTree.Nodes.Add("Laksmi");
            enemyTree.Nodes.Add("Oberon");
            enemyTree.Nodes.Add("King Frost");
            enemyTree.Nodes.Add("Setanta");
            enemyTree.Nodes.Add("Mezuki");
            enemyTree.Nodes.Add("Oukuninushi");
            enemyTree.Nodes.Add("Thoth");
            enemyTree.Nodes.Add("Ouyamatsumi");
            enemyTree.Nodes.Add("Pabilsag");
            enemyTree.Nodes.Add("Kingu");
            enemyTree.Nodes.Add("Barong");
            enemyTree.Nodes.Add("Odin");
            enemyTree.Nodes.Add("Anzu");
            enemyTree.Nodes.Add("Shiisaa");
            enemyTree.Nodes.Add("Unicorn");
            enemyTree.Nodes.Add("Gozuki");
            enemyTree.Nodes.Add("Flauros");
            enemyTree.Nodes.Add("Daisoujou");
            enemyTree.Nodes.Add("Hachiman");
            enemyTree.Nodes.Add("Kohryu");
            enemyTree.Nodes.Add("Pixie");
            enemyTree.Nodes.Add("Alp");
            enemyTree.Nodes.Add("Moh Shuvuu");
            enemyTree.Nodes.Add("Queen Mab");
            enemyTree.Nodes.Add("Leanan Sidhe");
            enemyTree.Nodes.Add("Raphael");
            enemyTree.Nodes.Add("Cybele");
            enemyTree.Nodes.Add("Ishtar");
            enemyTree.Nodes.Add("Nata Taishi");
            enemyTree.Nodes.Add("Chimera");
            enemyTree.Nodes.Add("Eligor");
            enemyTree.Nodes.Add("Nezha");
            enemyTree.Nodes.Add("Ares");
            enemyTree.Nodes.Add("Oumitsunu");
            enemyTree.Nodes.Add("Triglav");
            enemyTree.Nodes.Add("Thor");
            enemyTree.Nodes.Add("Ophanim");
            enemyTree.Nodes.Add("Atavaka");
            enemyTree.Nodes.Add("Futsunushi");
            enemyTree.Nodes.Add("Angel");
            enemyTree.Nodes.Add("Power");
            enemyTree.Nodes.Add("Virtue");
            enemyTree.Nodes.Add("Throne");
            enemyTree.Nodes.Add("Uriel");
            enemyTree.Nodes.Add("Melchizedek");
            enemyTree.Nodes.Add("Sraosha");
            enemyTree.Nodes.Add("Azumi");
            enemyTree.Nodes.Add("Ippon-Datara");
            enemyTree.Nodes.Add("Mothman");
            enemyTree.Nodes.Add("Hitokotonusi");
            enemyTree.Nodes.Add("Kurama Tengu");
            enemyTree.Nodes.Add("Niddhoggr");
            enemyTree.Nodes.Add("Nebiros");
            enemyTree.Nodes.Add("Arahabaki");
            enemyTree.Nodes.Add("Ongyo-ki");
            enemyTree.Nodes.Add("Empusa");
            enemyTree.Nodes.Add("Raiju");
            enemyTree.Nodes.Add("Fortuna");
            enemyTree.Nodes.Add("Clotho");
            enemyTree.Nodes.Add("Lachesis");
            enemyTree.Nodes.Add("Ananta");
            enemyTree.Nodes.Add("Atropos");
            enemyTree.Nodes.Add("Norn");
            enemyTree.Nodes.Add("Pazuzu");
            enemyTree.Nodes.Add("Sandman");
            enemyTree.Nodes.Add("Valkyrie");
            enemyTree.Nodes.Add("Rakshasa");
            enemyTree.Nodes.Add("Tsuchigumo");
            enemyTree.Nodes.Add("Oni");
            enemyTree.Nodes.Add("Hanuman");
            enemyTree.Nodes.Add("Siegfried");
            enemyTree.Nodes.Add("Kali");
            enemyTree.Nodes.Add("Zaou-Gongen");
            enemyTree.Nodes.Add("Onmoraki");
            enemyTree.Nodes.Add("Berith");
            enemyTree.Nodes.Add("Ikusa");
            enemyTree.Nodes.Add("Orthrus");
            enemyTree.Nodes.Add("Yatsufusa");
            enemyTree.Nodes.Add("Basilisk");
            enemyTree.Nodes.Add("Hell Biker");
            enemyTree.Nodes.Add("Vasuki");
            enemyTree.Nodes.Add("Attis");
            enemyTree.Nodes.Add("Mokoi");
            enemyTree.Nodes.Add("Turdak");
            enemyTree.Nodes.Add("Matador");
            enemyTree.Nodes.Add("White Rider");
            enemyTree.Nodes.Add("Samael");
            enemyTree.Nodes.Add("Mot");
            enemyTree.Nodes.Add("Pale Rider");
            enemyTree.Nodes.Add("Alice");
            enemyTree.Nodes.Add("Mahakala");
            enemyTree.Nodes.Add("Apsaras");
            enemyTree.Nodes.Add("Xiezhai");
            enemyTree.Nodes.Add("Mithra");
            enemyTree.Nodes.Add("Genbu");
            enemyTree.Nodes.Add("Seiryu");
            enemyTree.Nodes.Add("Suzaku");
            enemyTree.Nodes.Add("Byakko");
            enemyTree.Nodes.Add("Vishnu");
            enemyTree.Nodes.Add("Ukobach");
            enemyTree.Nodes.Add("Incubus");
            enemyTree.Nodes.Add("Succubus");
            enemyTree.Nodes.Add("Lilith");
            enemyTree.Nodes.Add("Belphegor");
            enemyTree.Nodes.Add("Belial");
            enemyTree.Nodes.Add("Astaroth");
            enemyTree.Nodes.Add("Beelzebub");
            enemyTree.Nodes.Add("Cu Chulainn");
            enemyTree.Nodes.Add("Abaddon");
            enemyTree.Nodes.Add("Mara");
            enemyTree.Nodes.Add("Seiten Taisei");
            enemyTree.Nodes.Add("Yoshitsune");
            enemyTree.Nodes.Add("Masakado");
            enemyTree.Nodes.Add("Shiva");
            enemyTree.Nodes.Add("Chi You");
            enemyTree.Nodes.Add("Kaiwan");
            enemyTree.Nodes.Add("Nue");
            enemyTree.Nodes.Add("Neko Shogun");
            enemyTree.Nodes.Add("Ganesha");
            enemyTree.Nodes.Add("Garuda");
            enemyTree.Nodes.Add("Kartikeya");
            enemyTree.Nodes.Add("Saturnus");
            enemyTree.Nodes.Add("Helel");
            enemyTree.Nodes.Add("Andras");
            enemyTree.Nodes.Add("Nozuchi");
            enemyTree.Nodes.Add("Orochi");
            enemyTree.Nodes.Add("Alraune");
            enemyTree.Nodes.Add("Girimehkala");
            enemyTree.Nodes.Add("Mishaguji");
            enemyTree.Nodes.Add("Chernobog");
            enemyTree.Nodes.Add("Seth");
            enemyTree.Nodes.Add("Baal Zebul");
            enemyTree.Nodes.Add("Sandalphon");
            enemyTree.Nodes.Add("Cu Sith");
            enemyTree.Nodes.Add("Phoenix");
            enemyTree.Nodes.Add("Yatagarasu");
            enemyTree.Nodes.Add("Narasimha");
            enemyTree.Nodes.Add("Tam Lin");
            enemyTree.Nodes.Add("Jatayu");
            enemyTree.Nodes.Add("Suparna");
            enemyTree.Nodes.Add("Asura");
            enemyTree.Nodes.Add("Red Rider");
            enemyTree.Nodes.Add("Anubis");
            enemyTree.Nodes.Add("Black Rider");
            enemyTree.Nodes.Add("Trumpeter");
            enemyTree.Nodes.Add("Michael");
            enemyTree.Nodes.Add("Satan");
            enemyTree.Nodes.Add("Metatron");
            enemyTree.Nodes.Add("Ardha");
            enemyTree.Nodes.Add("Lucifer");
            enemyTree.Nodes.Add("Warrior Zeus");
            enemyTree.Nodes.Add("Zeus");
            enemyTree.Nodes.Add("Archangel");
            enemyTree.Nodes.Add("Alilat");
            enemyTree.Nodes.Add("Dominion");
            enemyTree.Nodes.Add("Turdak");
            enemyTree.Nodes.Add("Basilisk");
            enemyTree.Nodes.Add("Ouyamatsumi");
            enemyTree.Nodes.Add("Warrior Zeus");
            enemyTree.Nodes.Add("Zeus");
            enemyTree.Nodes.Add("Siegfried");
            enemyTree.Nodes.Add("Oberon");
            enemyTree.Nodes.Add("Cu Chulainn");
            enemyTree.Nodes.Add("Asura");
            enemyTree.Nodes.Add("Loki");
            enemyTree.Nodes.Add("Okuninushi");
            enemyTree.Nodes.Add("Odin");
            enemyTree.Nodes.Add("Yoshitsune");
            enemyTree.Nodes.Add("Helel");
            enemyTree.Nodes.Add("Black Frost");
            enemyTree.Nodes.Add("Surt");
            enemyTree.Nodes.Add("Jack Frost");
            enemyTree.Nodes.Add("Thor");
            enemyTree.Nodes.Add("Thanatos");
            enemyTree.Nodes.Add("Kaguya");
            enemyTree.Nodes.Add("Magatsu-Izanagi");
            enemyTree.Nodes.Add("Orpheus Telos");
            enemyTree.Nodes.Add("Kamui-Moshiri");
            enemyTree.Nodes.Add("Kouzeon");
            enemyTree.Nodes.Add("Sumeo-Okami");
            enemyTree.Nodes.Add("Takeji Zaiten");
            enemyTree.Nodes.Add("Takehaya Susano-o");
            enemyTree.Nodes.Add("Haraedo-no-Okami");
            enemyTree.Nodes.Add("Yamato Sumeragi");
            enemyTree.Nodes.Add("Shiva");
            enemyTree.Nodes.Add("Vishnu");
            enemyTree.Nodes.Add("Legion");
            enemyTree.Nodes.Add("Masakado");
            enemyTree.Nodes.Add("Alice");
            enemyTree.Nodes.Add("Kohryu");
            enemyTree.Nodes.Add("Sandalphon");
            enemyTree.Nodes.Add("Beelzebub");
            enemyTree.Nodes.Add("Satan");
            enemyTree.Nodes.Add("Trumpeter");
            enemyTree.Nodes.Add("Lilith");
            enemyTree.Nodes.Add("Michael");
            enemyTree.Nodes.Add("Uriel");
            enemyTree.Nodes.Add("Gabriel");
            enemyTree.Nodes.Add("Raphael");
            enemyTree.Nodes.Add("0x0EA");
            enemyTree.Nodes.Add("0x0EB");
            enemyTree.Nodes.Add("0x0EC");
            enemyTree.Nodes.Add("0x0ED");
            enemyTree.Nodes.Add("0x0EE");
            enemyTree.Nodes.Add("0x0EF");
            enemyTree.Nodes.Add("Izanagi");
            enemyTree.Nodes.Add("Izanagi-no-Okami+");
            enemyTree.Nodes.Add("Orpheus");
            enemyTree.Nodes.Add("Messiah+");
            enemyTree.Nodes.Add("Jiraiya");
            enemyTree.Nodes.Add("Susano-o+");
            enemyTree.Nodes.Add("Tomoe");
            enemyTree.Nodes.Add("Suzuka Gongen+");
            enemyTree.Nodes.Add("Konohana Sakuya");
            enemyTree.Nodes.Add("Amaterasu+");
            enemyTree.Nodes.Add("Himiko");
            enemyTree.Nodes.Add("Kanzeon+");
            enemyTree.Nodes.Add("Take-Mikazuchi");
            enemyTree.Nodes.Add("Rokuten Maou+");
            enemyTree.Nodes.Add("Sukuna-Hikona");
            enemyTree.Nodes.Add("Yamato Takeru+");
            enemyTree.Nodes.Add("Kintoki-Douji");
            enemyTree.Nodes.Add("Kamui+");
            enemyTree.Nodes.Add("Io");
            enemyTree.Nodes.Add("Isis+");
            enemyTree.Nodes.Add("Hermes");
            enemyTree.Nodes.Add("Trismegistus+");
            enemyTree.Nodes.Add("Polydeuces");
            enemyTree.Nodes.Add("Caesar+");
            enemyTree.Nodes.Add("Penthesilea");
            enemyTree.Nodes.Add("Artemisia+");
            enemyTree.Nodes.Add("Lucia");
            enemyTree.Nodes.Add("Juno+");
            enemyTree.Nodes.Add("Palladion");
            enemyTree.Nodes.Add("Athena+");
            enemyTree.Nodes.Add("Nemesis");
            enemyTree.Nodes.Add("Kala-Nemi+");
            enemyTree.Nodes.Add("Cerberus");
            enemyTree.Nodes.Add("Cerberus+");
            enemyTree.Nodes.Add("Castor");
            enemyTree.Nodes.Add("Castor+");
            enemyTree.Nodes.Add("Zen");
            enemyTree.Nodes.Add("Zen+?");
            enemyTree.Nodes.Add("Rei");
            enemyTree.Nodes.Add("Stuffed Doll");
            enemyTree.Nodes.Add("0x118");
            enemyTree.Nodes.Add("0x119");
            enemyTree.Nodes.Add("0x11A");
            enemyTree.Nodes.Add("0x11B");
            enemyTree.Nodes.Add("0x11C");
            enemyTree.Nodes.Add("0x11D");
            enemyTree.Nodes.Add("0x11E");
            enemyTree.Nodes.Add("0x11F");

            TreeNodeCollection nodeCollect = enemyTree.Nodes;
            enemyTree.SelectedNode = nodeCollect[0];
        }

        private void FormQPersonaEditor_Load(object sender, EventArgs e)
        {

        }

        private void enemyTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //Value 1 is distance / offset from the start of the file to the start of the array ("Start" in 010) (The first byte is 0) 
            //Value 2 is how many bytes / hexes are in a "row"   (First byte is 1 NOT 0)
            //Value 3 is how many bytes into the row info starts (The first byte is byte 0)

            richTextBoxLv.Text = personadata_array[0 + (enemyTree.SelectedNode.Index * 148) + 3].ToString("D");
            richTextBoxArcana.Text = personadata_array[0 + (enemyTree.SelectedNode.Index * 148) + 2].ToString("D");

            richTextBoxStr.Text = BitConverter.ToUInt16(personadata_array, 0 + (enemyTree.SelectedNode.Index * 148) + 8).ToString("D");
            richTextBoxMag.Text = BitConverter.ToUInt16(personadata_array, 0 + (enemyTree.SelectedNode.Index * 148) + 10).ToString("D");
            richTextBoxEn.Text = BitConverter.ToUInt16(personadata_array, 0 + (enemyTree.SelectedNode.Index * 148) + 12).ToString("D");
            richTextBoxAgi.Text = BitConverter.ToUInt16(personadata_array, 0 + (enemyTree.SelectedNode.Index * 148) + 14).ToString("D");
            richTextBoxLuck.Text = BitConverter.ToUInt16(personadata_array, 0 + (enemyTree.SelectedNode.Index * 148) + 16).ToString("D");

            richTextBoxCut.Text = BitConverter.ToUInt16(personadata_array, 0 + (enemyTree.SelectedNode.Index * 148) + 18).ToString("D");
            richTextBoxStab.Text = BitConverter.ToUInt16(personadata_array, 0 + (enemyTree.SelectedNode.Index * 148) + 20).ToString("D");
            richTextBoxBash.Text = BitConverter.ToUInt16(personadata_array, 0 + (enemyTree.SelectedNode.Index * 148) + 22).ToString("D");
            richTextBoxFire.Text = BitConverter.ToUInt16(personadata_array, 0 + (enemyTree.SelectedNode.Index * 148) + 24).ToString("D");
            richTextBoxIce.Text = BitConverter.ToUInt16(personadata_array, 0 + (enemyTree.SelectedNode.Index * 148) + 26).ToString("D");
            richTextBoxElec.Text = BitConverter.ToUInt16(personadata_array, 0 + (enemyTree.SelectedNode.Index * 148) + 28).ToString("D");
            richTextBoxWind.Text = BitConverter.ToUInt16(personadata_array, 0 + (enemyTree.SelectedNode.Index * 148) + 30).ToString("D");
            richTextBoxLight.Text = BitConverter.ToUInt16(personadata_array, 0 + (enemyTree.SelectedNode.Index * 148) + 32).ToString("D");
            richTextBoxDark.Text = BitConverter.ToUInt16(personadata_array, 0 + (enemyTree.SelectedNode.Index * 148) + 34).ToString("D");



            richTextBoxLearnLv1.Text = subpersonadata_array[0 + (enemyTree.SelectedNode.Index * 72) + 8].ToString("D");
            richTextBoxLearnLv2.Text = subpersonadata_array[0 + (enemyTree.SelectedNode.Index * 72) + 12].ToString("D");
            richTextBoxLearnLv3.Text = subpersonadata_array[0 + (enemyTree.SelectedNode.Index * 72) + 16].ToString("D");
            richTextBoxLearnLv4.Text = subpersonadata_array[0 + (enemyTree.SelectedNode.Index * 72) + 20].ToString("D");
            richTextBoxLearnLv5.Text = subpersonadata_array[0 + (enemyTree.SelectedNode.Index * 72) + 24].ToString("D");
            richTextBoxLearnLv6.Text = subpersonadata_array[0 + (enemyTree.SelectedNode.Index * 72) + 28].ToString("D");
            richTextBoxLearnLv7.Text = subpersonadata_array[0 + (enemyTree.SelectedNode.Index * 72) + 32].ToString("D");
            richTextBoxLearnLv8.Text = subpersonadata_array[0 + (enemyTree.SelectedNode.Index * 72) + 36].ToString("D");

            richTextBoxLearnFlag1.Text = subpersonadata_array[0 + (enemyTree.SelectedNode.Index * 72) + 9].ToString("D");
            richTextBoxLearnFlag2.Text = subpersonadata_array[0 + (enemyTree.SelectedNode.Index * 72) + 13].ToString("D");
            richTextBoxLearnFlag3.Text = subpersonadata_array[0 + (enemyTree.SelectedNode.Index * 72) + 17].ToString("D");
            richTextBoxLearnFlag4.Text = subpersonadata_array[0 + (enemyTree.SelectedNode.Index * 72) + 21].ToString("D");
            richTextBoxLearnFlag5.Text = subpersonadata_array[0 + (enemyTree.SelectedNode.Index * 72) + 25].ToString("D");
            richTextBoxLearnFlag6.Text = subpersonadata_array[0 + (enemyTree.SelectedNode.Index * 72) + 29].ToString("D");
            richTextBoxLearnFlag7.Text = subpersonadata_array[0 + (enemyTree.SelectedNode.Index * 72) + 33].ToString("D");
            richTextBoxLearnFlag8.Text = subpersonadata_array[0 + (enemyTree.SelectedNode.Index * 72) + 37].ToString("D");

            richTextBoxLearnSkill1.Text = subpersonadata_array[0 + (enemyTree.SelectedNode.Index * 72) + 10].ToString("D");
            richTextBoxLearnSkill2.Text = subpersonadata_array[0 + (enemyTree.SelectedNode.Index * 72) + 14].ToString("D");
            richTextBoxLearnSkill3.Text = subpersonadata_array[0 + (enemyTree.SelectedNode.Index * 72) + 18].ToString("D");
            richTextBoxLearnSkill4.Text = subpersonadata_array[0 + (enemyTree.SelectedNode.Index * 72) + 22].ToString("D");
            richTextBoxLearnSkill5.Text = subpersonadata_array[0 + (enemyTree.SelectedNode.Index * 72) + 26].ToString("D");
            richTextBoxLearnSkill6.Text = subpersonadata_array[0 + (enemyTree.SelectedNode.Index * 72) + 30].ToString("D");
            richTextBoxLearnSkill7.Text = subpersonadata_array[0 + (enemyTree.SelectedNode.Index * 72) + 34].ToString("D");
            richTextBoxLearnSkill8.Text = subpersonadata_array[0 + (enemyTree.SelectedNode.Index * 72) + 38].ToString("D");

            richTextBoxUnknown1.Text = subpersonadata_array[0 + (enemyTree.SelectedNode.Index * 72) + 11].ToString("D");
            richTextBoxUnknown2.Text = subpersonadata_array[0 + (enemyTree.SelectedNode.Index * 72) + 15].ToString("D");
            richTextBoxUnknown3.Text = subpersonadata_array[0 + (enemyTree.SelectedNode.Index * 72) + 19].ToString("D");
            richTextBoxUnknown4.Text = subpersonadata_array[0 + (enemyTree.SelectedNode.Index * 72) + 23].ToString("D");
            richTextBoxUnknown5.Text = subpersonadata_array[0 + (enemyTree.SelectedNode.Index * 72) + 27].ToString("D");
            richTextBoxUnknown6.Text = subpersonadata_array[0 + (enemyTree.SelectedNode.Index * 72) + 31].ToString("D");
            richTextBoxUnknown7.Text = subpersonadata_array[0 + (enemyTree.SelectedNode.Index * 72) + 35].ToString("D");
            richTextBoxUnknown8.Text = subpersonadata_array[0 + (enemyTree.SelectedNode.Index * 72) + 39].ToString("D");

            //Unknown main-persona values
            richTextBoxUnknownMain0.Text = personadata_array[0 + (enemyTree.SelectedNode.Index * 148) + 0].ToString("D");
            richTextBoxUnknownMain1.Text = personadata_array[0 + (enemyTree.SelectedNode.Index * 148) + 1].ToString("D");
            richTextBoxUnknownMain01.Text = BitConverter.ToUInt16(personadata_array, 0 + (enemyTree.SelectedNode.Index * 148) + 0).ToString("D");
            richTextBoxUnknownMain45.Text = BitConverter.ToUInt16(personadata_array, 0 + (enemyTree.SelectedNode.Index * 148) + 4).ToString("D");
            richTextBoxUnknownMain67.Text = BitConverter.ToUInt16(personadata_array, 0 + (enemyTree.SelectedNode.Index * 148) + 6).ToString("D");

            richTextBoxAilment1.Text = BitConverter.ToUInt16(personadata_array, 0 + (enemyTree.SelectedNode.Index * 148) + 36).ToString("D");
            richTextBoxAilment2.Text = BitConverter.ToUInt16(personadata_array, 0 + (enemyTree.SelectedNode.Index * 148) + 38).ToString("D");
            richTextBoxAilment3.Text = BitConverter.ToUInt16(personadata_array, 0 + (enemyTree.SelectedNode.Index * 148) + 40).ToString("D");
            richTextBoxAilment4.Text = BitConverter.ToUInt16(personadata_array, 0 + (enemyTree.SelectedNode.Index * 148) + 42).ToString("D");
            richTextBoxAilment5.Text = BitConverter.ToUInt16(personadata_array, 0 + (enemyTree.SelectedNode.Index * 148) + 44).ToString("D");
            richTextBoxAilment6.Text = BitConverter.ToUInt16(personadata_array, 0 + (enemyTree.SelectedNode.Index * 148) + 46).ToString("D");
            richTextBoxAilment7.Text = BitConverter.ToUInt16(personadata_array, 0 + (enemyTree.SelectedNode.Index * 148) + 48).ToString("D");
            richTextBoxAilment8.Text = BitConverter.ToUInt16(personadata_array, 0 + (enemyTree.SelectedNode.Index * 148) + 50).ToString("D");
            richTextBoxAilment9.Text = BitConverter.ToUInt16(personadata_array, 0 + (enemyTree.SelectedNode.Index * 148) + 52).ToString("D");
            
            richTextBoxAilment10.Text = BitConverter.ToUInt16(personadata_array, 0 + (enemyTree.SelectedNode.Index * 148) + 54).ToString("D");
            richTextBoxAilment11.Text = BitConverter.ToUInt16(personadata_array, 0 + (enemyTree.SelectedNode.Index * 148) + 56).ToString("D");
            richTextBoxAilment12.Text = BitConverter.ToUInt16(personadata_array, 0 + (enemyTree.SelectedNode.Index * 148) + 58).ToString("D");
            richTextBoxAilment13.Text = BitConverter.ToUInt16(personadata_array, 0 + (enemyTree.SelectedNode.Index * 148) + 60).ToString("D");
            richTextBoxAilment14.Text = BitConverter.ToUInt16(personadata_array, 0 + (enemyTree.SelectedNode.Index * 148) + 62).ToString("D");
            richTextBoxAilment15.Text = BitConverter.ToUInt16(personadata_array, 0 + (enemyTree.SelectedNode.Index * 148) + 64).ToString("D");
            richTextBoxAilment16.Text = BitConverter.ToUInt16(personadata_array, 0 + (enemyTree.SelectedNode.Index * 148) + 66).ToString("D");


            //Unknown sub-persona values
            richTextBoxUnknownSub0.Text = subpersonadata_array[0 + (enemyTree.SelectedNode.Index * 72) + 0].ToString("D");
            richTextBoxUnknownSub1.Text = subpersonadata_array[0 + (enemyTree.SelectedNode.Index * 72) + 1].ToString("D");





        }

        private void label20_Click(object sender, EventArgs e) //delete mee
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e) //delete me
        {

        }

        private void buttonSave_Click(object sender, EventArgs e) //Save Button
        {
            //B! .TryParse(Name! .Text, out type! value! ); { Form1.ByteWriter( value! , enemydata_array, StartingHex! + (treeView1.SelectedNode.Index * RowSize! ) + ArrayOfset! ); }
            //B=Byte size, 1="Byte" 2="UInt16" 4="UInt32"         Name!=the name of the textbox        type!= byte / ushort / uint, only include this in the FIRST time this ever happens in a form, later copies ommit this!
            //value!=Name of variable that holds the byte type (so byte/short/int has diffrent names)       StartingHex!= The hex offset      RowSize!=How many bytes in a row    Arrayofset! = how far into the row do we start grabbing info or saving it
            
            Byte.TryParse(richTextBoxLv.Text, out byte value8); { Form1.ByteWriter(value8, personadata_array, 0 + (enemyTree.SelectedNode.Index * 148) + 3); } //First 1 byte save
            Byte.TryParse(richTextBoxArcana.Text, out value8); { Form1.ByteWriter(value8, personadata_array, 0 + (enemyTree.SelectedNode.Index * 148) + 2); }

            UInt16.TryParse(richTextBoxStr.Text, out ushort value16); { Form1.ByteWriter(value16, personadata_array, 0 + (enemyTree.SelectedNode.Index * 148) + 8); } //First 2 byte save
            UInt16.TryParse(richTextBoxMag.Text, out value16); { Form1.ByteWriter(value16, personadata_array, 0 + (enemyTree.SelectedNode.Index * 148) + 10); }
            UInt16.TryParse(richTextBoxEn.Text, out value16); { Form1.ByteWriter(value16, personadata_array, 0 + (enemyTree.SelectedNode.Index * 148) + 12); }
            UInt16.TryParse(richTextBoxAgi.Text, out value16); { Form1.ByteWriter(value16, personadata_array, 0 + (enemyTree.SelectedNode.Index * 148) + 14); }
            UInt16.TryParse(richTextBoxLuck.Text, out value16); { Form1.ByteWriter(value16, personadata_array, 0 + (enemyTree.SelectedNode.Index * 148) + 16); }

            UInt16.TryParse(richTextBoxCut.Text, out value16); { Form1.ByteWriter(value16, personadata_array, 0 + (enemyTree.SelectedNode.Index * 148) + 18); }
            UInt16.TryParse(richTextBoxStab.Text, out value16); { Form1.ByteWriter(value16, personadata_array, 0 + (enemyTree.SelectedNode.Index * 148) + 20); }
            UInt16.TryParse(richTextBoxBash.Text, out value16); { Form1.ByteWriter(value16, personadata_array, 0 + (enemyTree.SelectedNode.Index * 148) + 22); }
            UInt16.TryParse(richTextBoxFire.Text, out value16); { Form1.ByteWriter(value16, personadata_array, 0 + (enemyTree.SelectedNode.Index * 148) + 24); }
            UInt16.TryParse(richTextBoxIce.Text, out value16); { Form1.ByteWriter(value16, personadata_array, 0 + (enemyTree.SelectedNode.Index * 148) + 26); }
            UInt16.TryParse(richTextBoxElec.Text, out value16); { Form1.ByteWriter(value16, personadata_array, 0 + (enemyTree.SelectedNode.Index * 148) + 28); }
            UInt16.TryParse(richTextBoxWind.Text, out value16); { Form1.ByteWriter(value16, personadata_array, 0 + (enemyTree.SelectedNode.Index * 148) + 30); }
            UInt16.TryParse(richTextBoxLight.Text, out value16); { Form1.ByteWriter(value16, personadata_array, 0 + (enemyTree.SelectedNode.Index * 148) + 32); }
            UInt16.TryParse(richTextBoxDark.Text, out value16); { Form1.ByteWriter(value16, personadata_array, 0 + (enemyTree.SelectedNode.Index * 148) + 34); }


            //Sub persona skill learning
            Byte.TryParse(richTextBoxLearnLv1.Text, out value8); { Form1.ByteWriter(value8, subpersonadata_array, 0 + (enemyTree.SelectedNode.Index * 72) + 8); }
            Byte.TryParse(richTextBoxLearnLv2.Text, out value8); { Form1.ByteWriter(value8, subpersonadata_array, 0 + (enemyTree.SelectedNode.Index * 72) + 12); }
            Byte.TryParse(richTextBoxLearnLv3.Text, out value8); { Form1.ByteWriter(value8, subpersonadata_array, 0 + (enemyTree.SelectedNode.Index * 72) + 16); }
            Byte.TryParse(richTextBoxLearnLv4.Text, out value8); { Form1.ByteWriter(value8, subpersonadata_array, 0 + (enemyTree.SelectedNode.Index * 72) + 20); }
            Byte.TryParse(richTextBoxLearnLv5.Text, out value8); { Form1.ByteWriter(value8, subpersonadata_array, 0 + (enemyTree.SelectedNode.Index * 72) + 24); }
            Byte.TryParse(richTextBoxLearnLv6.Text, out value8); { Form1.ByteWriter(value8, subpersonadata_array, 0 + (enemyTree.SelectedNode.Index * 72) + 28); }
            Byte.TryParse(richTextBoxLearnLv7.Text, out value8); { Form1.ByteWriter(value8, subpersonadata_array, 0 + (enemyTree.SelectedNode.Index * 72) + 32); }
            Byte.TryParse(richTextBoxLearnLv8.Text, out value8); { Form1.ByteWriter(value8, subpersonadata_array, 0 + (enemyTree.SelectedNode.Index * 72) + 36); }
            
            Byte.TryParse(richTextBoxLearnFlag1.Text, out value8); { Form1.ByteWriter(value8, subpersonadata_array, 0 + (enemyTree.SelectedNode.Index * 72) + 9); }
            Byte.TryParse(richTextBoxLearnFlag2.Text, out value8); { Form1.ByteWriter(value8, subpersonadata_array, 0 + (enemyTree.SelectedNode.Index * 72) + 13); }
            Byte.TryParse(richTextBoxLearnFlag3.Text, out value8); { Form1.ByteWriter(value8, subpersonadata_array, 0 + (enemyTree.SelectedNode.Index * 72) + 17); }
            Byte.TryParse(richTextBoxLearnFlag4.Text, out value8); { Form1.ByteWriter(value8, subpersonadata_array, 0 + (enemyTree.SelectedNode.Index * 72) + 21); }
            Byte.TryParse(richTextBoxLearnFlag5.Text, out value8); { Form1.ByteWriter(value8, subpersonadata_array, 0 + (enemyTree.SelectedNode.Index * 72) + 25); }
            Byte.TryParse(richTextBoxLearnFlag6.Text, out value8); { Form1.ByteWriter(value8, subpersonadata_array, 0 + (enemyTree.SelectedNode.Index * 72) + 29); }
            Byte.TryParse(richTextBoxLearnFlag7.Text, out value8); { Form1.ByteWriter(value8, subpersonadata_array, 0 + (enemyTree.SelectedNode.Index * 72) + 33); }
            Byte.TryParse(richTextBoxLearnFlag8.Text, out value8); { Form1.ByteWriter(value8, subpersonadata_array, 0 + (enemyTree.SelectedNode.Index * 72) + 37); }

            //Unknown main-persona values
            Byte.TryParse(richTextBoxUnknownMain0.Text, out value8); { Form1.ByteWriter(value8, personadata_array, 0 + (enemyTree.SelectedNode.Index * 148) + 0); }
            Byte.TryParse(richTextBoxUnknownMain1.Text, out value8); { Form1.ByteWriter(value8, personadata_array, 0 + (enemyTree.SelectedNode.Index * 148) + 1); }
            UInt16.TryParse(richTextBoxUnknownMain01.Text, out value16); { Form1.ByteWriter(value16, personadata_array, 0 + (enemyTree.SelectedNode.Index * 148) + 0); }
            UInt16.TryParse(richTextBoxUnknownMain45.Text, out value16); { Form1.ByteWriter(value16, personadata_array, 0 + (enemyTree.SelectedNode.Index * 148) + 4); }
            UInt16.TryParse(richTextBoxUnknownMain67.Text, out value16); { Form1.ByteWriter(value16, personadata_array, 0 + (enemyTree.SelectedNode.Index * 148) + 6); }
            
            UInt16.TryParse(richTextBoxAilment1.Text, out value16); { Form1.ByteWriter(value16, personadata_array, 0 + (enemyTree.SelectedNode.Index * 148) + 36); }
            UInt16.TryParse(richTextBoxAilment2.Text, out value16); { Form1.ByteWriter(value16, personadata_array, 0 + (enemyTree.SelectedNode.Index * 148) + 38); }
            UInt16.TryParse(richTextBoxAilment3.Text, out value16); { Form1.ByteWriter(value16, personadata_array, 0 + (enemyTree.SelectedNode.Index * 148) + 40); }
            UInt16.TryParse(richTextBoxAilment4.Text, out value16); { Form1.ByteWriter(value16, personadata_array, 0 + (enemyTree.SelectedNode.Index * 148) + 42); }
            UInt16.TryParse(richTextBoxAilment5.Text, out value16); { Form1.ByteWriter(value16, personadata_array, 0 + (enemyTree.SelectedNode.Index * 148) + 44); }
            UInt16.TryParse(richTextBoxAilment6.Text, out value16); { Form1.ByteWriter(value16, personadata_array, 0 + (enemyTree.SelectedNode.Index * 148) + 46); }
            UInt16.TryParse(richTextBoxAilment7.Text, out value16); { Form1.ByteWriter(value16, personadata_array, 0 + (enemyTree.SelectedNode.Index * 148) + 48); }
            UInt16.TryParse(richTextBoxAilment8.Text, out value16); { Form1.ByteWriter(value16, personadata_array, 0 + (enemyTree.SelectedNode.Index * 148) + 50); }
            UInt16.TryParse(richTextBoxAilment9.Text, out value16); { Form1.ByteWriter(value16, personadata_array, 0 + (enemyTree.SelectedNode.Index * 148) + 52); }
            UInt16.TryParse(richTextBoxAilment10.Text, out value16); { Form1.ByteWriter(value16, personadata_array, 0 + (enemyTree.SelectedNode.Index * 148) + 54); }
            UInt16.TryParse(richTextBoxAilment11.Text, out value16); { Form1.ByteWriter(value16, personadata_array, 0 + (enemyTree.SelectedNode.Index * 148) + 56); }
            UInt16.TryParse(richTextBoxAilment12.Text, out value16); { Form1.ByteWriter(value16, personadata_array, 0 + (enemyTree.SelectedNode.Index * 148) + 58); }
            UInt16.TryParse(richTextBoxAilment13.Text, out value16); { Form1.ByteWriter(value16, personadata_array, 0 + (enemyTree.SelectedNode.Index * 148) + 60); }
            UInt16.TryParse(richTextBoxAilment14.Text, out value16); { Form1.ByteWriter(value16, personadata_array, 0 + (enemyTree.SelectedNode.Index * 148) + 62); }
            UInt16.TryParse(richTextBoxAilment15.Text, out value16); { Form1.ByteWriter(value16, personadata_array, 0 + (enemyTree.SelectedNode.Index * 148) + 64); }
            UInt16.TryParse(richTextBoxAilment16.Text, out value16); { Form1.ByteWriter(value16, personadata_array, 0 + (enemyTree.SelectedNode.Index * 148) + 66); }

            //Unknown sub-persona values
            Byte.TryParse(richTextBoxUnknownSub0.Text, out value8); { Form1.ByteWriter(value8, subpersonadata_array, 0 + (enemyTree.SelectedNode.Index * 72) + 0); }
            Byte.TryParse(richTextBoxUnknownSub1.Text, out value8); { Form1.ByteWriter(value8, subpersonadata_array, 0 + (enemyTree.SelectedNode.Index * 72) + 1); }





            

            File.WriteAllBytes(Properties.Settings.Default.PQRomFS + "\\battle\\table\\datpersonaformat.tbl", personadata_array); //saves to the path i set, everything in the array/
            File.WriteAllBytes(Properties.Settings.Default.PQRomFS + "\\battle\\table\\datsubpersonagrowth.tbl", subpersonadata_array); //saves to the path i set, everything in the array/
        }
    }
}
