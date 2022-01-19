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
    public partial class FormFETHShop : Form
    {
        String treeloaded = "No";
        String shopTreeLoaded = "None";
        byte[] shopdata_array; //This starts the array, the name after is what i name this array?

        public FormFETHShop()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e) //Weapon Shop
        {
            treeloaded = "No";
            shopTreeLoaded = "None";
            shopTree.Nodes.Clear();

            string shopdata_path = Properties.Settings.Default.FETHRomFS + "\\romfs\\patch4\\nx\\data\\fixed_shopdata.bin";
            int shopdata_length = (int)(new FileInfo(shopdata_path).Length);   //The leagth of the array?
            shopdata_array = File.ReadAllBytes(shopdata_path);

            shopTree.Nodes.Add("Unarmed");
            shopTree.Nodes.Add("Broken Sword");
            shopTree.Nodes.Add("Broken Lance");
            shopTree.Nodes.Add("Broken Axe");
            shopTree.Nodes.Add("Broken Bow");
            shopTree.Nodes.Add("Broken Gauntlet");
            shopTree.Nodes.Add("?????");
            shopTree.Nodes.Add("?????");
            shopTree.Nodes.Add("?????");
            shopTree.Nodes.Add("?????");
            shopTree.Nodes.Add("?????");
            shopTree.Nodes.Add("?????");
            shopTree.Nodes.Add("?????");
            shopTree.Nodes.Add("?????");
            shopTree.Nodes.Add("?????");
            shopTree.Nodes.Add("?????");
            shopTree.Nodes.Add("Iron Sword");
            shopTree.Nodes.Add("Steel Sword");
            shopTree.Nodes.Add("Silver Sword");
            shopTree.Nodes.Add("Brave Sword");
            shopTree.Nodes.Add("Killing Edge");
            shopTree.Nodes.Add("Training Sword");
            shopTree.Nodes.Add("Iron Lance");
            shopTree.Nodes.Add("Steel Lance");
            shopTree.Nodes.Add("Silver Lance");
            shopTree.Nodes.Add("Brave Lance");
            shopTree.Nodes.Add("Killing Lance");
            shopTree.Nodes.Add("Training Lance");
            shopTree.Nodes.Add("Iron Axe");
            shopTree.Nodes.Add("Steel Axe");
            shopTree.Nodes.Add("Silver Axe");
            shopTree.Nodes.Add("Brave Axe");
            shopTree.Nodes.Add("Killing Axe");
            shopTree.Nodes.Add("Training Axe");
            shopTree.Nodes.Add("Iron Bow");
            shopTree.Nodes.Add("Steel Bow");
            shopTree.Nodes.Add("Silver Bow");
            shopTree.Nodes.Add("Brave Bow");
            shopTree.Nodes.Add("Killing Bow");
            shopTree.Nodes.Add("Training Bow");
            shopTree.Nodes.Add("Iron Gauntlets");
            shopTree.Nodes.Add("Steel Gauntlets");
            shopTree.Nodes.Add("Silver Gauntlets");
            shopTree.Nodes.Add("Brave Gauntlets");
            shopTree.Nodes.Add("Killing Gauntlets");
            shopTree.Nodes.Add("Training Gauntlets");
            shopTree.Nodes.Add("Levin Sword");
            shopTree.Nodes.Add("Bolt Axe");
            shopTree.Nodes.Add("Magic Bow");
            shopTree.Nodes.Add("Javalin");
            shopTree.Nodes.Add("Short Spear");
            shopTree.Nodes.Add("Spear");
            shopTree.Nodes.Add("Hand Axe");
            shopTree.Nodes.Add("Short Axe");
            shopTree.Nodes.Add("Tomahawk");
            shopTree.Nodes.Add("Longbow");
            shopTree.Nodes.Add("Mini Bow");
            shopTree.Nodes.Add("Armorslayer");
            shopTree.Nodes.Add("Rapier");
            shopTree.Nodes.Add("Horse Slayer");
            shopTree.Nodes.Add("Hammer");
            shopTree.Nodes.Add("Blessed Lance");
            shopTree.Nodes.Add("Blessed Bow");
            shopTree.Nodes.Add("Devil Sword");
            shopTree.Nodes.Add("Devil Axe");
            shopTree.Nodes.Add("Wo Dao");
            shopTree.Nodes.Add("Crescent Sickle");
            shopTree.Nodes.Add("Sword of Seiros");
            shopTree.Nodes.Add("Sword of Begalta");
            shopTree.Nodes.Add("Sword of Moralta");
            shopTree.Nodes.Add("Cursed Ashiya Sword");
            shopTree.Nodes.Add("Sword of Zoltan");
            shopTree.Nodes.Add("Thundebrand");
            shopTree.Nodes.Add("Blutgang");
            shopTree.Nodes.Add("Sword of the creator");
            shopTree.Nodes.Add("Lance of Zolton");
            shopTree.Nodes.Add("Lance of ruin");
            shopTree.Nodes.Add("Areadbhar");
            shopTree.Nodes.Add("Luin");
            shopTree.Nodes.Add("Spear of Assal");
            shopTree.Nodes.Add("Scythe of Sariel");
            shopTree.Nodes.Add("Arrow of Indra");
            shopTree.Nodes.Add("Freikugel");
            shopTree.Nodes.Add("Crusher");
            shopTree.Nodes.Add("Axe of Ukonvasara");
            shopTree.Nodes.Add("Axe of Zolton");
            shopTree.Nodes.Add("Tathlum Bow");
            shopTree.Nodes.Add("The Inexhaustiable");
            shopTree.Nodes.Add("Bow of Zolton");
            shopTree.Nodes.Add("Failnaught");
            shopTree.Nodes.Add("Dragon Claw");
            shopTree.Nodes.Add("Mace");
            shopTree.Nodes.Add("Athame");
            shopTree.Nodes.Add("Ridill");
            shopTree.Nodes.Add("Aymr");
            shopTree.Nodes.Add("Dark Sword of the Creator");
            shopTree.Nodes.Add("Venin Edge");
            shopTree.Nodes.Add("Venin Lance");
            shopTree.Nodes.Add("Venin Axe");
            shopTree.Nodes.Add("Venin Bow");
            shopTree.Nodes.Add("Mercurius");
            shopTree.Nodes.Add("Gradivus");
            shopTree.Nodes.Add("Hauteclere");
            shopTree.Nodes.Add("Parthia");
            shopTree.Nodes.Add("Killer Knuckles");
            shopTree.Nodes.Add("Aura Knuckles");
            shopTree.Nodes.Add("Rusted Iron Sword");
            shopTree.Nodes.Add("Rusted Steel Sword");
            shopTree.Nodes.Add("Rusted Silver Sword");
            shopTree.Nodes.Add("Rusted Brave Sword");
            shopTree.Nodes.Add("Rusted Mercurius Sword");
            shopTree.Nodes.Add("(Add more weapons later)");


            shopTreeLoaded = "Weapon";
            TreeNodeCollection nodeCollect = shopTree.Nodes;
            shopTree.SelectedNode = nodeCollect[0];

            
        }

        private void button5_Click(object sender, EventArgs e) // Equipment Editor Button
        {
            treeloaded = "No";
            shopTreeLoaded = "None";
            shopTree.Nodes.Clear();

            string shopdata_path = Properties.Settings.Default.FETHRomFS + "\\romfs\\patch4\\nx\\data\\fixed_shopdata.bin";
            int shopdata_length = (int)(new FileInfo(shopdata_path).Length);   //The leagth of the array?
            shopdata_array = File.ReadAllBytes(shopdata_path);

            shopTree.Nodes.Add("Leather Shield");
            shopTree.Nodes.Add("Iron Shield");
            shopTree.Nodes.Add("Steel Shield");
            shopTree.Nodes.Add("Silver Shield");
            shopTree.Nodes.Add("Talisman Shield");
            shopTree.Nodes.Add("Hexlock Shield");
            shopTree.Nodes.Add("Aegis Shield");
            shopTree.Nodes.Add("Ochain Shield");
            shopTree.Nodes.Add("Seiros Shield");
            shopTree.Nodes.Add("Aurora Shield");
            shopTree.Nodes.Add("Kadmos Shield");
            shopTree.Nodes.Add("Lampos Shield");
            shopTree.Nodes.Add("Accuracy Ring");
            shopTree.Nodes.Add("Critical Ring");
            shopTree.Nodes.Add("Evasion Ring");
            shopTree.Nodes.Add("Speed Ring");
            shopTree.Nodes.Add("March Ring");
            shopTree.Nodes.Add("Goddess Ring");
            shopTree.Nodes.Add("Prayer Ring");
            shopTree.Nodes.Add("Magic Staff");
            shopTree.Nodes.Add("Healing Staff");
            shopTree.Nodes.Add("Caduceus Staff");
            shopTree.Nodes.Add("Thyrsus");
            shopTree.Nodes.Add("Rafail Gem");
            shopTree.Nodes.Add("Experience Gem");
            shopTree.Nodes.Add("Knowledge Gem");
            shopTree.Nodes.Add("Circe Staff");
            shopTree.Nodes.Add("Tomas Staff");
            shopTree.Nodes.Add("Armored Knight Shield");
            shopTree.Nodes.Add("Great Knight Shield");
            shopTree.Nodes.Add("Fortress Knight Shield");
            shopTree.Nodes.Add("Asclepius");
            shopTree.Nodes.Add("Dark Aegis Shield");
            shopTree.Nodes.Add("Dark Thyrsus");
            shopTree.Nodes.Add("Dark Rafail Gem");
            shopTree.Nodes.Add("Flame Shield");
            shopTree.Nodes.Add("Emperor Shield");
            shopTree.Nodes.Add("Black Eagle Pendant");
            shopTree.Nodes.Add("Blue Lion Brooch");
            shopTree.Nodes.Add("Golden Deer Bracelet");
            shopTree.Nodes.Add("White Dragon Scarf");
            shopTree.Nodes.Add("?????");
            shopTree.Nodes.Add("?????");
            shopTree.Nodes.Add("?????");
            shopTree.Nodes.Add("?????");
            shopTree.Nodes.Add("?????");
            shopTree.Nodes.Add("?????");
            shopTree.Nodes.Add("?????");
            shopTree.Nodes.Add("?????");
            shopTree.Nodes.Add("?????");



            shopTreeLoaded = "Equipment";
            TreeNodeCollection nodeCollect = shopTree.Nodes;
            shopTree.SelectedNode = nodeCollect[0];
        }

        private void button1_Click(object sender, EventArgs e) //Item Shop
        {
            treeloaded = "No";
            shopTreeLoaded = "None";
            shopTree.Nodes.Clear();

            string shopdata_path = Properties.Settings.Default.FETHRomFS + "\\romfs\\patch4\\nx\\data\\fixed_shopdata.bin";
            int shopdata_length = (int)(new FileInfo(shopdata_path).Length);   //The leagth of the array?
            shopdata_array = File.ReadAllBytes(shopdata_path);

            shopTree.Nodes.Add("Vulnerary");
            shopTree.Nodes.Add("Concoction");
            shopTree.Nodes.Add("Elixer");
            shopTree.Nodes.Add("Beginner Seal");
            shopTree.Nodes.Add("Intermediate Seal");
            shopTree.Nodes.Add("Advanced Seal");
            shopTree.Nodes.Add("Master Seal");
            shopTree.Nodes.Add("Torch");
            shopTree.Nodes.Add("Bullion");
            shopTree.Nodes.Add("Large Bullion");
            shopTree.Nodes.Add("Extra Large Bullion");
            shopTree.Nodes.Add("Antitoxin");
            shopTree.Nodes.Add("Pure Water");
            shopTree.Nodes.Add("Door Key");
            shopTree.Nodes.Add("Chest Key");
            shopTree.Nodes.Add("Master Key");
            shopTree.Nodes.Add("Seraph Robe");
            shopTree.Nodes.Add("Energy Drop");
            shopTree.Nodes.Add("Spirit Dust");
            shopTree.Nodes.Add("Secret Book");
            shopTree.Nodes.Add("Speed Wing");
            shopTree.Nodes.Add("Goddess Icon");
            shopTree.Nodes.Add("Giant Shell");
            shopTree.Nodes.Add("Talisman");
            shopTree.Nodes.Add("Black Pearl");
            shopTree.Nodes.Add("Shoes of the Wind");
            shopTree.Nodes.Add("Grilled Duck");
            shopTree.Nodes.Add("Fried Boar");
            shopTree.Nodes.Add("Sacred Galewind Shoes");
            shopTree.Nodes.Add("Sacred Moonstone");
            shopTree.Nodes.Add("Magical Herb Salad");
            shopTree.Nodes.Add("Dried Plums");
            shopTree.Nodes.Add("Pike Casserole");
            shopTree.Nodes.Add("Bear and Vegetable Soup");
            shopTree.Nodes.Add("Fried Gar");
            shopTree.Nodes.Add("Grilled Chicken and Herbs");
            shopTree.Nodes.Add("Grilled Duck Plus");
            shopTree.Nodes.Add("Fried Boar Plus");
            shopTree.Nodes.Add("Magical Herb Salad Plus");
            shopTree.Nodes.Add("??????");
            shopTree.Nodes.Add("Dried Plums Plus");
            shopTree.Nodes.Add("Pike Casserole Plus");
            shopTree.Nodes.Add("Bear and Vegetable Soup Plus");
            shopTree.Nodes.Add("Fried Gar Plus");
            shopTree.Nodes.Add("Fried Queen Koi Plus");
            shopTree.Nodes.Add("Sculpin Gratin Plus");
            shopTree.Nodes.Add("Grilled Wolverine and Herb Plus");
            shopTree.Nodes.Add("Albinea Juice");
            shopTree.Nodes.Add("Grilled Chicken and Herbs");
            shopTree.Nodes.Add("Roast Duck");
            shopTree.Nodes.Add("Sacred Floral Robe");
            shopTree.Nodes.Add("?????");
            shopTree.Nodes.Add("Sacred Snowmelt Drop");
            shopTree.Nodes.Add("?????");
            shopTree.Nodes.Add("More Items Later");





            shopTreeLoaded = "Item";
            TreeNodeCollection nodeCollect = shopTree.Nodes;
            shopTree.SelectedNode = nodeCollect[0];

            
        }


        private void button4_Click(object sender, EventArgs e) //Battalion Button
        {

        }

        private void button6_Click(object sender, EventArgs e) // Forge Editor
        {

            treeloaded = "No";
            shopTreeLoaded = "None";
            shopTree.Nodes.Clear();

            string shopdata_path = Properties.Settings.Default.FETHRomFS + "\\romfs\\patch4\\nx\\data\\fixed_shopdata.bin";
            int shopdata_length = (int)(new FileInfo(shopdata_path).Length);   //The leagth of the array?
            shopdata_array = File.ReadAllBytes(shopdata_path);

            shopTree.Nodes.Add("Rusted Axe Hauteclere");
            shopTree.Nodes.Add("?????");
            shopTree.Nodes.Add("?????");
            shopTree.Nodes.Add("Tathlum Bow");
            shopTree.Nodes.Add("Rusted Iron Bow");
            shopTree.Nodes.Add("?????");
            shopTree.Nodes.Add("Iron Bow");
            shopTree.Nodes.Add("Rusted Steel Bow");
            shopTree.Nodes.Add("?????");
            shopTree.Nodes.Add("Rusted Silver Bow");
            shopTree.Nodes.Add("Rusted Brave Bow");
            shopTree.Nodes.Add("Longbow");
            shopTree.Nodes.Add("Rusted Parthia Bow");
            shopTree.Nodes.Add("Rusted Iron Gauntlets");
            shopTree.Nodes.Add("?????");
            shopTree.Nodes.Add("Iron Sword");
            shopTree.Nodes.Add("The Inexhaustiable");
            shopTree.Nodes.Add("Rusted Steel Gauntlets");
            shopTree.Nodes.Add("?????");
            shopTree.Nodes.Add("Rusted Silver Gauntlets");
            shopTree.Nodes.Add("?????");
            shopTree.Nodes.Add("Rusted Dragon Claw Gauntlets");
            shopTree.Nodes.Add("Iron Sword Plus");
            shopTree.Nodes.Add("Steel Sword Plus");
            shopTree.Nodes.Add("Silver Sword Plus");
            shopTree.Nodes.Add("Brave Sword");
            shopTree.Nodes.Add("Iron Lance");
            shopTree.Nodes.Add("Bow of Zoltan");
            shopTree.Nodes.Add("Brave Sword Plus");
            shopTree.Nodes.Add("Killing Edge");
            shopTree.Nodes.Add("Steel Bow");
            shopTree.Nodes.Add("Killing Edge Plus");
            shopTree.Nodes.Add("Training Sword");
            shopTree.Nodes.Add("Training Sword Plus");
            shopTree.Nodes.Add("Iron Lance Plus");
            shopTree.Nodes.Add("Steel Lance Plus");
            shopTree.Nodes.Add("Silver Lance Plus");
            shopTree.Nodes.Add("Brave Lance");
            shopTree.Nodes.Add("Iron Axe");
            shopTree.Nodes.Add("Failnaught");
            shopTree.Nodes.Add("Brave Lance Plus");
            shopTree.Nodes.Add("Killer Lance");
            shopTree.Nodes.Add("Silver Bow");
            shopTree.Nodes.Add("Training Gauntlets");
            shopTree.Nodes.Add("Killer Lance Plus");
            shopTree.Nodes.Add("Training Lance");
            shopTree.Nodes.Add("Training Lance Plus");
            shopTree.Nodes.Add("Iron Axe Plus");
            shopTree.Nodes.Add("Steel Axe Plus");
            shopTree.Nodes.Add("Silver Axe Plus");
            shopTree.Nodes.Add("Brave Axe");
            shopTree.Nodes.Add("Aymr");
            shopTree.Nodes.Add("Brave Axe Plus");
            shopTree.Nodes.Add("Killer Axe");
            shopTree.Nodes.Add("Dark Sword of the Creator");
            shopTree.Nodes.Add("Killer Axe Plus");
            shopTree.Nodes.Add("Scythe of Sariel");
            shopTree.Nodes.Add("Training Axe Plus");
            shopTree.Nodes.Add("Iron Bow Plus");
            shopTree.Nodes.Add("More Weapons Soon");


            shopTreeLoaded = "Forge";
            TreeNodeCollection nodeCollect = shopTree.Nodes;
            shopTree.SelectedNode = nodeCollect[0];

        }


        private void button3_Click(object sender, EventArgs e) //SAVE and Empty list button
        {
            if (shopTreeLoaded == "Item2222")
            {
                //First offset INCLUDES decimal 0 (so Row leagth -1), row does NOT, neither does per row offset.
                UInt32.TryParse(richTextBoxBuy.Text, out uint value32); { Form1.ByteWriter(value32, shopdata_array, 5060 + (shopTree.SelectedNode.Index * 16) + 0); }//First 4 byte save
                UInt32.TryParse(richTextBoxSell.Text, out value32); { Form1.ByteWriter(value32, shopdata_array, 5060 + (shopTree.SelectedNode.Index * 16) + 4); }
                Byte.TryParse(richTextBoxAvailability.Text, out byte value8); { Form1.ByteWriter(value8, shopdata_array, 5060 + (shopTree.SelectedNode.Index * 16) + 12); }//First 1 byte save

                File.WriteAllBytes(Properties.Settings.Default.FETHRomFS + "\\romfs\\patch4\\nx\\data\\fixed_shopdata.bin", shopdata_array); //saves to the path i set, everything in the array/

            }

            treeloaded = "No";
            shopTreeLoaded = "None";
            shopTree.Nodes.Clear();

        }

        

        

        private void shopTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (shopTreeLoaded == "Item")
            {
            
                //First offset INCLUDES decimal 0, row does NOT, neither does per row offset.
                richTextBoxBuy.Text = BitConverter.ToUInt32(shopdata_array, 5100 + (shopTree.SelectedNode.Index * 16) + 0).ToString("D"); //Value 1 is distance / offset from the start of the file to the start of the array ("Start" in 010) (The first byte is 0) 
                richTextBoxSell.Text = BitConverter.ToUInt32(shopdata_array, 5100 + (shopTree.SelectedNode.Index * 16) + 4).ToString("D"); //Value 2 is how many bytes / hexes are in a "row"   (First byte is 1 NOT 0)
                richTextBoxAvailability.Text = shopdata_array[5100 + (shopTree.SelectedNode.Index * 16) + 12].ToString("D"); //Value 3 is how many bytes into the row info starts (The first byte is byte 0)  
            }

            if (shopTreeLoaded == "Weapon")
            {

                //First offset INCLUDES decimal 0, row does NOT, neither does per row offset.
                richTextBoxBuy.Text = BitConverter.ToUInt32(shopdata_array, 172 + (shopTree.SelectedNode.Index * 20) + 0).ToString("D"); //Value 1 is distance / offset from the start of the file to the start of the array ("Start" in 010) (The first byte is 0) 
                richTextBoxSell.Text = BitConverter.ToUInt32(shopdata_array, 172 + (shopTree.SelectedNode.Index * 20) + 4).ToString("D"); //Value 2 is how many bytes / hexes are in a "row"   (First byte is 1 NOT 0)
                richTextBoxAvailability.Text = shopdata_array[172 + (shopTree.SelectedNode.Index * 20) + 16].ToString("D"); //Value 3 is how many bytes into the row info starts (The first byte is byte 0)  
                label3.Text = "Whatever you want the text to say";
            }

            if (shopTreeLoaded == "Equipment")
            {

                richTextBoxBuy.Text = BitConverter.ToUInt32(shopdata_array, 4236 + (shopTree.SelectedNode.Index * 16) + 0).ToString("D"); //Value 1 is distance / offset from the start of the file to the start of the array ("Start" in 010) (The first byte is 0) 
                richTextBoxSell.Text = BitConverter.ToUInt32(shopdata_array, 4236 + (shopTree.SelectedNode.Index * 16) + 4).ToString("D"); //Value 2 is how many bytes / hexes are in a "row"   (First byte is 1 NOT 0)
                richTextBoxAvailability.Text = shopdata_array[4236 + (shopTree.SelectedNode.Index * 16) + 12].ToString("D"); //Value 3 is how many bytes into the row info starts (The first byte is byte 0)  
                label3.Text = "Availability";

            }


        }

        private void shopTree_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {


            if (treeloaded == "Yes")
            {
                if (shopTreeLoaded == "Item")
                {
                //First offset INCLUDES decimal 0 (so Row leagth -1), row does NOT, neither does per row offset.
                UInt32.TryParse(richTextBoxBuy.Text, out uint value32); { Form1.ByteWriter(value32, shopdata_array, 5100 + (shopTree.SelectedNode.Index * 16) + 0); }//First 4 byte save
                UInt32.TryParse(richTextBoxSell.Text, out value32); { Form1.ByteWriter(value32, shopdata_array, 5100 + (shopTree.SelectedNode.Index * 16) + 4); }
                Byte.TryParse(richTextBoxAvailability.Text, out byte value8); { Form1.ByteWriter(value8, shopdata_array, 5100 + (shopTree.SelectedNode.Index * 16) + 12); }//First 1 byte save

                //File.WriteAllBytes(Properties.Settings.Default.FETHRomFS + "\\romfs\\patch4\\nx\\data\\fixed_shopdata.bin", shopdata_array); //saves to the path i set, everything in the array/
                }

                if (shopTreeLoaded == "Weapon")
                {
                //First offset INCLUDES decimal 0 (so Row leagth -1), row does NOT, neither does per row offset.
                UInt32.TryParse(richTextBoxBuy.Text, out uint value32); { Form1.ByteWriter(value32, shopdata_array, 172 + (shopTree.SelectedNode.Index * 20) + 0); }//First 4 byte save
                UInt32.TryParse(richTextBoxSell.Text, out value32); { Form1.ByteWriter(value32, shopdata_array, 172 + (shopTree.SelectedNode.Index * 20) + 4); }
                //Byte.TryParse(richTextBoxAvailability.Text, out byte value8); { Form1.ByteWriter(value8, shopdata_array, 132 + (shopTree.SelectedNode.Index * 20) + 12); }//First 1 byte save

                //File.WriteAllBytes(Properties.Settings.Default.FETHRomFS + "\\romfs\\mods\\30 - shopdata.bin", shopdata_array); //saves to the path i set, everything in the array/
                }
            }
            else
            {
                treeloaded = "Yes";
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            treeloaded = "No";
            shopTreeLoaded = "None";
            shopTree.Nodes.Clear();
        }
    }
}
