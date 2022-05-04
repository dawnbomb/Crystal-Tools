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
    public partial class FormVesperiaArteEditor : Form
    {
        
        byte[] enemydata_array; //This starts the array, the name after is what i name this array?

        public FormVesperiaArteEditor()
        {
            InitializeComponent();

            string enemydata_path = Properties.Settings.Default.VesperiaData64 + "\\Data64\\btl.svo"; //This defines the path as a string, so i can refer to it by this string/name instead of the full path every time
            int enemydata_length = (int)(new FileInfo(enemydata_path).Length);   //The leagth of the array?
            enemydata_array = File.ReadAllBytes(enemydata_path);  //loads an array with whatever is in the path

            //Add the EO1 enemy list to the in editor list of enemy names
            enemyTree.Nodes.Add("Dummy 1");
            enemyTree.Nodes.Add("2");
            enemyTree.Nodes.Add("3");
            enemyTree.Nodes.Add("4");
            enemyTree.Nodes.Add("5");
            enemyTree.Nodes.Add("6");
            enemyTree.Nodes.Add("7");
            enemyTree.Nodes.Add("8");
            enemyTree.Nodes.Add("9");
            enemyTree.Nodes.Add("10");
            enemyTree.Nodes.Add("11");
            enemyTree.Nodes.Add("12");
            enemyTree.Nodes.Add("13");
            enemyTree.Nodes.Add("14");
            enemyTree.Nodes.Add("15");
            enemyTree.Nodes.Add("16");
            enemyTree.Nodes.Add("17");
            enemyTree.Nodes.Add("18");
            enemyTree.Nodes.Add("Azure Edge");
            enemyTree.Nodes.Add("Cerberus Strike");
            enemyTree.Nodes.Add("Fang Strike");
            enemyTree.Nodes.Add("Wolf Strike");
            enemyTree.Nodes.Add("Destruction Field");
            enemyTree.Nodes.Add("Dhaos Blast (Accessory)");
            enemyTree.Nodes.Add("Shining Fang");
            enemyTree.Nodes.Add("Tiger Blade");
            enemyTree.Nodes.Add("Draconian Slash");
            enemyTree.Nodes.Add("Ghost Wolf");
            enemyTree.Nodes.Add("Azure Wolf Strike");
            enemyTree.Nodes.Add("Crushing Eagle");
            enemyTree.Nodes.Add("Dragon Swarm");
            enemyTree.Nodes.Add("Concealed Wave");
            enemyTree.Nodes.Add("Severing Fang");
            enemyTree.Nodes.Add("Shining Eagle");
            enemyTree.Nodes.Add("Shining Dragon Swarm");
            enemyTree.Nodes.Add("Raging Blast");
            enemyTree.Nodes.Add("Brutal Fang");
            enemyTree.Nodes.Add("Wailing Havoc");
            enemyTree.Nodes.Add("Lone Wolf Charge");
            enemyTree.Nodes.Add("Final Gale");
            enemyTree.Nodes.Add("Wailing Blast");
            enemyTree.Nodes.Add("Rendering Wold Charge");
            enemyTree.Nodes.Add("Azure Storm");
            enemyTree.Nodes.Add("Azure Blast");
            enemyTree.Nodes.Add("Cerberus Blast");
            enemyTree.Nodes.Add("Shining Fang Drop");
            enemyTree.Nodes.Add("Guardian Field");
            enemyTree.Nodes.Add("Shredding Palm");
            enemyTree.Nodes.Add("Pyre Havoc");
            enemyTree.Nodes.Add("Lone Wolf Storm");
            enemyTree.Nodes.Add("Frigid Blast");
            enemyTree.Nodes.Add("Demon Attack (Title)");
            enemyTree.Nodes.Add("Divine Wolf");
            enemyTree.Nodes.Add("Divine Wolf Fire");
            enemyTree.Nodes.Add("Divine Wolf Earth");
            enemyTree.Nodes.Add("Divine Wolf Wind");
            enemyTree.Nodes.Add("Divine Wolf Water");
            enemyTree.Nodes.Add("Savage Wolf Fury");
            enemyTree.Nodes.Add("Heavenly Bladewing *MA");
            enemyTree.Nodes.Add("Twin Wave  *Duel MA");
            enemyTree.Nodes.Add("Step Combo");
            enemyTree.Nodes.Add("Regular Attack (Estelle)");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("Regular Secondary Attack - Jumping");
            enemyTree.Nodes.Add("Regular Secondary Attack - Jumping");
            enemyTree.Nodes.Add("Free Run Attack");
            enemyTree.Nodes.Add("Indigo Fatal Strike");
            enemyTree.Nodes.Add("Crimson Fatal Strike");
            enemyTree.Nodes.Add("Viridian Fatal Strike");
            enemyTree.Nodes.Add("Pow Hammer");
            enemyTree.Nodes.Add("Star Stroke");
            enemyTree.Nodes.Add("Pierce Cluster");
            enemyTree.Nodes.Add("Cavalry");
            enemyTree.Nodes.Add("Dividing Edge");
            enemyTree.Nodes.Add("Marche Waltz");
            enemyTree.Nodes.Add("Delight Roll");
            enemyTree.Nodes.Add("Tri Slash");
            enemyTree.Nodes.Add("Ray Sting");
            enemyTree.Nodes.Add("Blazing Pillar");
            enemyTree.Nodes.Add("Amenes Sorbe");
            enemyTree.Nodes.Add("Air Divide");
            enemyTree.Nodes.Add("Sylphy Roll");
            enemyTree.Nodes.Add("Phantom Blade");
            enemyTree.Nodes.Add("First Aid");
            enemyTree.Nodes.Add("Recover");
            enemyTree.Nodes.Add("Sharpness");
            enemyTree.Nodes.Add("Barrier");
            enemyTree.Nodes.Add("Astion");
            enemyTree.Nodes.Add("Resist");
            enemyTree.Nodes.Add("Photon");
            enemyTree.Nodes.Add("Healing Circle");
            enemyTree.Nodes.Add("Resurrection");
            enemyTree.Nodes.Add("Dispel");
            enemyTree.Nodes.Add("Angel Ring");
            enemyTree.Nodes.Add("Nurse");
            enemyTree.Nodes.Add("Holy Lance");
            enemyTree.Nodes.Add("Revitalize");
            enemyTree.Nodes.Add("Force Field");
            enemyTree.Nodes.Add("Variable Hex");
            enemyTree.Nodes.Add("Resist Field");
            enemyTree.Nodes.Add("Grand Chariot");
            enemyTree.Nodes.Add("Revive");
            enemyTree.Nodes.Add("Revitalize");
            enemyTree.Nodes.Add("Nightingale");
            enemyTree.Nodes.Add("Holy Rain");
            enemyTree.Nodes.Add("Extreme Stars");
            enemyTree.Nodes.Add("Star Sign - Flame");
            enemyTree.Nodes.Add("Star Sign - Geo");
            enemyTree.Nodes.Add("Star Sign - Gale");
            enemyTree.Nodes.Add("Star Sign - Aqua");
            enemyTree.Nodes.Add("Sacred Penance");
            enemyTree.Nodes.Add("Sacred Penance");
            enemyTree.Nodes.Add("Ultimate Elementia");
            enemyTree.Nodes.Add("Spirit Boom (Efreet)");
            enemyTree.Nodes.Add("Spirit Boom (Gnome)");
            enemyTree.Nodes.Add("Spirit Boom (Sylph)");
            enemyTree.Nodes.Add("Spirit Boom (Undine)");
            enemyTree.Nodes.Add("Pow Hammer Revenge");
            enemyTree.Nodes.Add("Auto Medicine");
            enemyTree.Nodes.Add("Auto Medicine 2");
            enemyTree.Nodes.Add("Regular Attack (Karol)");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("Dragon Upper");
            enemyTree.Nodes.Add("Destroying Rock");
            enemyTree.Nodes.Add("Nice Aid Smash");
            enemyTree.Nodes.Add("Destructo Pain Shot");
            enemyTree.Nodes.Add("Lightning Wave");
            enemyTree.Nodes.Add("Nice Recovery Smash");
            enemyTree.Nodes.Add("Bug Breath");
            enemyTree.Nodes.Add("Punishing Smash");
            enemyTree.Nodes.Add("Gaia Bug");
            enemyTree.Nodes.Add("Destructo Spider Web");
            enemyTree.Nodes.Add("Havoc Break");
            enemyTree.Nodes.Add("Coil Beat");
            enemyTree.Nodes.Add("Roaring Revolution");
            enemyTree.Nodes.Add("Destructo Booing");
            enemyTree.Nodes.Add("Hammer Flow Upper");
            enemyTree.Nodes.Add("Punishing Aid Smash");
            enemyTree.Nodes.Add("Reaper Knock");
            enemyTree.Nodes.Add("Punishing Beast Flash");
            enemyTree.Nodes.Add("Roaring Dragon Blow");
            enemyTree.Nodes.Add("Devil Rage Rise");
            enemyTree.Nodes.Add("Rending Drop");
            enemyTree.Nodes.Add("Ultimate Divine Destruction");
            enemyTree.Nodes.Add("Destruction Street");
            enemyTree.Nodes.Add("Nice Healing Smash");
            enemyTree.Nodes.Add("Nice Curing Smash");
            enemyTree.Nodes.Add("Destructo Pain Carnival");
            enemyTree.Nodes.Add("Hellfire Breath");
            enemyTree.Nodes.Add("Twin Punishing Smash");
            enemyTree.Nodes.Add("Havoc Thunder");
            enemyTree.Nodes.Add("Hurricane Revolution");
            enemyTree.Nodes.Add("Destructo Booing Festival");
            enemyTree.Nodes.Add("Diablo Hyper Buster");
            enemyTree.Nodes.Add("Death Quake Spark");
            enemyTree.Nodes.Add("Blazing Tempest (Title)");
            enemyTree.Nodes.Add("Ultra Punishing Swing");
            enemyTree.Nodes.Add("Ultra Punishing Heat");
            enemyTree.Nodes.Add("Ultra Punishing Crush");
            enemyTree.Nodes.Add("Ultra Punishing Typhoon");
            enemyTree.Nodes.Add("Ultra Punishing Typhoon");
            enemyTree.Nodes.Add("Ultra Punishing Soul");
            enemyTree.Nodes.Add("Overlord Reign Impact");
            enemyTree.Nodes.Add("Mega Flashbang Ultra X Bomber");
            enemyTree.Nodes.Add("Regular Attack (Rita)");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("β×ψ＝√");
            enemyTree.Nodes.Add("ζ×ψ＝φ");
            enemyTree.Nodes.Add("∠＝（x,y,z）");
            enemyTree.Nodes.Add("ζ＝δτ（ωρ）");
            enemyTree.Nodes.Add("∠＝∞");
            enemyTree.Nodes.Add("（δ/χ）λ＝ι");
            enemyTree.Nodes.Add("（δ/χ）λ＝ι With Whip?");
            enemyTree.Nodes.Add("∫∇＝Σ（ωπ）");
            enemyTree.Nodes.Add("∠＝（r,θ,φ）");
            enemyTree.Nodes.Add("Ａ＝Ｉｋ｛λ∈Λ｝");
            enemyTree.Nodes.Add("Fireball");
            enemyTree.Nodes.Add("Stone Blast");
            enemyTree.Nodes.Add("Champagne");
            enemyTree.Nodes.Add("Spread Zero");
            enemyTree.Nodes.Add("Splash");
            enemyTree.Nodes.Add("Stalagmite");
            enemyTree.Nodes.Add("Tractor Beam");
            enemyTree.Nodes.Add("Negative Gate");
            enemyTree.Nodes.Add("Spiral Flare");
            enemyTree.Nodes.Add("Tidal Wave");
            enemyTree.Nodes.Add("Violent Pain");
            enemyTree.Nodes.Add("Blade Roll");
            enemyTree.Nodes.Add("Ground Dasher");
            enemyTree.Nodes.Add("Crimson Flare");
            enemyTree.Nodes.Add("Meteor Storm");
            enemyTree.Nodes.Add("Eruption");
            enemyTree.Nodes.Add("Ivy Rush");
            enemyTree.Nodes.Add("Demon's Lance");
            enemyTree.Nodes.Add("Aqua Laser");
            enemyTree.Nodes.Add("Freeze lancer");
            enemyTree.Nodes.Add("Riot Horn");
            enemyTree.Nodes.Add("Gold Cat");
            enemyTree.Nodes.Add("Flame Dragon");
            enemyTree.Nodes.Add("Bloody Howling");
            enemyTree.Nodes.Add("Thunder Blade");
            enemyTree.Nodes.Add("Burning Strike");
            enemyTree.Nodes.Add("Mystic Drive");
            enemyTree.Nodes.Add("Raging Drive");
            enemyTree.Nodes.Add("Ruinous Drive");
            enemyTree.Nodes.Add("Fleeting Drive");
            enemyTree.Nodes.Add("Diffusional Drive");
            enemyTree.Nodes.Add("Ancient Catastrophe");
            enemyTree.Nodes.Add("Indignation");
            enemyTree.Nodes.Add("Indignation (Dhaos)");
            enemyTree.Nodes.Add("Spell Revenge/Fire Ball");
            enemyTree.Nodes.Add("Spell Revenge/Champagne");
            enemyTree.Nodes.Add("Spell Revenge/Stone Blast");
            enemyTree.Nodes.Add("Spell Revenge/Spread Zero");
            enemyTree.Nodes.Add("Regular Attack (Raven)");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("Rain");
            enemyTree.Nodes.Add("Bouquet");
            enemyTree.Nodes.Add("Serpent");
            enemyTree.Nodes.Add("Glimmer of Heaven");
            enemyTree.Nodes.Add("Around");
            enemyTree.Nodes.Add("Love Shot");
            enemyTree.Nodes.Add("Dark Chase");
            enemyTree.Nodes.Add("Violet Snake");
            enemyTree.Nodes.Add("Just Like Dancing");
            enemyTree.Nodes.Add("Cyan Instant");
            enemyTree.Nodes.Add("Heaven's Tear");
            enemyTree.Nodes.Add("Falling");
            enemyTree.Nodes.Add("Azure Heavens");
            enemyTree.Nodes.Add("Falling Stars");
            enemyTree.Nodes.Add("Crime");
            enemyTree.Nodes.Add("The Wind's Howl");
            enemyTree.Nodes.Add("Rainsong");
            enemyTree.Nodes.Add("Firefly");
            enemyTree.Nodes.Add("Rain Down");
            enemyTree.Nodes.Add("Around and Around");
            enemyTree.Nodes.Add("Crimson Helix");
            enemyTree.Nodes.Add("Rain of Heaven's Tears");
            enemyTree.Nodes.Add("Cloud of Heaven's Tears");
            enemyTree.Nodes.Add("Falling Further");
            enemyTree.Nodes.Add("The Growing World");
            enemyTree.Nodes.Add("Violent Weasel");
            enemyTree.Nodes.Add("Punishment");
            enemyTree.Nodes.Add("Flying");
            enemyTree.Nodes.Add("The Wind's Rage");
            enemyTree.Nodes.Add("Elemental Master");
            enemyTree.Nodes.Add("Elemental Master Fire");
            enemyTree.Nodes.Add("Elemental Master Earth");
            enemyTree.Nodes.Add("Elemental Master Wind");
            enemyTree.Nodes.Add("Elemental Master Water");
            enemyTree.Nodes.Add("Elemental Master Light");
            enemyTree.Nodes.Add("Elemental Master Dark");
            enemyTree.Nodes.Add("Wind Blade");
            enemyTree.Nodes.Add("Arrivederci");
            enemyTree.Nodes.Add("Hevoc Gale");
            enemyTree.Nodes.Add("Vanji Lost");
            enemyTree.Nodes.Add("Air Thrust");
            enemyTree.Nodes.Add("Inverno");
            enemyTree.Nodes.Add("Tempest");
            enemyTree.Nodes.Add("Stop Flow");
            enemyTree.Nodes.Add("Fury Blast");
            enemyTree.Nodes.Add("Chaotic Fury");
            enemyTree.Nodes.Add("Garnet Chaos");
            enemyTree.Nodes.Add("Kamikaze Fury");
            enemyTree.Nodes.Add("Storm of Chaos");
            enemyTree.Nodes.Add("Blast Heart");
            enemyTree.Nodes.Add("Crisis Rain");
            enemyTree.Nodes.Add("Arrow Revenge");
            enemyTree.Nodes.Add("Wide slice (Judith?)");
            enemyTree.Nodes.Add("High thrust");
            enemyTree.Nodes.Add("Middle thrust");
            enemyTree.Nodes.Add("Leg sweep");
            enemyTree.Nodes.Add("Jump cut");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("Crescent Moon");
            enemyTree.Nodes.Add("Luna Fang");
            enemyTree.Nodes.Add("Moonlight Havoc");
            enemyTree.Nodes.Add("New Moon Blade");
            enemyTree.Nodes.Add("Crescent Strike");
            enemyTree.Nodes.Add("Luna Rise");
            enemyTree.Nodes.Add("Moonlight Talon");
            enemyTree.Nodes.Add("Dawn Moon");
            enemyTree.Nodes.Add("Crescent Moon Blade");
            enemyTree.Nodes.Add("Moonlight Blast");
            enemyTree.Nodes.Add("Luna Storm");
            enemyTree.Nodes.Add("Piercing Moon");
            enemyTree.Nodes.Add("Luna Gale");
            enemyTree.Nodes.Add("Luna Ascendent");
            enemyTree.Nodes.Add("Luna Rondo");
            enemyTree.Nodes.Add("Rising Moonlight Havoc");
            enemyTree.Nodes.Add("Moonbeam");
            enemyTree.Nodes.Add("Luna Crush");
            enemyTree.Nodes.Add("Thunder Moon Rising");
            enemyTree.Nodes.Add("Luna Havoc");
            enemyTree.Nodes.Add("Sundering Moon");
            enemyTree.Nodes.Add("Moon Glare");
            enemyTree.Nodes.Add("Luna Talon");
            enemyTree.Nodes.Add("Guiding Moon");
            enemyTree.Nodes.Add("Moonlit Knife");
            enemyTree.Nodes.Add("Moonlight Drop");
            enemyTree.Nodes.Add("Dawn Moon Falcon");
            enemyTree.Nodes.Add("Raging Luna Storm");
            enemyTree.Nodes.Add("Rising Luna Rondo");
            enemyTree.Nodes.Add("Moonbeam - Bird");
            enemyTree.Nodes.Add("Thunder Moon");
            enemyTree.Nodes.Add("Luna Storm");
            enemyTree.Nodes.Add("Bloody Rose");
            enemyTree.Nodes.Add("Ashen Moonlight");
            enemyTree.Nodes.Add("Conflagration Blast");
            enemyTree.Nodes.Add("Crushing Grave");
            enemyTree.Nodes.Add("Quasi Seal");
            enemyTree.Nodes.Add("Midnight Flood");
            enemyTree.Nodes.Add("Radiant Moonlight");
            enemyTree.Nodes.Add("Dragon's Moon Spear");
            enemyTree.Nodes.Add("Touchdown");
            enemyTree.Nodes.Add("Regular Attack (Dog)");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("Sonic Dog");
            enemyTree.Nodes.Add("Crescent Fang");
            enemyTree.Nodes.Add("Punishing Fang");
            enemyTree.Nodes.Add("Thievery");
            enemyTree.Nodes.Add("Falling Leaf");
            enemyTree.Nodes.Add("Shadow Fang");
            enemyTree.Nodes.Add("Demon Dog");
            enemyTree.Nodes.Add("Gale Dog");
            enemyTree.Nodes.Add("Shining Dog");
            enemyTree.Nodes.Add("Sonic Return");
            enemyTree.Nodes.Add("Light Spear");
            enemyTree.Nodes.Add("Shadow Fang Punishment");
            enemyTree.Nodes.Add("Phantom Fang");
            enemyTree.Nodes.Add("Hell Hound");
            enemyTree.Nodes.Add("Demon Spear");
            enemyTree.Nodes.Add("Cyclone Shot");
            enemyTree.Nodes.Add("Hell Hound Return");
            enemyTree.Nodes.Add("Shining Fang");
            enemyTree.Nodes.Add("Ghost Wolf");
            enemyTree.Nodes.Add("Lightning Dog");
            enemyTree.Nodes.Add("Punishing Air Fang");
            enemyTree.Nodes.Add("Snatch Item");
            enemyTree.Nodes.Add("Swirling Nature");
            enemyTree.Nodes.Add("Demon Dog Rush");
            enemyTree.Nodes.Add("Dense Demon Dog");
            enemyTree.Nodes.Add("Illusory Dog");
            enemyTree.Nodes.Add("Sonic Fang");
            enemyTree.Nodes.Add("Victory Light Spear");
            enemyTree.Nodes.Add("Shadow Fang Wave");
            enemyTree.Nodes.Add("Phantom Glacier");
            enemyTree.Nodes.Add("Beastly Blow");
            enemyTree.Nodes.Add("Divine Dog");
            enemyTree.Nodes.Add("Divine Dog - Blaze");
            enemyTree.Nodes.Add("Divine Dog - Tremble");
            enemyTree.Nodes.Add("Divine Dog - Savage");
            enemyTree.Nodes.Add("Divine Dog - Whirlpool");
            enemyTree.Nodes.Add("Lightning Flash");
            enemyTree.Nodes.Add("?? (Dummy?)");
            enemyTree.Nodes.Add("Regular Attack (Flynn)");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("Demon Fang");
            enemyTree.Nodes.Add("Sonic Thrust");
            enemyTree.Nodes.Add("Tiger Blade");
            enemyTree.Nodes.Add("Shining Falcon");
            enemyTree.Nodes.Add("Rising Falcon");
            enemyTree.Nodes.Add("Severing Blade");
            enemyTree.Nodes.Add("Sword Rain");
            enemyTree.Nodes.Add("Demonic Chaos");
            enemyTree.Nodes.Add("Hell Fire Blade");
            enemyTree.Nodes.Add("Beast");
            enemyTree.Nodes.Add("Dragon Swarm");
            enemyTree.Nodes.Add("Dazzling Spin");
            enemyTree.Nodes.Add("Demonic Circle");
            enemyTree.Nodes.Add("Guardian Field");
            enemyTree.Nodes.Add("Tiger Rage");
            enemyTree.Nodes.Add("Rising Phoenix");
            enemyTree.Nodes.Add("Burning Phoenix*Extend");
            enemyTree.Nodes.Add("Fierce Hell Fire Blade");
            enemyTree.Nodes.Add("Shining Falcon - Dispersion");
            enemyTree.Nodes.Add("Rending Quake");
            enemyTree.Nodes.Add("Sword Rain: Alpha");
            enemyTree.Nodes.Add("Distortion Blade");
            enemyTree.Nodes.Add("First Aid");
            enemyTree.Nodes.Add("Luminant Scythe");
            enemyTree.Nodes.Add("Divine Streak");
            enemyTree.Nodes.Add("Holy Lance");
            enemyTree.Nodes.Add("Cure");
            enemyTree.Nodes.Add("Mistral Soul");
            enemyTree.Nodes.Add("Blazing Pillar Smash");
            enemyTree.Nodes.Add("Blazing Pillar Smash - Fiery Lion");
            enemyTree.Nodes.Add("Blazing Pillar Smash - Earthquaker");
            enemyTree.Nodes.Add("Blazing Pillar Smash - Tornado Cutter");
            enemyTree.Nodes.Add("Blazing Pillar Smash - Bubble Bomber");
            enemyTree.Nodes.Add("Radiant Dragon Fang");
            enemyTree.Nodes.Add("Firebird Flight");
            enemyTree.Nodes.Add("Twin Wave");
            enemyTree.Nodes.Add("Regular Attack (Patty)");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("");
            enemyTree.Nodes.Add("Form Change");
            enemyTree.Nodes.Add("Form Change ?");
            enemyTree.Nodes.Add("Form Change ??");
            enemyTree.Nodes.Add("Variable Trigger");
            enemyTree.Nodes.Add("Trick Trick");
            enemyTree.Nodes.Add("Clunky Bomb");
            enemyTree.Nodes.Add("Clunky Bomb ?");
            enemyTree.Nodes.Add("Clunky Bomb ??");
            enemyTree.Nodes.Add("Random Fall");
            enemyTree.Nodes.Add("Search Gald");
            enemyTree.Nodes.Add("Little Big Chef");
            enemyTree.Nodes.Add("Little Big Chef  (Looks Tasty...)");
            enemyTree.Nodes.Add("Little Big Chef (Ice Shavings)");
            enemyTree.Nodes.Add("Little Big Chef (Not a Fan?)");
            enemyTree.Nodes.Add("Risky Bet");
            enemyTree.Nodes.Add("Risky Bet ?");
            enemyTree.Nodes.Add("Risky Bet ??");
            enemyTree.Nodes.Add("Risky Bet ???");
            enemyTree.Nodes.Add("Risky Bet ????");
            enemyTree.Nodes.Add("Risky Bet ?????");
            enemyTree.Nodes.Add("Severed Fate");
            enemyTree.Nodes.Add("Severed Fate ? ");
            enemyTree.Nodes.Add("Welcome Dish ");
            enemyTree.Nodes.Add("Welcome Dish ?");
            enemyTree.Nodes.Add("Welcome Dish ??");
            enemyTree.Nodes.Add("Welcome Dish ???");
            enemyTree.Nodes.Add("Welcome Dish ????");
            enemyTree.Nodes.Add("Welcome Dish ?????");
            enemyTree.Nodes.Add("Dangerous Ladder");
            enemyTree.Nodes.Add("Dangerous Ladder ?");
            enemyTree.Nodes.Add("Dream Star");
            enemyTree.Nodes.Add("Dream Star ?");
            enemyTree.Nodes.Add("Dream Star ??");
            enemyTree.Nodes.Add("Trigger Tune");
            enemyTree.Nodes.Add("Trick or Treat");
            enemyTree.Nodes.Add("Trick or Treat ?");
            enemyTree.Nodes.Add("Trick or Treat ??");
            enemyTree.Nodes.Add("Falling Ice");
            enemyTree.Nodes.Add("Falling Ice?");
            enemyTree.Nodes.Add("Gald Steal");
            enemyTree.Nodes.Add("Fire Big Chef");
            enemyTree.Nodes.Add("Fire Big Chef ?");
            enemyTree.Nodes.Add("Fire Big Chef ??");
            enemyTree.Nodes.Add("Fatal Triangle");
            enemyTree.Nodes.Add("Fatal Triangle (Fail)");
            enemyTree.Nodes.Add("Happy Light");
            enemyTree.Nodes.Add("Happy Light (Luck)");
            enemyTree.Nodes.Add("Happy Light (Luck)");
            enemyTree.Nodes.Add("Happy Light (P. ATK)");
            enemyTree.Nodes.Add("Happy Light (P. DEF)");
            enemyTree.Nodes.Add("Happy Light (M. ATK)");
            enemyTree.Nodes.Add("Happy Light (M. DEF)");
            enemyTree.Nodes.Add("Risky Cast");
            enemyTree.Nodes.Add("Fancy Elements");
            enemyTree.Nodes.Add("Fancy Elements Fire");
            enemyTree.Nodes.Add("Fancy Elements Earth");
            enemyTree.Nodes.Add("Fancy Elements Wind");
            enemyTree.Nodes.Add("Fancy Elements Water");
            enemyTree.Nodes.Add("Fancy Elements Light");
            enemyTree.Nodes.Add("Fancy Elements Dark");
            enemyTree.Nodes.Add("Gamble Cast");
            enemyTree.Nodes.Add("Marvelous Fountain (From gamble)");
            enemyTree.Nodes.Add("Big Marvelous Fountain (From gamble)");
            enemyTree.Nodes.Add("Card Gamble");
            enemyTree.Nodes.Add("Critical Moment");
            enemyTree.Nodes.Add("Critical Moment (Pow Hammer Shower)");
            enemyTree.Nodes.Add("Critical Moment 3");
            enemyTree.Nodes.Add("Critical Moment 4");
            enemyTree.Nodes.Add("Critical Moment 5");
            enemyTree.Nodes.Add("Critical Moment 6");
            enemyTree.Nodes.Add("Critical Moment 7");
            enemyTree.Nodes.Add("Critical Moment 8");
            enemyTree.Nodes.Add("Critical Moment 9");
            enemyTree.Nodes.Add("Critical Moment 10");
            enemyTree.Nodes.Add("Critical Moment 11");
            enemyTree.Nodes.Add("Critical Moment 12");
            enemyTree.Nodes.Add("Big Rish");
            enemyTree.Nodes.Add("Mahjong");
            enemyTree.Nodes.Add("Glittery Rain");
            enemyTree.Nodes.Add("Glittery Rain (Fail)");
            enemyTree.Nodes.Add("Volcanic Blast");
            enemyTree.Nodes.Add("Volcanic Blast (Fail)");
            enemyTree.Nodes.Add("Grand Blow");
            enemyTree.Nodes.Add("Grand Blow (Fail)");
            enemyTree.Nodes.Add("Windy Rage");
            enemyTree.Nodes.Add("Windy Rage (Fail)");
            enemyTree.Nodes.Add("Hydraulic Raid");
            enemyTree.Nodes.Add("Hydraulic Raid (Recovery)");
            enemyTree.Nodes.Add("Hydraulic Raid (Fail)");
            enemyTree.Nodes.Add("Summon Friends");
            enemyTree.Nodes.Add("Summon Friends (Rappigs)");
            enemyTree.Nodes.Add("Summon Friends (Stall)");
            enemyTree.Nodes.Add("Summon Friends (Stall)");
            enemyTree.Nodes.Add("Summon Friends (Seagulls)");
            enemyTree.Nodes.Add("Summon Friends (Octopi)");
            enemyTree.Nodes.Add("Summon Friends (Mieu)");
            enemyTree.Nodes.Add("Summon Friends (Penguins)");
            enemyTree.Nodes.Add("Summon Friends (Penguins)");
            enemyTree.Nodes.Add("Summon Friends (Nurses)");
            enemyTree.Nodes.Add("Summon Friends (Quickie)");
            enemyTree.Nodes.Add("Summon Friends (Angels)");
            enemyTree.Nodes.Add("Summon Friends (Barbatos)");
            enemyTree.Nodes.Add("Summon Friends (Barbatos)");
            enemyTree.Nodes.Add("Summon Friends (Seifer)");



            TreeNodeCollection nodeCollect = enemyTree.Nodes;
            enemyTree.SelectedNode = nodeCollect[0];

            
        }

        private void enemyTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            richTextBoxSortID.Text = BitConverter.ToUInt32(enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 4).ToString("D");
            richTextBoxTier.Text = BitConverter.ToUInt32(enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 36).ToString("D");

            richTextBoxTP.Text = BitConverter.ToUInt32(enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 40).ToString("D");
            richTextBoxDamage.Text = BitConverter.ToUInt32(enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 44).ToString("D");
            richTextBoxFire.Text = BitConverter.ToUInt32(enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 48).ToString("D");
            richTextBoxEarth.Text = BitConverter.ToUInt32(enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 52).ToString("D");
            richTextBoxWind.Text = BitConverter.ToUInt32(enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 56).ToString("D");
            richTextBoxWater.Text = BitConverter.ToUInt32(enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 60).ToString("D");
            richTextBoxLight.Text = BitConverter.ToUInt32(enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 64).ToString("D");
            richTextBoxDark.Text = BitConverter.ToUInt32(enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 68).ToString("D");

            
            richTextBoxLv.Text = BitConverter.ToUInt32(enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 120).ToString("D");

            richTextBoxHeal.Text = BitConverter.ToUInt32(enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 256).ToString("D");

            richTextBoxPAtk.Text = BitConverter.ToUInt32(enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 324).ToString("D");
            richTextBoxMAtk.Text = BitConverter.ToUInt32(enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 172).ToString("D");


            richTextBoxUnknown1.Text = BitConverter.ToUInt32(enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 8).ToString("D");
            richTextBoxUnknown2.Text = BitConverter.ToUInt32(enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 12).ToString("D");
            richTextBoxUnknown3.Text = BitConverter.ToUInt32(enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 20).ToString("D");
            richTextBoxUnknown4.Text = BitConverter.ToUInt32(enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 28).ToString("D");
            richTextBoxUnknown5.Text = BitConverter.ToUInt32(enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 32).ToString("D");
            richTextBoxUnknown6.Text = BitConverter.ToUInt32(enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 80).ToString("D");
            richTextBoxUnknown7.Text = BitConverter.ToUInt32(enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 92).ToString("D");
            richTextBoxUnknown8.Text = BitConverter.ToUInt32(enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 96).ToString("D");
            richTextBoxUnknown9.Text = BitConverter.ToUInt32(enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 100).ToString("D");
            richTextBoxUnknown10.Text = BitConverter.ToUInt32(enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 104).ToString("D");
            richTextBoxUnknown11.Text = BitConverter.ToUInt32(enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 124).ToString("D");
            richTextBoxUnknown12.Text = BitConverter.ToUInt32(enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 128).ToString("D");

            richTextBoxUnknown13.Text = BitConverter.ToUInt32(enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 144).ToString("D");
            richTextBoxUnknown14.Text = BitConverter.ToUInt32(enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 148).ToString("D");
            richTextBoxUnknown15.Text = BitConverter.ToUInt32(enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 152).ToString("D");
            richTextBoxUnknown16.Text = BitConverter.ToUInt32(enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 168).ToString("D");
            richTextBoxUnknown17.Text = BitConverter.ToUInt32(enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 184).ToString("D");
            richTextBoxUnknown18.Text = BitConverter.ToUInt32(enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 188).ToString("D");
            richTextBoxUnknown19.Text = BitConverter.ToUInt32(enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 192).ToString("D");
            richTextBoxUnknown20.Text = BitConverter.ToUInt32(enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 196).ToString("D");
            richTextBoxUnknown21.Text = BitConverter.ToUInt32(enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 200).ToString("D");

            richTextBoxUnknown22.Text = BitConverter.ToUInt32(enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 204).ToString("D");
            richTextBoxUnknown23.Text = BitConverter.ToUInt32(enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 208).ToString("D");
            richTextBoxUnknown24.Text = BitConverter.ToUInt32(enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 212).ToString("D");
            richTextBoxUnknown25.Text = BitConverter.ToUInt32(enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 216).ToString("D");
            richTextBoxUnknown26.Text = BitConverter.ToUInt32(enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 220).ToString("D");
            richTextBoxUnknown27.Text = BitConverter.ToUInt32(enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 224).ToString("D");
            richTextBoxUnknown28.Text = BitConverter.ToUInt32(enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 228).ToString("D");
            richTextBoxUnknown29.Text = BitConverter.ToUInt32(enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 232).ToString("D");
            richTextBoxUnknown30.Text = BitConverter.ToUInt32(enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 236).ToString("D");
            richTextBoxUnknown31.Text = BitConverter.ToUInt32(enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 240).ToString("D");
            richTextBoxUnknown32.Text = BitConverter.ToUInt32(enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 244).ToString("D");

            richTextBoxUnknown33.Text = BitConverter.ToUInt32(enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 248).ToString("D");
            richTextBoxUnknown34.Text = BitConverter.ToUInt32(enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 260).ToString("D");
            richTextBoxUnknown35.Text = BitConverter.ToUInt32(enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 280).ToString("D");
            richTextBoxUnknown36.Text = BitConverter.ToUInt32(enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 284).ToString("D");
            richTextBoxUnknown37.Text = BitConverter.ToUInt32(enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 288).ToString("D");
            richTextBoxUnknown38.Text = BitConverter.ToUInt32(enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 292).ToString("D");
            richTextBoxUnknown39.Text = BitConverter.ToUInt32(enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 296).ToString("D");
            richTextBoxUnknown40.Text = BitConverter.ToUInt32(enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 300).ToString("D");
            richTextBoxUnknown41.Text = BitConverter.ToUInt32(enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 304).ToString("D");
            richTextBoxUnknown42.Text = BitConverter.ToUInt32(enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 308).ToString("D");
            richTextBoxUnknown43.Text = BitConverter.ToUInt32(enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 312).ToString("D");
            richTextBoxUnknown44.Text = BitConverter.ToUInt32(enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 316).ToString("D");
            richTextBoxUnknown45.Text = BitConverter.ToUInt32(enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 320).ToString("D");
            richTextBoxUnknown46.Text = BitConverter.ToUInt32(enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 328).ToString("D");
            richTextBoxUnknown47.Text = BitConverter.ToUInt32(enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 332).ToString("D");
            richTextBoxUnknown48.Text = BitConverter.ToUInt32(enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 340).ToString("D");
            richTextBoxUnknown49.Text = BitConverter.ToUInt32(enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 180).ToString("D");
            richTextBoxUnknown50.Text = BitConverter.ToUInt32(enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 272).ToString("D");
            richTextBoxUnknown51.Text = BitConverter.ToUInt32(enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 276).ToString("D");
            richTextBoxUnknown52.Text = BitConverter.ToUInt32(enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 344).ToString("D");
            richTextBoxUnknown53.Text = BitConverter.ToUInt32(enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 348).ToString("D");
            richTextBoxUnknown54.Text = BitConverter.ToUInt32(enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 352).ToString("D");
            richTextBoxUnknown55.Text = BitConverter.ToUInt32(enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 356).ToString("D");
            richTextBoxUnknown56.Text = BitConverter.ToUInt32(enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 360).ToString("D");
            richTextBoxUnknown57.Text = BitConverter.ToUInt32(enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 364).ToString("D");
            richTextBoxUnknown58.Text = BitConverter.ToUInt32(enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 368).ToString("D");
            richTextBoxUnknown59.Text = BitConverter.ToUInt32(enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 372).ToString("D");
            richTextBoxUnknown60.Text = BitConverter.ToUInt32(enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 392).ToString("D");
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //B! .TryParse(Name! .Text, out type! value! ); { Form1.ByteWriter( value! , enemydata_array, StartingHex! + (treeView1.SelectedNode.Index * RowSize! ) + ArrayOfset! ); }
            //B=Byte size, 1="Byte" 2="UInt16" 4="UInt32"         Name!=the name of the textbox        type!= byte / ushort / uint, only include this in the FIRST time this ever happens in a form, later copies ommit this!
            //value!=Name of variable that holds the byte type (so byte/short/int has diffrent names)       StartingHex!= The hex offset      RowSize!=How many bytes in a row    Arrayofset! = how far into the row do we start grabbing info or saving it

            //Byte.TryParse(textBoxLv.Text, out byte value8); { Form1.ByteWriter(value8, enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 1); } //First 1 byte save    currently unused
            //UInt16.TryParse(textBoxOther.Text, out ushort value16); { Form1.ByteWriter(value16, enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 3); } //First 2 byte save   currently unused

            UInt32.TryParse(richTextBoxSortID.Text, out uint value32); { Form1.ByteWriter(value32, enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 4); } //First 4 byte save
            UInt32.TryParse(richTextBoxTier.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 36); } 

            UInt32.TryParse(richTextBoxTP.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 40); } 
            UInt32.TryParse(richTextBoxDamage.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 44); } 
            UInt32.TryParse(richTextBoxFire.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 48); } 
            UInt32.TryParse(richTextBoxEarth.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 52); } 
            UInt32.TryParse(richTextBoxWind.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 56); } 
            UInt32.TryParse(richTextBoxWater.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 60); } 
            UInt32.TryParse(richTextBoxLight.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 64); } 
            UInt32.TryParse(richTextBoxDark.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 68); } 
            
            UInt32.TryParse(richTextBoxLv.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 120); } 

            UInt32.TryParse(richTextBoxHeal.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 256); } 

            UInt32.TryParse(richTextBoxPAtk.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 324); } 
            UInt32.TryParse(richTextBoxMAtk.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 172); } 

            UInt32.TryParse(richTextBoxUnknown1.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 8); } 
            UInt32.TryParse(richTextBoxUnknown2.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 12); } 
            UInt32.TryParse(richTextBoxUnknown3.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 20); } 
            UInt32.TryParse(richTextBoxUnknown4.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 28); } 
            UInt32.TryParse(richTextBoxUnknown5.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 32); } 
            UInt32.TryParse(richTextBoxUnknown6.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 80); } 
            UInt32.TryParse(richTextBoxUnknown7.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 92); } 
            UInt32.TryParse(richTextBoxUnknown8.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 96); } 
            UInt32.TryParse(richTextBoxUnknown9.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 100); } 
            UInt32.TryParse(richTextBoxUnknown10.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 104); } 
            UInt32.TryParse(richTextBoxUnknown11.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 124); } 
            UInt32.TryParse(richTextBoxUnknown12.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 128); }

            
            UInt32.TryParse(richTextBoxUnknown13.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 144); }
            UInt32.TryParse(richTextBoxUnknown14.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 148); }
            UInt32.TryParse(richTextBoxUnknown15.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 152); }
            UInt32.TryParse(richTextBoxUnknown16.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 168); }
            UInt32.TryParse(richTextBoxUnknown17.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 184); }
            UInt32.TryParse(richTextBoxUnknown18.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 188); }
            UInt32.TryParse(richTextBoxUnknown19.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 192); }
            UInt32.TryParse(richTextBoxUnknown20.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 196); }
            UInt32.TryParse(richTextBoxUnknown21.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 200); }

            UInt32.TryParse(richTextBoxUnknown22.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 204); }
            UInt32.TryParse(richTextBoxUnknown23.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 208); }
            UInt32.TryParse(richTextBoxUnknown24.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 212); }
            UInt32.TryParse(richTextBoxUnknown25.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 216); }
            UInt32.TryParse(richTextBoxUnknown26.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 220); }
            UInt32.TryParse(richTextBoxUnknown27.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 224); }
            UInt32.TryParse(richTextBoxUnknown28.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 228); }
            UInt32.TryParse(richTextBoxUnknown29.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 232); }
            UInt32.TryParse(richTextBoxUnknown30.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 236); }
            UInt32.TryParse(richTextBoxUnknown31.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 240); }
            UInt32.TryParse(richTextBoxUnknown32.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 244); }

            UInt32.TryParse(richTextBoxUnknown33.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 248); }
            UInt32.TryParse(richTextBoxUnknown34.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 260); }
            UInt32.TryParse(richTextBoxUnknown35.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 280); }
            UInt32.TryParse(richTextBoxUnknown36.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 284); }
            UInt32.TryParse(richTextBoxUnknown37.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 288); }
            UInt32.TryParse(richTextBoxUnknown38.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 292); }
            UInt32.TryParse(richTextBoxUnknown39.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 296); }
            UInt32.TryParse(richTextBoxUnknown40.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 300); }
            UInt32.TryParse(richTextBoxUnknown41.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 304); }
            UInt32.TryParse(richTextBoxUnknown42.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 308); }
            UInt32.TryParse(richTextBoxUnknown43.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 312); }
            UInt32.TryParse(richTextBoxUnknown44.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 316); }
            UInt32.TryParse(richTextBoxUnknown45.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 320); }
            UInt32.TryParse(richTextBoxUnknown46.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 328); }
            UInt32.TryParse(richTextBoxUnknown47.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 332); }
            UInt32.TryParse(richTextBoxUnknown48.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 340); }
            UInt32.TryParse(richTextBoxUnknown49.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 180); }
            UInt32.TryParse(richTextBoxUnknown50.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 272); }
            UInt32.TryParse(richTextBoxUnknown51.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 276); }
            UInt32.TryParse(richTextBoxUnknown52.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 344); }
            UInt32.TryParse(richTextBoxUnknown53.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 348); }
            UInt32.TryParse(richTextBoxUnknown54.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 352); }
            UInt32.TryParse(richTextBoxUnknown55.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 356); }
            UInt32.TryParse(richTextBoxUnknown56.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 360); }
            UInt32.TryParse(richTextBoxUnknown57.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 364); }
            UInt32.TryParse(richTextBoxUnknown58.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 368); }
            UInt32.TryParse(richTextBoxUnknown59.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 372); }
            UInt32.TryParse(richTextBoxUnknown60.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 81604293 + (enemyTree.SelectedNode.Index * 396) + 392); }
            

            File.WriteAllBytes(Properties.Settings.Default.VesperiaData64 + "\\Data64\\btl.svo", enemydata_array); //saves to the path i set, everything in the array/

        }

        private void button6_Click(object sender, EventArgs e) //Skill editor
        {
            if (File.Exists(Properties.Settings.Default.VesperiaData64 + "\\Data64\\btl.svo"))
            {
                FormVesperiaSkillEditor f2 = new FormVesperiaSkillEditor(); //Create the new form
                f2.StartPosition = FormStartPosition.Manual;  //Grab current windows location
                f2.Location = this.Location; //Create the new window at the same location as current one
                f2.Show(); //Show the new window
                this.Close(); //Close the current window
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("The mod directory is not set");
            }
        }

        private void button2_Click(object sender, EventArgs e) //Items and equipment
        {
            if (File.Exists(Properties.Settings.Default.VesperiaData64 + "\\Data64\\item.svo"))
            {
                FormVesperiaItem f2 = new FormVesperiaItem(); //Create the new form
                f2.StartPosition = FormStartPosition.Manual;  //Grab current windows location
                f2.Location = this.Location; //Create the new window at the same location as current one
                f2.Show(); //Show the new window
                this.Close(); //Close the current window
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("The mod directory is not set");
            }
        }

        private void button3_Click(object sender, EventArgs e) //Enemy Editor
        {
            if (File.Exists(Properties.Settings.Default.VesperiaData64 + "\\Data64\\btl.svo"))
            {
                FormVesperiaEnemyEditor f2 = new FormVesperiaEnemyEditor(); //Create the new form
                f2.StartPosition = FormStartPosition.Manual;  //Grab current windows location
                f2.Location = this.Location; //Create the new window at the same location as current one
                f2.Show(); //Show the new window
                this.Close(); //Close the current window
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("The mod directory is not set");
            }
        }

        private void label25_Click(object sender, EventArgs e) //Name Pointer Popup
        {
            richTextBoxInfoBox.Text = "Decides what line to read from for displaying \r\n" +
                "a artes name. Don't fuck with this unless you know what your doing.";
        }

        private void label5_Click(object sender, EventArgs e) //Damage Formula Text
        {
            richTextBoxInfoBox.Text = "The basic attack  formula is Your Atk - (Enemy Def /2) \r\n " +
                "For artes the damage formula is:  \r\n" +
                "Usage* ArteDmg% *((P.Atk % -Target P.Def) +(M.Atk % -Target M.Def)  ) \r\n" +
                "Finally, *0.9~1.1 for damage variance.   \r\n" +
                "*1.5 if critical.      * Weakness % (Default 1.00)  *Back attack bonus\r\n" +
                "Note: By default most enemies take 150 % Weakness 50 % Resist \r\n" +
                "\r\n" +
                "Arte usage starts at 1, goes upto 3 at 9999 uses.\r\n" +
                "ArteDmg % is the damage number of the arte as a %\r\n" +
                "P.Atk % and M.Atk % is that % of the users stat\r\n" +
                "Minimum for everything is 1.";
            
            
        }

        private void label26_Click(object sender, EventArgs e) //Description Pointer popup
        {
            richTextBoxInfoBox.Text = "Decides what line to read from for displaying \r\n" +
                "a artes description. Don't fuck with this unless you know what your doing.";
        }

        private void label21_Click(object sender, EventArgs e) //Menu Save ID
        {
            richTextBoxInfoBox.Text = "Seems to change where in ram or savefile the game \r\n" +
                "stores what artes are in what slots on each character. \r\n" +
                "If your save file has phantom fang set on repede and this number changes \r\n" +
                "to 4885 then repede now has glacian fang set instead. \r\n" +
                "Basically worthless to edit.";
        }

        private void label18_Click(object sender, EventArgs e) //Arte ID
        {
            richTextBoxInfoBox.Text = "Decides what arte gets used when using this arte. \r\n" +
                "You could use this to change what artes each character can use.\r\n" +
                "The game reads this artes usage count, TP and FS/element for ingame info\r\n" +
                "but doesn't change the name or description, thats for the pointers.";
        }
    }
}
