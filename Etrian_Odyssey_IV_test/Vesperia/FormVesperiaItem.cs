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
    public partial class FormVesperiaItem : Form
    {

        String treeloaded = "No";
        byte[] enemydata_array; //This starts the array, the name after is what i name this array?
        List<ComboBox> boxes = new List<ComboBox>();  //Puts the combo boxes in an array called boxes so i can refernce this array later (to make the code pretty and save time) This is for skills.



        public FormVesperiaItem()
        {
            InitializeComponent();

            string enemydata_path = Properties.Settings.Default.VesperiaData64 + "\\Data64\\item.svo"; //This defines the path as a string, so i can refer to it by this string/name instead of the full path every time
            int enemydata_length = (int)(new FileInfo(enemydata_path).Length);   //The leagth of the array?
            enemydata_array = File.ReadAllBytes(enemydata_path);  //loads an array with whatever is in the path



            //Add the EO1 enemy list to the in editor list of enemy names
            enemyTree.Nodes.Add("APPLEGUMI");
            enemyTree.Nodes.Add("LEMONGUMI");
            enemyTree.Nodes.Add("ORANGEGUMI");
            enemyTree.Nodes.Add("PINEGUMI");
            enemyTree.Nodes.Add("MIXGUMI");
            enemyTree.Nodes.Add("MIRACLEGUMI");
            enemyTree.Nodes.Add("TREET");
            enemyTree.Nodes.Add("SPECIFIC");
            enemyTree.Nodes.Add("ELIXIR");
            enemyTree.Nodes.Add("KUJIGUMI");
            enemyTree.Nodes.Add("POISONBOTTLE");
            enemyTree.Nodes.Add("PARALYZEBOTTLE");
            enemyTree.Nodes.Add("STONEBOTTLE");
            enemyTree.Nodes.Add("SEALBOTTLE");
            enemyTree.Nodes.Add("WEAKBOTTLE");
            enemyTree.Nodes.Add("VIRUSBOTTLE");
            enemyTree.Nodes.Add("CUREBOTTLE");
            enemyTree.Nodes.Add("DENYBOTTLE");
            enemyTree.Nodes.Add("PANACEABOTTLE");
            enemyTree.Nodes.Add("LIFEBOTTLE");
            enemyTree.Nodes.Add("HOLYBOTLLE");
            enemyTree.Nodes.Add("HOLYBOTLLE2");
            enemyTree.Nodes.Add("DARKBOTTLE");
            enemyTree.Nodes.Add("LIQUEUR_BOTTLE");
            enemyTree.Nodes.Add("COCKTAIL_BOTTLE");
            enemyTree.Nodes.Add("LIMIT_BOTTLE");
            enemyTree.Nodes.Add("SAGE");
            enemyTree.Nodes.Add("REDSAGE");
            enemyTree.Nodes.Add("SAVORY");
            enemyTree.Nodes.Add("REDSAVORY");
            enemyTree.Nodes.Add("LAVENDER");
            enemyTree.Nodes.Add("REDLAVENDER");
            enemyTree.Nodes.Add("VERVAIN");
            enemyTree.Nodes.Add("REDVERVAIN");
            enemyTree.Nodes.Add("CHAMOMILE");
            enemyTree.Nodes.Add("REDCHAMOMILE");
            enemyTree.Nodes.Add("BASIL");
            enemyTree.Nodes.Add("REDBASIL");
            enemyTree.Nodes.Add("SAFFRON");
            enemyTree.Nodes.Add("REDSAFFRON");
            enemyTree.Nodes.Add("ALLDIVIDE");
            enemyTree.Nodes.Add("HOURGLASS");
            enemyTree.Nodes.Add("SPECTACLES");
            enemyTree.Nodes.Add("CAMP00");
            enemyTree.Nodes.Add("CAMP01");
            enemyTree.Nodes.Add("CAMP02");
            enemyTree.Nodes.Add("CAMP03");
            enemyTree.Nodes.Add("SWO00 Compact Sword");
            enemyTree.Nodes.Add("SWO00 Compact Sword +1");
            enemyTree.Nodes.Add("SWO01");
            enemyTree.Nodes.Add("SWO01");
            enemyTree.Nodes.Add("SWO02 Scimitar");
            enemyTree.Nodes.Add("SWO03");
            enemyTree.Nodes.Add("SWO04 Long Sword");
            enemyTree.Nodes.Add("SWO05 Knight Sword");
            enemyTree.Nodes.Add("SWO06");
            enemyTree.Nodes.Add("SWO07 Rapier");
            enemyTree.Nodes.Add("SWO08 Tsurugi");
            enemyTree.Nodes.Add("SWO08 Tsurugi+1");
            enemyTree.Nodes.Add("SWO09");
            enemyTree.Nodes.Add("SWO09");
            enemyTree.Nodes.Add("SWO10");
            enemyTree.Nodes.Add("SWO10");
            enemyTree.Nodes.Add("SWO11 Blue Dragon");
            enemyTree.Nodes.Add("SWO11 Blue Dragon+1");
            enemyTree.Nodes.Add("SWO12 Battle Sword");
            enemyTree.Nodes.Add("SWO12 Battle Sword+1");
            enemyTree.Nodes.Add("SWO13 Estoc");
            enemyTree.Nodes.Add("SWO13 Estoc+1");
            enemyTree.Nodes.Add("SWO14");
            enemyTree.Nodes.Add("SWO14");
            enemyTree.Nodes.Add("SWO14");
            enemyTree.Nodes.Add("SWO15");
            enemyTree.Nodes.Add("SWO15");
            enemyTree.Nodes.Add("SWO16 Sentinel");
            enemyTree.Nodes.Add("SWO16 Sentinel+1");
            enemyTree.Nodes.Add("SWO17");
            enemyTree.Nodes.Add("SWO17");
            enemyTree.Nodes.Add("SWO17");
            enemyTree.Nodes.Add("SWO18 Ogre Sword");
            enemyTree.Nodes.Add("SWO18 Ogre Sword+1");
            enemyTree.Nodes.Add("SWO19");
            enemyTree.Nodes.Add("SWO20 Damascus Sword");
            enemyTree.Nodes.Add("SWO21 High Tsurugi");
            enemyTree.Nodes.Add("SWO22 Sinclair Saber");
            enemyTree.Nodes.Add("SWO22 Sinclair Saber+1");
            enemyTree.Nodes.Add("SWO23 Rune Blade");
            enemyTree.Nodes.Add("SWO23 Rune Blade+1");
            enemyTree.Nodes.Add("SWO24");
            enemyTree.Nodes.Add("SWO24");
            enemyTree.Nodes.Add("SWO24");
            enemyTree.Nodes.Add("SWO25");
            enemyTree.Nodes.Add("SWO25");
            enemyTree.Nodes.Add("SWO25");
            enemyTree.Nodes.Add("SWO26 Ares");
            enemyTree.Nodes.Add("SWO27 Real Knight Sword");
            enemyTree.Nodes.Add("SWO28 Shadow Fang");
            enemyTree.Nodes.Add("SWO28 Shadow Fang+1");
            enemyTree.Nodes.Add("SWO29");
            enemyTree.Nodes.Add("SWO29");
            enemyTree.Nodes.Add("SWO29");
            enemyTree.Nodes.Add("SWO30 Highlander");
            enemyTree.Nodes.Add("SWO31 Spine Ripper");
            enemyTree.Nodes.Add("SWO31 Spine Ripper+1");
            enemyTree.Nodes.Add("SWO32 Shiden");
            enemyTree.Nodes.Add("SWO33");
            enemyTree.Nodes.Add("SWO33");
            enemyTree.Nodes.Add("SWO33");
            enemyTree.Nodes.Add("SWO34 Caladbolg");
            enemyTree.Nodes.Add("SWO35 Holy Avenger");
            enemyTree.Nodes.Add("SWO35 Holy Avenger+1");
            enemyTree.Nodes.Add("SWO36");
            enemyTree.Nodes.Add("SWO36");
            enemyTree.Nodes.Add("SWO36");
            enemyTree.Nodes.Add("SWO37");
            enemyTree.Nodes.Add("SWO37");
            enemyTree.Nodes.Add("SWO38 Claiomh Solais");
            enemyTree.Nodes.Add("SWO39 Flamberge");
            enemyTree.Nodes.Add("SWO40 Vorpal Sword");
            enemyTree.Nodes.Add("SWO40 Vorpal Sword+1");
            enemyTree.Nodes.Add("SWO41 Last Fencer");
            enemyTree.Nodes.Add("SWO42 Colossus");
            enemyTree.Nodes.Add("SWO43 Meteorite Blade");
            enemyTree.Nodes.Add("SWO48");
            enemyTree.Nodes.Add("SWO49 False Dein Nomos");
            enemyTree.Nodes.Add("SWO50");
            enemyTree.Nodes.Add("SWO51");
            enemyTree.Nodes.Add("SWO52 White Knight Sword");
            enemyTree.Nodes.Add("SWO53 Second Star");
            enemyTree.Nodes.Add("SWO54 Dein Nomos");
            enemyTree.Nodes.Add("SWO57");
            enemyTree.Nodes.Add("SWO58 Knight Sword Spir");
            enemyTree.Nodes.Add("SWO59 Judex");
            enemyTree.Nodes.Add("SWO60 Moonlight Aqua");
            enemyTree.Nodes.Add("SWO61 Berserker Heart");
            enemyTree.Nodes.Add("SWO62 Shinai");
            enemyTree.Nodes.Add("SWO63 Sword of Prayer Rag Auerion");
            enemyTree.Nodes.Add("EVENT_124   Vesperia No. 2?");
            enemyTree.Nodes.Add("SWO46 Radiant Star");
            enemyTree.Nodes.Add("SWO64 Bouquet of Roses");
            enemyTree.Nodes.Add("SWO65 Demonic Sword Ogre Fang");
            enemyTree.Nodes.Add("SWO66 Imperial Sword of Light Fielacius");
            enemyTree.Nodes.Add("SWO44");
            enemyTree.Nodes.Add("SWO55");
            enemyTree.Nodes.Add("SWO45");
            enemyTree.Nodes.Add("SWO56 Blazor Edge Abyssion???");
            enemyTree.Nodes.Add("SWO67");
            enemyTree.Nodes.Add("SWO68 Entelexeia Sword: Seven-Branched Blade????");
            enemyTree.Nodes.Add("AXE00 Hand Axe");
            enemyTree.Nodes.Add("AXE01");
            enemyTree.Nodes.Add("AXE01");
            enemyTree.Nodes.Add("AXE02");
            enemyTree.Nodes.Add("AXE02");
            enemyTree.Nodes.Add("AXE03 Francisca");
            enemyTree.Nodes.Add("AXE04 Ogre Axe");
            enemyTree.Nodes.Add("AXE04 Ogre Axe +1");
            enemyTree.Nodes.Add("AXE05 Crescent Axe");
            enemyTree.Nodes.Add("AXE05 Crescent Axe +1");
            enemyTree.Nodes.Add("AXE06");
            enemyTree.Nodes.Add("AXE06");
            enemyTree.Nodes.Add("AXE06");
            enemyTree.Nodes.Add("AXE07");
            enemyTree.Nodes.Add("AXE07");
            enemyTree.Nodes.Add("AXE07");
            enemyTree.Nodes.Add("AXE08 Kalinga");
            enemyTree.Nodes.Add("AXE08 Kalinga +1");
            enemyTree.Nodes.Add("AXE09");
            enemyTree.Nodes.Add("AXE09");
            enemyTree.Nodes.Add("AXE09");
            enemyTree.Nodes.Add("AXE10");
            enemyTree.Nodes.Add("AXE10");
            enemyTree.Nodes.Add("AXE10");
            enemyTree.Nodes.Add("AXE11 Tabar");
            enemyTree.Nodes.Add("AXE11 Tabar +1a");
            enemyTree.Nodes.Add("AXE11 Tabar +1b");
            enemyTree.Nodes.Add("AXE12 Bardiche");
            enemyTree.Nodes.Add("AXE12 Bardiche +1");
            enemyTree.Nodes.Add("AXE13 Bone Slasher");
            enemyTree.Nodes.Add("AXE13 Bone Slasher +1");
            enemyTree.Nodes.Add("AXE14 Bahamut Tear");
            enemyTree.Nodes.Add("AXE14 Bahamut Tear +1");
            enemyTree.Nodes.Add("AXE15 Gaia Cleaver");
            enemyTree.Nodes.Add("AXE16");
            enemyTree.Nodes.Add("AXE16");
            enemyTree.Nodes.Add("AXE17");
            enemyTree.Nodes.Add("AXE17");
            enemyTree.Nodes.Add("AXE17");
            enemyTree.Nodes.Add("AXE18");
            enemyTree.Nodes.Add("AXE19");
            enemyTree.Nodes.Add("AXE20");
            enemyTree.Nodes.Add("SPE00");
            enemyTree.Nodes.Add("SPE00");
            enemyTree.Nodes.Add("SPE01");
            enemyTree.Nodes.Add("SPE02");
            enemyTree.Nodes.Add("SPE03");
            enemyTree.Nodes.Add("SPE04");
            enemyTree.Nodes.Add("SPE04");
            enemyTree.Nodes.Add("SPE04");
            enemyTree.Nodes.Add("SPE05");
            enemyTree.Nodes.Add("SPE06");
            enemyTree.Nodes.Add("SPE07");
            enemyTree.Nodes.Add("SPE08");
            enemyTree.Nodes.Add("SPE09");
            enemyTree.Nodes.Add("SPE10");
            enemyTree.Nodes.Add("SPE11");
            enemyTree.Nodes.Add("SPE11");
            enemyTree.Nodes.Add("SPE12");
            enemyTree.Nodes.Add("SPE13");
            enemyTree.Nodes.Add("SPE14");
            enemyTree.Nodes.Add("SPE14");
            enemyTree.Nodes.Add("SPE14");
            enemyTree.Nodes.Add("SPE15");
            enemyTree.Nodes.Add("SPE16");
            enemyTree.Nodes.Add("SPE16");
            enemyTree.Nodes.Add("SPE16");
            enemyTree.Nodes.Add("SPE17");
            enemyTree.Nodes.Add("SPE19");
            enemyTree.Nodes.Add("SPE21");
            enemyTree.Nodes.Add("SPE18");
            enemyTree.Nodes.Add("SPE20");
            enemyTree.Nodes.Add("HAM00 Wood Maul");
            enemyTree.Nodes.Add("HAM00 Wood Maul +1");
            enemyTree.Nodes.Add("HAM01 Heavy Maul");
            enemyTree.Nodes.Add("HAM01 Heavy Maul +1");
            enemyTree.Nodes.Add("HAM02 Spike Hammer");
            enemyTree.Nodes.Add("HAM02 Spike Hammer +1a");
            enemyTree.Nodes.Add("HAM02 Spike Hammer +1b");
            enemyTree.Nodes.Add("HAM03 Iron Hammer");
            enemyTree.Nodes.Add("HAM03 Iron Hammer +1");
            enemyTree.Nodes.Add("HAM04 Deadly Horn");
            enemyTree.Nodes.Add("HAM05 Guardian Stamp");
            enemyTree.Nodes.Add("HAM05 Guardian Stamp +1a");
            enemyTree.Nodes.Add("HAM05 Guardian Stamp +1b");
            enemyTree.Nodes.Add("HAM06 Spinning Drill Hammer");
            enemyTree.Nodes.Add("HAM07 Pile Driver");
            enemyTree.Nodes.Add("HAM07 Pile Driver +1a");
            enemyTree.Nodes.Add("HAM07 Pile Driver +1b");
            enemyTree.Nodes.Add("HAM08 765kh Hammer");
            enemyTree.Nodes.Add("HAM09 Rending Hammer");
            enemyTree.Nodes.Add("HAM10 Mjolnir");
            enemyTree.Nodes.Add("HAM10 Mjolnir +1a");
            enemyTree.Nodes.Add("HAM10 Mjolnir +1b");
            enemyTree.Nodes.Add("HAM11 Golden Hammer");
            enemyTree.Nodes.Add("HAM12 Karolian Hammer");
            enemyTree.Nodes.Add("HAM12 Karolian Hammer +1");
            enemyTree.Nodes.Add("HAM13 Rising Flame");
            enemyTree.Nodes.Add("CLU00 Oar");
            enemyTree.Nodes.Add("CLU01 War Staff");
            enemyTree.Nodes.Add("CLU02 Tribal Guard");
            enemyTree.Nodes.Add("CLU03 Serpent Staff");
            enemyTree.Nodes.Add("CLU04 Shakujo");
            enemyTree.Nodes.Add("CLU05 Full Metal Staff");
            enemyTree.Nodes.Add("CLU06");
            enemyTree.Nodes.Add("CLU07");
            enemyTree.Nodes.Add("CLU07");
            enemyTree.Nodes.Add("CLU07");
            enemyTree.Nodes.Add("CLU07");
            enemyTree.Nodes.Add("CLU08");
            enemyTree.Nodes.Add("CLU08");
            enemyTree.Nodes.Add("CLU08");
            enemyTree.Nodes.Add("CLU09");
            enemyTree.Nodes.Add("CLU09");
            enemyTree.Nodes.Add("CLU09");
            enemyTree.Nodes.Add("CLU10");
            enemyTree.Nodes.Add("CLU10");
            enemyTree.Nodes.Add("CLU11");
            enemyTree.Nodes.Add("ROD00");
            enemyTree.Nodes.Add("ROD01");
            enemyTree.Nodes.Add("ROD02");
            enemyTree.Nodes.Add("ROD02");
            enemyTree.Nodes.Add("ROD03");
            enemyTree.Nodes.Add("ROD03");
            enemyTree.Nodes.Add("ROD03");
            enemyTree.Nodes.Add("ROD04");
            enemyTree.Nodes.Add("ROD04");
            enemyTree.Nodes.Add("ROD04");
            enemyTree.Nodes.Add("ROD05");
            enemyTree.Nodes.Add("ROD05");
            enemyTree.Nodes.Add("ROD05");
            enemyTree.Nodes.Add("ROD06");
            enemyTree.Nodes.Add("ROD06");
            enemyTree.Nodes.Add("ROD06");
            enemyTree.Nodes.Add("ROD07");
            enemyTree.Nodes.Add("ROD08");
            enemyTree.Nodes.Add("ROD09");
            enemyTree.Nodes.Add("ROD10");
            enemyTree.Nodes.Add("ROD10");
            enemyTree.Nodes.Add("ROD11");
            enemyTree.Nodes.Add("ROD12");
            enemyTree.Nodes.Add("TEX00");
            enemyTree.Nodes.Add("TEX00");
            enemyTree.Nodes.Add("TEX01");
            enemyTree.Nodes.Add("TEX01");
            enemyTree.Nodes.Add("TEX02");
            enemyTree.Nodes.Add("TEX02");
            enemyTree.Nodes.Add("TEX03");
            enemyTree.Nodes.Add("TEX03");
            enemyTree.Nodes.Add("TEX04");
            enemyTree.Nodes.Add("TEX04");
            enemyTree.Nodes.Add("TEX04");
            enemyTree.Nodes.Add("TEX05");
            enemyTree.Nodes.Add("TEX05");
            enemyTree.Nodes.Add("TEX05");
            enemyTree.Nodes.Add("TEX06");
            enemyTree.Nodes.Add("TEX07");
            enemyTree.Nodes.Add("TEX07");
            enemyTree.Nodes.Add("TEX07");
            enemyTree.Nodes.Add("TEX08");
            enemyTree.Nodes.Add("TEX09");
            enemyTree.Nodes.Add("TEX09");
            enemyTree.Nodes.Add("TEX09");
            enemyTree.Nodes.Add("TEX10");
            enemyTree.Nodes.Add("TEX10");
            enemyTree.Nodes.Add("TEX10");
            enemyTree.Nodes.Add("TEX10");
            enemyTree.Nodes.Add("TEX11");
            enemyTree.Nodes.Add("TEX11");
            enemyTree.Nodes.Add("TEX12");
            enemyTree.Nodes.Add("TEX12");
            enemyTree.Nodes.Add("TEX13");
            enemyTree.Nodes.Add("TEX14");
            enemyTree.Nodes.Add("TEX15");
            enemyTree.Nodes.Add("CHA00");
            enemyTree.Nodes.Add("CHA00");
            enemyTree.Nodes.Add("CHA01");
            enemyTree.Nodes.Add("CHA01");
            enemyTree.Nodes.Add("CHA02");
            enemyTree.Nodes.Add("CHA02");
            enemyTree.Nodes.Add("CHA03");
            enemyTree.Nodes.Add("CHA03");
            enemyTree.Nodes.Add("CHA04");
            enemyTree.Nodes.Add("CHA04");
            enemyTree.Nodes.Add("CHA04");
            enemyTree.Nodes.Add("CHA05");
            enemyTree.Nodes.Add("CHA05");
            enemyTree.Nodes.Add("CHA05");
            enemyTree.Nodes.Add("CHA06");
            enemyTree.Nodes.Add("CHA06");
            enemyTree.Nodes.Add("CHA06");
            enemyTree.Nodes.Add("CHA07");
            enemyTree.Nodes.Add("CHA07");
            enemyTree.Nodes.Add("CHA07");
            enemyTree.Nodes.Add("CHA08");
            enemyTree.Nodes.Add("CHA09");
            enemyTree.Nodes.Add("CHA09");
            enemyTree.Nodes.Add("CHA10");
            enemyTree.Nodes.Add("CHA11");
            enemyTree.Nodes.Add("CHA11");
            enemyTree.Nodes.Add("CHA11");
            enemyTree.Nodes.Add("CHA12");
            enemyTree.Nodes.Add("CHA13");
            enemyTree.Nodes.Add("CHA14");
            enemyTree.Nodes.Add("CHA15");
            enemyTree.Nodes.Add("BOL00");
            enemyTree.Nodes.Add("BOL00");
            enemyTree.Nodes.Add("BOL00");
            enemyTree.Nodes.Add("BOL01");
            enemyTree.Nodes.Add("BOL01");
            enemyTree.Nodes.Add("BOL01");
            enemyTree.Nodes.Add("BOL02");
            enemyTree.Nodes.Add("BOL02");
            enemyTree.Nodes.Add("BOL02");
            enemyTree.Nodes.Add("BOL02");
            enemyTree.Nodes.Add("BOL03");
            enemyTree.Nodes.Add("BOL03");
            enemyTree.Nodes.Add("BOL03");
            enemyTree.Nodes.Add("BOL04");
            enemyTree.Nodes.Add("BOL04");
            enemyTree.Nodes.Add("BOL04");
            enemyTree.Nodes.Add("BOL05");
            enemyTree.Nodes.Add("BOL05");
            enemyTree.Nodes.Add("BOL05");
            enemyTree.Nodes.Add("BOL06");
            enemyTree.Nodes.Add("BOL07");
            enemyTree.Nodes.Add("BOL08");
            enemyTree.Nodes.Add("BOL08");
            enemyTree.Nodes.Add("BOL08");
            enemyTree.Nodes.Add("BOL09");
            enemyTree.Nodes.Add("BOL10");
            enemyTree.Nodes.Add("BOL10");
            enemyTree.Nodes.Add("BOL10");
            enemyTree.Nodes.Add("BOL11");
            enemyTree.Nodes.Add("BOL11");
            enemyTree.Nodes.Add("BOL12");
            enemyTree.Nodes.Add("BOL12");
            enemyTree.Nodes.Add("BOL12");
            enemyTree.Nodes.Add("BOL14");
            enemyTree.Nodes.Add("BOL16");
            enemyTree.Nodes.Add("BOL13");
            enemyTree.Nodes.Add("BOL15");
            enemyTree.Nodes.Add("BOH00");
            enemyTree.Nodes.Add("BOH00");
            enemyTree.Nodes.Add("BOH00");
            enemyTree.Nodes.Add("BOH00");
            enemyTree.Nodes.Add("BOH01");
            enemyTree.Nodes.Add("BOH02");
            enemyTree.Nodes.Add("BOH03");
            enemyTree.Nodes.Add("BOH04");
            enemyTree.Nodes.Add("BOH05");
            enemyTree.Nodes.Add("BOH06");
            enemyTree.Nodes.Add("BOH07");
            enemyTree.Nodes.Add("BOH07");
            enemyTree.Nodes.Add("BOH07");
            enemyTree.Nodes.Add("BOH08");
            enemyTree.Nodes.Add("BOH09");
            enemyTree.Nodes.Add("DOS00 Kogarashi");
            enemyTree.Nodes.Add("DOS00 Kogarashi +1");
            enemyTree.Nodes.Add("DOS01 Karakaze");
            enemyTree.Nodes.Add("DOS01 Karakaze +1");
            enemyTree.Nodes.Add("DOS03 Ohka");
            enemyTree.Nodes.Add("DOS03 Ohka +1");
            enemyTree.Nodes.Add("DOS06 Tama-hagane");
            enemyTree.Nodes.Add("DOS06 Tama-hagane +1");
            enemyTree.Nodes.Add("DOS06 Tama-hagane +2a");
            enemyTree.Nodes.Add("DOS06 Tama-hagane +2a");
            enemyTree.Nodes.Add("DOS07 Kotaro");
            enemyTree.Nodes.Add("DOS07 Kotaro +1");
            enemyTree.Nodes.Add("DOS07 Kotaro +2a");
            enemyTree.Nodes.Add("DOS07 Kotaro +2b");
            enemyTree.Nodes.Add("DOS08 Holy Raven");
            enemyTree.Nodes.Add("DOS08 Holy Raven +1");
            enemyTree.Nodes.Add("DOS08 Holy Raven +2a");
            enemyTree.Nodes.Add("DOS08 Holy Raven +2b");
            enemyTree.Nodes.Add("DOS10");
            enemyTree.Nodes.Add("DOS10");
            enemyTree.Nodes.Add("DOS10");
            enemyTree.Nodes.Add("DOS05");
            enemyTree.Nodes.Add("DOS05");
            enemyTree.Nodes.Add("DOS05");
            enemyTree.Nodes.Add("DOS12");
            enemyTree.Nodes.Add("DOS12");
            enemyTree.Nodes.Add("DOS12");
            enemyTree.Nodes.Add("DOS12");
            enemyTree.Nodes.Add("DOS11");
            enemyTree.Nodes.Add("DOS11");
            enemyTree.Nodes.Add("DOS11");
            enemyTree.Nodes.Add("DOS11");
            enemyTree.Nodes.Add("DOS13");
            enemyTree.Nodes.Add("DOS13");
            enemyTree.Nodes.Add("DOS13");
            enemyTree.Nodes.Add("DOS13");
            enemyTree.Nodes.Add("DOS14");
            enemyTree.Nodes.Add("DOS14");
            enemyTree.Nodes.Add("DOS14");
            enemyTree.Nodes.Add("DOS14");
            enemyTree.Nodes.Add("DOS15");
            enemyTree.Nodes.Add("DOS15");
            enemyTree.Nodes.Add("DOS15");
            enemyTree.Nodes.Add("DOS16");
            enemyTree.Nodes.Add("DOS16");
            enemyTree.Nodes.Add("DOS16");
            enemyTree.Nodes.Add("DOS16");
            enemyTree.Nodes.Add("DOS09");
            enemyTree.Nodes.Add("DOS09");
            enemyTree.Nodes.Add("DOS09");
            enemyTree.Nodes.Add("DOS20");
            enemyTree.Nodes.Add("DOS02");
            enemyTree.Nodes.Add("DOS02");
            enemyTree.Nodes.Add("DOS02");
            enemyTree.Nodes.Add("DOS02");
            enemyTree.Nodes.Add("DOS02");
            enemyTree.Nodes.Add("DOS02");
            enemyTree.Nodes.Add("DOS02");
            enemyTree.Nodes.Add("DOS04");
            enemyTree.Nodes.Add("DOS04");
            enemyTree.Nodes.Add("DOS04");
            enemyTree.Nodes.Add("DOS17");
            enemyTree.Nodes.Add("DOS17");
            enemyTree.Nodes.Add("DOS19");
            enemyTree.Nodes.Add("DOS22");
            enemyTree.Nodes.Add("DOS18");
            enemyTree.Nodes.Add("DOS21");
            enemyTree.Nodes.Add("KNI01");
            enemyTree.Nodes.Add("KNI01");
            enemyTree.Nodes.Add("KNI02");
            enemyTree.Nodes.Add("KNI02");
            enemyTree.Nodes.Add("KNI02");
            enemyTree.Nodes.Add("KNI03");
            enemyTree.Nodes.Add("KNI03");
            enemyTree.Nodes.Add("KNI04");
            enemyTree.Nodes.Add("KNI04");
            enemyTree.Nodes.Add("KNI04");
            enemyTree.Nodes.Add("KNI05");
            enemyTree.Nodes.Add("KNI05");
            enemyTree.Nodes.Add("KNI05");
            enemyTree.Nodes.Add("KNI06");
            enemyTree.Nodes.Add("KNI06");
            enemyTree.Nodes.Add("KNI06");
            enemyTree.Nodes.Add("KNI07");
            enemyTree.Nodes.Add("KNI07");
            enemyTree.Nodes.Add("KNI07");
            enemyTree.Nodes.Add("KNI08");
            enemyTree.Nodes.Add("KNI08");
            enemyTree.Nodes.Add("KNI09");
            enemyTree.Nodes.Add("KNI09");
            enemyTree.Nodes.Add("KNI10");
            enemyTree.Nodes.Add("KNI10");
            enemyTree.Nodes.Add("KNI10 Flay Mars +1b");
            enemyTree.Nodes.Add("KNI11");
            enemyTree.Nodes.Add("KNI11");
            enemyTree.Nodes.Add("KNI11");
            enemyTree.Nodes.Add("KNI12");
            enemyTree.Nodes.Add("KNI12");
            enemyTree.Nodes.Add("KNI12");
            enemyTree.Nodes.Add("KNI13");
            enemyTree.Nodes.Add("KNI13");
            enemyTree.Nodes.Add("KNI14");
            enemyTree.Nodes.Add("KNI14");
            enemyTree.Nodes.Add("KNI14");
            enemyTree.Nodes.Add("KNI15");
            enemyTree.Nodes.Add("KNI16 Jupiter ");
            enemyTree.Nodes.Add("KNI16 Jupiter +1a");
            enemyTree.Nodes.Add("KNI16 Jupiter +1b");
            enemyTree.Nodes.Add("KNI17 Scorpia");
            enemyTree.Nodes.Add("KNI17 Scorpia +1a");
            enemyTree.Nodes.Add("KNI17 Scorpia +1b");
            enemyTree.Nodes.Add("KNI18 Saturn Claw");
            enemyTree.Nodes.Add("KNI18 Saturn Claw +1");
            enemyTree.Nodes.Add("KNI19 Geminio");
            enemyTree.Nodes.Add("KNI19 Geminio +1a");
            enemyTree.Nodes.Add("KNI19 Geminio +1b");
            enemyTree.Nodes.Add("KNI20 Perceus");
            enemyTree.Nodes.Add("KNI21 Leoluca");
            enemyTree.Nodes.Add("KNI23 Dried Squid");
            enemyTree.Nodes.Add("KNI22 Star Blade Tautus");
            enemyTree.Nodes.Add("KNI24 Corbis");
            enemyTree.Nodes.Add("KNI25 Fox Spirit Blade Corbis");
            enemyTree.Nodes.Add("SHI00 Buckler");
            enemyTree.Nodes.Add("SHI01 Round Shield");
            enemyTree.Nodes.Add("SHI02 Kite Shield");
            enemyTree.Nodes.Add("SHI03 Knight Shield");
            enemyTree.Nodes.Add("SHI18 Knight Shield F");
            enemyTree.Nodes.Add("SHI04 Spike Shield");
            enemyTree.Nodes.Add("SHI05 Hyperion");
            enemyTree.Nodes.Add("SHI06 Iron Plate");
            enemyTree.Nodes.Add("SHI07 Aegis");
            enemyTree.Nodes.Add("SHI08 Sanctuary");
            enemyTree.Nodes.Add("SHI09 Katz Guard");
            enemyTree.Nodes.Add("SHI10 Order Shield");
            enemyTree.Nodes.Add("SHI11 Queen of Hearts");
            enemyTree.Nodes.Add("SHI12 Shield of Valor");
            enemyTree.Nodes.Add("SHI13 Star Light");
            enemyTree.Nodes.Add("SHI14 White Knight Shield");
            enemyTree.Nodes.Add("DEF19 Arredoval");
            enemyTree.Nodes.Add("SHI16 Heater Shield");
            enemyTree.Nodes.Add("SHI17 Master Shield");
            enemyTree.Nodes.Add("GLO01 Black Leather");
            enemyTree.Nodes.Add("GLO02 Knuckle Duster");
            enemyTree.Nodes.Add("GLO03 Defender");
            enemyTree.Nodes.Add("GLO04 Tyrant Fist");
            enemyTree.Nodes.Add("GLO05 Garm Fang");
            enemyTree.Nodes.Add("BOK00 Burning Blood");
            enemyTree.Nodes.Add("BOK01 Hydronomos");
            enemyTree.Nodes.Add("BOK02 Storm Bringer");
            enemyTree.Nodes.Add("BOK03 Xaosologos");
            enemyTree.Nodes.Add("BOK04 Song of Gaia");
            enemyTree.Nodes.Add("BOK05 Thanatologos");
            enemyTree.Nodes.Add("BOK06 Lovely Cat Dictionary");
            enemyTree.Nodes.Add("SHO00 Battle Knife");
            enemyTree.Nodes.Add("SHO01 Maine Gauche");
            enemyTree.Nodes.Add("SHO02 Jitte");
            enemyTree.Nodes.Add("SHO03 Sword Breaker");
            enemyTree.Nodes.Add("SHO04 Misericorde");
            enemyTree.Nodes.Add("LEG00 Boots");
            enemyTree.Nodes.Add("LEG01 Dragon Boots");
            enemyTree.Nodes.Add("LEG02 Crystal Heels");
            enemyTree.Nodes.Add("LEG03 Dragon Skin");
            enemyTree.Nodes.Add("LEG04 Sandals");
            enemyTree.Nodes.Add("BAG00 Normal Size Bag");
            enemyTree.Nodes.Add("BAG01 Medium Size Bag");
            enemyTree.Nodes.Add("BAG02 Large Size Bag");
            enemyTree.Nodes.Add("BAG03 King Size Bag");
            enemyTree.Nodes.Add("DOG00 Chain Collar");
            enemyTree.Nodes.Add("DOG01 Spike Collar");
            enemyTree.Nodes.Add("DOG02 Metal Collar");
            enemyTree.Nodes.Add("DOG03 Gladiator");
            enemyTree.Nodes.Add("DOG04 Eternal Ring");
            enemyTree.Nodes.Add("DOG05 Beast King");
            enemyTree.Nodes.Add("GUN01 Pirate's Gun: Maiden Battle");
            enemyTree.Nodes.Add("GUN02 Pirate's Gun: Scarlet Splendor");
            enemyTree.Nodes.Add("GUN03 Pirate's Gun: Cerulean");
            enemyTree.Nodes.Add("GUN04 Pirate's Gun: White Wave");
            enemyTree.Nodes.Add("GUN05 Pirate's Gun: Black Thunder");
            enemyTree.Nodes.Add("ARM00 Leather Armor");
            enemyTree.Nodes.Add("ARM01 Hard Mail");
            enemyTree.Nodes.Add("ARM02 Ring Mail");
            enemyTree.Nodes.Add("ARM03 Iron Mail");
            enemyTree.Nodes.Add("ARM04 Chain Mail");
            enemyTree.Nodes.Add("ARM05 Lamellar Leather");
            enemyTree.Nodes.Add("ARM06 Splint Mail");
            enemyTree.Nodes.Add("ARM07 Breastplate");
            enemyTree.Nodes.Add("ARM08 Battle Suit");
            enemyTree.Nodes.Add("ARM09 Knight Armor");
            enemyTree.Nodes.Add("ARM10 Absolute");
            enemyTree.Nodes.Add("ARM11 Silver Mail");
            enemyTree.Nodes.Add("ARM12 Full Plate");
            enemyTree.Nodes.Add("ARM13 Gothic Plate");
            enemyTree.Nodes.Add("ARM14 Mythril Plate");
            enemyTree.Nodes.Add("ARM15 Rare Plate");
            enemyTree.Nodes.Add("ARM16 Gold Armor");
            enemyTree.Nodes.Add("ARM17 Body Paint");
            enemyTree.Nodes.Add("ARM18");
            enemyTree.Nodes.Add("ARM19");
            enemyTree.Nodes.Add("ARM20");
            enemyTree.Nodes.Add("ARM21");
            enemyTree.Nodes.Add("ARM22");
            enemyTree.Nodes.Add("ARM23");
            enemyTree.Nodes.Add("ARM24 Hyper Armor?");
            enemyTree.Nodes.Add("ARM25");
            enemyTree.Nodes.Add("ARM26");
            enemyTree.Nodes.Add("GUD00 Leather Guard");
            enemyTree.Nodes.Add("GUD01 Iron Guard");
            enemyTree.Nodes.Add("GUD02 Chain Guard");
            enemyTree.Nodes.Add("GUD03 Lamellar Guard");
            enemyTree.Nodes.Add("GUD04 Half Guard");
            enemyTree.Nodes.Add("GUD05 Breast Guard");
            enemyTree.Nodes.Add("GUD06 Royal Guard");
            enemyTree.Nodes.Add("GUD07 Battle Guard");
            enemyTree.Nodes.Add("GUD08");
            enemyTree.Nodes.Add("GUD09");
            enemyTree.Nodes.Add("GUD10");
            enemyTree.Nodes.Add("GUD11");
            enemyTree.Nodes.Add("GUD12");
            enemyTree.Nodes.Add("GUD13");
            enemyTree.Nodes.Add("GUD14");
            enemyTree.Nodes.Add("GUD15");
            enemyTree.Nodes.Add("GUD16");
            enemyTree.Nodes.Add("GUD17");
            enemyTree.Nodes.Add("GUD18");
            enemyTree.Nodes.Add("GUD19");
            enemyTree.Nodes.Add("GUD20");
            enemyTree.Nodes.Add("GUD21");
            enemyTree.Nodes.Add("CLO00 Cloak");
            enemyTree.Nodes.Add("CLO01 Amber Cloak");
            enemyTree.Nodes.Add("CLO02 Silk Cloak");
            enemyTree.Nodes.Add("CLO03 Feather Cloak");
            enemyTree.Nodes.Add("CLO04 Cocktail Dress");
            enemyTree.Nodes.Add("CLO05 Magic Tunic");
            enemyTree.Nodes.Add("CLO06 Silver Cloak");
            enemyTree.Nodes.Add("CLO07 Witch Dress");
            enemyTree.Nodes.Add("CLO08 Holy Cloak");
            enemyTree.Nodes.Add("CLO09 Mythril Cloak");
            enemyTree.Nodes.Add("CLO10 Midi Blouse");
            enemyTree.Nodes.Add("CLO11 Mermaid Cloak");
            enemyTree.Nodes.Add("CLO12 Platinum Cloak");
            enemyTree.Nodes.Add("CLO13 Gothic Dress");
            enemyTree.Nodes.Add("CLO14 Mirage Cloak");
            enemyTree.Nodes.Add("CLO15 Elder Cloak");
            enemyTree.Nodes.Add("CLO16 Moon Cloak");
            enemyTree.Nodes.Add("CLO17 Elemtnal Cloak");
            enemyTree.Nodes.Add("CLO18 Rune Cloak");
            enemyTree.Nodes.Add("CLO19 Empress Dress");
            enemyTree.Nodes.Add("COA00 Trench Coat");
            enemyTree.Nodes.Add("COA01 Leather Coat");
            enemyTree.Nodes.Add("COA02 Feather Coat");
            enemyTree.Nodes.Add("COA03 Hard Leather Coat");
            enemyTree.Nodes.Add("COA04 Long Coat");
            enemyTree.Nodes.Add("COA05 Mythril Coat");
            enemyTree.Nodes.Add("COA06 Elven Coat");
            enemyTree.Nodes.Add("COA07 Splash Dress");
            enemyTree.Nodes.Add("COA08 Rare Coat");
            enemyTree.Nodes.Add("COA09 Silver Coat");
            enemyTree.Nodes.Add("COA10 Bloody Coat");
            enemyTree.Nodes.Add("COA11 Gothic Cardigan");
            enemyTree.Nodes.Add("COA12 Kritya Coat");
            enemyTree.Nodes.Add("COA13 Holy Coat");
            enemyTree.Nodes.Add("COA14 Hero Coat");
            enemyTree.Nodes.Add("COA15 Queen's Coat");
            enemyTree.Nodes.Add("COA16 Rune Coat");
            enemyTree.Nodes.Add("COA17 Dragon Coat");
            enemyTree.Nodes.Add("COA18 Marine Suit");
            enemyTree.Nodes.Add("COA19");
            enemyTree.Nodes.Add("COD00 Belly Warmer");
            enemyTree.Nodes.Add("COD01 Leather Jacket");
            enemyTree.Nodes.Add("COD02 Iron Protector");
            enemyTree.Nodes.Add("COD03 Thief's Jacket");
            enemyTree.Nodes.Add("COD04 Rain Cape");
            enemyTree.Nodes.Add("COD05 Steel Protector");
            enemyTree.Nodes.Add("COD06 Metal Jacket");
            enemyTree.Nodes.Add("COD07 Magical Collar");
            enemyTree.Nodes.Add("COD08 Spiny Jacket");
            enemyTree.Nodes.Add("COD09 Silver Protector");
            enemyTree.Nodes.Add("COD10 Fancy Belly Warmer");
            enemyTree.Nodes.Add("COD11 Mythril Protector");
            enemyTree.Nodes.Add("COD12 Dragon Protector");
            enemyTree.Nodes.Add("COD13 Loyal Belly Warmer");
            enemyTree.Nodes.Add("COD14 Aer Fragment");
            enemyTree.Nodes.Add("HEL00 Leather Helm");
            enemyTree.Nodes.Add("HEL01 Iron Sallet");
            enemyTree.Nodes.Add("HEL02 Armet Helm");
            enemyTree.Nodes.Add("HEL03 Knight Helm");
            enemyTree.Nodes.Add("HEL04 Silver Helm");
            enemyTree.Nodes.Add("HEL05");
            enemyTree.Nodes.Add("HEL06");
            enemyTree.Nodes.Add("HEL07");
            enemyTree.Nodes.Add("HEL08");
            enemyTree.Nodes.Add("HEL09");
            enemyTree.Nodes.Add("HEL10");
            enemyTree.Nodes.Add("HEL11");
            enemyTree.Nodes.Add("HEL12");
            enemyTree.Nodes.Add("HEL13");
            enemyTree.Nodes.Add("HEL14");
            enemyTree.Nodes.Add("HEL15");
            enemyTree.Nodes.Add("HEL16");
            enemyTree.Nodes.Add("CIR00");
            enemyTree.Nodes.Add("CIR01");
            enemyTree.Nodes.Add("CIR02");
            enemyTree.Nodes.Add("CIR03");
            enemyTree.Nodes.Add("CIR04");
            enemyTree.Nodes.Add("CIR05");
            enemyTree.Nodes.Add("CIR06");
            enemyTree.Nodes.Add("CIR07");
            enemyTree.Nodes.Add("CIR08");
            enemyTree.Nodes.Add("CIR09");
            enemyTree.Nodes.Add("CIR10");
            enemyTree.Nodes.Add("CIR11");
            enemyTree.Nodes.Add("CIR12");
            enemyTree.Nodes.Add("CIR13");
            enemyTree.Nodes.Add("CIR14");
            enemyTree.Nodes.Add("CIR15");
            enemyTree.Nodes.Add("CIR16");
            enemyTree.Nodes.Add("BEL00");
            enemyTree.Nodes.Add("BEL01");
            enemyTree.Nodes.Add("BEL02");
            enemyTree.Nodes.Add("BEL03");
            enemyTree.Nodes.Add("BEL04");
            enemyTree.Nodes.Add("BEL05");
            enemyTree.Nodes.Add("BEL06");
            enemyTree.Nodes.Add("BEL07");
            enemyTree.Nodes.Add("BEL08");
            enemyTree.Nodes.Add("BEL09");
            enemyTree.Nodes.Add("RIB00");
            enemyTree.Nodes.Add("RIB01");
            enemyTree.Nodes.Add("RIB02");
            enemyTree.Nodes.Add("RIB03");
            enemyTree.Nodes.Add("RIB04");
            enemyTree.Nodes.Add("RIB05");
            enemyTree.Nodes.Add("RIB06");
            enemyTree.Nodes.Add("RIB07");
            enemyTree.Nodes.Add("RIB08");
            enemyTree.Nodes.Add("RIB09");
            enemyTree.Nodes.Add("AMU00");
            enemyTree.Nodes.Add("AMU01");
            enemyTree.Nodes.Add("AMU02");
            enemyTree.Nodes.Add("AMU03");
            enemyTree.Nodes.Add("AMU04");
            enemyTree.Nodes.Add("AMU05");
            enemyTree.Nodes.Add("AMU06");
            enemyTree.Nodes.Add("AMU07");
            enemyTree.Nodes.Add("AMU08");
            enemyTree.Nodes.Add("AMU09");
            enemyTree.Nodes.Add("AMU10");
            enemyTree.Nodes.Add("AMU11");
            enemyTree.Nodes.Add("AMU12");
            enemyTree.Nodes.Add("AMU13");
            enemyTree.Nodes.Add("AMU14");
            enemyTree.Nodes.Add("AMU15");
            enemyTree.Nodes.Add("AMU16");
            enemyTree.Nodes.Add("DEF18");
            enemyTree.Nodes.Add("SYM16");
            enemyTree.Nodes.Add("RIN00");
            enemyTree.Nodes.Add("RIN01");
            enemyTree.Nodes.Add("RIN02");
            enemyTree.Nodes.Add("RIN03");
            enemyTree.Nodes.Add("RIN04");
            enemyTree.Nodes.Add("RIN05");
            enemyTree.Nodes.Add("RIN06");
            enemyTree.Nodes.Add("RIN12");
            enemyTree.Nodes.Add("RIN07");
            enemyTree.Nodes.Add("RIN08");
            enemyTree.Nodes.Add("RIN09");
            enemyTree.Nodes.Add("RIN10");
            enemyTree.Nodes.Add("DEF16");
            enemyTree.Nodes.Add("RIN11");
            enemyTree.Nodes.Add("MAN00");
            enemyTree.Nodes.Add("MAN01");
            enemyTree.Nodes.Add("MAN02");
            enemyTree.Nodes.Add("MAN04");
            enemyTree.Nodes.Add("MAN05");
            enemyTree.Nodes.Add("MAN06");
            enemyTree.Nodes.Add("MAN07");
            enemyTree.Nodes.Add("MAN08");
            enemyTree.Nodes.Add("MAN09");
            enemyTree.Nodes.Add("DEF17");
            enemyTree.Nodes.Add("MAN10");
            enemyTree.Nodes.Add("MAN11");
            enemyTree.Nodes.Add("SYM00");
            enemyTree.Nodes.Add("SYM01");
            enemyTree.Nodes.Add("SYM02");
            enemyTree.Nodes.Add("SYM03");
            enemyTree.Nodes.Add("SYM04");
            enemyTree.Nodes.Add("SYM05");
            enemyTree.Nodes.Add("SYM06");
            enemyTree.Nodes.Add("SYM07");
            enemyTree.Nodes.Add("SYM08");
            enemyTree.Nodes.Add("SYM09");
            enemyTree.Nodes.Add("SYM10");
            enemyTree.Nodes.Add("SYM12");
            enemyTree.Nodes.Add("SYM13");
            enemyTree.Nodes.Add("SYM14");
            enemyTree.Nodes.Add("SYM15");
            enemyTree.Nodes.Add("BOT00");
            enemyTree.Nodes.Add("BOT01");
            enemyTree.Nodes.Add("BOT02");
            enemyTree.Nodes.Add("BOT04");
            enemyTree.Nodes.Add("BOT05");
            enemyTree.Nodes.Add("BOT06");
            enemyTree.Nodes.Add("BOT08");
            enemyTree.Nodes.Add("BOT09");
            enemyTree.Nodes.Add("JEW00");
            enemyTree.Nodes.Add("JEW01");
            enemyTree.Nodes.Add("JEW02");
            enemyTree.Nodes.Add("JEW03");
            enemyTree.Nodes.Add("JEW04");
            enemyTree.Nodes.Add("JEW05");
            enemyTree.Nodes.Add("JEW06");
            enemyTree.Nodes.Add("JEW07");
            enemyTree.Nodes.Add("JEW08");
            enemyTree.Nodes.Add("JEW11");
            enemyTree.Nodes.Add("JEW13");
            enemyTree.Nodes.Add("JEW14");
            enemyTree.Nodes.Add("DEF00");
            enemyTree.Nodes.Add("DEF01");
            enemyTree.Nodes.Add("DEF02");
            enemyTree.Nodes.Add("DEF03");
            enemyTree.Nodes.Add("DEF04");
            enemyTree.Nodes.Add("DEF13");
            enemyTree.Nodes.Add("AMU17");
            enemyTree.Nodes.Add("SYM17");
            enemyTree.Nodes.Add("BEEF");
            enemyTree.Nodes.Add("CHICKEN");
            enemyTree.Nodes.Add("PORK");
            enemyTree.Nodes.Add("TUNA");
            enemyTree.Nodes.Add("MACKEREL");
            enemyTree.Nodes.Add("SCALLOP");
            enemyTree.Nodes.Add("SALMON");
            enemyTree.Nodes.Add("SQUID");
            enemyTree.Nodes.Add("SHRIMP");
            enemyTree.Nodes.Add("CABBAGE");
            enemyTree.Nodes.Add("LETTUCE");
            enemyTree.Nodes.Add("CUCUMBER");
            enemyTree.Nodes.Add("CARROT");
            enemyTree.Nodes.Add("ONION");
            enemyTree.Nodes.Add("RADISH");
            enemyTree.Nodes.Add("MUSHROOM");
            enemyTree.Nodes.Add("TOMATO");
            enemyTree.Nodes.Add("POTATO");
            enemyTree.Nodes.Add("C_CABBEGE");
            enemyTree.Nodes.Add("PEACH");
            enemyTree.Nodes.Add("APPLE");
            enemyTree.Nodes.Add("KIWI");
            enemyTree.Nodes.Add("STRAWBERRY");
            enemyTree.Nodes.Add("BANANA");
            enemyTree.Nodes.Add("ORANGE");
            enemyTree.Nodes.Add("USELESSRICE");
            enemyTree.Nodes.Add("USELESSBREAD");
            enemyTree.Nodes.Add("FLOUR");
            enemyTree.Nodes.Add("EGG");
            enemyTree.Nodes.Add("MILK");
            enemyTree.Nodes.Add("BEANCURD");
            enemyTree.Nodes.Add("SEATANGLE");
            enemyTree.Nodes.Add("SEAWEED");
            enemyTree.Nodes.Add("BEANPASTE");
            enemyTree.Nodes.Add("RED_TUBOMI");
            enemyTree.Nodes.Add("ABURAMUSHI");
            enemyTree.Nodes.Add("ARUMAJIRO_TOGE");
            enemyTree.Nodes.Add("DARK_STAR");
            enemyTree.Nodes.Add("IGAIGA_BOKKURI");
            enemyTree.Nodes.Add("BOA_FUR");
            enemyTree.Nodes.Add("IRIKICE");
            enemyTree.Nodes.Add("IRIKIAGRASS");
            enemyTree.Nodes.Add("LIZARDFOSSIL");
            enemyTree.Nodes.Add("WEKEA_STONE");
            enemyTree.Nodes.Add("RABBIT_EAR");
            enemyTree.Nodes.Add("RABBIT_FUR");
            enemyTree.Nodes.Add("AIR_STONE");
            enemyTree.Nodes.Add("WARAIDAKE");
            enemyTree.Nodes.Add("EVENT_102");
            enemyTree.Nodes.Add("MONKEY_HAIR");
            enemyTree.Nodes.Add("GOLD_TATEGAMI");
            enemyTree.Nodes.Add("EVENT_20");
            enemyTree.Nodes.Add("WOLFFUNG");
            enemyTree.Nodes.Add("WOLFFUNG_BIG");
            enemyTree.Nodes.Add("BIG_SIZZAR");
            enemyTree.Nodes.Add("BREAK_SWORD");
            enemyTree.Nodes.Add("SHELL");
            enemyTree.Nodes.Add("GAJU_KEGAWA");
            enemyTree.Nodes.Add("HARD_SPIKE");
            enemyTree.Nodes.Add("HARD_LEATHER");
            enemyTree.Nodes.Add("STRONG_KARA");
            enemyTree.Nodes.Add("KABA_AKUBI");
            enemyTree.Nodes.Add("GAMA_OIL");
            enemyTree.Nodes.Add("TURTLE_KOURA");
            enemyTree.Nodes.Add("KAME_SHIPPO");
            enemyTree.Nodes.Add("GIZAGIZA_HAIR");
            enemyTree.Nodes.Add("KNIGHT_WATER2");
            enemyTree.Nodes.Add("KNIGHT_WATER");
            enemyTree.Nodes.Add("LIGHT_STAR");
            enemyTree.Nodes.Add("KINO_POWDER");
            enemyTree.Nodes.Add("KINO_POWDER_MAX");
            enemyTree.Nodes.Add("STRANGE_MASS");
            enemyTree.Nodes.Add("MIMIC_KIBA");
            enemyTree.Nodes.Add("STRONG_SAKE");
            enemyTree.Nodes.Add("FISHMAN_KIBA");
            enemyTree.Nodes.Add("FISHMAN_WEAPON");
            enemyTree.Nodes.Add("FISHMAN_SEBIRE");
            enemyTree.Nodes.Add("BIG_SHELL");
            enemyTree.Nodes.Add("KING_ABURAMUSHI");
            enemyTree.Nodes.Add("SILVER_STONE");
            enemyTree.Nodes.Add("KUTIBASHI_RAPPA");
            enemyTree.Nodes.Add("BEARSFUR");
            enemyTree.Nodes.Add("ORIGINALGUMI");
            enemyTree.Nodes.Add("KUMONOSU");
            enemyTree.Nodes.Add("GREEN_LIGHT");
            enemyTree.Nodes.Add("GRIFIN_CROW");
            enemyTree.Nodes.Add("LIGHT_STAR");
            enemyTree.Nodes.Add("BAT_WING");
            enemyTree.Nodes.Add("GORIKI_BALL");
            enemyTree.Nodes.Add("KOKATORI_KUTIBASHI");
            enemyTree.Nodes.Add("KOKATORI_CROW");
            enemyTree.Nodes.Add("BIRDWING");
            enemyTree.Nodes.Add("GOMU_KAWA");
            enemyTree.Nodes.Add("SAI_HORN");
            enemyTree.Nodes.Add("SASORI_SHIPPO");
            enemyTree.Nodes.Add("SABOTEN_NEEDLE");
            enemyTree.Nodes.Add("SH_LIGHIT");
            enemyTree.Nodes.Add("GEO_STONE");
            enemyTree.Nodes.Add("HELL_KAMA");
            enemyTree.Nodes.Add("SISI_KIBA");
            enemyTree.Nodes.Add("SISI_GO_KIBA");
            enemyTree.Nodes.Add("IKASUMI");
            enemyTree.Nodes.Add("SHIBIRE_POWDER");
            enemyTree.Nodes.Add("STRONG_TUTA");
            enemyTree.Nodes.Add("GENTLE_PRIDE");
            enemyTree.Nodes.Add("SACREDTREE");
            enemyTree.Nodes.Add("SUISHO");
            enemyTree.Nodes.Add("STRANGE_STONE");
            enemyTree.Nodes.Add("SP_LIGHIT");
            enemyTree.Nodes.Add("SURUDOI_YAIBA");
            enemyTree.Nodes.Add("BLUE_STAR");
            enemyTree.Nodes.Add("UNICORN_HORN");
            enemyTree.Nodes.Add("AKAME_LENZ");
            enemyTree.Nodes.Add("RED_STAR");
            enemyTree.Nodes.Add("SOULGRASS");
            enemyTree.Nodes.Add("BIG_BIRD_KUTI");
            enemyTree.Nodes.Add("TATEGAMI");
            enemyTree.Nodes.Add("TIGRE_SP");
            enemyTree.Nodes.Add("JWEL_OF_INT");
            enemyTree.Nodes.Add("MID_BIRD_WING");
            enemyTree.Nodes.Add("LUKE_SP");
            enemyTree.Nodes.Add("GOLDSAND");
            enemyTree.Nodes.Add("IRONSAND");
            enemyTree.Nodes.Add("IRON_FOOT");
            enemyTree.Nodes.Add("IRON_TUKA");
            enemyTree.Nodes.Add("IRON_HOSAKI");
            enemyTree.Nodes.Add("ORANGE_STAR");
            enemyTree.Nodes.Add("TOGARI_KUTI");
            enemyTree.Nodes.Add("IKASUMI_S");
            enemyTree.Nodes.Add("DRAGON_POWDER");
            enemyTree.Nodes.Add("TORBI_WATER");
            enemyTree.Nodes.Add("TORBI_FISH");
            enemyTree.Nodes.Add("TORENT_HANA");
            enemyTree.Nodes.Add("DONGRI_MET");
            enemyTree.Nodes.Add("LONG_NEEDLE");
            enemyTree.Nodes.Add("RAINBOW_LENS");
            enemyTree.Nodes.Add("NAVIMETAL");
            enemyTree.Nodes.Add("KUSAI_BAG");
            enemyTree.Nodes.Add("BIO_CROW");
            enemyTree.Nodes.Add("HAGANE_HIJIRI");
            enemyTree.Nodes.Add("BARIGESCSCALE");
            enemyTree.Nodes.Add("HANE_HARISEN");
            enemyTree.Nodes.Add("ROSE_FLOWER");
            enemyTree.Nodes.Add("P_LIGHIT");
            enemyTree.Nodes.Add("JET_RABBIT");
            enemyTree.Nodes.Add("PIKO_KUTIBASHI");
            enemyTree.Nodes.Add("HIDUME");
            enemyTree.Nodes.Add("HIPIONI_SANGO");
            enemyTree.Nodes.Add("HIPIONI_JUHI");
            enemyTree.Nodes.Add("PIYO_TAMAGO");
            enemyTree.Nodes.Add("W_MIRROR");
            enemyTree.Nodes.Add("ORANGE_TEX");
            enemyTree.Nodes.Add("TEAR_SP");
            enemyTree.Nodes.Add("PUTI_MI");
            enemyTree.Nodes.Add("PUTI_HA");
            enemyTree.Nodes.Add("ICE_BALL");
            enemyTree.Nodes.Add("BULL_WING");
            enemyTree.Nodes.Add("FIRE_BALL");
            enemyTree.Nodes.Add("BEAR_CROW");
            enemyTree.Nodes.Add("PERIKAN_BAG");
            enemyTree.Nodes.Add("MAGIC_BALL");
            enemyTree.Nodes.Add("MAGARI_SAKE");
            enemyTree.Nodes.Add("WARM_HORN");
            enemyTree.Nodes.Add("INSECTSPLASH");
            enemyTree.Nodes.Add("MAGIC_STONE");
            enemyTree.Nodes.Add("MAGIC_STONE_J");
            enemyTree.Nodes.Add("_MAGICALRESIN");
            enemyTree.Nodes.Add("MADOU_BOOK");
            enemyTree.Nodes.Add("BEAST_BORN");
            enemyTree.Nodes.Add("MANDRA_EYE");
            enemyTree.Nodes.Add("MIZUHAJIKI_TEX");
            enemyTree.Nodes.Add("MEDICALHARB");
            enemyTree.Nodes.Add("R_POISON");
            enemyTree.Nodes.Add("OTAMA_TALE");
            enemyTree.Nodes.Add("YURZO_CRYSTAL");
            enemyTree.Nodes.Add("YURZO_MI");
            enemyTree.Nodes.Add("LIZARDMAN_WEAPON");
            enemyTree.Nodes.Add("DRAGON_FOSSIL");
            enemyTree.Nodes.Add("GREEN_STAR");
            enemyTree.Nodes.Add("UROKO_LEATHER");
            enemyTree.Nodes.Add("RARE_METAL");
            enemyTree.Nodes.Add("REIKON_KAKERA");
            enemyTree.Nodes.Add("ROPER_SHOKUSHU");
            enemyTree.Nodes.Add("LONG_HORN");
            enemyTree.Nodes.Add("WATAGE");
            enemyTree.Nodes.Add("G_KUMA_CROW");
            enemyTree.Nodes.Add("G_DRA_SKALE");
            enemyTree.Nodes.Add("EVIL_BONE");
            enemyTree.Nodes.Add("MKNIGHT_EDGE");
            enemyTree.Nodes.Add("MKNIGHT_EDGE2");
            enemyTree.Nodes.Add("MKNIGHT_EDGE3");
            enemyTree.Nodes.Add("EVENT_01");
            enemyTree.Nodes.Add("EVENT_02");
            enemyTree.Nodes.Add("EVENT_03");
            enemyTree.Nodes.Add("EVENT_04");
            enemyTree.Nodes.Add("EVENT_05");
            enemyTree.Nodes.Add("EVENT_06");
            enemyTree.Nodes.Add("EVENT_07");
            enemyTree.Nodes.Add("EVENT_08");
            enemyTree.Nodes.Add("EVENT_10");
            enemyTree.Nodes.Add("EVENT_12");
            enemyTree.Nodes.Add("EVENT_13");
            enemyTree.Nodes.Add("EVENT_116");
            enemyTree.Nodes.Add("EVENT_117");
            enemyTree.Nodes.Add("EVENT_19");
            enemyTree.Nodes.Add("EVENT_20");
            enemyTree.Nodes.Add("EVENT_22");
            enemyTree.Nodes.Add("EVENT_23");
            enemyTree.Nodes.Add("EVENT_24");
            enemyTree.Nodes.Add("EVENT_34");
            enemyTree.Nodes.Add("EVENT_35");
            enemyTree.Nodes.Add("EVENT_36");
            enemyTree.Nodes.Add("EVENT_86");
            enemyTree.Nodes.Add("EVENT_101");
            enemyTree.Nodes.Add("EVENT_102");
            enemyTree.Nodes.Add("EVENT_103");
            enemyTree.Nodes.Add("EVENT_107");
            enemyTree.Nodes.Add("EVENT_121");
            enemyTree.Nodes.Add("EVENT_104");
            enemyTree.Nodes.Add("EVENT_105");
            enemyTree.Nodes.Add("EVENT_106");
            enemyTree.Nodes.Add("EVENT_118");
            enemyTree.Nodes.Add("EVENT_123");
            enemyTree.Nodes.Add("EVENT_108");
            enemyTree.Nodes.Add("EVENT_109");
            enemyTree.Nodes.Add("EVENT_114");
            enemyTree.Nodes.Add("EVENT_110");
            enemyTree.Nodes.Add("EVENT_111");
            enemyTree.Nodes.Add("EVENT_112");
            enemyTree.Nodes.Add("EVENT_37");
            enemyTree.Nodes.Add("SWO54");
            enemyTree.Nodes.Add("EVENT_98");
            enemyTree.Nodes.Add("EVENT_99");
            enemyTree.Nodes.Add("EVENT_119");
            enemyTree.Nodes.Add("EVENT_120");
            enemyTree.Nodes.Add("EVENT_115");
            enemyTree.Nodes.Add("EVENT_124");
            enemyTree.Nodes.Add("EVENT_38");
            enemyTree.Nodes.Add("EVENT_40");
            enemyTree.Nodes.Add("EVENT_41");
            enemyTree.Nodes.Add("EVENT_49");
            enemyTree.Nodes.Add("EVENT_50");
            enemyTree.Nodes.Add("EVENT_51");
            enemyTree.Nodes.Add("EVENT_125");
            enemyTree.Nodes.Add("STATUE_01");
            enemyTree.Nodes.Add("STATUE_02");
            enemyTree.Nodes.Add("STATUE_03");
            enemyTree.Nodes.Add("STATUE_04");
            enemyTree.Nodes.Add("STATUE_05");
            enemyTree.Nodes.Add("STATUE_06");
            enemyTree.Nodes.Add("STATUE_07");
            enemyTree.Nodes.Add("STATUE_08");
            enemyTree.Nodes.Add("STATUE_09");
            enemyTree.Nodes.Add("STATUE_10");
            enemyTree.Nodes.Add("STATUE_11");
            enemyTree.Nodes.Add("EVENT_65");
            enemyTree.Nodes.Add("EVENT_78");
            enemyTree.Nodes.Add("EVENT_79");
            enemyTree.Nodes.Add("SUB_EVENT_01");
            enemyTree.Nodes.Add("SUB_EVENT_02");
            enemyTree.Nodes.Add("SUB_EVENT_03");
            enemyTree.Nodes.Add("SUB_EVENT_04");
            enemyTree.Nodes.Add("SUB_EVENT_05");
            enemyTree.Nodes.Add("SUB_EVENT_07");
            enemyTree.Nodes.Add("SUB_EVENT_08");
            enemyTree.Nodes.Add("SUB_EVENT_09");
            enemyTree.Nodes.Add("SUB_EVENT_10");
            enemyTree.Nodes.Add("SUB_EVENT_11");
            enemyTree.Nodes.Add("SUB_EVENT_12");
            enemyTree.Nodes.Add("SUB_EVENT_13");
            enemyTree.Nodes.Add("SUB_EVENT_14");
            enemyTree.Nodes.Add("SUB_EVENT_15");
            enemyTree.Nodes.Add("SUB_EVENT_16");
            enemyTree.Nodes.Add("SUB_EVENT_17");
            enemyTree.Nodes.Add("SUB_EVENT_18");
            enemyTree.Nodes.Add("SUB_EVENT_19");
            enemyTree.Nodes.Add("SUB_EVENT_20");
            enemyTree.Nodes.Add("SUB_EVENT_21");
            enemyTree.Nodes.Add("SUB_EVENT_22");
            enemyTree.Nodes.Add("SUB_EVENT_44");
            enemyTree.Nodes.Add("SUB_EVENT_23");
            enemyTree.Nodes.Add("SUB_EVENT_24");
            enemyTree.Nodes.Add("SUB_EVENT_25");
            enemyTree.Nodes.Add("SUB_EVENT_26");
            enemyTree.Nodes.Add("SUB_EVENT_27");
            enemyTree.Nodes.Add("SUB_EVENT_28");
            enemyTree.Nodes.Add("SUB_EVENT_29");
            enemyTree.Nodes.Add("SUB_EVENT_30");
            enemyTree.Nodes.Add("SUB_EVENT_31");
            enemyTree.Nodes.Add("SUB_EVENT_32");
            enemyTree.Nodes.Add("SUB_EVENT_33");
            enemyTree.Nodes.Add("SUB_EVENT_34");
            enemyTree.Nodes.Add("SUB_EVENT_35");
            enemyTree.Nodes.Add("SUB_EVENT_41");
            enemyTree.Nodes.Add("SUB_EVENT_47");
            enemyTree.Nodes.Add("SUB_EVENT_48");
            enemyTree.Nodes.Add("SUB_EVENT_36");
            enemyTree.Nodes.Add("SUB_EVENT_37");
            enemyTree.Nodes.Add("SUB_EVENT_38");
            enemyTree.Nodes.Add("SUB_EVENT_43");
            enemyTree.Nodes.Add("EVENT_122");
            enemyTree.Nodes.Add("SUB_EVENT_49");
            enemyTree.Nodes.Add("SUB_EVENT_50");
            enemyTree.Nodes.Add("SUB_EVENT_45");
            enemyTree.Nodes.Add("SUB_EVENT_46");
            enemyTree.Nodes.Add("ATMP_004");
            enemyTree.Nodes.Add("ATMP_006");
            enemyTree.Nodes.Add("ATMP_007");
            enemyTree.Nodes.Add("ATMP_056");
            enemyTree.Nodes.Add("ATMP_008");
            enemyTree.Nodes.Add("ATMP_013");
            enemyTree.Nodes.Add("ATMP_017");
            enemyTree.Nodes.Add("ATMP_018");
            enemyTree.Nodes.Add("ATMP_023");
            enemyTree.Nodes.Add("ATMP_031");
            enemyTree.Nodes.Add("ATMP_034");
            enemyTree.Nodes.Add("ATMP_037");
            enemyTree.Nodes.Add("ATMP_114");
            enemyTree.Nodes.Add("ATMP_115");
            enemyTree.Nodes.Add("ATMP_038");
            enemyTree.Nodes.Add("ATMP_039");
            enemyTree.Nodes.Add("ATMP_041");
            enemyTree.Nodes.Add("ATMP_065");
            enemyTree.Nodes.Add("ATMP_067");
            enemyTree.Nodes.Add("ATMP_068");
            enemyTree.Nodes.Add("ATMP_024");
            enemyTree.Nodes.Add("ATMP_028");
            enemyTree.Nodes.Add("ATMP_030");
            enemyTree.Nodes.Add("ATMP_025");
            enemyTree.Nodes.Add("ATMP_045");
            enemyTree.Nodes.Add("ATMP_046");
            enemyTree.Nodes.Add("ATMP_048");
            enemyTree.Nodes.Add("ATMP_073");
            enemyTree.Nodes.Add("ATMP_047");
            enemyTree.Nodes.Add("ATMP_049");
            enemyTree.Nodes.Add("ATMP_050");
            enemyTree.Nodes.Add("ATMP_051");
            enemyTree.Nodes.Add("ATMP_052");
            enemyTree.Nodes.Add("ATMP_053");
            enemyTree.Nodes.Add("ATMP_071");
            enemyTree.Nodes.Add("ATMP_072");
            enemyTree.Nodes.Add("ATMP_069");
            enemyTree.Nodes.Add("ATMP_070");
            enemyTree.Nodes.Add("ATMP_104");
            enemyTree.Nodes.Add("ATMP_074");
            enemyTree.Nodes.Add("ATMP_085");
            enemyTree.Nodes.Add("ATMP_087");
            enemyTree.Nodes.Add("ATMP_089");
            enemyTree.Nodes.Add("ATMP_090");
            enemyTree.Nodes.Add("ATMP_092");
            enemyTree.Nodes.Add("ATMP_093");
            enemyTree.Nodes.Add("ATMP_107");
            enemyTree.Nodes.Add("ATMP_109");
            enemyTree.Nodes.Add("ATMP_111");
            enemyTree.Nodes.Add("ATMP_075");
            enemyTree.Nodes.Add("ATMP_076");
            enemyTree.Nodes.Add("ATMP_077");
            enemyTree.Nodes.Add("ATMP_078");
            enemyTree.Nodes.Add("ATMP_079");
            enemyTree.Nodes.Add("ATMP_080");
            enemyTree.Nodes.Add("ATMP_084");
            enemyTree.Nodes.Add("ATMP_122");
            enemyTree.Nodes.Add("ATMP_120");
            enemyTree.Nodes.Add("ATMP_121");
            enemyTree.Nodes.Add("ATMP_112");
            enemyTree.Nodes.Add("ATMP_113");
            enemyTree.Nodes.Add("ATMP_012");
            enemyTree.Nodes.Add("ATMP_057");
            enemyTree.Nodes.Add("ATMP_066");
            enemyTree.Nodes.Add("ATMP_005");
            enemyTree.Nodes.Add("ATMP_022");
            enemyTree.Nodes.Add("ATMP_061");
            enemyTree.Nodes.Add("ATMP_027");
            enemyTree.Nodes.Add("ATMP_021");
            enemyTree.Nodes.Add("ATMP_058");
            enemyTree.Nodes.Add("ATMP_059");
            enemyTree.Nodes.Add("ATMP_060");
            enemyTree.Nodes.Add("ATMP_010");
            enemyTree.Nodes.Add("ATMP_011");
            enemyTree.Nodes.Add("ATMP_014");
            enemyTree.Nodes.Add("ATMP_035");
            enemyTree.Nodes.Add("ATMP_001");
            enemyTree.Nodes.Add("ATMP_002");
            enemyTree.Nodes.Add("ATMP_016");
            enemyTree.Nodes.Add("ATMP_040");
            enemyTree.Nodes.Add("ATMP_029");
            enemyTree.Nodes.Add("ATMP_003");
            enemyTree.Nodes.Add("ATMP_009");
            enemyTree.Nodes.Add("ATMP_019");
            enemyTree.Nodes.Add("ATMP_043");
            enemyTree.Nodes.Add("ATMP_026");
            enemyTree.Nodes.Add("ATMP_032");
            enemyTree.Nodes.Add("ATMP_033");
            enemyTree.Nodes.Add("ATMP_062");
            enemyTree.Nodes.Add("ATMP_063");
            enemyTree.Nodes.Add("ATMP_064");
            enemyTree.Nodes.Add("ATMP_096");
            enemyTree.Nodes.Add("ATMP_097");
            enemyTree.Nodes.Add("ATMP_098");
            enemyTree.Nodes.Add("ATMP_106");
            enemyTree.Nodes.Add("ATMP_099");
            enemyTree.Nodes.Add("ATMP_102");
            enemyTree.Nodes.Add("ATMP_116");
            enemyTree.Nodes.Add("ATMP_100");
            enemyTree.Nodes.Add("ATMP_101");
            enemyTree.Nodes.Add("ATMP_094");
            enemyTree.Nodes.Add("ATMP_095");
            enemyTree.Nodes.Add("ATMP_105");
            enemyTree.Nodes.Add("ATMP_081");
            enemyTree.Nodes.Add("ATMP_082");
            enemyTree.Nodes.Add("ATMP_083");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");
            enemyTree.Nodes.Add("NETWORK_01");

            TreeNodeCollection nodeCollect = enemyTree.Nodes;
            enemyTree.SelectedNode = nodeCollect[0];

            boxes.Add(comboBoxSkill1);
            boxes.Add(comboBoxSkill2);
            boxes.Add(comboBoxSkill3);


            string[] values = new[] {
            "Unknown Skill",
            "No Skill",
            "Empty Skill",
            "1 Strength",
"2 Strength 2",
"3 Strength 3",
"4 Magic",
"5 Magic 2",
"6 Magic 3",
"7 Elemental",
"8 Heavy Hit",
"9 Stun Magic",
"10 Cross Counter",
"11 FS Bonus",
"12 FS Bonus 2",
"13 Reflect",
"14 Aerial Combo",
"15 HP Condition",
"16 HP Condition 2",
"17 HP Condition 3   (Yes really)",
"18 HP Condition 4",
"19 Half Damage",
"20 Quarter Damage",
"21 Minimum Damage",
"22 Chain",
"23 Hell Fire",
"24 Defend",
"25 Defend 2",
"26 Defend 3",
"27 Resist",
"28 Resist 2",
"29 Resist 3",
"30 Critical Guard",
"31 Magic Guard",
"32 Roll",
"33 Guard Plus",
"34 Void Attack",
"35 Void Magic",
"36 Immunity",
"37 Endure",
"38 Anti Element",
"39 Step Away",
"40 Guard Reflect",
"41 Status Guard",
"42 Condition Guard",
"43 Magic Guard Plus",
"44 TP Condition",
"45 TP Condition 2?",
"46 TP Condition 3?",
"47 TP Condition 4",
"48 Crucible",
"49 Athenor",
"50 Evade",
"51 Evade 2",
"52 Evade 3",
"53 Backstep",
"54 Recover",
"55 O.L. Boost",
"56 Combo Force",
"57 Item Pro",
"58 Lucky End",
"59 Combo Plus",
"60 Alembic",
"61 Gale",
"62 Vitality",
"63 Vitality 2",
"64 Vitality 3",
"65 Spirits",
"66 Spirits 2",
"67 Spirits 3",
"68 Taunt",
"69 Taunt 2",
"70 OVL Taunt",
"71 OVL Taunt 2",
"72 Resurrect",
"73 Stat Boost",
"74 Life Healer",
"75 Spirit Healer",
"76 Happiness",
"77 Happiness 2",
"78 Happiness 3",
"79 Life Up",
"80 Mental Up",
"81 HP Recover",
"82 TP Recover",
"84 OVL Bonus",
"85 OVL Bonus 2",
"86 Lucky Soul",
"87 Rebirth",
"88 Rebirth 2",
"89 BA Force",
"90 Rise Attack",
"91 EXP Share",
"93 Dispersion",
"94 Great Deluge",
"96 Strength 4",
"97 Combo Voltage",
"98 Step Combo",
"99 Combination",
"100 Combination 2",
"101 Combination 3",
"102 High Tension",
"103 Hyper Tension",
"104 Ultimate Tension",
"105 Swords Up",
"106 Hit Plus",
"107 Dragon Buster",
"108 Axes Up",
"109 Assassin",
"111 One Man Show",
"112 Defend Artes",
"113 Glory",
"114 Combo Plus 2",
"115 Combo Plus 3",
"116 Super Chain",
"117 Ability Plus",
"118 High Ability Plus",
"119 Hyper Ability Plus",
"120 Super Chain 4",
"121 Super Chain 2",
"122 Super Chain 3",
"123 Super Chain 5",
"125 Fatal Finish",
"126 Fatal Finish Plus",
"127 Link Slash",
"130 Loner",
"131 Charming Thrust",
"132 Sleepy Thrust",
"134 Guard Plus 2",
"135 Defend 4",
"136 Resist 4",
"137 Guard Impact",
"138 Cure Guard",
"139 Guardian",
"140 Super Guard",
"141 Super Resist",
"142 Anti Magic",
"144 Guard Artes",
"145 Guard All",
"146 Extend Guard",
"147 Guard Supply",
"148 Survive",
"149 Extra Combo I",
"150 Extra Combo II",
"151 Extra Combo III",
"155 Pow Hammer Revenge",
"156 Eternal Support",
"157 Lovely Dog",
"159 Medical Boost",
"160 Auto Medicine",
"161 Healing Artes",
"162 Angel's Tear",
"163 Sleep 'n Heal",
"164 Critical Break",
"165 Charge Smash",
"166 Critical",
"167 Second Attack",
"168 Bug Busters",
"169 Combatir",
"170 Raynard",
"171 Mighty Charge",
"172 Speed Charge",
"173 Attack Arte Charge",
"174 Charge Hold",
"175 Break Down",
"177 Steel Defense",
"178 Down Hit",
"179 Heavy Weight",
"180 Healing Arte Charge",
"181 Taunt & Evade",
"182 Play Dead",
"183 Run",
"184 Taunt Gamble",
"185 Member Taunt",
"186 Motion Change",
"187 Vitality 4",
"189 Medical Smash",
"190 Coward",
"191 Heal Supply",
"192 Safety",
"194 Eternal Weakness",
"195 Support Arte Charge",
"196 Critical Recover",
"197 Magic 4",
"199 Over Cast",
"200 Over Cast 2",
"201 Over Cast 3",
"202 Heavy Magic",
"203 Light Magic",
"204 Critical Magic",
"206 Resilience",
"207 Elemental Effect",
"208 Perfect Magic",
"210 Absorption",
"211 Rhythm",
"212 Recast",
"213 Randomize",
"214 Revenge Spell",
"215 Levitation",
"216 Overheat",
"217 Liner Shot",
"218 Magic Combo",
"219 Speed Cast",
"220 Spell Charge",
"221 Spell Charge 2",
"222 Spell Charge 3",
"223 Spell End",
"224 Lucky Magic",
"225 Spirit Absorb",
"226 Spirits 4",
"227 Reducer",
"228 Convert Absorption",
"229 Combat Force",
"230 Endless Shot",
"231 Hunter",
"232 TP Attack",
"233 Change Style",
"234 Change Style 2",
"236 Strength T",
"237 Magic T",
"238 Light Force",
"239 Revenge Arrow",
"240 Heavy Arrow",
"241 Power Shot",
"242 Defend T",
"243 Resist T",
"244 Escape Step",
"245 Heavy Energy",
"246 High Tension",
"248 In Step",
"249 Quick Arrow",
"251 Long Range",
"252 Step Cancel",
"253 Long Step",
"254 Cooking Plus",
"255 Hunter 2",
"256 Chivalry",
"257 Appeal Target",
"259 Technical Half",
"260 Aerial Combo 2",
"261 Aerial Combo 3",
"262 High Combo",
"263 Aerial Artes",
"264 Aerial Artes 2",
"265 Aerial Artes 3",
"268 Aerial Force",
"269 Aerial Magic Guard",
"270 Aerial Guard",
"271 Aerial Armor",
"272 Escape Jump",
"273 Spear Master",
"274 Rod Master",
"275 Jump Cancel",
"276 Aerial OVL",
"277 Recovery Artes",
"278 Aerial Jump",
"279 Aerial Jump 2",
"280 Aerial Finish",
"281 Aerial Step",
"282 Landing",
"283 Touch Down",
"284 Aerial Dash",
"285 Aerial Tension",
"286 Temptation",
"289 Rod",
"290 Lucky Spear",
"291 Hunter's Fang",
"292 Lucky Limit",
"293 Steal Plus",
"294 Mobile Armor",
"295 Evade 4",
"296 Runners",
"297 Runners 2",
"298 Encounter Bonus",
"299 Quick Turn",
"300 Holy Breath",
"301 Dark Breath",
"302 Double Appeal",
"303 Speed Up",
"304 Speed Up 2",
"305 Item Thrower",
"306 Speedy Item",
"307 Dash Cancel",
"308 Dash",
"309 Item Amplifier",
"310 Item Amplifier 2",
"311 Lucky Item",
"312 Inspector",
"313 Treasure Fangs",
"314 Bark",
"316 Lucky Plus",
"317 Lucky Plus 2",
"318 Full Check",
"319 Scanning",
"320 Lucky Call",
"321 Stinger Blow",
"324 Hero",
"325 Shine",
"326 Team Work",
"327 Devotion",
"328 Shield",
"329 Magic Shield",
"330 Energy Coat",
"331 Lion Heart",
"333 Cure Area",
"334 OVL Boost Area",
"335 S. Spell Area",
"336 HP Relax",
"337 OVL Relax",
"338 TP Support",
"340 No Artes Plus",
"343 Defend Conversion",
"344 Resist Conversion",
"345 Vacance",
"346 Landing Step",
"347 Bastion",
"348 Special",
"349 Anti Break",
"350 Standing Guard",
"351 OVL Plus",
"352 Burst Guard",
"353 OVL Concentrate",
"354 Recovering Guard",
"355 OVL Team",
"356 OVL Team 2",
"357 OVL Team 3",
"358 Burst Hold",
"359 Perfect Tension",
"360 High Heal",
"361 Hyper Heal",
"362 Guard All 2",
"363 Rallying Cast",
"364 Auto Medicine 2",
"365 Sustained Critical",
"366 Charge Hold 2",
"367 High Fatal Tension",
"368 Hyper Fatal Tension",
"370 High Magic Tension",
"371 Hyper Magic Tension",
"372 Combo Magic",
"373 Combo Magic 2",
"375 Bullfight Mind",
"376 Headhunter",
"377 Healing Arrow",
"378 Healing Arrow 2",
"379 High Taunt",
"380 High Aerial Tension",
"381 Hyper Aerial Tension",
"382 Aerial Ability Plus",
"383 Aerial High Ability Plus",
"384 Aerial Hyper Ability Plus",
"385 Multi-Item",
"386 OVL Plus 2",
"387 OVL Plus 3",
"388 High Mobility",
"389 Item Pro 2",
"390 Arte Smash",
"391 Magic Smash",
"392 Burst Smash",
"393 OVL Recover",
"394 Natural Recover",
"395 Guarding Skill",
"396 Guard Artes 2",
"397 Guarding Cast",
"398 Hyper Guard",
"399 Hyper Magic Guard",
"400 HP Surge",
"401 TP Surge",
"402 Just Soul",
"403 Rival Surge",
"404 Rival Surge 2",
"405 Safe Bet",
"406 Gambler's Soul",
"407 High Form Change",
"408 OVL Gamble",
"409 Limit Fever",
"410 Form Selection",
"411 Fighting Lens",
"412 Hyper Form Change",
"413 Critical Upgrade 2",
"414 Brainiac Speed Cast",
"415 Brainiac Combo Magic 2",
"416 Critical Hitter",
"417 OVL Roulette: HP",
"418 OVL Roulette: TP",
"419 OVL Roulette: OVL",
"420 Reincarnation",
"421 Combo Plus Advance",
"422 Brainiac Combo Magic",
"423 Advance Ability Plus",
"424 Brainiac Magic Combo",
"425 Brainiac Grace",
"426 Defend Artes Advance",
"427 Burst Security",
"428 Sticky Fingers",
"429 Female Company",
"430 Kids' Association",
"431 Marksmen's Society",
"432 Blonde Universe",
"433 Dream Couple",
"434 Mascot Soul",
"435 COS_YUR",
"436 COS_EST",
"437 COS_KAR",
"438 COS_RIT",
"439 COS_RAV",
"440 COS_JUD",
"441 COS_RAP",
"442 COS_FRE",
"443 COS_PAT",
"444 Stand Alone",
"445 HEAL_DOWN",
"446 Fatal Exceed",
"447 Form Hold",
"448 Critical Upgrade",
"449 Step Cancel F",
"450 Brainiac Magic Selection",
            };
            comboBoxSkill1.Items.AddRange(values);
            comboBoxSkill2.Items.AddRange(values);
            comboBoxSkill3.Items.AddRange(values);

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void enemyTree_AfterSelect(object sender, TreeViewEventArgs e) 
        {
            

            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 172, 4);
            string VarSkillFlag = BitConverter.ToUInt32(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 172).ToString("D"); //We put the hex into this string, and if the string is read, we make the text appear in the combo box.
            nameOfFlags(0);
            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 172, 4);

            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 180, 4);
            VarSkillFlag = BitConverter.ToUInt32(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 180).ToString("D"); //We put the hex into this string, and if the string is read, we make the text appear in the combo box.
            nameOfFlags(1);
            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 180, 4);

            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 188, 4);
            VarSkillFlag = BitConverter.ToUInt32(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 188).ToString("D"); //We put the hex into this string, and if the string is read, we make the text appear in the combo box.
            nameOfFlags(2);
            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 188, 4);

            void nameOfFlags(int box_id)
            {
                //skillTree.Nodes.Add("Function Is Working!" + VarcomboBoxSkillFlag);
                boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("Unknown Skill");
                if (VarSkillFlag == "0") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("No Skill"); }
                if (VarSkillFlag == "1") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("1 Strength"); }
                if (VarSkillFlag == "2") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("2 Strength 2"); }
                if (VarSkillFlag == "3") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("3 Strength 3"); }
                if (VarSkillFlag == "4") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("4 Magic"); }
                if (VarSkillFlag == "5") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("5 Magic 2"); }
                if (VarSkillFlag == "6") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("6 Magic 3"); }
                if (VarSkillFlag == "7") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("7 Elemental"); }
                if (VarSkillFlag == "8") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("8 Heavy Hit"); }
                if (VarSkillFlag == "9") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("9 Stun Magic"); }
                if (VarSkillFlag == "10") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("10 Cross Counter"); }
                if (VarSkillFlag == "11") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("11 FS Bonus"); }
                if (VarSkillFlag == "12") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("12 FS Bonus 2"); }
                if (VarSkillFlag == "13") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("13 Reflect"); }
                if (VarSkillFlag == "14") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("14 Aerial Combo"); }
                if (VarSkillFlag == "15") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("15 HP Condition"); }
                if (VarSkillFlag == "16") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("16 HP Condition 2"); }
                if (VarSkillFlag == "17") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("17 HP Condition 3   (Yes really)"); }
                if (VarSkillFlag == "18") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("18 HP Condition 4"); }
                if (VarSkillFlag == "19") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("19 Half Damage"); }
                if (VarSkillFlag == "20") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("20 Quarter Damage"); }
                if (VarSkillFlag == "21") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("21 Minimum Damage"); }
                if (VarSkillFlag == "22") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("22 Chain"); }
                if (VarSkillFlag == "23") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("23 Hell Fire"); }
                if (VarSkillFlag == "24") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("24 Defend"); }
                if (VarSkillFlag == "25") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("25 Defend 2"); }
                if (VarSkillFlag == "26") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("26 Defend 3"); }
                if (VarSkillFlag == "27") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("27 Resist"); }
                if (VarSkillFlag == "28") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("28 Resist 2"); }
                if (VarSkillFlag == "29") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("29 Resist 3"); }
                if (VarSkillFlag == "30") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("30 Critical Guard"); }
                if (VarSkillFlag == "31") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("31 Magic Guard"); }
                if (VarSkillFlag == "32") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("32 Roll"); }
                if (VarSkillFlag == "33") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("33 Guard Plus"); }
                if (VarSkillFlag == "34") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("34 Void Attack"); }
                if (VarSkillFlag == "35") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("35 Void Magic"); }
                if (VarSkillFlag == "36") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("36 Immunity"); }
                if (VarSkillFlag == "37") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("37 Endure"); }
                if (VarSkillFlag == "38") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("38 Anti Element"); }
                if (VarSkillFlag == "39") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("39 Step Away"); }
                if (VarSkillFlag == "40") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("40 Guard Reflect"); }
                if (VarSkillFlag == "41") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("41 Status Guard"); }
                if (VarSkillFlag == "42") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("42 Condition Guard"); }
                if (VarSkillFlag == "43") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("43 Magic Guard Plus"); }
                if (VarSkillFlag == "44") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("44 TP Condition"); }
                if (VarSkillFlag == "45") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("45 TP Condition 2?"); }
                if (VarSkillFlag == "46") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("46 TP Condition 3?"); }
                if (VarSkillFlag == "47") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("47 TP Condition 4"); }
                if (VarSkillFlag == "48") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("48 Crucible"); }
                if (VarSkillFlag == "49") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("49 Athenor"); }
                if (VarSkillFlag == "50") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("50 Evade"); }
                if (VarSkillFlag == "51") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("51 Evade 2"); }
                if (VarSkillFlag == "52") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("52 Evade 3"); }
                if (VarSkillFlag == "53") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("53 Backstep"); }
                if (VarSkillFlag == "54") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("54 Recover"); }
                if (VarSkillFlag == "55") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("55 O.L. Boost"); }
                if (VarSkillFlag == "56") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("56 Combo Force"); }
                if (VarSkillFlag == "57") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("57 Item Pro"); }
                if (VarSkillFlag == "58") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("58 Lucky End"); }
                if (VarSkillFlag == "59") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("59 Combo Plus"); }
                if (VarSkillFlag == "60") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("60 Alembic"); }
                if (VarSkillFlag == "61") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("61 Gale"); }
                if (VarSkillFlag == "62") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("62 Vitality"); }
                if (VarSkillFlag == "63") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("63 Vitality 2"); }
                if (VarSkillFlag == "64") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("64 Vitality 3"); }
                if (VarSkillFlag == "65") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("65 Spirits"); }
                if (VarSkillFlag == "66") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("66 Spirits 2"); }
                if (VarSkillFlag == "67") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("67 Spirits 3"); }
                if (VarSkillFlag == "68") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("68 Taunt"); }
                if (VarSkillFlag == "69") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("69 Taunt 2"); }
                if (VarSkillFlag == "70") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("70 OVL Taunt"); }
                if (VarSkillFlag == "71") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("71 OVL Taunt 2"); }
                if (VarSkillFlag == "72") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("72 Resurrect"); }
                if (VarSkillFlag == "73") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("73 Stat Boost"); }
                if (VarSkillFlag == "74") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("74 Life Healer"); }
                if (VarSkillFlag == "75") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("75 Spirit Healer"); }
                if (VarSkillFlag == "76") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("76 Happiness"); }
                if (VarSkillFlag == "77") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("77 Happiness 2"); }
                if (VarSkillFlag == "78") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("78 Happiness 3"); }
                if (VarSkillFlag == "79") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("79 Life Up"); }
                if (VarSkillFlag == "80") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("80 Mental Up"); }
                if (VarSkillFlag == "81") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("81 HP Recover"); }
                if (VarSkillFlag == "82") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("82 TP Recover"); }
                if (VarSkillFlag == "84") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("84 OVL Bonus"); }
                if (VarSkillFlag == "85") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("85 OVL Bonus 2"); }
                if (VarSkillFlag == "86") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("86 Lucky Soul"); }
                if (VarSkillFlag == "87") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("87 Rebirth"); }
                if (VarSkillFlag == "88") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("88 Rebirth 2"); }
                if (VarSkillFlag == "89") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("89 BA Force"); }
                if (VarSkillFlag == "90") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("90 Rise Attack"); }
                if (VarSkillFlag == "91") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("91 EXP Share"); }
                if (VarSkillFlag == "93") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("93 Dispersion"); }
                if (VarSkillFlag == "94") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("94 Great Deluge"); }
                if (VarSkillFlag == "96") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("96 Strength 4"); }
                if (VarSkillFlag == "97") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("97 Combo Voltage"); }
                if (VarSkillFlag == "98") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("98 Step Combo"); }
                if (VarSkillFlag == "99") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("99 Combination"); }
                if (VarSkillFlag == "100") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("100 Combination 2"); }
                if (VarSkillFlag == "101") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("101 Combination 3"); }
                if (VarSkillFlag == "102") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("102 High Tension"); }
                if (VarSkillFlag == "103") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("103 Hyper Tension"); }
                if (VarSkillFlag == "104") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("104 Ultimate Tension"); }
                if (VarSkillFlag == "105") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("105 Swords Up"); }
                if (VarSkillFlag == "106") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("106 Hit Plus"); }
                if (VarSkillFlag == "107") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("107 Dragon Buster"); }
                if (VarSkillFlag == "108") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("108 Axes Up"); }
                if (VarSkillFlag == "109") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("109 Assassin"); }
                if (VarSkillFlag == "111") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("111 One Man Show"); }
                if (VarSkillFlag == "112") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("112 Defend Artes"); }
                if (VarSkillFlag == "113") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("113 Glory"); }
                if (VarSkillFlag == "114") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("114 Combo Plus 2"); }
                if (VarSkillFlag == "115") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("115 Combo Plus 3"); }
                if (VarSkillFlag == "116") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("116 Super Chain"); }
                if (VarSkillFlag == "117") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("117 Ability Plus"); }
                if (VarSkillFlag == "118") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("118 High Ability Plus"); }
                if (VarSkillFlag == "119") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("119 Hyper Ability Plus"); }
                if (VarSkillFlag == "120") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("120 Super Chain 4"); }
                if (VarSkillFlag == "121") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("121 Super Chain 2"); }
                if (VarSkillFlag == "122") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("122 Super Chain 3"); }
                if (VarSkillFlag == "123") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("123 Super Chain 5"); }
                if (VarSkillFlag == "125") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("125 Fatal Finish"); }
                if (VarSkillFlag == "126") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("126 Fatal Finish Plus"); }
                if (VarSkillFlag == "127") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("127 Link Slash"); }
                if (VarSkillFlag == "130") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("130 Loner"); }
                if (VarSkillFlag == "131") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("131 Charming Thrust"); }
                if (VarSkillFlag == "132") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("132 Sleepy Thrust"); }
                if (VarSkillFlag == "134") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("134 Guard Plus 2"); }
                if (VarSkillFlag == "135") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("135 Defend 4"); }
                if (VarSkillFlag == "136") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("136 Resist 4"); }
                if (VarSkillFlag == "137") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("137 Guard Impact"); }
                if (VarSkillFlag == "138") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("138 Cure Guard"); }
                if (VarSkillFlag == "139") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("139 Guardian"); }
                if (VarSkillFlag == "140") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("140 Super Guard"); }
                if (VarSkillFlag == "141") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("141 Super Resist"); }
                if (VarSkillFlag == "142") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("142 Anti Magic"); }
                if (VarSkillFlag == "144") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("144 Guard Artes"); }
                if (VarSkillFlag == "145") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("145 Guard All"); }
                if (VarSkillFlag == "146") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("146 Extend Guard"); }
                if (VarSkillFlag == "147") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("147 Guard Supply"); }
                if (VarSkillFlag == "148") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("148 Survive"); }
                if (VarSkillFlag == "149") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("149 Extra Combo I"); }
                if (VarSkillFlag == "150") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("150 Extra Combo II"); }
                if (VarSkillFlag == "151") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("151 Extra Combo III"); }
                if (VarSkillFlag == "155") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("155 Pow Hammer Revenge"); }
                if (VarSkillFlag == "156") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("156 Eternal Support"); }
                if (VarSkillFlag == "157") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("157 Lovely Dog"); }
                if (VarSkillFlag == "159") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("159 Medical Boost"); }
                if (VarSkillFlag == "160") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("160 Auto Medicine"); }
                if (VarSkillFlag == "161") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("161 Healing Artes"); }
                if (VarSkillFlag == "162") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("162 Angel's Tear"); }
                if (VarSkillFlag == "163") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("163 Sleep 'n Heal"); }
                if (VarSkillFlag == "164") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("164 Critical Break"); }
                if (VarSkillFlag == "165") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("165 Charge Smash"); }
                if (VarSkillFlag == "166") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("166 Critical"); }
                if (VarSkillFlag == "167") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("167 Second Attack"); }
                if (VarSkillFlag == "168") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("168 Bug Busters"); }
                if (VarSkillFlag == "169") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("169 Combatir"); }
                if (VarSkillFlag == "170") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("170 Raynard"); }
                if (VarSkillFlag == "171") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("171 Mighty Charge"); }
                if (VarSkillFlag == "172") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("172 Speed Charge"); }
                if (VarSkillFlag == "173") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("173 Attack Arte Charge"); }
                if (VarSkillFlag == "174") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("174 Charge Hold"); }
                if (VarSkillFlag == "175") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("175 Break Down"); }
                if (VarSkillFlag == "177") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("177 Steel Defense"); }
                if (VarSkillFlag == "178") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("178 Down Hit"); }
                if (VarSkillFlag == "179") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("179 Heavy Weight"); }
                if (VarSkillFlag == "180") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("180 Healing Arte Charge"); }
                if (VarSkillFlag == "181") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("181 Taunt & Evade"); }
                if (VarSkillFlag == "182") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("182 Play Dead"); }
                if (VarSkillFlag == "183") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("183 Run"); }
                if (VarSkillFlag == "184") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("184 Taunt Gamble"); }
                if (VarSkillFlag == "185") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("185 Member Taunt"); }
                if (VarSkillFlag == "186") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("186 Motion Change"); }
                if (VarSkillFlag == "187") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("187 Vitality 4"); }
                if (VarSkillFlag == "189") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("189 Medical Smash"); }
                if (VarSkillFlag == "190") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("190 Coward"); }
                if (VarSkillFlag == "191") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("191 Heal Supply"); }
                if (VarSkillFlag == "192") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("192 Safety"); }
                if (VarSkillFlag == "194") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("194 Eternal Weakness"); }
                if (VarSkillFlag == "195") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("195 Support Arte Charge"); }
                if (VarSkillFlag == "196") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("196 Critical Recover"); }
                if (VarSkillFlag == "197") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("197 Magic 4"); }
                if (VarSkillFlag == "199") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("199 Over Cast"); }
                if (VarSkillFlag == "200") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("200 Over Cast 2"); }
                if (VarSkillFlag == "201") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("201 Over Cast 3"); }
                if (VarSkillFlag == "202") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("202 Heavy Magic"); }
                if (VarSkillFlag == "203") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("203 Light Magic"); }
                if (VarSkillFlag == "204") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("204 Critical Magic"); }
                if (VarSkillFlag == "206") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("206 Resilience"); }
                if (VarSkillFlag == "207") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("207 Elemental Effect"); }
                if (VarSkillFlag == "208") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("208 Perfect Magic"); }
                if (VarSkillFlag == "210") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("210 Absorption"); }
                if (VarSkillFlag == "211") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("211 Rhythm"); }
                if (VarSkillFlag == "212") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("212 Recast"); }
                if (VarSkillFlag == "213") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("213 Randomize"); }
                if (VarSkillFlag == "214") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("214 Revenge Spell"); }
                if (VarSkillFlag == "215") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("215 Levitation"); }
                if (VarSkillFlag == "216") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("216 Overheat"); }
                if (VarSkillFlag == "217") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("217 Liner Shot"); }
                if (VarSkillFlag == "218") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("218 Magic Combo"); }
                if (VarSkillFlag == "219") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("219 Speed Cast"); }
                if (VarSkillFlag == "220") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("220 Spell Charge"); }
                if (VarSkillFlag == "221") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("221 Spell Charge 2"); }
                if (VarSkillFlag == "222") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("222 Spell Charge 3"); }
                if (VarSkillFlag == "223") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("223 Spell End"); }
                if (VarSkillFlag == "224") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("224 Lucky Magic"); }
                if (VarSkillFlag == "225") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("225 Spirit Absorb"); }
                if (VarSkillFlag == "226") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("226 Spirits 4"); }
                if (VarSkillFlag == "227") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("227 Reducer"); }
                if (VarSkillFlag == "228") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("228 Convert Absorption"); }
                if (VarSkillFlag == "229") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("229 Combat Force"); }
                if (VarSkillFlag == "230") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("230 Endless Shot"); }
                if (VarSkillFlag == "231") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("231 Hunter"); }
                if (VarSkillFlag == "232") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("232 TP Attack"); }
                if (VarSkillFlag == "233") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("233 Change Style"); }
                if (VarSkillFlag == "234") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("234 Change Style 2"); }
                if (VarSkillFlag == "236") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("236 Strength T"); }
                if (VarSkillFlag == "237") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("237 Magic T"); }
                if (VarSkillFlag == "238") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("238 Light Force"); }
                if (VarSkillFlag == "239") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("239 Revenge Arrow"); }
                if (VarSkillFlag == "240") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("240 Heavy Arrow"); }
                if (VarSkillFlag == "241") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("241 Power Shot"); }
                if (VarSkillFlag == "242") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("242 Defend T"); }
                if (VarSkillFlag == "243") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("243 Resist T"); }
                if (VarSkillFlag == "244") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("244 Escape Step"); }
                if (VarSkillFlag == "245") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("245 Heavy Energy"); }
                if (VarSkillFlag == "246") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("246 High Tension"); }
                if (VarSkillFlag == "248") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("248 In Step"); }
                if (VarSkillFlag == "249") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("249 Quick Arrow"); }
                if (VarSkillFlag == "251") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("251 Long Range"); }
                if (VarSkillFlag == "252") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("252 Step Cancel"); }
                if (VarSkillFlag == "253") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("253 Long Step"); }
                if (VarSkillFlag == "254") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("254 Cooking Plus"); }
                if (VarSkillFlag == "255") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("255 Hunter 2"); }
                if (VarSkillFlag == "256") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("256 Chivalry"); }
                if (VarSkillFlag == "257") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("257 Appeal Target"); }
                if (VarSkillFlag == "259") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("259 Technical Half"); }
                if (VarSkillFlag == "260") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("260 Aerial Combo 2"); }
                if (VarSkillFlag == "261") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("261 Aerial Combo 3"); }
                if (VarSkillFlag == "262") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("262 High Combo"); }
                if (VarSkillFlag == "263") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("263 Aerial Artes"); }
                if (VarSkillFlag == "264") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("264 Aerial Artes 2"); }
                if (VarSkillFlag == "265") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("265 Aerial Artes 3"); }
                if (VarSkillFlag == "268") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("268 Aerial Force"); }
                if (VarSkillFlag == "269") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("269 Aerial Magic Guard"); }
                if (VarSkillFlag == "270") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("270 Aerial Guard"); }
                if (VarSkillFlag == "271") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("271 Aerial Armor"); }
                if (VarSkillFlag == "272") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("272 Escape Jump"); }
                if (VarSkillFlag == "273") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("273 Spear Master"); }
                if (VarSkillFlag == "274") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("274 Rod Master"); }
                if (VarSkillFlag == "275") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("275 Jump Cancel"); }
                if (VarSkillFlag == "276") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("276 Aerial OVL"); }
                if (VarSkillFlag == "277") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("277 Recovery Artes"); }
                if (VarSkillFlag == "278") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("278 Aerial Jump"); }
                if (VarSkillFlag == "279") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("279 Aerial Jump 2"); }
                if (VarSkillFlag == "280") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("280 Aerial Finish"); }
                if (VarSkillFlag == "281") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("281 Aerial Step"); }
                if (VarSkillFlag == "282") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("282 Landing"); }
                if (VarSkillFlag == "283") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("283 Touch Down"); }
                if (VarSkillFlag == "284") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("284 Aerial Dash"); }
                if (VarSkillFlag == "285") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("285 Aerial Tension"); }
                if (VarSkillFlag == "286") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("286 Temptation"); }
                if (VarSkillFlag == "289") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("289 Rod"); }
                if (VarSkillFlag == "290") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("290 Lucky Spear"); }
                if (VarSkillFlag == "291") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("291 Hunter's Fang"); }
                if (VarSkillFlag == "292") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("292 Lucky Limit"); }
                if (VarSkillFlag == "293") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("293 Steal Plus"); }
                if (VarSkillFlag == "294") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("294 Mobile Armor"); }
                if (VarSkillFlag == "295") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("295 Evade 4"); }
                if (VarSkillFlag == "296") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("296 Runners"); }
                if (VarSkillFlag == "297") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("297 Runners 2"); }
                if (VarSkillFlag == "298") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("298 Encounter Bonus"); }
                if (VarSkillFlag == "299") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("299 Quick Turn"); }
                if (VarSkillFlag == "300") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("300 Holy Breath"); }
                if (VarSkillFlag == "301") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("301 Dark Breath"); }
                if (VarSkillFlag == "302") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("302 Double Appeal"); }
                if (VarSkillFlag == "303") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("303 Speed Up"); }
                if (VarSkillFlag == "304") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("304 Speed Up 2"); }
                if (VarSkillFlag == "305") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("305 Item Thrower"); }
                if (VarSkillFlag == "306") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("306 Speedy Item"); }
                if (VarSkillFlag == "307") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("307 Dash Cancel"); }
                if (VarSkillFlag == "308") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("308 Dash"); }
                if (VarSkillFlag == "309") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("309 Item Amplifier"); }
                if (VarSkillFlag == "310") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("310 Item Amplifier 2"); }
                if (VarSkillFlag == "311") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("311 Lucky Item"); }
                if (VarSkillFlag == "312") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("312 Inspector"); }
                if (VarSkillFlag == "313") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("313 Treasure Fangs"); }
                if (VarSkillFlag == "314") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("314 Bark"); }
                if (VarSkillFlag == "316") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("316 Lucky Plus"); }
                if (VarSkillFlag == "317") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("317 Lucky Plus 2"); }
                if (VarSkillFlag == "318") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("318 Full Check"); }
                if (VarSkillFlag == "319") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("319 Scanning"); }
                if (VarSkillFlag == "320") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("320 Lucky Call"); }
                if (VarSkillFlag == "321") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("321 Stinger Blow"); }
                if (VarSkillFlag == "324") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("324 Hero"); }
                if (VarSkillFlag == "325") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("325 Shine"); }
                if (VarSkillFlag == "326") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("326 Team Work"); }
                if (VarSkillFlag == "327") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("327 Devotion"); }
                if (VarSkillFlag == "328") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("328 Shield"); }
                if (VarSkillFlag == "329") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("329 Magic Shield"); }
                if (VarSkillFlag == "330") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("330 Energy Coat"); }
                if (VarSkillFlag == "331") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("331 Lion Heart"); }
                if (VarSkillFlag == "333") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("333 Cure Area"); }
                if (VarSkillFlag == "334") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("334 OVL Boost Area"); }
                if (VarSkillFlag == "335") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("335 S. Spell Area"); }
                if (VarSkillFlag == "336") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("336 HP Relax"); }
                if (VarSkillFlag == "337") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("337 OVL Relax"); }
                if (VarSkillFlag == "338") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("338 TP Support"); }
                if (VarSkillFlag == "340") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("340 No Artes Plus"); }
                if (VarSkillFlag == "343") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("343 Defend Conversion"); }
                if (VarSkillFlag == "344") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("344 Resist Conversion"); }
                if (VarSkillFlag == "345") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("345 Vacance"); }
                if (VarSkillFlag == "346") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("346 Landing Step"); }
                if (VarSkillFlag == "347") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("347 Bastion"); }
                if (VarSkillFlag == "348") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("348 Special"); }
                if (VarSkillFlag == "349") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("349 Anti Break"); }
                if (VarSkillFlag == "350") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("350 Standing Guard"); }
                if (VarSkillFlag == "351") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("351 OVL Plus"); }
                if (VarSkillFlag == "352") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("352 Burst Guard"); }
                if (VarSkillFlag == "353") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("353 OVL Concentrate"); }
                if (VarSkillFlag == "354") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("354 Recovering Guard"); }
                if (VarSkillFlag == "355") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("355 OVL Team"); }
                if (VarSkillFlag == "356") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("356 OVL Team 2"); }
                if (VarSkillFlag == "357") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("357 OVL Team 3"); }
                if (VarSkillFlag == "358") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("358 Burst Hold"); }
                if (VarSkillFlag == "359") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("359 Perfect Tension"); }
                if (VarSkillFlag == "360") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("360 High Heal"); }
                if (VarSkillFlag == "361") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("361 Hyper Heal"); }
                if (VarSkillFlag == "362") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("362 Guard All 2"); }
                if (VarSkillFlag == "363") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("363 Rallying Cast"); }
                if (VarSkillFlag == "364") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("364 Auto Medicine 2"); }
                if (VarSkillFlag == "365") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("365 Sustained Critical"); }
                if (VarSkillFlag == "366") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("366 Charge Hold 2"); }
                if (VarSkillFlag == "367") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("367 High Fatal Tension"); }
                if (VarSkillFlag == "368") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("368 Hyper Fatal Tension"); }
                if (VarSkillFlag == "370") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("370 High Magic Tension"); }
                if (VarSkillFlag == "371") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("371 Hyper Magic Tension"); }
                if (VarSkillFlag == "372") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("372 Combo Magic"); }
                if (VarSkillFlag == "373") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("373 Combo Magic 2"); }
                if (VarSkillFlag == "375") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("375 Bullfight Mind"); }
                if (VarSkillFlag == "376") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("376 Headhunter"); }
                if (VarSkillFlag == "377") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("377 Healing Arrow"); }
                if (VarSkillFlag == "378") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("378 Healing Arrow 2"); }
                if (VarSkillFlag == "379") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("379 High Taunt"); }
                if (VarSkillFlag == "380") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("380 High Aerial Tension"); }
                if (VarSkillFlag == "381") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("381 Hyper Aerial Tension"); }
                if (VarSkillFlag == "382") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("382 Aerial Ability Plus"); }
                if (VarSkillFlag == "383") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("383 Aerial High Ability Plus"); }
                if (VarSkillFlag == "384") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("384 Aerial Hyper Ability Plus"); }
                if (VarSkillFlag == "385") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("385 Multi-Item"); }
                if (VarSkillFlag == "386") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("386 OVL Plus 2"); }
                if (VarSkillFlag == "387") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("387 OVL Plus 3"); }
                if (VarSkillFlag == "388") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("388 High Mobility"); }
                if (VarSkillFlag == "389") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("389 Item Pro 2"); }
                if (VarSkillFlag == "390") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("390 Arte Smash"); }
                if (VarSkillFlag == "391") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("391 Magic Smash"); }
                if (VarSkillFlag == "392") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("392 Burst Smash"); }
                if (VarSkillFlag == "393") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("393 OVL Recover"); }
                if (VarSkillFlag == "394") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("394 Natural Recover"); }
                if (VarSkillFlag == "395") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("395 Guarding Skill"); }
                if (VarSkillFlag == "396") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("396 Guard Artes 2"); }
                if (VarSkillFlag == "397") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("397 Guarding Cast"); }
                if (VarSkillFlag == "398") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("398 Hyper Guard"); }
                if (VarSkillFlag == "399") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("399 Hyper Magic Guard"); }
                if (VarSkillFlag == "400") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("400 HP Surge"); }
                if (VarSkillFlag == "401") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("401 TP Surge"); }
                if (VarSkillFlag == "402") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("402 Just Soul"); }
                if (VarSkillFlag == "403") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("403 Rival Surge"); }
                if (VarSkillFlag == "404") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("404 Rival Surge 2"); }
                if (VarSkillFlag == "405") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("405 Safe Bet"); }
                if (VarSkillFlag == "406") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("406 Gambler's Soul"); }
                if (VarSkillFlag == "407") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("407 High Form Change"); }
                if (VarSkillFlag == "408") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("408 OVL Gamble"); }
                if (VarSkillFlag == "409") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("409 Limit Fever"); }
                if (VarSkillFlag == "410") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("410 Form Selection"); }
                if (VarSkillFlag == "411") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("411 Fighting Lens"); }
                if (VarSkillFlag == "412") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("412 Hyper Form Change"); }
                if (VarSkillFlag == "413") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("413 Critical Upgrade 2"); }
                if (VarSkillFlag == "414") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("414 Brainiac Speed Cast"); }
                if (VarSkillFlag == "415") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("415 Brainiac Combo Magic 2"); }
                if (VarSkillFlag == "416") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("416 Critical Hitter"); }
                if (VarSkillFlag == "417") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("417 OVL Roulette: HP"); }
                if (VarSkillFlag == "418") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("418 OVL Roulette: TP"); }
                if (VarSkillFlag == "419") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("419 OVL Roulette: OVL"); }
                if (VarSkillFlag == "420") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("420 Reincarnation"); }
                if (VarSkillFlag == "421") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("421 Combo Plus Advance"); }
                if (VarSkillFlag == "422") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("422 Brainiac Combo Magic"); }
                if (VarSkillFlag == "423") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("423 Advance Ability Plus"); }
                if (VarSkillFlag == "424") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("424 Brainiac Magic Combo"); }
                if (VarSkillFlag == "425") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("425 Brainiac Grace"); }
                if (VarSkillFlag == "426") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("426 Defend Artes Advance"); }
                if (VarSkillFlag == "427") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("427 Burst Security"); }
                if (VarSkillFlag == "428") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("428 Sticky Fingers"); }
                if (VarSkillFlag == "429") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("429 Female Company"); }
                if (VarSkillFlag == "430") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("430 Kids' Association"); }
                if (VarSkillFlag == "431") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("431 Marksmen's Society"); }
                if (VarSkillFlag == "432") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("432 Blonde Universe"); }
                if (VarSkillFlag == "433") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("433 Dream Couple"); }
                if (VarSkillFlag == "434") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("434 Mascot Soul"); }
                if (VarSkillFlag == "435") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("435 COS_YUR"); }
                if (VarSkillFlag == "436") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("436 COS_EST"); }
                if (VarSkillFlag == "437") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("437 COS_KAR"); }
                if (VarSkillFlag == "438") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("438 COS_RIT"); }
                if (VarSkillFlag == "439") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("439 COS_RAV"); }
                if (VarSkillFlag == "440") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("440 COS_JUD"); }
                if (VarSkillFlag == "441") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("441 COS_RAP"); }
                if (VarSkillFlag == "442") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("442 COS_FRE"); }
                if (VarSkillFlag == "443") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("443 COS_PAT"); }
                if (VarSkillFlag == "444") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("444 Stand Alone"); }
                if (VarSkillFlag == "445") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("445 HEAL_DOWN"); }
                if (VarSkillFlag == "446") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("446 Fatal Exceed"); }
                if (VarSkillFlag == "447") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("447 Form Hold"); }
                if (VarSkillFlag == "448") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("448 Critical Upgrade"); }
                if (VarSkillFlag == "449") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("449 Step Cancel F"); }
                if (VarSkillFlag == "450") { boxes[box_id].SelectedIndex = boxes[box_id].FindStringExact("450 Brainiac Magic Selection"); }






            }


            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 0, 4);
            richTextBoxSortID.Text = BitConverter.ToUInt32(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 0).ToString("D");
            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 0, 4);

            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 112, 4);
            richTextBoxPAtk.Text = BitConverter.ToUInt32(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 112).ToString("D");
            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 112, 4);

            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 116, 4);
            richTextBoxMAtk.Text = BitConverter.ToUInt32(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 116).ToString("D");
            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 116, 4);

            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 120, 4);
            richTextBoxPDef.Text = BitConverter.ToUInt32(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 120).ToString("D");
            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 120, 4);

            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 124, 4);
            richTextBoxMDef.Text = BitConverter.ToUInt32(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 124).ToString("D");
            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 124, 4);

            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 136, 4);
            richTextBoxAgi.Text = BitConverter.ToUInt32(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 136).ToString("D");
            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 136, 4);


            //One of these is probably the luck stat
            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 128, 4);
            richTextBoxUnknown1.Text = BitConverter.ToUInt32(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 128).ToString("D");
            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 128, 4);

            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 132, 4);
            richTextBoxUnknown2.Text = BitConverter.ToUInt32(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 132).ToString("D");
            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 132, 4);

            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 140, 4);
            richTextBoxUnknown3.Text = BitConverter.ToUInt32(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 140).ToString("D");
            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 140, 4);

            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 144, 4);
            richTextBoxUnknown4.Text = BitConverter.ToUInt32(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 144).ToString("D");
            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 144, 4);


            richTextBoxFire.Text = enemydata_array[2752 + (enemyTree.SelectedNode.Index * 740) + 151].ToString("D");
            richTextBoxWater.Text = enemydata_array[2752 + (enemyTree.SelectedNode.Index * 740) + 155].ToString("D");
            richTextBoxWind.Text = enemydata_array[2752 + (enemyTree.SelectedNode.Index * 740) + 159].ToString("D");
            richTextBoxEarth.Text = enemydata_array[2752 + (enemyTree.SelectedNode.Index * 740) + 163].ToString("D");
            richTextBoxLight.Text = enemydata_array[2752 + (enemyTree.SelectedNode.Index * 740) + 167].ToString("D");
            richTextBoxDark.Text = enemydata_array[2752 + (enemyTree.SelectedNode.Index * 740) + 171].ToString("D");


            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 148, 4);
            richTextBoxFire.Text = BitConverter.ToUInt32(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 148).ToString("D");
            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 148, 4);

            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 152, 4);
            richTextBoxWater.Text = BitConverter.ToUInt32(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 152).ToString("D");
            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 152, 4);

            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 156, 4);
            richTextBoxWind.Text = BitConverter.ToUInt32(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 156).ToString("D");
            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 156, 4);

            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 160, 4);
            richTextBoxEarth.Text = BitConverter.ToUInt32(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 160).ToString("D");
            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 160, 4);

            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 164, 4);
            richTextBoxLight.Text = BitConverter.ToUInt32(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 164).ToString("D");
            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 164, 4);

            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 168, 4);
            richTextBoxDark.Text = BitConverter.ToUInt32(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 168).ToString("D");
            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 168, 4);



            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 172, 4);
            richTextBoxSkill1.Text = BitConverter.ToUInt32(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 172).ToString("D");
            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 172, 4);

            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 180, 4);
            richTextBoxSkill2.Text = BitConverter.ToUInt32(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 180).ToString("D");
            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 180, 4);

            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 188, 4);
            richTextBoxSkill3.Text = BitConverter.ToUInt32(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 188).ToString("D");
            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 188, 4);

            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 176, 4);
            richTextBoxSkill1LP.Text = BitConverter.ToUInt32(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 176).ToString("D");
            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 176, 4);

            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 184, 4);
            richTextBoxSkill2LP.Text = BitConverter.ToUInt32(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 184).ToString("D");
            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 184, 4);

            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 192, 4);
            richTextBoxSkill3LP.Text = BitConverter.ToUInt32(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 192).ToString("D");
            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 192, 4);



            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 52, 4);
            richTextBoxUser.Text = BitConverter.ToUInt32(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 52).ToString("D");
            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 52, 4);

            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 60, 4);
            richTextBoxWepType.Text = BitConverter.ToUInt32(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 60).ToString("D");
            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 60, 4);



            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 468, 4);
            richTextBoxUnknown10.Text = BitConverter.ToUInt32(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 468).ToString("D");
            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 468, 4);

            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 472, 4);
            richTextBoxUnknown11.Text = BitConverter.ToUInt32(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 472).ToString("D");
            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 472, 4);

            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 516, 4);
            richTextBoxUnknown12.Text = BitConverter.ToUInt32(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 516).ToString("D");
            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 516, 4);

            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 576, 4);
            richTextBoxUnknown13.Text = BitConverter.ToUInt32(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 576).ToString("D");
            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 576, 4);


            //Shop stuff
            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 44, 4);
            richTextBoxBuy.Text = BitConverter.ToUInt32(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 44).ToString("D");
            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 44, 4);

            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 520, 4);
            richTextBoxSynth.Text = BitConverter.ToUInt32(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 520).ToString("D");
            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 520, 4);

            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 528, 4);
            richTextBoxMat1.Text = BitConverter.ToUInt32(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 528).ToString("D");
            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 528, 4);

            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 532, 4);
            richTextBoxMat1Count.Text = BitConverter.ToUInt32(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 532).ToString("D");
            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 532, 4);

            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 536, 4);
            richTextBoxMat2.Text = BitConverter.ToUInt32(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 536).ToString("D");
            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 536, 4);

            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 540, 4);
            richTextBoxMat2Count.Text = BitConverter.ToUInt32(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 540).ToString("D");
            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 540, 4);

            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 544, 4);
            richTextBoxMat3.Text = BitConverter.ToUInt32(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 544).ToString("D");
            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 544, 4);

            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 548, 4);
            richTextBoxMat3Count.Text = BitConverter.ToUInt32(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 548).ToString("D");
            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 548, 4);

            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 552, 4);
            richTextBoxMat4.Text = BitConverter.ToUInt32(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 552).ToString("D");
            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 552, 4);

            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 556, 4);
            richTextBoxMat4Count.Text = BitConverter.ToUInt32(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 556).ToString("D");
            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 556, 4);

            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 560, 4);
            richTextBoxMat5.Text = BitConverter.ToUInt32(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 560).ToString("D");
            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 560, 4);

            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 564, 4);
            richTextBoxMat5Count.Text = BitConverter.ToUInt32(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 564).ToString("D");
            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 564, 4);
        }

        private void button1_Click(object sender, EventArgs e) //Save button
        {
            //Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 0, 4);
            UInt32.TryParse(richTextBoxSortID.Text, out uint value32); { Form1.ByteWriter(value32, enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 0); } //First 4 byte save
            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 0, 4);
            
            UInt32.TryParse(richTextBoxPAtk.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 112); }
            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 112, 4);

            UInt32.TryParse(richTextBoxMAtk.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 116); }
            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 116, 4);

            UInt32.TryParse(richTextBoxPDef.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 120); }
            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 120, 4);

            UInt32.TryParse(richTextBoxMDef.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 124); }
            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 124, 4);

            UInt32.TryParse(richTextBoxAgi.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 136); }
            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 136, 4);

            
            //elements
            UInt32.TryParse(richTextBoxFire.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 148); }
            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 148, 4);
            UInt32.TryParse(richTextBoxWater.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 152); }
            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 152, 4);
            UInt32.TryParse(richTextBoxWind.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 156); }
            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 156, 4);
            UInt32.TryParse(richTextBoxEarth.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 160); }
            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 160, 4);
            UInt32.TryParse(richTextBoxLight.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 164); }
            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 164, 4);
            UInt32.TryParse(richTextBoxDark.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 168); }
            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 168, 4);

            UInt32.TryParse(richTextBoxUnknown1.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 128); }
            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 128, 4);

            UInt32.TryParse(richTextBoxUnknown2.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 132); }
            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 132, 4);

            UInt32.TryParse(richTextBoxUnknown3.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 140); }
            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 140, 4);

            UInt32.TryParse(richTextBoxUnknown4.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 144); }
            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 144, 4);



            UInt32.TryParse(richTextBoxSkill1.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 172); }
            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 172, 4);

            UInt32.TryParse(richTextBoxSkill2.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 180); }
            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 180, 4);

            UInt32.TryParse(richTextBoxSkill3.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 188); }
            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 188, 4);

            UInt32.TryParse(richTextBoxSkill1LP.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 176); }
            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 176, 4);

            UInt32.TryParse(richTextBoxSkill2LP.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 184); }
            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 184, 4);

            UInt32.TryParse(richTextBoxSkill3LP.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 192); }
            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 192, 4);



            UInt32.TryParse(richTextBoxUser.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 52); }
            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 52, 4);

            UInt32.TryParse(richTextBoxWepType.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 60); }
            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 60, 4);




            UInt32.TryParse(richTextBoxUnknown10.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 468); }
            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 468, 4);

            UInt32.TryParse(richTextBoxUnknown11.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 472); }
            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 472, 4);

            UInt32.TryParse(richTextBoxUnknown12.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 516); }
            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 516, 4);

            UInt32.TryParse(richTextBoxUnknown13.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 576); }
            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 576, 4);
            


            //Shop stuff
            UInt32.TryParse(richTextBoxBuy.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 44); }
            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 44, 4);

            UInt32.TryParse(richTextBoxSynth.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 520); }
            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 520, 4);

            UInt32.TryParse(richTextBoxMat1.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 528); }
            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 528, 4);

            UInt32.TryParse(richTextBoxMat1Count.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 532); }
            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 532, 4);

            UInt32.TryParse(richTextBoxMat2.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 536); }
            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 536, 4);

            UInt32.TryParse(richTextBoxMat2Count.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 540); }
            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 540, 4);

            UInt32.TryParse(richTextBoxMat3.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 544); }
            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 544, 4);

            UInt32.TryParse(richTextBoxMat3Count.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 548); }
            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 548, 4);

            UInt32.TryParse(richTextBoxMat4.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 552); }
            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 552, 4);

            UInt32.TryParse(richTextBoxMat4Count.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 556); }
            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 556, 4);

            UInt32.TryParse(richTextBoxMat5.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 560); }
            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 560, 4);

            UInt32.TryParse(richTextBoxMat5Count.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 564); }
            Array.Reverse(enemydata_array, 2752 + (enemyTree.SelectedNode.Index * 740) + 564, 4);

            File.WriteAllBytes(Properties.Settings.Default.VesperiaData64 + "\\Data64\\item.svo", enemydata_array); //saves to the path i set, everything in the array/   
        }

        private void button4_Click(object sender, EventArgs e) //arte editor
        {
            if (File.Exists(Properties.Settings.Default.VesperiaData64 + "\\Data64\\btl.svo"))
            {
                FormVesperiaArteEditor f2 = new FormVesperiaArteEditor(); //Create the new form
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

        private void button6_Click(object sender, EventArgs e) //Skill Editor
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
    }
}
