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
    public partial class FormQEnemyEditor : Form
    {
        String treeloaded = "No";
        byte[] enemydata_array; //This starts the array, the name after is what i name this array?
        public FormQEnemyEditor()
        {
            InitializeComponent();

            string enemydata_path = Properties.Settings.Default.PQRomFS + "\\battle\\table\\enemydata.tbl"; //This defines the path as a string, so i can refer to it by this string/name instead of the full path every time
            int enemydata_length = (int)(new FileInfo(enemydata_path).Length);   //The leagth of the array?
            enemydata_array = File.ReadAllBytes(enemydata_path);  //loads an array with whatever is in the path

            //Add the EO1 enemy list to the in editor list of enemy names
            enemyTree.Nodes.Add("Header?");
            enemyTree.Nodes.Add("Cowardly Maya");
            enemyTree.Nodes.Add("Selfish Basalt");
            enemyTree.Nodes.Add("Rainy Sister 4");
            enemyTree.Nodes.Add("Slipping Hablerie");
            enemyTree.Nodes.Add("Magic Hand");
            enemyTree.Nodes.Add("Dancing Hand");
            enemyTree.Nodes.Add("Killing Hand");
            enemyTree.Nodes.Add("Almighty Hand");
            enemyTree.Nodes.Add("Laughing Table");
            enemyTree.Nodes.Add("Crying Table");
            enemyTree.Nodes.Add("Angry Table");
            enemyTree.Nodes.Add("Sleeping Table");
            enemyTree.Nodes.Add("Magical Magus");
            enemyTree.Nodes.Add("Wondrous Magus");
            enemyTree.Nodes.Add("Prime Magus");
            enemyTree.Nodes.Add("Grand Magus");
            enemyTree.Nodes.Add("Lying Hablerie");
            enemyTree.Nodes.Add("Forgotten Hablerie");
            enemyTree.Nodes.Add("Flattering Hablerie");
            enemyTree.Nodes.Add("Agitating Hablerie");
            enemyTree.Nodes.Add("Merciless Maya");
            enemyTree.Nodes.Add("Autonomic Basalt");
            enemyTree.Nodes.Add("Rainy Brother 4");
            enemyTree.Nodes.Add("Slipping Hablerie");
            enemyTree.Nodes.Add("Cloudgirl Pot");
            enemyTree.Nodes.Add("Rainy Pot");
            enemyTree.Nodes.Add("Yearning Pot");
            enemyTree.Nodes.Add("Mistress Pot");
            enemyTree.Nodes.Add("Spurious Book");
            enemyTree.Nodes.Add("Maniacal Book");
            enemyTree.Nodes.Add("Silent Book");
            enemyTree.Nodes.Add("Wrathful Book");
            enemyTree.Nodes.Add("Tranquil Idol");
            enemyTree.Nodes.Add("Liberating Idol");
            enemyTree.Nodes.Add("Leading Idol");
            enemyTree.Nodes.Add("Vehement Idol");
            enemyTree.Nodes.Add("Primitive Idol");
            enemyTree.Nodes.Add("Calm Pesce");
            enemyTree.Nodes.Add("Pursuing Pesce");
            enemyTree.Nodes.Add("Truth Pesce");
            enemyTree.Nodes.Add("Revelation Pesce");
            enemyTree.Nodes.Add("Frivolous Maya");
            enemyTree.Nodes.Add("Idle Basalt");
            enemyTree.Nodes.Add("Rainy Sister 3");
            enemyTree.Nodes.Add("blank");
            enemyTree.Nodes.Add("Venus Eagle");
            enemyTree.Nodes.Add("Dark Eagle");
            enemyTree.Nodes.Add("Jupiter Eagle");
            enemyTree.Nodes.Add("Eternal Eagle");
            enemyTree.Nodes.Add("Creation Relic");
            enemyTree.Nodes.Add("Constancy Relic");
            enemyTree.Nodes.Add("Growth Relic");
            enemyTree.Nodes.Add("Change Relic");
            enemyTree.Nodes.Add("Elegant Mother");
            enemyTree.Nodes.Add("Regal Mother");
            enemyTree.Nodes.Add("Pistil Mother");
            enemyTree.Nodes.Add("Divine Mother");
            enemyTree.Nodes.Add("Secret Bambino");
            enemyTree.Nodes.Add("Blooming Bambino");
            enemyTree.Nodes.Add("Avarice Bambino");
            enemyTree.Nodes.Add("Free Bambino");
            enemyTree.Nodes.Add("Haughty Maya");
            enemyTree.Nodes.Add("Large Basalt");
            enemyTree.Nodes.Add("Rainy Brother 3");
            enemyTree.Nodes.Add("blank");
            enemyTree.Nodes.Add("Grave Beetle");
            enemyTree.Nodes.Add("Adamant Beetle");
            enemyTree.Nodes.Add("Strength Beetle");
            enemyTree.Nodes.Add("Emperor Beetle");
            enemyTree.Nodes.Add("Burning Beetle");
            enemyTree.Nodes.Add("Avenger Knight");
            enemyTree.Nodes.Add("Champion Knight");
            enemyTree.Nodes.Add("Hell Knight");
            enemyTree.Nodes.Add("Intrepid Knight");
            enemyTree.Nodes.Add("Rainy Castle");
            enemyTree.Nodes.Add("Power Castle");
            enemyTree.Nodes.Add("Raindrop Castle");
            enemyTree.Nodes.Add("King Castle");
            enemyTree.Nodes.Add("Positive King");
            enemyTree.Nodes.Add("Egotistical King");
            enemyTree.Nodes.Add("Great King");
            enemyTree.Nodes.Add("Brilliant King");
            enemyTree.Nodes.Add("Indolent Maya");
            enemyTree.Nodes.Add("Dependent Basalt");
            enemyTree.Nodes.Add("Rainy Sister 2");
            enemyTree.Nodes.Add("blank");
            enemyTree.Nodes.Add("Trance Twins");
            enemyTree.Nodes.Add("Killer Twins");
            enemyTree.Nodes.Add("Rainbow Twins");
            enemyTree.Nodes.Add("Crazy Twins");
            enemyTree.Nodes.Add("Corrupt Tower");
            enemyTree.Nodes.Add("Dogmatic Tower");
            enemyTree.Nodes.Add("Apostate Tower");
            enemyTree.Nodes.Add("Fanatic Tower");
            enemyTree.Nodes.Add("Grudge Tower");
            enemyTree.Nodes.Add("Blue Sigil");
            enemyTree.Nodes.Add("Red Sigil");
            enemyTree.Nodes.Add("Green Sigil");
            enemyTree.Nodes.Add("Purple Sigil");
            enemyTree.Nodes.Add("Bribed Fuzz");
            enemyTree.Nodes.Add("Persistent Fuzz");
            enemyTree.Nodes.Add("Monomaniac Fuzz");
            enemyTree.Nodes.Add("Chaos Fuzz");
            enemyTree.Nodes.Add("Insidious Maya");
            enemyTree.Nodes.Add("Anguish Basalt");
            enemyTree.Nodes.Add("Rainy Brother 2");
            enemyTree.Nodes.Add("blank");
            enemyTree.Nodes.Add("Possessive Cupid");
            enemyTree.Nodes.Add("Blind Cupid");
            enemyTree.Nodes.Add("Devoted Cupid");
            enemyTree.Nodes.Add("Gracious Cupid");
            enemyTree.Nodes.Add("Soul Dancer");
            enemyTree.Nodes.Add("Ardent Dancer");
            enemyTree.Nodes.Add("Royal Dancer");
            enemyTree.Nodes.Add("Natural Dancer");
            enemyTree.Nodes.Add("Harem Dancer");
            enemyTree.Nodes.Add("Lustful Snake");
            enemyTree.Nodes.Add("Immoral Snake");
            enemyTree.Nodes.Add("Carnal Snake");
            enemyTree.Nodes.Add("Amorous Snake");
            enemyTree.Nodes.Add("Stoic Snake");
            enemyTree.Nodes.Add("Whimsical Papillon");
            enemyTree.Nodes.Add("Finicky Papillon");
            enemyTree.Nodes.Add("Fickle Papillon");
            enemyTree.Nodes.Add("Pure Papillon");
            enemyTree.Nodes.Add("Ill-Fated Maya");
            enemyTree.Nodes.Add("Insolent Basalt");
            enemyTree.Nodes.Add("Rainy Sister 1");
            enemyTree.Nodes.Add("blank");
            enemyTree.Nodes.Add("Rain Wheel");
            enemyTree.Nodes.Add("Mach Wheel");
            enemyTree.Nodes.Add("Brave Wheel");
            enemyTree.Nodes.Add("Battle Wheel");
            enemyTree.Nodes.Add("Wild Drive");
            enemyTree.Nodes.Add("Killer Drive");
            enemyTree.Nodes.Add("Slaughter Drive");
            enemyTree.Nodes.Add("Rampage Drive");
            enemyTree.Nodes.Add("Arcane Turret");
            enemyTree.Nodes.Add("Scarlet Turret");
            enemyTree.Nodes.Add("Wicked Turret");
            enemyTree.Nodes.Add("Hallowed Turret");
            enemyTree.Nodes.Add("Spastic Turret");
            enemyTree.Nodes.Add("Berserk Turret");
            enemyTree.Nodes.Add("Dismayed Panzer");
            enemyTree.Nodes.Add("Rash Panzer");
            enemyTree.Nodes.Add("Conceited Panzer");
            enemyTree.Nodes.Add("Ptarmigan Panzer");
            enemyTree.Nodes.Add("Visceral Maya");
            enemyTree.Nodes.Add("Source Basalt");
            enemyTree.Nodes.Add("Rainy Brother 1");
            enemyTree.Nodes.Add("blank");
            enemyTree.Nodes.Add("Rain Leg Musha");
            enemyTree.Nodes.Add("Rain End Musha");
            enemyTree.Nodes.Add("Raindrop Musha");
            enemyTree.Nodes.Add("Rain Wind Musha");
            enemyTree.Nodes.Add("Daring Gigas");
            enemyTree.Nodes.Add("Beastly Gigas");
            enemyTree.Nodes.Add("Furious Gigas");
            enemyTree.Nodes.Add("Mythical Gigas");
            enemyTree.Nodes.Add("Immortal Gigas");
            enemyTree.Nodes.Add("Nizam Beast");
            enemyTree.Nodes.Add("Enslaved Beast");
            enemyTree.Nodes.Add("Mighty Beast");
            enemyTree.Nodes.Add("Nemean Beast");
            enemyTree.Nodes.Add("El Dorado Beast");
            enemyTree.Nodes.Add("Inviting Nyogo");
            enemyTree.Nodes.Add("Blossom Nyogo");
            enemyTree.Nodes.Add("Valuing Nyogo");
            enemyTree.Nodes.Add("Silent Nyogo");
            enemyTree.Nodes.Add("Desirous Maya");
            enemyTree.Nodes.Add("Submissive Basalt");
            enemyTree.Nodes.Add("Rainy Sister 2");
            enemyTree.Nodes.Add("blank");
            enemyTree.Nodes.Add("Black Raven");
            enemyTree.Nodes.Add("Vicious Raven");
            enemyTree.Nodes.Add("Sonic Raven");
            enemyTree.Nodes.Add("Amenti Raven");
            enemyTree.Nodes.Add("Phantom Mage");
            enemyTree.Nodes.Add("Phantom Master");
            enemyTree.Nodes.Add("Phantom Lord");
            enemyTree.Nodes.Add("Phantom King");
            enemyTree.Nodes.Add("Phantom Hero");
            enemyTree.Nodes.Add("Death Seeker");
            enemyTree.Nodes.Add("Fate Seeker");
            enemyTree.Nodes.Add("Noble Seeker");
            enemyTree.Nodes.Add("Acheron Seeker");
            enemyTree.Nodes.Add("Shallow Okina");
            enemyTree.Nodes.Add("Reckless Okina");
            enemyTree.Nodes.Add("Reformed Okina");
            enemyTree.Nodes.Add("Moon Okina");
            enemyTree.Nodes.Add("Imprudent Maya");
            enemyTree.Nodes.Add("Accidental Basalt");
            enemyTree.Nodes.Add("Rainy Brother 2");
            enemyTree.Nodes.Add("blank");
            enemyTree.Nodes.Add("Bronze Dice");
            enemyTree.Nodes.Add("Iron Dice");
            enemyTree.Nodes.Add("Silver Dice");
            enemyTree.Nodes.Add("Platinum Dice");
            enemyTree.Nodes.Add("Mind Dice");
            enemyTree.Nodes.Add("Curse Dice");
            enemyTree.Nodes.Add("Death Dice");
            enemyTree.Nodes.Add("Reckoning Dice");
            enemyTree.Nodes.Add("Flowing Sand");
            enemyTree.Nodes.Add("Perpetual Sand");
            enemyTree.Nodes.Add("Infinite Sand");
            enemyTree.Nodes.Add("Eternal Sand");
            enemyTree.Nodes.Add("Miss Gene");
            enemyTree.Nodes.Add("Fail Gene");
            enemyTree.Nodes.Add("Happy Gene");
            enemyTree.Nodes.Add("Next Gene");
            enemyTree.Nodes.Add("Bigoted Maya");
            enemyTree.Nodes.Add("Convicted Basalt");
            enemyTree.Nodes.Add("Rainy Sister 1");
            enemyTree.Nodes.Add("blank");
            enemyTree.Nodes.Add("Justice Sword");
            enemyTree.Nodes.Add("Conviction Sword");
            enemyTree.Nodes.Add("Judgment Sword");
            enemyTree.Nodes.Add("Doom Sword");
            enemyTree.Nodes.Add("Heat Balance");
            enemyTree.Nodes.Add("Sky Balance");
            enemyTree.Nodes.Add("World Balance");
            enemyTree.Nodes.Add("Light Balance");
            enemyTree.Nodes.Add("Order Giant");
            enemyTree.Nodes.Add("Stasis Giant");
            enemyTree.Nodes.Add("Harmony Giant");
            enemyTree.Nodes.Add("Void Giant");
            enemyTree.Nodes.Add("Steel Machine");
            enemyTree.Nodes.Add("Dominating Machine");
            enemyTree.Nodes.Add("Solemn Machine");
            enemyTree.Nodes.Add("Heartless Machine");
            enemyTree.Nodes.Add("Devious Maya");
            enemyTree.Nodes.Add("Oppressive Basalt");
            enemyTree.Nodes.Add("Rainy Brother 1");
            enemyTree.Nodes.Add("blank");
            enemyTree.Nodes.Add("Minotaur IV");
            enemyTree.Nodes.Add("Minotaur III");
            enemyTree.Nodes.Add("Minotaur II");
            enemyTree.Nodes.Add("Minotaur I");
            enemyTree.Nodes.Add("Neo Minotaur");
            enemyTree.Nodes.Add("Jotun of Power");
            enemyTree.Nodes.Add("Jotun of Blood");
            enemyTree.Nodes.Add("Jotun of Evil");
            enemyTree.Nodes.Add("Jotun of Grief");
            enemyTree.Nodes.Add("Mighty Cyclops");
            enemyTree.Nodes.Add("Mad Cyclops");
            enemyTree.Nodes.Add("Fierce Cyclops");
            enemyTree.Nodes.Add("Chaos Cyclops");
            enemyTree.Nodes.Add("Brilliant Cyclops");
            enemyTree.Nodes.Add("Rebellious Cyclops");
            enemyTree.Nodes.Add("Protective Lexy");
            enemyTree.Nodes.Add("Dry Dexy");
            enemyTree.Nodes.Add("Earnest Calocy");
            enemyTree.Nodes.Add("Successful Junecy");
            enemyTree.Nodes.Add("Test Rare");
            enemyTree.Nodes.Add("blank");
            enemyTree.Nodes.Add("Shadow Yosuke");
            enemyTree.Nodes.Add("Queen of Hearts");
            enemyTree.Nodes.Add("Sword Soldier");
            enemyTree.Nodes.Add("Spear Soldier");
            enemyTree.Nodes.Add("Staff Soldier");
            enemyTree.Nodes.Add("Wand Soldier");
            enemyTree.Nodes.Add("Merciful Clergyman");
            enemyTree.Nodes.Add("Kind Doctor");
            enemyTree.Nodes.Add("Calm Nurse");
            enemyTree.Nodes.Add("Caring Nurse");
            enemyTree.Nodes.Add("Best Friend");
            enemyTree.Nodes.Add("Captor Spider");
            enemyTree.Nodes.Add("Blazing Leg");
            enemyTree.Nodes.Add("Freezing Leg");
            enemyTree.Nodes.Add("Lightning Leg");
            enemyTree.Nodes.Add("Whirlwind Leg");
            enemyTree.Nodes.Add("Clockwork God");
            enemyTree.Nodes.Add("blank");
            enemyTree.Nodes.Add("Margaret");
            enemyTree.Nodes.Add("Elizabeth");
            enemyTree.Nodes.Add("Golden Beetle");
            enemyTree.Nodes.Add("Engage King");
            enemyTree.Nodes.Add("Soul Seeker");
            enemyTree.Nodes.Add("Guardian Machine");
            enemyTree.Nodes.Add("blank");
            enemyTree.Nodes.Add("Theodore");
            enemyTree.Nodes.Add("Margaret");
            enemyTree.Nodes.Add("Elizabeth");
            enemyTree.Nodes.Add("Elizabeth");
            enemyTree.Nodes.Add("Elizabeth");
            enemyTree.Nodes.Add("Elizabeth");
            enemyTree.Nodes.Add("Elizabeth");
            enemyTree.Nodes.Add("The Reaper");
            enemyTree.Nodes.Add("The Reaper");
            enemyTree.Nodes.Add("The Reaper");
            enemyTree.Nodes.Add("The Reaper");
            enemyTree.Nodes.Add("The Reaper");
            enemyTree.Nodes.Add("The Reaper");
            enemyTree.Nodes.Add("The Reaper");
            enemyTree.Nodes.Add("The Reaper");
            enemyTree.Nodes.Add("God of Romance");
            enemyTree.Nodes.Add("Fast Guy");
            enemyTree.Nodes.Add("Card Soldier");
            enemyTree.Nodes.Add("Painting Soldier");
            enemyTree.Nodes.Add("Black Rabbit");
            enemyTree.Nodes.Add("Angel of Love");
            enemyTree.Nodes.Add("Beast of Lust");
            enemyTree.Nodes.Add("Messenger of Love");
            enemyTree.Nodes.Add("Cute Baby");
            enemyTree.Nodes.Add("Lovely Doll");
            enemyTree.Nodes.Add("Old Doll");
            enemyTree.Nodes.Add("Kowakashu");
            enemyTree.Nodes.Add("Sweaty Guy");
            enemyTree.Nodes.Add("Festival Dudes");
            enemyTree.Nodes.Add("The Capturer");
            enemyTree.Nodes.Add("The Watcher");
            enemyTree.Nodes.Add("Kumiashira");
            enemyTree.Nodes.Add("blank");
            enemyTree.Nodes.Add("Wealth Hand");
            enemyTree.Nodes.Add("Treasure Hand");
            enemyTree.Nodes.Add("Supreme Hand");
            enemyTree.Nodes.Add("Opulent Hand");
            enemyTree.Nodes.Add("Luxury Hand");
            enemyTree.Nodes.Add("Glorious Hand");
            enemyTree.Nodes.Add("Burning Beetle");
            enemyTree.Nodes.Add("blank");
            enemyTree.Nodes.Add("Gorgeous King");
            enemyTree.Nodes.Add("blank");
            enemyTree.Nodes.Add("Horror L Shadow");
            enemyTree.Nodes.Add("Fate Seeker");
            enemyTree.Nodes.Add("Indignant Machine");
            enemyTree.Nodes.Add("blank");
            enemyTree.Nodes.Add("Order Giant");
            enemyTree.Nodes.Add("blank");
            enemyTree.Nodes.Add("blank");
            enemyTree.Nodes.Add("blank");
            enemyTree.Nodes.Add("blank");
            enemyTree.Nodes.Add("blank");
            enemyTree.Nodes.Add("blank");
            enemyTree.Nodes.Add("blank");
            enemyTree.Nodes.Add("Gauntlet Hand");
            enemyTree.Nodes.Add("Sword Soldier");
            enemyTree.Nodes.Add("Spear Soldier");
            enemyTree.Nodes.Add("Staff Soldier");
            enemyTree.Nodes.Add("Wand Soldier");
            enemyTree.Nodes.Add("Emaciated Garcy");
            enemyTree.Nodes.Add("Execution Sword");
            enemyTree.Nodes.Add("Cursed Woman's Pot");
            enemyTree.Nodes.Add("Stupendous Relic");
            enemyTree.Nodes.Add("Gorgeous King");
            enemyTree.Nodes.Add("Spectral Raven");
            enemyTree.Nodes.Add("Praying Nyogo");
            enemyTree.Nodes.Add("Superstitious Okina");
            enemyTree.Nodes.Add("Lawless Fuzz");
            enemyTree.Nodes.Add("Stone Panzer");
            enemyTree.Nodes.Add("Harmonious Giant");
            enemyTree.Nodes.Add("Snowfall Musha");
            enemyTree.Nodes.Add("Calm Machine");
            enemyTree.Nodes.Add("Clear Sky Musha");
            enemyTree.Nodes.Add("Indignant Machine");
            enemyTree.Nodes.Add("Heaven's Giant");
            enemyTree.Nodes.Add("blank");
            enemyTree.Nodes.Add("blank");
            enemyTree.Nodes.Add("Test S Size");
            enemyTree.Nodes.Add("Test M Size");
            enemyTree.Nodes.Add("Test L Size");
            enemyTree.Nodes.Add("blank");
            enemyTree.Nodes.Add("blank");
            enemyTree.Nodes.Add("blank");
            enemyTree.Nodes.Add("blank");
            enemyTree.Nodes.Add("blank");
            enemyTree.Nodes.Add("blank");

            TreeNodeCollection nodeCollect = enemyTree.Nodes;
            enemyTree.SelectedNode = nodeCollect[0];
        }

        private void FormQEnemyEditor_Load(object sender, EventArgs e)
        {

        }

        private void enemyTree_AfterSelect(object sender, TreeViewEventArgs e) //After selecting an enemy on the list
        {
            richTextBoxLv.Text = enemydata_array[0 + (enemyTree.SelectedNode.Index * 136) + 8].ToString("D");  //Value 1 is distance / offset from the start of the file to the start of the array ("Start" in 010) (The first byte is 0) 
            richTextBoxMaxHP.Text = BitConverter.ToUInt32(enemydata_array, 0 + (enemyTree.SelectedNode.Index * 136) + 12).ToString("D");  //Value 2 is how many bytes / hexes are in a "row"   (First byte is 1 NOT 0)

            richTextBoxStr.Text = BitConverter.ToUInt16(enemydata_array, 0 + (enemyTree.SelectedNode.Index * 136) + 20).ToString("D");//Value 3 is how many bytes into the row info starts (The first byte is byte 0)
            richTextBoxMag.Text = BitConverter.ToUInt16(enemydata_array, 0 + (enemyTree.SelectedNode.Index * 136) + 22).ToString("D");
            richTextBoxEn.Text = BitConverter.ToUInt16(enemydata_array, 0 + (enemyTree.SelectedNode.Index * 136) + 24).ToString("D");
            richTextBoxAgi.Text = BitConverter.ToUInt16(enemydata_array, 0 + (enemyTree.SelectedNode.Index * 136) + 26).ToString("D");
            richTextBoxLuck.Text = BitConverter.ToUInt16(enemydata_array, 0 + (enemyTree.SelectedNode.Index * 136) + 28).ToString("D");

            richTextBoxCut.Text = BitConverter.ToUInt16(enemydata_array, 0 + (enemyTree.SelectedNode.Index * 136) + 36).ToString("D");
            richTextBoxStab.Text = BitConverter.ToUInt16(enemydata_array, 0 + (enemyTree.SelectedNode.Index * 136) + 38).ToString("D");
            richTextBoxBash.Text = BitConverter.ToUInt16(enemydata_array, 0 + (enemyTree.SelectedNode.Index * 136) + 40).ToString("D");
            richTextBoxFire.Text = BitConverter.ToUInt16(enemydata_array, 0 + (enemyTree.SelectedNode.Index * 136) + 42).ToString("D");
            richTextBoxIce.Text = BitConverter.ToUInt16(enemydata_array, 0 + (enemyTree.SelectedNode.Index * 136) + 44).ToString("D");
            richTextBoxElec.Text = BitConverter.ToUInt16(enemydata_array, 0 + (enemyTree.SelectedNode.Index * 136) + 46).ToString("D");
            richTextBoxWind.Text = BitConverter.ToUInt16(enemydata_array, 0 + (enemyTree.SelectedNode.Index * 136) + 48).ToString("D");
            richTextBoxLight.Text = BitConverter.ToUInt16(enemydata_array, 0 + (enemyTree.SelectedNode.Index * 136) + 50).ToString("D");
            richTextBoxDark.Text = BitConverter.ToUInt16(enemydata_array, 0 + (enemyTree.SelectedNode.Index * 136) + 52).ToString("D");

            

            richTextBoxExp.Text = BitConverter.ToUInt32(enemydata_array, 0 + (enemyTree.SelectedNode.Index * 136) + 104).ToString("D");


            //Unknown Values
            richTextBoxByte4.Text = enemydata_array[0 + (enemyTree.SelectedNode.Index * 136) + 4].ToString("D"); //byte 4
            richTextBoxByte16.Text = enemydata_array[0 + (enemyTree.SelectedNode.Index * 136) + 16].ToString("D"); //byte 16
            richTextBoxByte32.Text = enemydata_array[0 + (enemyTree.SelectedNode.Index * 136) + 32].ToString("D"); //byte 32

            richTextBoxAilment1.Text = BitConverter.ToUInt16(enemydata_array, 0 + (enemyTree.SelectedNode.Index * 136) + 54).ToString("D");
            richTextBoxAilment2.Text = BitConverter.ToUInt16(enemydata_array, 0 + (enemyTree.SelectedNode.Index * 136) + 56).ToString("D");
            richTextBoxAilment3.Text = BitConverter.ToUInt16(enemydata_array, 0 + (enemyTree.SelectedNode.Index * 136) + 58).ToString("D");
            richTextBoxAilment4.Text = BitConverter.ToUInt16(enemydata_array, 0 + (enemyTree.SelectedNode.Index * 136) + 60).ToString("D");
            richTextBoxAilment5.Text = BitConverter.ToUInt16(enemydata_array, 0 + (enemyTree.SelectedNode.Index * 136) + 62).ToString("D");
            richTextBoxAilment6.Text = BitConverter.ToUInt16(enemydata_array, 0 + (enemyTree.SelectedNode.Index * 136) + 64).ToString("D");
            richTextBoxAilment7.Text = BitConverter.ToUInt16(enemydata_array, 0 + (enemyTree.SelectedNode.Index * 136) + 66).ToString("D");
            richTextBoxAilment8.Text = BitConverter.ToUInt16(enemydata_array, 0 + (enemyTree.SelectedNode.Index * 136) + 68).ToString("D");
            richTextBoxAilment9.Text = BitConverter.ToUInt16(enemydata_array, 0 + (enemyTree.SelectedNode.Index * 136) + 70).ToString("D");

            richTextBoxAilment10.Text = BitConverter.ToUInt16(enemydata_array, 0 + (enemyTree.SelectedNode.Index * 136) + 72).ToString("D");
            richTextBoxAilment11.Text = BitConverter.ToUInt16(enemydata_array, 0 + (enemyTree.SelectedNode.Index * 136) + 74).ToString("D");
            richTextBoxAilment12.Text = BitConverter.ToUInt16(enemydata_array, 0 + (enemyTree.SelectedNode.Index * 136) + 76).ToString("D");
            richTextBoxAilment13.Text = BitConverter.ToUInt16(enemydata_array, 0 + (enemyTree.SelectedNode.Index * 136) + 78).ToString("D");
            richTextBoxAilment14.Text = BitConverter.ToUInt16(enemydata_array, 0 + (enemyTree.SelectedNode.Index * 136) + 80).ToString("D");
            richTextBoxAilment15.Text = BitConverter.ToUInt16(enemydata_array, 0 + (enemyTree.SelectedNode.Index * 136) + 82).ToString("D");
            richTextBoxAilment16.Text = BitConverter.ToUInt16(enemydata_array, 0 + (enemyTree.SelectedNode.Index * 136) + 84).ToString("D");


            richTextBoxItem1.Text = BitConverter.ToUInt16(enemydata_array, 0 + (enemyTree.SelectedNode.Index * 136) + 108).ToString("D");
            richTextBoxItem2.Text = BitConverter.ToUInt16(enemydata_array, 0 + (enemyTree.SelectedNode.Index * 136) + 114).ToString("D");
            richTextBoxItem3.Text = BitConverter.ToUInt16(enemydata_array, 0 + (enemyTree.SelectedNode.Index * 136) + 120).ToString("D");
            richTextBoxItem1Drop.Text = enemydata_array[0 + (enemyTree.SelectedNode.Index * 136) + 110].ToString("D");
            richTextBoxItem2Drop.Text = enemydata_array[0 + (enemyTree.SelectedNode.Index * 136) + 116].ToString("D");
            richTextBoxItem3Drop.Text = enemydata_array[0 + (enemyTree.SelectedNode.Index * 136) + 122].ToString("D");

        }

        private void buttonSave_Click(object sender, EventArgs e) //Save Button
        {
            //B! .TryParse(Name! .Text, out type! value! ); { Form1.ByteWriter( value! , enemydata_array, StartingHex! + (treeView1.SelectedNode.Index * RowSize! ) + ArrayOfset! ); }
            //B=Byte size, 1="Byte" 2="UInt16" 4="UInt32"         Name!=the name of the textbox        type!= byte / ushort / uint, only include this in the FIRST time this ever happens in a form, later copies ommit this!
            //value!=Name of variable that holds the byte type (so byte/short/int has diffrent names)       StartingHex!= The hex offset      RowSize!=How many bytes in a row    Arrayofset! = how far into the row do we start grabbing info or saving it
            
            Byte.TryParse(richTextBoxLv.Text, out byte value8); { Form1.ByteWriter(value8, enemydata_array, 0 + (enemyTree.SelectedNode.Index * 136) + 8); } //First 1 byte save
            UInt32.TryParse(richTextBoxMaxHP.Text, out uint value32); { Form1.ByteWriter(value32, enemydata_array, 0 + (enemyTree.SelectedNode.Index * 136) + 12); } //First 4 byte save

            UInt16.TryParse(richTextBoxStr.Text, out ushort value16); { Form1.ByteWriter(value16, enemydata_array, 0 + (enemyTree.SelectedNode.Index * 136) + 20); } //First 2 byte save
            UInt16.TryParse(richTextBoxMag.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 0 + (enemyTree.SelectedNode.Index * 136) + 22); } 
            UInt16.TryParse(richTextBoxEn.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 0 + (enemyTree.SelectedNode.Index * 136) + 24); } 
            UInt16.TryParse(richTextBoxAgi.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 0 + (enemyTree.SelectedNode.Index * 136) + 26); } 
            UInt16.TryParse(richTextBoxLuck.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 0 + (enemyTree.SelectedNode.Index * 136) + 28); } 

            UInt16.TryParse(richTextBoxCut.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 0 + (enemyTree.SelectedNode.Index * 136) + 36); } 
            UInt16.TryParse(richTextBoxStab.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 0 + (enemyTree.SelectedNode.Index * 136) + 38); } 
            UInt16.TryParse(richTextBoxBash.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 0 + (enemyTree.SelectedNode.Index * 136) + 40); } 
            UInt16.TryParse(richTextBoxFire.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 0 + (enemyTree.SelectedNode.Index * 136) + 42); } 
            UInt16.TryParse(richTextBoxIce.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 0 + (enemyTree.SelectedNode.Index * 136) + 44); } 
            UInt16.TryParse(richTextBoxElec.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 0 + (enemyTree.SelectedNode.Index * 136) + 46); } 
            UInt16.TryParse(richTextBoxWind.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 0 + (enemyTree.SelectedNode.Index * 136) + 48); } 
            UInt16.TryParse(richTextBoxLight.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 0 + (enemyTree.SelectedNode.Index * 136) + 50); } 
            UInt16.TryParse(richTextBoxDark.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 0 + (enemyTree.SelectedNode.Index * 136) + 52); } 

            UInt32.TryParse(richTextBoxExp.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 0 + (enemyTree.SelectedNode.Index * 136) + 104); } 


            Byte.TryParse(richTextBoxByte4.Text, out value8); { Form1.ByteWriter(value8, enemydata_array, 0 + (enemyTree.SelectedNode.Index * 136) + 4); } 
            Byte.TryParse(richTextBoxByte16.Text, out value8); { Form1.ByteWriter(value8, enemydata_array, 0 + (enemyTree.SelectedNode.Index * 136) + 16); } 
            Byte.TryParse(richTextBoxByte32.Text, out value8); { Form1.ByteWriter(value8, enemydata_array, 0 + (enemyTree.SelectedNode.Index * 136) + 32); } 

            UInt16.TryParse(richTextBoxAilment1.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 0 + (enemyTree.SelectedNode.Index * 136) + 54); } 
            UInt16.TryParse(richTextBoxAilment2.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 0 + (enemyTree.SelectedNode.Index * 136) + 56); } 
            UInt16.TryParse(richTextBoxAilment3.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 0 + (enemyTree.SelectedNode.Index * 136) + 58); } 
            UInt16.TryParse(richTextBoxAilment4.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 0 + (enemyTree.SelectedNode.Index * 136) + 60); } 
            UInt16.TryParse(richTextBoxAilment5.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 0 + (enemyTree.SelectedNode.Index * 136) + 62); } 
            UInt16.TryParse(richTextBoxAilment6.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 0 + (enemyTree.SelectedNode.Index * 136) + 64); } 
            UInt16.TryParse(richTextBoxAilment7.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 0 + (enemyTree.SelectedNode.Index * 136) + 66); } 
            UInt16.TryParse(richTextBoxAilment8.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 0 + (enemyTree.SelectedNode.Index * 136) + 68); } 
            UInt16.TryParse(richTextBoxAilment9.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 0 + (enemyTree.SelectedNode.Index * 136) + 70); } 
            
            UInt16.TryParse(richTextBoxAilment10.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 0 + (enemyTree.SelectedNode.Index * 136) + 72); } 
            UInt16.TryParse(richTextBoxAilment11.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 0 + (enemyTree.SelectedNode.Index * 136) + 74); } 
            UInt16.TryParse(richTextBoxAilment12.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 0 + (enemyTree.SelectedNode.Index * 136) + 76); } 
            UInt16.TryParse(richTextBoxAilment13.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 0 + (enemyTree.SelectedNode.Index * 136) + 78); } 
            UInt16.TryParse(richTextBoxAilment14.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 0 + (enemyTree.SelectedNode.Index * 136) + 80); } 
            UInt16.TryParse(richTextBoxAilment15.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 0 + (enemyTree.SelectedNode.Index * 136) + 82); } 
            UInt16.TryParse(richTextBoxAilment16.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 0 + (enemyTree.SelectedNode.Index * 136) + 84); } 
            

            File.WriteAllBytes(Properties.Settings.Default.PQRomFS + "\\battle\\table\\enemydata.tbl", enemydata_array); //saves to the path i set, everything in the array/
        }

        private void label41_Click(object sender, EventArgs e) //delete me
        {

        }
    }
}
