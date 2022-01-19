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
using Microsoft.WindowsAPICodePack.Dialogs; // used for the folder browser
//using OriginTablets.Types;

namespace Etrian_Odyssey_IV_test
{
    public partial class FormIVSkill : Form
    {
        String treeloaded = "No";
        List<ComboBox> boxes = new List<ComboBox>();  //Puts the combo boxes in an array called boxes so i can refernce this array later (to make the code pretty and save time)
        byte[] enemydata_array; //This starts the array, the name after is what i name this array?
        public FormIVSkill()
        {
            InitializeComponent();
            boxes.Add(comboBoxSkillFlag1);
            boxes.Add(comboBoxSkillFlag2);
            boxes.Add(comboBoxSkillFlag3);
            boxes.Add(comboBoxSkillFlag4);
            boxes.Add(comboBoxSkillFlag5);
            boxes.Add(comboBoxSkillFlag6);
            boxes.Add(comboBoxSkillFlag7);
            boxes.Add(comboBoxSkillFlag8);



            string enemydata_path = Properties.Settings.Default.EOIVRomFS + "\\romfs\\00040000000BD300\\Skill\\playerskilltable.tbl";
            int enemydata_length = (int)(new FileInfo(enemydata_path).Length);   //The leagth of the array?
            enemydata_array = File.ReadAllBytes(enemydata_path);


            skillTree.Nodes.Add("Attack");
            skillTree.Nodes.Add("Proficiency");
            skillTree.Nodes.Add("Expertise");
            skillTree.Nodes.Add("Enlightenment");
            skillTree.Nodes.Add("Swordbreaker");
            skillTree.Nodes.Add("Weapon Parry");
            skillTree.Nodes.Add("Initiative");
            skillTree.Nodes.Add("Link Mastery");
            skillTree.Nodes.Add("Power Boost");
            skillTree.Nodes.Add("Iron Wall");
            skillTree.Nodes.Add("Vanguard");
            skillTree.Nodes.Add("Improved Link");
            skillTree.Nodes.Add("Power Break");
            skillTree.Nodes.Add("Mind Break");
            skillTree.Nodes.Add("Sonic Raid");
            skillTree.Nodes.Add("Blazing Link");
            skillTree.Nodes.Add("Freezing Link");
            skillTree.Nodes.Add("Electric Link");
            skillTree.Nodes.Add("Double Strike");
            skillTree.Nodes.Add("Spiral Slice");
            skillTree.Nodes.Add("Sword Tempest");
            skillTree.Nodes.Add("Penetrate");
            skillTree.Nodes.Add("Swift Stab");
            skillTree.Nodes.Add("Bandage");
            skillTree.Nodes.Add("Mineralogy");
            skillTree.Nodes.Add("Muscular Chef");
            skillTree.Nodes.Add("Proficiency");
            skillTree.Nodes.Add("Expertise");
            skillTree.Nodes.Add("Enlightenment");
            skillTree.Nodes.Add("Blade Flurry");
            skillTree.Nodes.Add("Follow Trace");
            skillTree.Nodes.Add("Auto-Cloak");
            skillTree.Nodes.Add("Auto-Spread");
            skillTree.Nodes.Add("Foul Mastery");
            skillTree.Nodes.Add("Speed Boost");
            skillTree.Nodes.Add("Shadow Cloak");
            skillTree.Nodes.Add("Decoy Sign");
            skillTree.Nodes.Add("Spread Throw");
            skillTree.Nodes.Add("Ice Knife");
            skillTree.Nodes.Add("Biding Slice");
            skillTree.Nodes.Add("Assassinate");
            skillTree.Nodes.Add("Shadow Bite");
            skillTree.Nodes.Add("Swift Edge");
            skillTree.Nodes.Add("Sand Throw");
            skillTree.Nodes.Add("Venom Throw");
            skillTree.Nodes.Add("Sleep Throw");
            skillTree.Nodes.Add("Nerve Throw");
            skillTree.Nodes.Add("Curse Throw");
            skillTree.Nodes.Add("Sneak Attack");
            skillTree.Nodes.Add("Herbology");
            skillTree.Nodes.Add("Agile Chef");
            skillTree.Nodes.Add("Proficiency");
            skillTree.Nodes.Add("Expertise");
            skillTree.Nodes.Add("Enlightenment");
            skillTree.Nodes.Add("Knight's Boon");
            skillTree.Nodes.Add("Healing Wall");
            skillTree.Nodes.Add("Auto-Taunt");
            skillTree.Nodes.Add("Guard Mastery");
            skillTree.Nodes.Add("Iron Wall");
            skillTree.Nodes.Add("HP Boost");
            skillTree.Nodes.Add("Rampart");
            skillTree.Nodes.Add("Taunt");
            skillTree.Nodes.Add("Bolt Strike");
            skillTree.Nodes.Add("Holy Smite");
            skillTree.Nodes.Add("Vengeance Bash");
            skillTree.Nodes.Add("Earth Break");
            skillTree.Nodes.Add("Ally Shield");
            skillTree.Nodes.Add("Line Shield");
            skillTree.Nodes.Add("Party Shield");
            skillTree.Nodes.Add("Weak Shield");
            skillTree.Nodes.Add("Holy Blessing");
            skillTree.Nodes.Add("Strike Guard");
            skillTree.Nodes.Add("Element Guard");
            skillTree.Nodes.Add("Sentry");
            skillTree.Nodes.Add("Mineralogy");
            skillTree.Nodes.Add("Hardy Chef");
            skillTree.Nodes.Add("Proficiency");
            skillTree.Nodes.Add("Expertise");
            skillTree.Nodes.Add("Enlightenment");
            skillTree.Nodes.Add("Scavenger");
            skillTree.Nodes.Add("Bullseye");
            skillTree.Nodes.Add("Chase Bind");
            skillTree.Nodes.Add("Snipe Mastery");
            skillTree.Nodes.Add("High Caution");
            skillTree.Nodes.Add("Power Boost");
            skillTree.Nodes.Add("Eagle Eye");
            skillTree.Nodes.Add("Spotter");
            skillTree.Nodes.Add("Lock On");
            skillTree.Nodes.Add("Fire Shot");
            skillTree.Nodes.Add("Leg Snipe");
            skillTree.Nodes.Add("Arm Snipe");
            skillTree.Nodes.Add("Head Snipe");
            skillTree.Nodes.Add("Steel Arrow");
            skillTree.Nodes.Add("Silver Arrow");
            skillTree.Nodes.Add("Impact Arrow");
            skillTree.Nodes.Add("Flank Shot");
            skillTree.Nodes.Add("Squall Volley");
            skillTree.Nodes.Add("Divine Shot");
            skillTree.Nodes.Add("Camouflage");
            skillTree.Nodes.Add("Dendrology");
            skillTree.Nodes.Add("Discerning Eye");
            skillTree.Nodes.Add("Proficiency");
            skillTree.Nodes.Add("Expertise");
            skillTree.Nodes.Add("Enlightenment");
            skillTree.Nodes.Add("Patch Up");
            skillTree.Nodes.Add("Auto-Heal");
            skillTree.Nodes.Add("Auto-Revive");
            skillTree.Nodes.Add("Heal Mastery");
            skillTree.Nodes.Add("Stretch");
            skillTree.Nodes.Add("TP Boost");
            skillTree.Nodes.Add("Steady Hands");
            skillTree.Nodes.Add("Group Therapy");
            skillTree.Nodes.Add("Healing");
            skillTree.Nodes.Add("Line Heal");
            skillTree.Nodes.Add("Party Heal");
            skillTree.Nodes.Add("Full Heal");
            skillTree.Nodes.Add("Revive");
            skillTree.Nodes.Add("Treat");
            skillTree.Nodes.Add("Refresh");
            skillTree.Nodes.Add("Recovery");
            skillTree.Nodes.Add("Full Refresh");
            skillTree.Nodes.Add("Heavy Strike");
            skillTree.Nodes.Add("Knockout Blow");
            skillTree.Nodes.Add("Star Drop");
            skillTree.Nodes.Add("Herbology");
            skillTree.Nodes.Add("Toxin Study");
            skillTree.Nodes.Add("Proficiency");
            skillTree.Nodes.Add("Expertise");
            skillTree.Nodes.Add("Enlightenment");
            skillTree.Nodes.Add("Runic Shield");
            skillTree.Nodes.Add("Runic Guidance");
            skillTree.Nodes.Add("Rune Mastery");
            skillTree.Nodes.Add("Free Energy");
            skillTree.Nodes.Add("TP Boost");
            skillTree.Nodes.Add("Runic Flare");
            skillTree.Nodes.Add("Runic Gleam");
            skillTree.Nodes.Add("Fire Rune");
            skillTree.Nodes.Add("Ice Rune");
            skillTree.Nodes.Add("Volt Rune");
            skillTree.Nodes.Add("Origin Rune");
            skillTree.Nodes.Add("Fireball Rune");
            skillTree.Nodes.Add("Flame Rune");
            skillTree.Nodes.Add("Inferno Rune");
            skillTree.Nodes.Add("Ice Lance Rune");
            skillTree.Nodes.Add("Glacier Rune");
            skillTree.Nodes.Add("Blizzard Rune");
            skillTree.Nodes.Add("Lightning Rune");
            skillTree.Nodes.Add("Storm Rune");
            skillTree.Nodes.Add("Galvanic Rune");
            skillTree.Nodes.Add("Herbology");
            skillTree.Nodes.Add("Wise Chef");
            skillTree.Nodes.Add("Proficiency");
            skillTree.Nodes.Add("Expertise");
            skillTree.Nodes.Add("Enlightenment");
            skillTree.Nodes.Add("Sword Dance");
            skillTree.Nodes.Add("Fan Dance");
            skillTree.Nodes.Add("Dance Mastery");
            skillTree.Nodes.Add("Burst Saver");
            skillTree.Nodes.Add("Mist Dance");
            skillTree.Nodes.Add("Speed Boost");
            skillTree.Nodes.Add("Quick Step");
            skillTree.Nodes.Add("Regen Waltz");
            skillTree.Nodes.Add("Freedom Waltz");
            skillTree.Nodes.Add("Refresh Waltz");
            skillTree.Nodes.Add("Attack Tango");
            skillTree.Nodes.Add("Guard Tango");
            skillTree.Nodes.Add("Energy Tango");
            skillTree.Nodes.Add("Counter Samba");
            skillTree.Nodes.Add("Chase Samba");
            skillTree.Nodes.Add("Trick Samba");
            skillTree.Nodes.Add("Healing Step");
            skillTree.Nodes.Add("Wide Dance");
            skillTree.Nodes.Add("Rush Dance");
            skillTree.Nodes.Add("Beat Dance");
            skillTree.Nodes.Add("Dendrology");
            skillTree.Nodes.Add("Lucky Chef");
            skillTree.Nodes.Add("Proficiency");
            skillTree.Nodes.Add("Expertise");
            skillTree.Nodes.Add("Enlightenment");
            skillTree.Nodes.Add("Warding Mist");
            skillTree.Nodes.Add("Circle Boon");
            skillTree.Nodes.Add("TP Return");
            skillTree.Nodes.Add("Bracing Walk");
            skillTree.Nodes.Add("Circle Mastery");
            skillTree.Nodes.Add("Ailment Boost");
            skillTree.Nodes.Add("Dismiss Blow");
            skillTree.Nodes.Add("Dismiss Blast");
            skillTree.Nodes.Add("Dismiss Heal");
            skillTree.Nodes.Add("Releasal Spell");
            skillTree.Nodes.Add("Nerve Circle");
            skillTree.Nodes.Add("Sleep Circle");
            skillTree.Nodes.Add("Poison Circle");
            skillTree.Nodes.Add("Chaos Circle");
            skillTree.Nodes.Add("Hood Circle");
            skillTree.Nodes.Add("Chain Circle");
            skillTree.Nodes.Add("Snare Circle");
            skillTree.Nodes.Add("Charm Eye");
            skillTree.Nodes.Add("Atrophic Eye");
            skillTree.Nodes.Add("Tame Ground");
            skillTree.Nodes.Add("Herbology");
            skillTree.Nodes.Add("Purist Chef");
            skillTree.Nodes.Add("Proficiency");
            skillTree.Nodes.Add("Expertise");
            skillTree.Nodes.Add("Enlightenment");
            skillTree.Nodes.Add("Defiance");
            skillTree.Nodes.Add("Auto-Surge");
            skillTree.Nodes.Add("Endure");
            skillTree.Nodes.Add("Ferocity");
            skillTree.Nodes.Add("Surge Mastery");
            skillTree.Nodes.Add("Power Boost");
            skillTree.Nodes.Add("Charge");
            skillTree.Nodes.Add("Blood Surge");
            skillTree.Nodes.Add("Deep Breath");
            skillTree.Nodes.Add("Roar");
            skillTree.Nodes.Add("Nerve Strike");
            skillTree.Nodes.Add("Shockwave");
            skillTree.Nodes.Add("Moon Slash");
            skillTree.Nodes.Add("Ice Slash");
            skillTree.Nodes.Add("Flash Slice");
            skillTree.Nodes.Add("Multi-Slash");
            skillTree.Nodes.Add("Skull Crusher");
            skillTree.Nodes.Add("Fire Strike");
            skillTree.Nodes.Add("Meteor Strike");
            skillTree.Nodes.Add("Fierce Strike");
            skillTree.Nodes.Add("Dendrology");
            skillTree.Nodes.Add("Robust Chef");
            skillTree.Nodes.Add("Proficiency");
            skillTree.Nodes.Add("Expertise");
            skillTree.Nodes.Add("Enlightenment");
            skillTree.Nodes.Add("Absorber");
            skillTree.Nodes.Add("Wide Effect");
            skillTree.Nodes.Add("Finisher");
            skillTree.Nodes.Add("Drive Mastery");
            skillTree.Nodes.Add("Power Boost");
            skillTree.Nodes.Add("Element Boost");
            skillTree.Nodes.Add("Hawkeye");
            skillTree.Nodes.Add("Rear Guard");
            skillTree.Nodes.Add("Heat Sink");
            skillTree.Nodes.Add("Ignition");
            skillTree.Nodes.Add("Sharp Edge");
            skillTree.Nodes.Add("Impulse Edge");
            skillTree.Nodes.Add("Cool Edge");
            skillTree.Nodes.Add("Charge Edge");
            skillTree.Nodes.Add("Assault Drive");
            skillTree.Nodes.Add("Flame Drive");
            skillTree.Nodes.Add("Freeze Drive");
            skillTree.Nodes.Add("Shock Drive");
            skillTree.Nodes.Add("Accel Drive");
            skillTree.Nodes.Add("Overdrive");
            skillTree.Nodes.Add("Mineralogy");
            skillTree.Nodes.Add("Hunter Sense");
            skillTree.Nodes.Add("Full Retreat");
            skillTree.Nodes.Add("Calm Breath");
            skillTree.Nodes.Add("Analyze");
            skillTree.Nodes.Add("Double Slash");
            skillTree.Nodes.Add("Flame Wall");
            skillTree.Nodes.Add("Holy Gift");
            skillTree.Nodes.Add("Superspeed");
            skillTree.Nodes.Add("Black Mist");
            skillTree.Nodes.Add("Charge Order");
            skillTree.Nodes.Add("Guard Order");
            skillTree.Nodes.Add("Ice Coffin");
            skillTree.Nodes.Add("Aegis Guard");
            skillTree.Nodes.Add("Aegis Ward");
            skillTree.Nodes.Add("Falling Stars");
            skillTree.Nodes.Add("Triumph Song");
            skillTree.Nodes.Add("Swipe Slash");
            skillTree.Nodes.Add("Spectral Cage");
            skillTree.Nodes.Add("Aegis Shield");
            skillTree.Nodes.Add("Zeus' Wrath");
            skillTree.Nodes.Add("Geo Impact");
            skillTree.Nodes.Add("Supernova");
            skillTree.Nodes.Add("Hygieia's Bowl");
            skillTree.Nodes.Add("Acupuncture Pin");
            skillTree.Nodes.Add("NONE");
            skillTree.Nodes.Add("NONE");
            skillTree.Nodes.Add("NONE");
            skillTree.Nodes.Add("NONE");
            skillTree.Nodes.Add("NONE");
            skillTree.Nodes.Add("NONE");
            skillTree.Nodes.Add("NONE");
            skillTree.Nodes.Add("Trick Samba");
            skillTree.Nodes.Add("Chase Bind");
            skillTree.Nodes.Add("NONE");
            skillTree.Nodes.Add("NONE");
            skillTree.Nodes.Add("NONE");
            skillTree.Nodes.Add("NONE");
            skillTree.Nodes.Add("NONE");
            skillTree.Nodes.Add("NONE");
            skillTree.Nodes.Add("NONE");
            skillTree.Nodes.Add("NONE");
            skillTree.Nodes.Add("NONE");
            skillTree.Nodes.Add("NONE");
            skillTree.Nodes.Add("NONE");
            skillTree.Nodes.Add("NONE");
            skillTree.Nodes.Add("NONE");
            skillTree.Nodes.Add("NONE");
            skillTree.Nodes.Add("NONE");
            skillTree.Nodes.Add("NONE");
            skillTree.Nodes.Add("NONE");
            skillTree.Nodes.Add("NONE");
            skillTree.Nodes.Add("NONE");
            skillTree.Nodes.Add("NONE");
            skillTree.Nodes.Add("Nerve Circle");
            skillTree.Nodes.Add("Sleep Circle");
            skillTree.Nodes.Add("Poison Circle");
            skillTree.Nodes.Add("Chaos Circle");
            skillTree.Nodes.Add("Hood Circle");
            skillTree.Nodes.Add("Chain Circle");
            skillTree.Nodes.Add("Snare Circle");
            skillTree.Nodes.Add("NONE");
            skillTree.Nodes.Add("NONE");
            skillTree.Nodes.Add("NONE");
            skillTree.Nodes.Add("NONE");
            skillTree.Nodes.Add("NONE");
            skillTree.Nodes.Add("NONE");
            skillTree.Nodes.Add("NONE");
            skillTree.Nodes.Add("NONE");
            skillTree.Nodes.Add("NONE");
            skillTree.Nodes.Add("NONE");
            skillTree.Nodes.Add("NONE");
            skillTree.Nodes.Add("NONE");
            skillTree.Nodes.Add("NONE");
            skillTree.Nodes.Add("NONE");
            skillTree.Nodes.Add("NONE");
            skillTree.Nodes.Add("NONE");
            skillTree.Nodes.Add("NONE");
            skillTree.Nodes.Add("NONE");
            skillTree.Nodes.Add("NONE");
            skillTree.Nodes.Add("Fusillade");
            skillTree.Nodes.Add("Beat Dance");
            skillTree.Nodes.Add("NONE");
            skillTree.Nodes.Add("Reflector");
            skillTree.Nodes.Add("EM Barrier");
            skillTree.Nodes.Add("Kaishaku");
            skillTree.Nodes.Add("NONE");
            skillTree.Nodes.Add("NONE");
            skillTree.Nodes.Add("Regen Waltz");
            skillTree.Nodes.Add("Freedom Waltz");
            skillTree.Nodes.Add("Refresh Waltz");
            skillTree.Nodes.Add("Biding Slice");
            skillTree.Nodes.Add("Buc Farm");
            skillTree.Nodes.Add("Counter Samba");
            skillTree.Nodes.Add("Snipe");
            skillTree.Nodes.Add("Sharpshooter");
            skillTree.Nodes.Add("NONE");
            skillTree.Nodes.Add("NONE");
            skillTree.Nodes.Add("NONE");
            skillTree.Nodes.Add("NONE");
            skillTree.Nodes.Add("NONE");
            skillTree.Nodes.Add("NONE");
            skillTree.Nodes.Add("NONE");
            skillTree.Nodes.Add("NONE");
            skillTree.Nodes.Add("Medica");
            skillTree.Nodes.Add("Amrita");
            skillTree.Nodes.Add("Hamao");
            skillTree.Nodes.Add("Nectar");
            skillTree.Nodes.Add("Nectar");
            skillTree.Nodes.Add("Soma");
            skillTree.Nodes.Add("Theriaca A");
            skillTree.Nodes.Add("Theriaca A");
            skillTree.Nodes.Add("Theriaca B");
            skillTree.Nodes.Add("Theriaca B");
            skillTree.Nodes.Add("NONE");
            skillTree.Nodes.Add("NONE");
            skillTree.Nodes.Add("NONE");
            skillTree.Nodes.Add("Discharge");
            skillTree.Nodes.Add("Ice Stake");
            skillTree.Nodes.Add("NONE");
            skillTree.Nodes.Add("Strange Seeds");
            skillTree.Nodes.Add("Tiger Counter");
            skillTree.Nodes.Add("Rush Dance");
            skillTree.Nodes.Add("Vengeance Bash");
            skillTree.Nodes.Add("Counter");
            skillTree.Nodes.Add("Retaliate");
            skillTree.Nodes.Add("Chase Saber");
            skillTree.Nodes.Add("Chase Blow");
            skillTree.Nodes.Add("Chase Thrust");
            skillTree.Nodes.Add("Chase Samba");
            skillTree.Nodes.Add("Chase Ice");
            skillTree.Nodes.Add("Chase Volt");
            skillTree.Nodes.Add("Makibishi");
            skillTree.Nodes.Add("Ambush Stance");
            skillTree.Nodes.Add("Rocket Punch");
            skillTree.Nodes.Add("Rocket Head");
            skillTree.Nodes.Add("Rocket Jump");
            skillTree.Nodes.Add("Red Bot");
            skillTree.Nodes.Add("Blue Bot");
            skillTree.Nodes.Add("Yellow Bot");
            skillTree.Nodes.Add("All Out");
            skillTree.Nodes.Add("Infect");
            skillTree.Nodes.Add("Restore Mark");
            skillTree.Nodes.Add("Fire Prophecy");
            skillTree.Nodes.Add("Ice Prophecy");
            skillTree.Nodes.Add("Volt Prophecy");
            skillTree.Nodes.Add("Last Chase");
            skillTree.Nodes.Add("Metopon");
            skillTree.Nodes.Add("Unihorn");
            skillTree.Nodes.Add("Bravant");
            skillTree.Nodes.Add("Stonard");
            skillTree.Nodes.Add("Fire Mist");
            skillTree.Nodes.Add("Ice Mist");
            skillTree.Nodes.Add("Volt Mist");
            skillTree.Nodes.Add("Cut Mist");
            skillTree.Nodes.Add("Bash Mist");
            skillTree.Nodes.Add("Stab Mist");
            skillTree.Nodes.Add("Blaze Oil");
            skillTree.Nodes.Add("Freeze Oil");
            skillTree.Nodes.Add("Shock Oil");
            skillTree.Nodes.Add("Fire Jar");
            skillTree.Nodes.Add("Blast Jar");
            skillTree.Nodes.Add("Ice Jar");
            skillTree.Nodes.Add("Frost Jar");
            skillTree.Nodes.Add("Volt Jar");
            skillTree.Nodes.Add("Thunderbolt Jar");
            skillTree.Nodes.Add("Poison Gas");
            skillTree.Nodes.Add("Nerve Gas");
            skillTree.Nodes.Add("Blind Gas");
            skillTree.Nodes.Add("Sleep Gas");
            skillTree.Nodes.Add("Curse Gas");
            skillTree.Nodes.Add("Addle Gas");

            string[] values = new[] { 
            "Unknown Flag", 
            "00 No Flag", 
            "01 TP Cost", 
            "02",
            "03 Speed Mod",
            "04 Base Accuracy",
            "05 Accuracy Mod",
            "A4 Never Miss",
            "3F Inflict Ailments",
            "48 Skill Damage%",
            "4A Amount Restored",
            "59 Poison Damage",
            "D9 Buff Turns",
            "FF"
            };
            comboBoxSkillFlag1.Items.AddRange(values);
            comboBoxSkillFlag2.Items.AddRange(values);
            comboBoxSkillFlag3.Items.AddRange(values);
            comboBoxSkillFlag4.Items.AddRange(values);
            comboBoxSkillFlag5.Items.AddRange(values);
            comboBoxSkillFlag6.Items.AddRange(values);
            comboBoxSkillFlag7.Items.AddRange(values);
            comboBoxSkillFlag8.Items.AddRange(values);


            


            /*
                        var subheaders = new Dictionary<int, string>
                        {
                            {0x000, "00 No Flag" },
                            {0x001, "01 TP Cost" },
                            {0x002, "02 " },
                            {0x003, "03 Speed Mod" },
                            {0x004, "04 Base Accuracy" },
                            {0x048, "48 Skill Damage" },
                            {0x04A, "4A Amount Restored" },
                            {0x059, "59 Poison Damage" },
                            {0x0D9, "D9 Buff Turns" },
                        };
                        comboBoxSkillFlag1.DataSource = new BindingSource(subheaders, null);
                        comboBoxSkillFlag1.ValueMember = "Key";
                        comboBoxSkillFlag1.DisplayMember = "Value";
                        comboBoxSkillFlag2.DataSource = new BindingSource(subheaders, null);
                        comboBoxSkillFlag2.ValueMember = "Key";
                        comboBoxSkillFlag2.DisplayMember = "Value";
                        comboBoxSkillFlag3.DataSource = new BindingSource(subheaders, null);
                        comboBoxSkillFlag3.ValueMember = "Key";
                        comboBoxSkillFlag3.DisplayMember = "Value";
                        comboBoxSkillFlag4.DataSource = new BindingSource(subheaders, null);
                        comboBoxSkillFlag4.ValueMember = "Key";
                        comboBoxSkillFlag4.DisplayMember = "Value";
             */


            TreeNodeCollection nodeCollect = skillTree.Nodes;
            skillTree.SelectedNode = nodeCollect[0];
        }

        
        

        private void FormIVSkill_Load(object sender, EventArgs e)
        {
            //This makes the label be transparent onto the image it is ontop of, to look stylish.
            labelLv.Parent = pictureBoxLv;
            labelLv.BackColor = System.Drawing.Color.Transparent;
            labelLv.Location = new Point(labelLv.Left - pictureBoxLv.Left, labelLv.Top - pictureBoxLv.Top);
        }

        private void skillTree_BeforeSelect(object sender, TreeViewCancelEventArgs e) //skillTree before select
        {
            if (treeloaded == "Yes")
            {
                //B! .TryParse(Name! .Text, out type! value! ); { Form1.ByteWriter( value! , enemydata_array, StartingHex! + (treeView1.SelectedNode.Index * RowSize! ) + ArrayOfset! ); }
                //B=Byte size, 1="Byte" 2="UInt16" 4="UInt32"         Name!=the name of the textbox        type!= byte / ushort / uint, only include this in the FIRST time this ever happens in a form, later copies ommit this!
                //value!=Name of variable that holds the byte type (so byte/short/int has diffrent names)       StartingHex!= The hex offset      RowSize!=How many bytes in a row    Arrayofset! = how far into the row do we start grabbing info or saving it
                Byte.TryParse(textBoxLv.Text, out byte value8); { Form1.ByteWriter(value8, enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 1); } //First 1 byte save


                UInt32.TryParse(textBoxFlag1Lv1.Text, out uint value32); { Form1.ByteWriter(value32, enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 29); }
                UInt32.TryParse(textBoxFlag1Lv2.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 33); }
                UInt32.TryParse(textBoxFlag1Lv3.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 37); }
                UInt32.TryParse(textBoxFlag1Lv4.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 41); }
                UInt32.TryParse(textBoxFlag1Lv5.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 45); }  //Flag 1 Lv1~10 Data
                UInt32.TryParse(textBoxFlag1Lv6.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 49); }
                UInt32.TryParse(textBoxFlag1Lv7.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 53); }
                UInt32.TryParse(textBoxFlag1Lv8.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 57); }
                UInt32.TryParse(textBoxFlag1Lv9.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 61); }
                UInt32.TryParse(textBoxFlag1Lv10.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 65); }

                UInt32.TryParse(textBoxFlag2Lv1.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 73); }
                UInt32.TryParse(textBoxFlag2Lv2.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 77); }
                UInt32.TryParse(textBoxFlag2Lv3.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 81); }
                UInt32.TryParse(textBoxFlag2Lv4.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 85); }
                UInt32.TryParse(textBoxFlag2Lv5.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 89); }  //Flag 2 Lv1~10 Data
                UInt32.TryParse(textBoxFlag2Lv6.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 93); }
                UInt32.TryParse(textBoxFlag2Lv7.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 97); }
                UInt32.TryParse(textBoxFlag2Lv8.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 101); }
                UInt32.TryParse(textBoxFlag2Lv9.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 105); }
                UInt32.TryParse(textBoxFlag2Lv10.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 109); }

                UInt32.TryParse(textBoxFlag3Lv1.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 117); }
                UInt32.TryParse(textBoxFlag3Lv2.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 121); }
                UInt32.TryParse(textBoxFlag3Lv3.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 125); }
                UInt32.TryParse(textBoxFlag3Lv4.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 129); }
                UInt32.TryParse(textBoxFlag3Lv5.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 133); }  //Flag 3 Lv1~10 Data
                UInt32.TryParse(textBoxFlag3Lv6.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 137); }
                UInt32.TryParse(textBoxFlag3Lv7.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 141); }
                UInt32.TryParse(textBoxFlag3Lv8.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 145); }
                UInt32.TryParse(textBoxFlag3Lv9.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 149); }
                UInt32.TryParse(textBoxFlag3Lv10.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 153); }

                UInt32.TryParse(textBoxFlag4Lv1.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 161); }
                UInt32.TryParse(textBoxFlag4Lv2.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 165); }
                UInt32.TryParse(textBoxFlag4Lv3.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 169); }
                UInt32.TryParse(textBoxFlag4Lv4.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 173); }
                UInt32.TryParse(textBoxFlag4Lv5.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 177); }  //Flag 4 Lv1~10 Data
                UInt32.TryParse(textBoxFlag4Lv6.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 181); }
                UInt32.TryParse(textBoxFlag4Lv7.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 185); }
                UInt32.TryParse(textBoxFlag4Lv8.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 189); }
                UInt32.TryParse(textBoxFlag4Lv9.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 193); }
                UInt32.TryParse(textBoxFlag4Lv10.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 197); }

                UInt32.TryParse(textBoxFlag5Lv1.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 205); }
                UInt32.TryParse(textBoxFlag5Lv2.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 209); }
                UInt32.TryParse(textBoxFlag5Lv3.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 213); }
                UInt32.TryParse(textBoxFlag5Lv4.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 217); }
                UInt32.TryParse(textBoxFlag5Lv5.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 221); }  //Flag 5 Lv1~10 Data
                UInt32.TryParse(textBoxFlag5Lv6.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 225); }
                UInt32.TryParse(textBoxFlag5Lv7.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 229); }
                UInt32.TryParse(textBoxFlag5Lv8.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 233); }
                UInt32.TryParse(textBoxFlag5Lv9.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 237); }
                UInt32.TryParse(textBoxFlag5Lv10.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 241); }

                UInt32.TryParse(textBoxFlag6Lv1.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 249); }
                UInt32.TryParse(textBoxFlag6Lv2.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 253); }
                UInt32.TryParse(textBoxFlag6Lv3.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 257); }
                UInt32.TryParse(textBoxFlag6Lv4.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 261); }
                UInt32.TryParse(textBoxFlag6Lv5.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 265); }  //Flag 6 Lv1~10 Data
                UInt32.TryParse(textBoxFlag6Lv6.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 269); }
                UInt32.TryParse(textBoxFlag6Lv7.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 273); }
                UInt32.TryParse(textBoxFlag6Lv8.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 277); }
                UInt32.TryParse(textBoxFlag6Lv9.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 281); }
                UInt32.TryParse(textBoxFlag6Lv10.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 285); }

                UInt32.TryParse(textBoxFlag7Lv1.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 293); }
                UInt32.TryParse(textBoxFlag7Lv2.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 297); }
                UInt32.TryParse(textBoxFlag7Lv3.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 301); }
                UInt32.TryParse(textBoxFlag7Lv4.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 305); }
                UInt32.TryParse(textBoxFlag7Lv5.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 309); }  //Flag 7 Lv1~10 Data
                UInt32.TryParse(textBoxFlag7Lv6.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 313); }
                UInt32.TryParse(textBoxFlag7Lv7.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 317); }
                UInt32.TryParse(textBoxFlag7Lv8.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 321); }
                UInt32.TryParse(textBoxFlag7Lv9.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 325); }
                UInt32.TryParse(textBoxFlag7Lv10.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 329); }

                UInt32.TryParse(textBoxFlag8Lv1.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 337); }
                UInt32.TryParse(textBoxFlag8Lv2.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 341); }
                UInt32.TryParse(textBoxFlag8Lv3.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 345); }
                UInt32.TryParse(textBoxFlag8Lv4.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 349); }
                UInt32.TryParse(textBoxFlag8Lv5.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 353); }  //Flag 8 Lv1~10 Data
                UInt32.TryParse(textBoxFlag8Lv6.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 357); }
                UInt32.TryParse(textBoxFlag8Lv7.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 361); }
                UInt32.TryParse(textBoxFlag8Lv8.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 365); }
                UInt32.TryParse(textBoxFlag8Lv9.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 369); }
                UInt32.TryParse(textBoxFlag8Lv10.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 373); }


                /*
                void nameOfFlags(int box_id)
                {
                    //skillTree.Nodes.Add("Function Is Working!" + VarcomboBoxSkillFlag);
                    boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("Unknown Flag");
                    if (VarSkillFlag == "0") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("00 No Flag"); }
                    if (VarSkillFlag == "1") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("01 TP Cost"); }
                    if (VarSkillFlag == "3") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("03 Speed Mod"); }
                

                saveFlags(0);

                void saveFlags(int box_id) 
                { 
                    if (   boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("00 No Flag")  ) {    }

                }
                */

                File.WriteAllBytes(Properties.Settings.Default.EOIVRomFS + "\\romfs\\00040000000BD300\\Skill\\playerskilltable.tbl", enemydata_array); //saves to the path i set, everything in the array/
            }

            else
            {
                treeloaded = "Yes";
            }
        }

        private void skillTree_AfterSelect(object sender, TreeViewEventArgs e) //skillTree after select
        {
            //First offset INCLUDES decimal 0, row does NOT, neither does per row offset.
            textBoxLv.Text = enemydata_array[375 + (skillTree.SelectedNode.Index * 376) + 1].ToString("D");


            //Load Lv1~10 data into textboxes for first 4 flags
            textBoxFlag1Lv1.Text = BitConverter.ToUInt32(enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 29).ToString("D");
            textBoxFlag1Lv2.Text = BitConverter.ToUInt32(enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 33).ToString("D");
            textBoxFlag1Lv3.Text = BitConverter.ToUInt32(enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 37).ToString("D");
            textBoxFlag1Lv4.Text = BitConverter.ToUInt32(enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 41).ToString("D");  //Flag 1 Lv1~10 Data
            textBoxFlag1Lv5.Text = BitConverter.ToUInt32(enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 45).ToString("D");
            textBoxFlag1Lv6.Text = BitConverter.ToUInt32(enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 49).ToString("D");
            textBoxFlag1Lv7.Text = BitConverter.ToUInt32(enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 53).ToString("D");
            textBoxFlag1Lv8.Text = BitConverter.ToUInt32(enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 57).ToString("D");
            textBoxFlag1Lv9.Text = BitConverter.ToUInt32(enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 61).ToString("D");
            textBoxFlag1Lv10.Text = BitConverter.ToUInt32(enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 65).ToString("D");

            textBoxFlag2Lv1.Text = BitConverter.ToUInt32(enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 73).ToString("D");
            textBoxFlag2Lv2.Text = BitConverter.ToUInt32(enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 77).ToString("D");
            textBoxFlag2Lv3.Text = BitConverter.ToUInt32(enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 81).ToString("D");
            textBoxFlag2Lv4.Text = BitConverter.ToUInt32(enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 85).ToString("D");
            textBoxFlag2Lv5.Text = BitConverter.ToUInt32(enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 89).ToString("D");  //Flag 2 Lv1~10 Data
            textBoxFlag2Lv6.Text = BitConverter.ToUInt32(enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 93).ToString("D");
            textBoxFlag2Lv7.Text = BitConverter.ToUInt32(enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 97).ToString("D");
            textBoxFlag2Lv8.Text = BitConverter.ToUInt32(enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 101).ToString("D");
            textBoxFlag2Lv9.Text = BitConverter.ToUInt32(enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 105).ToString("D");
            textBoxFlag2Lv10.Text = BitConverter.ToUInt32(enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 109).ToString("D");

            textBoxFlag3Lv1.Text = BitConverter.ToUInt32(enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 117).ToString("D");
            textBoxFlag3Lv2.Text = BitConverter.ToUInt32(enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 121).ToString("D");
            textBoxFlag3Lv3.Text = BitConverter.ToUInt32(enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 125).ToString("D");
            textBoxFlag3Lv4.Text = BitConverter.ToUInt32(enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 129).ToString("D");
            textBoxFlag3Lv5.Text = BitConverter.ToUInt32(enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 133).ToString("D");  //Flag 3 Lv1~10 Data
            textBoxFlag3Lv6.Text = BitConverter.ToUInt32(enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 137).ToString("D");
            textBoxFlag3Lv7.Text = BitConverter.ToUInt32(enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 141).ToString("D");
            textBoxFlag3Lv8.Text = BitConverter.ToUInt32(enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 145).ToString("D");
            textBoxFlag3Lv9.Text = BitConverter.ToUInt32(enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 149).ToString("D");
            textBoxFlag3Lv10.Text = BitConverter.ToUInt32(enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 153).ToString("D");

            textBoxFlag4Lv1.Text = BitConverter.ToUInt32(enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 161).ToString("D");
            textBoxFlag4Lv2.Text = BitConverter.ToUInt32(enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 165).ToString("D");
            textBoxFlag4Lv3.Text = BitConverter.ToUInt32(enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 169).ToString("D");
            textBoxFlag4Lv4.Text = BitConverter.ToUInt32(enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 173).ToString("D");
            textBoxFlag4Lv5.Text = BitConverter.ToUInt32(enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 177).ToString("D");
            textBoxFlag4Lv6.Text = BitConverter.ToUInt32(enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 181).ToString("D");  //Flag 4 Lv1~10 Data
            textBoxFlag4Lv7.Text = BitConverter.ToUInt32(enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 185).ToString("D");
            textBoxFlag4Lv8.Text = BitConverter.ToUInt32(enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 189).ToString("D");
            textBoxFlag4Lv9.Text = BitConverter.ToUInt32(enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 193).ToString("D");
            textBoxFlag4Lv10.Text = BitConverter.ToUInt32(enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 197).ToString("D");

            textBoxFlag5Lv1.Text = BitConverter.ToUInt32(enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 205).ToString("D");
            textBoxFlag5Lv2.Text = BitConverter.ToUInt32(enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 209).ToString("D");
            textBoxFlag5Lv3.Text = BitConverter.ToUInt32(enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 213).ToString("D");
            textBoxFlag5Lv4.Text = BitConverter.ToUInt32(enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 217).ToString("D");
            textBoxFlag5Lv5.Text = BitConverter.ToUInt32(enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 221).ToString("D");  //Flag 5 Lv1~10 Data
            textBoxFlag5Lv6.Text = BitConverter.ToUInt32(enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 225).ToString("D");
            textBoxFlag5Lv7.Text = BitConverter.ToUInt32(enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 229).ToString("D");
            textBoxFlag5Lv8.Text = BitConverter.ToUInt32(enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 233).ToString("D");
            textBoxFlag5Lv9.Text = BitConverter.ToUInt32(enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 237).ToString("D");
            textBoxFlag5Lv10.Text = BitConverter.ToUInt32(enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 241).ToString("D");

            textBoxFlag6Lv1.Text = BitConverter.ToUInt32(enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 249).ToString("D");
            textBoxFlag6Lv2.Text = BitConverter.ToUInt32(enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 253).ToString("D");
            textBoxFlag6Lv3.Text = BitConverter.ToUInt32(enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 257).ToString("D");
            textBoxFlag6Lv4.Text = BitConverter.ToUInt32(enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 261).ToString("D");
            textBoxFlag6Lv5.Text = BitConverter.ToUInt32(enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 265).ToString("D");   //Flag 6 Lv1~10 Data
            textBoxFlag6Lv6.Text = BitConverter.ToUInt32(enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 269).ToString("D");
            textBoxFlag6Lv7.Text = BitConverter.ToUInt32(enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 273).ToString("D");
            textBoxFlag6Lv8.Text = BitConverter.ToUInt32(enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 277).ToString("D");
            textBoxFlag6Lv9.Text = BitConverter.ToUInt32(enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 281).ToString("D");
            textBoxFlag6Lv10.Text = BitConverter.ToUInt32(enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 285).ToString("D");

            textBoxFlag7Lv1.Text = BitConverter.ToUInt32(enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 293).ToString("D");
            textBoxFlag7Lv2.Text = BitConverter.ToUInt32(enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 297).ToString("D");
            textBoxFlag7Lv3.Text = BitConverter.ToUInt32(enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 301).ToString("D");
            textBoxFlag7Lv4.Text = BitConverter.ToUInt32(enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 305).ToString("D");
            textBoxFlag7Lv5.Text = BitConverter.ToUInt32(enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 309).ToString("D");   //Flag 7 Lv1~10 Data
            textBoxFlag7Lv6.Text = BitConverter.ToUInt32(enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 313).ToString("D");
            textBoxFlag7Lv7.Text = BitConverter.ToUInt32(enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 317).ToString("D");
            textBoxFlag7Lv8.Text = BitConverter.ToUInt32(enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 321).ToString("D");
            textBoxFlag7Lv9.Text = BitConverter.ToUInt32(enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 325).ToString("D");
            textBoxFlag7Lv10.Text = BitConverter.ToUInt32(enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 329).ToString("D");

            textBoxFlag8Lv1.Text = BitConverter.ToUInt32(enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 337).ToString("D");
            textBoxFlag8Lv2.Text = BitConverter.ToUInt32(enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 341).ToString("D");
            textBoxFlag8Lv3.Text = BitConverter.ToUInt32(enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 345).ToString("D");
            textBoxFlag8Lv4.Text = BitConverter.ToUInt32(enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 349).ToString("D");
            textBoxFlag8Lv5.Text = BitConverter.ToUInt32(enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 353).ToString("D");   //Flag 8 Lv1~10 Data
            textBoxFlag8Lv6.Text = BitConverter.ToUInt32(enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 357).ToString("D");
            textBoxFlag8Lv7.Text = BitConverter.ToUInt32(enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 361).ToString("D");
            textBoxFlag8Lv8.Text = BitConverter.ToUInt32(enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 365).ToString("D");
            textBoxFlag8Lv9.Text = BitConverter.ToUInt32(enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 369).ToString("D");
            textBoxFlag8Lv10.Text = BitConverter.ToUInt32(enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 373).ToString("D");

            string VarSkillFlag = BitConverter.ToUInt16(enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 25).ToString("D"); //We put the hex into this string, and if the string is read, we make the text appear in the combo box.
            nameOfFlags(0);

            VarSkillFlag = BitConverter.ToUInt16(enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 69).ToString("D"); //We put the hex into this string, and if the string is read, we make the text appear in the combo box.
            nameOfFlags(1);

            VarSkillFlag = BitConverter.ToUInt16(enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 113).ToString("D"); //We put the hex into this string, and if the string is read, we make the text appear in the combo box.
            nameOfFlags(2);

            VarSkillFlag = BitConverter.ToUInt16(enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 157).ToString("D"); //We put the hex into this string, and if the string is read, we make the text appear in the combo box.
            nameOfFlags(3);

            VarSkillFlag = BitConverter.ToUInt16(enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 201).ToString("D"); //We put the hex into this string, and if the string is read, we make the text appear in the combo box.
            nameOfFlags(4);

            VarSkillFlag = BitConverter.ToUInt16(enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 245).ToString("D"); //We put the hex into this string, and if the string is read, we make the text appear in the combo box.
            nameOfFlags(5);

            VarSkillFlag = BitConverter.ToUInt16(enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 289).ToString("D"); //We put the hex into this string, and if the string is read, we make the text appear in the combo box.
            nameOfFlags(6);

            VarSkillFlag = BitConverter.ToUInt16(enemydata_array, 375 + (skillTree.SelectedNode.Index * 376) + 333).ToString("D"); //We put the hex into this string, and if the string is read, we make the text appear in the combo box.
            nameOfFlags(7);


            void nameOfFlags(int box_id)
            {
               //skillTree.Nodes.Add("Function Is Working!" + VarcomboBoxSkillFlag);
               boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("Unknown Flag");
               if (VarSkillFlag == "0") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("00 No Flag"); }
               if (VarSkillFlag == "1") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("01 TP Cost"); }
               if (VarSkillFlag == "3") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("03 Speed Mod"); }
               if (VarSkillFlag == "4") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("04 Base Accuracy"); }
               if (VarSkillFlag == "5") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("05 Accuracy Mod"); }
               if (VarSkillFlag == "63") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("3F Inflict Ailments"); }
               if (VarSkillFlag == "72") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("48 Skill Damage%"); }
               if (VarSkillFlag == "74") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("4A Amount Restored"); }
               if (VarSkillFlag == "89") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("59 Poison Damage"); }
               if (VarSkillFlag == "164") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("A4 Never Miss"); }
               if (VarSkillFlag == "217") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("D9 Buff Turns"); }

            }

        }


      

        private void comboBoxSkillFlag4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormIV f2 = new FormIV(); //Create the new form
            f2.StartPosition = FormStartPosition.Manual;  //Grab current windows location
            f2.Location = this.Location; //Create the new window at the same location as current one
            f2.Show(); //Show the new window
            this.Close(); //Close the current window
        }
    }

    
}
