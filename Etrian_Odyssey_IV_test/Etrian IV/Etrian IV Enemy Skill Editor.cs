﻿using System;
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
    public partial class FormIVEnemySkill : Form
    {
        String treeloaded = "No";
        byte[] enemydata_array; //This starts the array, the name after is what i name this array?
        public FormIVEnemySkill()
        {
            InitializeComponent();

            string enemydata_path = Properties.Settings.Default.EOIVRomFS + "\\romfs\\00040000000BD300\\Skill\\enemyskilltable.tbl";
            int enemydata_length = (int)(new FileInfo(enemydata_path).Length);   //The leagth of the array?
            enemydata_array = File.ReadAllBytes(enemydata_path);

            skillTree.Nodes.Add("Attack");
            skillTree.Nodes.Add("Deadly Incisor");
            skillTree.Nodes.Add("Blizzard");
            skillTree.Nodes.Add("Frozen Tongue");
            skillTree.Nodes.Add("Thunder Strike");
            skillTree.Nodes.Add("Flashy Scales");
            skillTree.Nodes.Add("Swing");
            skillTree.Nodes.Add("Throw");
            skillTree.Nodes.Add("Throw");
            skillTree.Nodes.Add("Camouflage");
            skillTree.Nodes.Add("Icicle");
            skillTree.Nodes.Add("Wheeled Attack");
            skillTree.Nodes.Add("Ruinous Strike");
            skillTree.Nodes.Add("Rising Bile");
            skillTree.Nodes.Add("Bear Claw");
            skillTree.Nodes.Add("Binding Voice");
            skillTree.Nodes.Add("Stomp");
            skillTree.Nodes.Add("Muddle Roar");
            skillTree.Nodes.Add("Tear Apart");
            skillTree.Nodes.Add("Boomerang Hook");
            skillTree.Nodes.Add("Rush Attack");
            skillTree.Nodes.Add("Nerve Stab");
            skillTree.Nodes.Add("Sticky Tongue");
            skillTree.Nodes.Add("Jump Kick");
            skillTree.Nodes.Add("Binding Root");
            skillTree.Nodes.Add("Jump");
            skillTree.Nodes.Add("Ruinous Pollen");
            skillTree.Nodes.Add("Jet Uppercut");
            skillTree.Nodes.Add("Icy Blast");
            skillTree.Nodes.Add("Blitzritter");
            skillTree.Nodes.Add("Rampage");
            skillTree.Nodes.Add("Bite Off");
            skillTree.Nodes.Add("Panic Spores");
            skillTree.Nodes.Add("Binge Eating");
            skillTree.Nodes.Add("Diving Press");
            skillTree.Nodes.Add("Raging Fangs");
            skillTree.Nodes.Add("Sleeper");
            skillTree.Nodes.Add("Sleeper");
            skillTree.Nodes.Add("Petals");
            skillTree.Nodes.Add("Black Poison");
            skillTree.Nodes.Add("Heat Wave");
            skillTree.Nodes.Add("Self-Destruct");
            skillTree.Nodes.Add("Lightning Call");
            skillTree.Nodes.Add("Bite");
            skillTree.Nodes.Add("Coiling Vine");
            skillTree.Nodes.Add("Poison Sting");
            skillTree.Nodes.Add("Nerve Spores");
            skillTree.Nodes.Add("Devour Ally");
            skillTree.Nodes.Add("Heavy Stamp");
            skillTree.Nodes.Add("High Jump");
            skillTree.Nodes.Add("Dozing Gaze");
            skillTree.Nodes.Add("Amputate");
            skillTree.Nodes.Add("Scythe Dance");
            skillTree.Nodes.Add("Mad Charge");
            skillTree.Nodes.Add("Electric Dive");
            skillTree.Nodes.Add("Belly Flop");
            skillTree.Nodes.Add("Crushing Kick");
            skillTree.Nodes.Add("Shell Wall");
            skillTree.Nodes.Add("Annoying Waves");
            skillTree.Nodes.Add("Lava Lump");
            skillTree.Nodes.Add("Icicle Lump");
            skillTree.Nodes.Add("Ram");
            skillTree.Nodes.Add("Slicing Arm");
            skillTree.Nodes.Add("Poison Spores");
            skillTree.Nodes.Add("Fire Breath");
            skillTree.Nodes.Add("Ice Breath");
            skillTree.Nodes.Add("Grinder");
            skillTree.Nodes.Add("Claw Dance");
            skillTree.Nodes.Add("Poison Tail");
            skillTree.Nodes.Add("Ripping Claw");
            skillTree.Nodes.Add("Avalanche");
            skillTree.Nodes.Add("Blizzard");
            skillTree.Nodes.Add("Hellish Sparks");
            skillTree.Nodes.Add("Target Search");
            skillTree.Nodes.Add("Spark");
            skillTree.Nodes.Add("Flame Claw");
            skillTree.Nodes.Add("Flaming Fang");
            skillTree.Nodes.Add("Stone Eye");
            skillTree.Nodes.Add("Panic Pollen");
            skillTree.Nodes.Add("Panic Pollen");
            skillTree.Nodes.Add("Armor Ripper");
            skillTree.Nodes.Add("Stone Needle");
            skillTree.Nodes.Add("Coiling Branch");
            skillTree.Nodes.Add("Self-Destruct");
            skillTree.Nodes.Add("Counter Blow");
            skillTree.Nodes.Add("Smashing Press");
            skillTree.Nodes.Add("Frozen Sphere");
            skillTree.Nodes.Add("Wrenching Fang");
            skillTree.Nodes.Add("Unseen Tongue");
            skillTree.Nodes.Add("Thorny Ball");
            skillTree.Nodes.Add("Entrapment");
            skillTree.Nodes.Add("Rush");
            skillTree.Nodes.Add("Charge");
            skillTree.Nodes.Add("Gavel Bang");
            skillTree.Nodes.Add("Purple Mist");
            skillTree.Nodes.Add("Finisher Slash");
            skillTree.Nodes.Add("Sleep Stomp");
            skillTree.Nodes.Add("Gravity Wave");
            skillTree.Nodes.Add("Oil Spin");
            skillTree.Nodes.Add("Raging Winds");
            skillTree.Nodes.Add("Frigid Scythe");
            skillTree.Nodes.Add("Overhand Swing");
            skillTree.Nodes.Add("Scythe Dance");
            skillTree.Nodes.Add("Blinding Blade");
            skillTree.Nodes.Add("Binding Ambush");
            skillTree.Nodes.Add("Ripping Arm");
            skillTree.Nodes.Add("Thermal Wave");
            skillTree.Nodes.Add("Icy Mist");
            skillTree.Nodes.Add("Cross Counter");
            skillTree.Nodes.Add("Poison");
            skillTree.Nodes.Add("Icy Ruin");
            skillTree.Nodes.Add("Sand Wing");
            skillTree.Nodes.Add("Bloodsucker");
            skillTree.Nodes.Add("Vapid Slash");
            skillTree.Nodes.Add("Sharp Claw");
            skillTree.Nodes.Add("Cursed Kick");
            skillTree.Nodes.Add("King's Claws");
            skillTree.Nodes.Add("Crab Shell");
            skillTree.Nodes.Add("Shivering Glare");
            skillTree.Nodes.Add("Thunderclap");
            skillTree.Nodes.Add("Skewer");
            skillTree.Nodes.Add("Flamethrower");
            skillTree.Nodes.Add("Acid Spray");
            skillTree.Nodes.Add("Heavenly Bolt");
            skillTree.Nodes.Add("Frost Claw");
            skillTree.Nodes.Add("Guillotine Arm");
            skillTree.Nodes.Add("Damage Drain");
            skillTree.Nodes.Add("Mow Down");
            skillTree.Nodes.Add("Emperor Guard");
            skillTree.Nodes.Add("Crushing Kick");
            skillTree.Nodes.Add("Raging Assault");
            skillTree.Nodes.Add("Predatory Ice");
            skillTree.Nodes.Add("Poison Dust");
            skillTree.Nodes.Add("Panic Stench");
            skillTree.Nodes.Add("Bloody Pact");
            skillTree.Nodes.Add("Icy Purge");
            skillTree.Nodes.Add("Poisonous Bind");
            skillTree.Nodes.Add("Shell Castle");
            skillTree.Nodes.Add("Nerve Spore");
            skillTree.Nodes.Add("Biting Flurry");
            skillTree.Nodes.Add("Piercing Claw");
            skillTree.Nodes.Add("Unload");
            skillTree.Nodes.Add("Ruinous Pollen");
            skillTree.Nodes.Add("Thorny Rain");
            skillTree.Nodes.Add("Revenge Blade");
            skillTree.Nodes.Add("Violent Vines");
            skillTree.Nodes.Add("Tangling Vines");
            skillTree.Nodes.Add("Trigourd Tune");
            skillTree.Nodes.Add("Binding");
            skillTree.Nodes.Add("Crazy Noise");
            skillTree.Nodes.Add("Strange Chant");
            skillTree.Nodes.Add("Bewildering Eye");
            skillTree.Nodes.Add("Scorching Hell");
            skillTree.Nodes.Add("Healing Chant");
            skillTree.Nodes.Add("Mince");
            skillTree.Nodes.Add("Madness Spores");
            skillTree.Nodes.Add("Kiss of Death");
            skillTree.Nodes.Add("Godly Storm");
            skillTree.Nodes.Add("NONE");
            skillTree.Nodes.Add("Blazing Link");
            skillTree.Nodes.Add("Freezing Link");
            skillTree.Nodes.Add("Electric Link");
            skillTree.Nodes.Add("NONE");
            skillTree.Nodes.Add("Icicle Jail");
            skillTree.Nodes.Add("Scale Chase");
            skillTree.Nodes.Add("No Message");
            skillTree.Nodes.Add("Fire Wall");
            skillTree.Nodes.Add("Expand");
            skillTree.Nodes.Add("NONE");
            skillTree.Nodes.Add("Unseen Tongue");
            skillTree.Nodes.Add("Delayed Stun");
            skillTree.Nodes.Add("Change");
            skillTree.Nodes.Add("Devour Ally");
            skillTree.Nodes.Add("NONE");
            skillTree.Nodes.Add("Entrapment");
            skillTree.Nodes.Add("NONE");
            skillTree.Nodes.Add("NONE");
            skillTree.Nodes.Add("NONE");
            skillTree.Nodes.Add("Counter Blow");
            skillTree.Nodes.Add("Kaishaku Heal");
            skillTree.Nodes.Add("NONE");
            skillTree.Nodes.Add("NONE");
            skillTree.Nodes.Add("NONE");
            skillTree.Nodes.Add("Cross Counter");
            skillTree.Nodes.Add("NONE");
            skillTree.Nodes.Add("NONE");
            skillTree.Nodes.Add("Counter");
            skillTree.Nodes.Add("NONE");
            skillTree.Nodes.Add("NONE");
            skillTree.Nodes.Add("NONE");
            skillTree.Nodes.Add("NONE");
            skillTree.Nodes.Add("NONE");
            skillTree.Nodes.Add("Crystal Edge");
            skillTree.Nodes.Add("Reversal Spore");
            skillTree.Nodes.Add("NONE");
            skillTree.Nodes.Add("NONE");
            skillTree.Nodes.Add("NONE");
            skillTree.Nodes.Add("NONE");
            skillTree.Nodes.Add("Counter");
            skillTree.Nodes.Add("Delay Charge");
            skillTree.Nodes.Add("Binding Voice");
            skillTree.Nodes.Add("Ruinous Strike");
            skillTree.Nodes.Add("Counter");
            skillTree.Nodes.Add("Rock Crusher");
            skillTree.Nodes.Add("Arm Breaker");
            skillTree.Nodes.Add("Berserker Rage");
            skillTree.Nodes.Add("Delayed Stun");
            skillTree.Nodes.Add("Long Thrust");
            skillTree.Nodes.Add("Cover");
            skillTree.Nodes.Add("Dark Healing");
            skillTree.Nodes.Add("Shadow Bind");
            skillTree.Nodes.Add("Shadow Curtain");
            skillTree.Nodes.Add("Dark Erosion");
            skillTree.Nodes.Add("Lovers' Breath");
            skillTree.Nodes.Add("Icy Aria");
            skillTree.Nodes.Add("Dazzling Eye");
            skillTree.Nodes.Add("Darkness Wing");
            skillTree.Nodes.Add("Dimensional Cut");
            skillTree.Nodes.Add("Blood Surge");
            skillTree.Nodes.Add("Deep Breath");
            skillTree.Nodes.Add("Moon Slash");
            skillTree.Nodes.Add("Ice Slash");
            skillTree.Nodes.Add("Fire Strike");
            skillTree.Nodes.Add("Roar");
            skillTree.Nodes.Add("Shockwave");
            skillTree.Nodes.Add("Charge");
            skillTree.Nodes.Add("Healing");
            skillTree.Nodes.Add("Knockout Blow");
            skillTree.Nodes.Add("Recovery");
            skillTree.Nodes.Add("Refresh");
            skillTree.Nodes.Add("Scorching Fire");
            skillTree.Nodes.Add("Fireball Cannon");
            skillTree.Nodes.Add("Fire Wall");
            skillTree.Nodes.Add("Fire Regen");
            skillTree.Nodes.Add("Upward Thrust");
            skillTree.Nodes.Add("Venom Tail");
            skillTree.Nodes.Add("Shock Drive");
            skillTree.Nodes.Add("Heat Sink");
            skillTree.Nodes.Add("Rear Guard");
            skillTree.Nodes.Add("Vanguard");
            skillTree.Nodes.Add("Sharp Edge");
            skillTree.Nodes.Add("Cool Edge");
            skillTree.Nodes.Add("Spiral Slice");
            skillTree.Nodes.Add("Sonic Raid");
            skillTree.Nodes.Add("Fire Shift");
            skillTree.Nodes.Add("Ice Shift");
            skillTree.Nodes.Add("Volt Shift");
            skillTree.Nodes.Add("Phys Shift");
            skillTree.Nodes.Add("Flame Mixer");
            skillTree.Nodes.Add("Ice Mixer");
            skillTree.Nodes.Add("Volt Mixer");
            skillTree.Nodes.Add("Arm Mixer");
            skillTree.Nodes.Add("Megaton Punch");
            skillTree.Nodes.Add("Pile Bunker");
            skillTree.Nodes.Add("Delayed Combo");
            skillTree.Nodes.Add("Restraint");
            skillTree.Nodes.Add("Dis-Element");
            skillTree.Nodes.Add("Electric Shock");
            skillTree.Nodes.Add("Final Strike");
            skillTree.Nodes.Add("Chaos Drive");
            skillTree.Nodes.Add("Flame Drive");
            skillTree.Nodes.Add("Ivy Thrust");
            skillTree.Nodes.Add("Heat Sink");
            skillTree.Nodes.Add("Wait W/Message");
            skillTree.Nodes.Add("Seizing Vine");
            skillTree.Nodes.Add("Kingly Ambition");
            skillTree.Nodes.Add("Ignition");
            skillTree.Nodes.Add("Overdrive");
            skillTree.Nodes.Add("Origin Flame");
            skillTree.Nodes.Add("Tundra Lance");
            skillTree.Nodes.Add("Ruinous Thunder");
            skillTree.Nodes.Add("Tempting Death");
            skillTree.Nodes.Add("Delay Charge");
            skillTree.Nodes.Add("Holy Chest");
            skillTree.Nodes.Add("Vanish Breath");
            skillTree.Nodes.Add("Regen Breath");
            skillTree.Nodes.Add("Gale Shockwave");
            skillTree.Nodes.Add("Cutting Leaves");
            skillTree.Nodes.Add("Light Barrier");
            skillTree.Nodes.Add("Protective Form");
            skillTree.Nodes.Add("Vine Cage");
            skillTree.Nodes.Add("Soul Control");
            skillTree.Nodes.Add("Hollow Domain");
            skillTree.Nodes.Add("Protective Form");
            skillTree.Nodes.Add("Holy Chest");
            skillTree.Nodes.Add("Summon Banshee");
            skillTree.Nodes.Add("Scaly Fire");
            skillTree.Nodes.Add("Face Close 1");
            skillTree.Nodes.Add("Face Close 2");
            skillTree.Nodes.Add("Head Kick");
            skillTree.Nodes.Add("Armlock");
            skillTree.Nodes.Add("Trip");
            skillTree.Nodes.Add("Lightning Kick");
            skillTree.Nodes.Add("Flame Breath");
            skillTree.Nodes.Add("Poison Breath");
            skillTree.Nodes.Add("Sonic Bite");
            skillTree.Nodes.Add("Bull Stamp");
            skillTree.Nodes.Add("Double Horns");
            skillTree.Nodes.Add("Raring Roar");
            skillTree.Nodes.Add("Withering Glare");
            skillTree.Nodes.Add("Defend");
            skillTree.Nodes.Add("Drill Rush");
            skillTree.Nodes.Add("Spin Rush");
            skillTree.Nodes.Add("Break Spin");
            skillTree.Nodes.Add("Binding Feather");
            skillTree.Nodes.Add("Eagle Dive");
            skillTree.Nodes.Add("In The Dark");
            skillTree.Nodes.Add("Feather Rain");
            skillTree.Nodes.Add("Lion's Blade");
            skillTree.Nodes.Add("Silencing Claw");
            skillTree.Nodes.Add("Fang Slice");
            skillTree.Nodes.Add("Sublime Fang");
            skillTree.Nodes.Add("Lion's Rage");
            skillTree.Nodes.Add("King's Rest");
            skillTree.Nodes.Add("Grand Uppercut");
            skillTree.Nodes.Add("Wild Tackle");
            skillTree.Nodes.Add("Healing Strike");
            skillTree.Nodes.Add("Healing Strike");
            skillTree.Nodes.Add("Summon Ball");
            skillTree.Nodes.Add("Fiery Bolts");
            skillTree.Nodes.Add("Sand Shot");
            skillTree.Nodes.Add("Withering Roar");
            skillTree.Nodes.Add("Stunning Bite");
            skillTree.Nodes.Add("Crushing Bite");
            skillTree.Nodes.Add("NONE");
            skillTree.Nodes.Add("Lick");
            skillTree.Nodes.Add("Ice Storm");
            skillTree.Nodes.Add("Poison Spit");
            skillTree.Nodes.Add("Supernova");
            skillTree.Nodes.Add("NONE");
            skillTree.Nodes.Add("NONE");
            skillTree.Nodes.Add("Summon");
            skillTree.Nodes.Add("Fortress");
            skillTree.Nodes.Add("Conciliate");
            skillTree.Nodes.Add("Restraint");
            skillTree.Nodes.Add("Cruel Stare");
            skillTree.Nodes.Add("Cruelty");
            skillTree.Nodes.Add("Demon Reaper");
            skillTree.Nodes.Add("Falcon Thrust");
            skillTree.Nodes.Add("War Spirit");
            skillTree.Nodes.Add("Kaitou Ranma");
            skillTree.Nodes.Add("Ouka no Mai");
            skillTree.Nodes.Add("Frigid Breath");
            skillTree.Nodes.Add("Glacial Regen");
            skillTree.Nodes.Add("Ice Shield");
            skillTree.Nodes.Add("NONE");
            skillTree.Nodes.Add("NONE");
            skillTree.Nodes.Add("Absolute Zero");
            skillTree.Nodes.Add("Dragon Dance");
            skillTree.Nodes.Add("NONE");
            skillTree.Nodes.Add("NONE");
            skillTree.Nodes.Add("NONEDATA");
            skillTree.Nodes.Add("NONE");
            skillTree.Nodes.Add("Regen");
            skillTree.Nodes.Add("Magic Lullaby");
            skillTree.Nodes.Add("Petrivoice");
            skillTree.Nodes.Add("Darkness Coil");
            skillTree.Nodes.Add("Poison Tail");
            skillTree.Nodes.Add("Volt Breath");
            skillTree.Nodes.Add("Cursed Strike");
            skillTree.Nodes.Add("Corrupt Howl");
            skillTree.Nodes.Add("Deadly Fangs");
            skillTree.Nodes.Add("Dragon Strike");
            skillTree.Nodes.Add("Searing Breath");
            skillTree.Nodes.Add("Echoing Howl");
            skillTree.Nodes.Add("NONEDATA");
            skillTree.Nodes.Add("Dragon Smash");
            skillTree.Nodes.Add("Red Fang");
            skillTree.Nodes.Add("Raging Strike");
            skillTree.Nodes.Add("Aquaveil");
            skillTree.Nodes.Add("Flood");
            skillTree.Nodes.Add("Coiling Tail");
            skillTree.Nodes.Add("Ice Gaze");
            skillTree.Nodes.Add("Frost Smile");
            skillTree.Nodes.Add("Shock");
            skillTree.Nodes.Add("Tentacle Beat");
            skillTree.Nodes.Add("Vampire Kiss");
            skillTree.Nodes.Add("Cursed Pollen");
            skillTree.Nodes.Add("Cry Soul");
            skillTree.Nodes.Add("Embrace");
            skillTree.Nodes.Add("Endure");
            skillTree.Nodes.Add("Chase Fire");
            skillTree.Nodes.Add("Six Sins");
            skillTree.Nodes.Add("NONEDATA");
            skillTree.Nodes.Add("Banshee Dodge");
            skillTree.Nodes.Add("NONEDATA");
            skillTree.Nodes.Add("Icicle Jail");
            skillTree.Nodes.Add("Lay Egg");
            skillTree.Nodes.Add("Finisher Slash");
            skillTree.Nodes.Add("Healing Spores");
            skillTree.Nodes.Add("Cursed Spores");
            skillTree.Nodes.Add("Multiply");
            skillTree.Nodes.Add("Palsy Destruct");
            skillTree.Nodes.Add("Coma Scream");
            skillTree.Nodes.Add("Icy Ruin");
            skillTree.Nodes.Add("Cowering Voice");
            skillTree.Nodes.Add("Self-Destruct");
            skillTree.Nodes.Add("Shrill Voice");
            skillTree.Nodes.Add("Endure");
            skillTree.Nodes.Add("Frigid Breath");
            skillTree.Nodes.Add("Absolute Zero");
            skillTree.Nodes.Add("Sonic Scream");
            skillTree.Nodes.Add("Dragon Dance");
            skillTree.Nodes.Add("Ice Crush");
            skillTree.Nodes.Add("Iceblock");
            skillTree.Nodes.Add("Glacial Regen");
            skillTree.Nodes.Add("Ice Domain");
            skillTree.Nodes.Add("Volt Breath");
            skillTree.Nodes.Add("Roaring Thunder");
            skillTree.Nodes.Add("Corrupt Howl");
            skillTree.Nodes.Add("Cursed Strike");
            skillTree.Nodes.Add("Dragon Strike");
            skillTree.Nodes.Add("Deadly Fangs");
            skillTree.Nodes.Add("Volt Domain");
            skillTree.Nodes.Add("Searing Breath");
            skillTree.Nodes.Add("Inferno");
            skillTree.Nodes.Add("Echoing Howl");
            skillTree.Nodes.Add("Dragon Claw");
            skillTree.Nodes.Add("Dragon Smash");
            skillTree.Nodes.Add("Raging Strike");
            skillTree.Nodes.Add("Fire Domain");
            skillTree.Nodes.Add("Thunder Wing");
            skillTree.Nodes.Add("Supersonic Wing");
            skillTree.Nodes.Add("Sonic Boom");
            skillTree.Nodes.Add("Deathbringer");
            skillTree.Nodes.Add("Chaosbringer");
            skillTree.Nodes.Add("Grab");
            skillTree.Nodes.Add("Twin Talons");
            skillTree.Nodes.Add("Darkness Curse");
            skillTree.Nodes.Add("Ancient Breath");
            skillTree.Nodes.Add("Infernal Flight");
            skillTree.Nodes.Add("Ice Pellets");
            skillTree.Nodes.Add("Gale Volt");
            skillTree.Nodes.Add("Dead Claw");
            skillTree.Nodes.Add("Bloody Blade");
            skillTree.Nodes.Add("Heavy Press");
            skillTree.Nodes.Add("Ground Shake");
            skillTree.Nodes.Add("Peptic Juices");
            skillTree.Nodes.Add("Guardian Thread");
            skillTree.Nodes.Add("Loosed Power");
            skillTree.Nodes.Add("Megido Flame");
            skillTree.Nodes.Add("Chaos Blizzard");
            skillTree.Nodes.Add("Volt Cyclone");
            skillTree.Nodes.Add("Holy Chest");
            skillTree.Nodes.Add("Chaotic Embrace");
            skillTree.Nodes.Add("Vanishing Wave");
            skillTree.Nodes.Add("Vanish Barrier");
            skillTree.Nodes.Add("Ragnarok");
            skillTree.Nodes.Add("Hollow Barrier");
            skillTree.Nodes.Add("Open Shell");
            skillTree.Nodes.Add("Close Shell");
            skillTree.Nodes.Add("Riot Lance");
            skillTree.Nodes.Add("Raging Bud");
            skillTree.Nodes.Add("Head Crusher");
            skillTree.Nodes.Add("Tentacle Rod");
            skillTree.Nodes.Add("Guillotine");
            skillTree.Nodes.Add("Hangman");
            skillTree.Nodes.Add("Arm Crusher");
            skillTree.Nodes.Add("Grand Scissors");
            skillTree.Nodes.Add("Raging Bud");
            skillTree.Nodes.Add("Head Crusher");
            skillTree.Nodes.Add("Tentacle Rod");
            skillTree.Nodes.Add("Hangman");
            skillTree.Nodes.Add("Arm Crusher");
            skillTree.Nodes.Add("Grand Scissors");
            skillTree.Nodes.Add("Holy Chest");
            skillTree.Nodes.Add("Riot Lance");
            skillTree.Nodes.Add("Guillotine");
            skillTree.Nodes.Add("NONEDATA");
            skillTree.Nodes.Add("NONEDATA");
            skillTree.Nodes.Add("NONEDATA");
            skillTree.Nodes.Add("NONEDATA");
            skillTree.Nodes.Add("NONEDATA");
            skillTree.Nodes.Add("NONEDATA");
            skillTree.Nodes.Add("NONEDATA");
            skillTree.Nodes.Add("NONEDATA");
            skillTree.Nodes.Add("NONEDATA");
            skillTree.Nodes.Add("NONEDATA");
            skillTree.Nodes.Add("NONEDATA");

            TreeNodeCollection nodeCollect = skillTree.Nodes;
            skillTree.SelectedNode = nodeCollect[0];
        }

        private void FormIVEnemySkill_Load(object sender, EventArgs e)
        {

        }

        private void skillTree_BeforeSelect(object sender, TreeViewCancelEventArgs e) //skillTree before select
        {
            if (treeloaded == "Yes")
            {
                File.WriteAllBytes(Properties.Settings.Default.EOIVRomFS + "\\romfs\\00040000000BD300\\Skill\\enemyskilltable.tbl", enemydata_array); //saves to the path i set, everything in the array/
            }

            else
            {
                treeloaded = "Yes";
            }
        }

        private void skillTree_AfterSelect(object sender, TreeViewEventArgs e) //skillTree after select
        {
            
        }

        private void button1_Click(object sender, EventArgs e) //Button IV
        {
            FormIV f2 = new FormIV(); //Create the new form
            f2.StartPosition = FormStartPosition.Manual;  //Grab current windows location
            f2.Location = this.Location; //Create the new window at the same location as current one
            f2.Show(); //Show the new window
            this.Close(); //Close the current window
        }
    }
}