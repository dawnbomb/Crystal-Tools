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
    public partial class FormVesperiaSkillEditor : Form
    {

        String treeloaded = "No";
        byte[] enemydata_array; //This starts the array, the name after is what i name this array?

        public FormVesperiaSkillEditor()
        {
            InitializeComponent();

            string enemydata_path = Properties.Settings.Default.VesperiaData64 + "\\Data64\\btl.svo"; //This defines the path as a string, so i can refer to it by this string/name instead of the full path every time
            int enemydata_length = (int)(new FileInfo(enemydata_path).Length);   //The leagth of the array?
            enemydata_array = File.ReadAllBytes(enemydata_path);  //loads an array with whatever is in the path

            //Add the EO1 enemy list to the in editor list of enemy names
            enemyTree.Nodes.Add("NONE");
            enemyTree.Nodes.Add("Strength");
            enemyTree.Nodes.Add("Strength 2");
            enemyTree.Nodes.Add("Strength 3");
            enemyTree.Nodes.Add("Strength 4");
            enemyTree.Nodes.Add("Strength T");
            enemyTree.Nodes.Add("Magic");
            enemyTree.Nodes.Add("Magic 2");
            enemyTree.Nodes.Add("Magic 3");
            enemyTree.Nodes.Add("Magic 4");
            enemyTree.Nodes.Add("Magic T");
            enemyTree.Nodes.Add("Rise Attack");
            enemyTree.Nodes.Add("Heavy Hit");
            enemyTree.Nodes.Add("Swords Up");
            enemyTree.Nodes.Add("Axes Up");
            enemyTree.Nodes.Add("Combatir");
            enemyTree.Nodes.Add("Raynard");
            enemyTree.Nodes.Add("Light Force");
            enemyTree.Nodes.Add("Rival Surge");
            enemyTree.Nodes.Add("Rival Surge 2");
            enemyTree.Nodes.Add("Assassin");
            enemyTree.Nodes.Add("Bug Busters");
            enemyTree.Nodes.Add("Hunter");
            enemyTree.Nodes.Add("Aerial Force");
            enemyTree.Nodes.Add("Hero");
            enemyTree.Nodes.Add("Second Attack");
            enemyTree.Nodes.Add("Critical");
            enemyTree.Nodes.Add("Critical Break");
            enemyTree.Nodes.Add("Sustained Critical");
            enemyTree.Nodes.Add("Charming Thrust");
            enemyTree.Nodes.Add("Sleepy Thrust");
            enemyTree.Nodes.Add("Stinger Blow");
            enemyTree.Nodes.Add("TP Attack");
            enemyTree.Nodes.Add("Elemental");
            enemyTree.Nodes.Add("Critical Magic");
            enemyTree.Nodes.Add("Stun Magic");
            enemyTree.Nodes.Add("Shine");
            enemyTree.Nodes.Add("Heavy Magic");
            enemyTree.Nodes.Add("Light Magic");
            enemyTree.Nodes.Add("Over Cast");
            enemyTree.Nodes.Add("Over Cast 2");
            enemyTree.Nodes.Add("Over Cast 3");
            enemyTree.Nodes.Add("Aerial Artes");
            enemyTree.Nodes.Add("Aerial Artes 2");
            enemyTree.Nodes.Add("Aerial Artes 3");
            enemyTree.Nodes.Add("Aerial Finish");
            enemyTree.Nodes.Add("High Combo");
            enemyTree.Nodes.Add("Change Style");
            enemyTree.Nodes.Add("Change Style 2");
            enemyTree.Nodes.Add("Bullfight Mind");
            enemyTree.Nodes.Add("Steal Plus");
            enemyTree.Nodes.Add("Combo Plus");
            enemyTree.Nodes.Add("Combo Plus 2");
            enemyTree.Nodes.Add("Combo Plus 3");
            enemyTree.Nodes.Add("Combo Plus Advance");
            enemyTree.Nodes.Add("Step Combo");
            enemyTree.Nodes.Add("Dragon Buster");
            enemyTree.Nodes.Add("Mighty Charge");
            enemyTree.Nodes.Add("Charge Hold");
            enemyTree.Nodes.Add("Charge Hold 2");
            enemyTree.Nodes.Add("Speed Charge");
            enemyTree.Nodes.Add("Charge Smash");
            enemyTree.Nodes.Add("Attack Arte Charge");
            enemyTree.Nodes.Add("Endless Shot");
            enemyTree.Nodes.Add("Combo Voltage");
            enemyTree.Nodes.Add("Combination");
            enemyTree.Nodes.Add("Combination 2");
            enemyTree.Nodes.Add("Combination 3");
            enemyTree.Nodes.Add("High Tension");
            enemyTree.Nodes.Add("Hyper Tension");
            enemyTree.Nodes.Add("Ultimate Tension");
            enemyTree.Nodes.Add("Perfect Tension");
            enemyTree.Nodes.Add("High Fatal Tension");
            enemyTree.Nodes.Add("Hyper Fatal Tension");
            enemyTree.Nodes.Add("High Magic Tension");
            enemyTree.Nodes.Add("Hyper Magic Tension");
            enemyTree.Nodes.Add("High Aerial Tension");
            enemyTree.Nodes.Add("Hyper Aerial Tension");
            enemyTree.Nodes.Add("Cross Counter");
            enemyTree.Nodes.Add("Safe Bet");
            enemyTree.Nodes.Add("Gambler's Soul");
            enemyTree.Nodes.Add("Critical Hitter");
            enemyTree.Nodes.Add("Reflect");
            enemyTree.Nodes.Add("FS Bonus");
            enemyTree.Nodes.Add("FS Bonus 2");
            enemyTree.Nodes.Add("Fatal Exceed");
            enemyTree.Nodes.Add("Hunter's Fang");
            enemyTree.Nodes.Add("BA Force");
            enemyTree.Nodes.Add("Burst Hold");
            enemyTree.Nodes.Add("Lucky Limit");
            enemyTree.Nodes.Add("Limit Fever");
            enemyTree.Nodes.Add("Special");
            enemyTree.Nodes.Add("Hit Plus");
            enemyTree.Nodes.Add("Team Work");
            enemyTree.Nodes.Add("HP Condition");
            enemyTree.Nodes.Add("HP Condition 3   (Yes really)");
            enemyTree.Nodes.Add("HP Condition 2");
            enemyTree.Nodes.Add("HP Condition 4");
            enemyTree.Nodes.Add("One Man Show");
            enemyTree.Nodes.Add("Arte Smash");
            enemyTree.Nodes.Add("Magic Smash");
            enemyTree.Nodes.Add("Burst Smash");
            enemyTree.Nodes.Add("Fighting Lens");
            enemyTree.Nodes.Add("Half Damage");
            enemyTree.Nodes.Add("Quarter Damage");
            enemyTree.Nodes.Add("Minimum Damage");
            enemyTree.Nodes.Add("Chain");
            enemyTree.Nodes.Add("Hell Fire");
            enemyTree.Nodes.Add("Defend");
            enemyTree.Nodes.Add("Defend 2");
            enemyTree.Nodes.Add("Defend 3");
            enemyTree.Nodes.Add("Defend 4");
            enemyTree.Nodes.Add("Defend T");
            enemyTree.Nodes.Add("Resist");
            enemyTree.Nodes.Add("Resist 2");
            enemyTree.Nodes.Add("Resist 3");
            enemyTree.Nodes.Add("Resist 4");
            enemyTree.Nodes.Add("Resist T");
            enemyTree.Nodes.Add("Critical Guard");
            enemyTree.Nodes.Add("Guard Impact");
            enemyTree.Nodes.Add("Magic Guard");
            enemyTree.Nodes.Add("Aerial Guard");
            enemyTree.Nodes.Add("Aerial Magic Guard");
            enemyTree.Nodes.Add("Guard Plus");
            enemyTree.Nodes.Add("Guard Plus 2");
            enemyTree.Nodes.Add("Magic Guard Plus");
            enemyTree.Nodes.Add("Guard Reflect");
            enemyTree.Nodes.Add("Guard Artes");
            enemyTree.Nodes.Add("Guard Artes 2");
            enemyTree.Nodes.Add("Extend Guard");
            enemyTree.Nodes.Add("Guard Supply");
            enemyTree.Nodes.Add("Roll");
            enemyTree.Nodes.Add("Revenge Arrow");
            enemyTree.Nodes.Add("Anti Element");
            enemyTree.Nodes.Add("Anti Break");
            enemyTree.Nodes.Add("Super Guard");
            enemyTree.Nodes.Add("Super Resist");
            enemyTree.Nodes.Add("Guarding Skill");
            enemyTree.Nodes.Add("Steel Defense");
            enemyTree.Nodes.Add("Status Guard");
            enemyTree.Nodes.Add("Condition Guard");
            enemyTree.Nodes.Add("Immunity");
            enemyTree.Nodes.Add("Lion Heart");
            enemyTree.Nodes.Add("Cure Area");
            enemyTree.Nodes.Add("Cure Guard");
            enemyTree.Nodes.Add("Guarding Cast");
            enemyTree.Nodes.Add("Endure");
            enemyTree.Nodes.Add("Void Attack");
            enemyTree.Nodes.Add("Void Magic");
            enemyTree.Nodes.Add("Step Away");
            enemyTree.Nodes.Add("Escape Step");
            enemyTree.Nodes.Add("Guard All");
            enemyTree.Nodes.Add("Guard All 2");
            enemyTree.Nodes.Add("Absorption");
            enemyTree.Nodes.Add("Defend Artes");
            enemyTree.Nodes.Add("Defend Artes Advance");
            enemyTree.Nodes.Add("Burst Guard");
            enemyTree.Nodes.Add("Recovering Guard");
            enemyTree.Nodes.Add("Resilience");
            enemyTree.Nodes.Add("Brainiac Grace");
            enemyTree.Nodes.Add("Anti Magic");
            enemyTree.Nodes.Add("Perfect Magic");
            enemyTree.Nodes.Add("Aerial Armor");
            enemyTree.Nodes.Add("Mobile Armor");
            enemyTree.Nodes.Add("Glory");
            enemyTree.Nodes.Add("Escape Jump");
            enemyTree.Nodes.Add("TP Condition");
            enemyTree.Nodes.Add("TP Condition 3?");
            enemyTree.Nodes.Add("TP Condition 2?");
            enemyTree.Nodes.Add("TP Condition 4");
            enemyTree.Nodes.Add("Guardian");
            enemyTree.Nodes.Add("Survive");
            enemyTree.Nodes.Add("Break Down");
            enemyTree.Nodes.Add("Down Hit");
            enemyTree.Nodes.Add("Heavy Weight");
            enemyTree.Nodes.Add("Healing Arte Charge");
            enemyTree.Nodes.Add("Elemental Effect");
            enemyTree.Nodes.Add("Heavy Arrow");
            enemyTree.Nodes.Add("Power Shot");
            enemyTree.Nodes.Add("Heavy Energy");
            enemyTree.Nodes.Add("Spear Master");
            enemyTree.Nodes.Add("Rod Master");
            enemyTree.Nodes.Add("Standing Guard");
            enemyTree.Nodes.Add("OVL Concentrate");
            enemyTree.Nodes.Add("Hyper Guard");
            enemyTree.Nodes.Add("Hyper Magic Guard");
            enemyTree.Nodes.Add("Shield");
            enemyTree.Nodes.Add("Magic Shield");
            enemyTree.Nodes.Add("Devotion");
            enemyTree.Nodes.Add("Energy Coat");
            enemyTree.Nodes.Add("Crucible");
            enemyTree.Nodes.Add("Athenor");
            enemyTree.Nodes.Add("Evade");
            enemyTree.Nodes.Add("Evade 2");
            enemyTree.Nodes.Add("Evade 3");
            enemyTree.Nodes.Add("Evade 4");
            enemyTree.Nodes.Add("Just Soul");
            enemyTree.Nodes.Add("Item Thrower");
            enemyTree.Nodes.Add("Item Pro");
            enemyTree.Nodes.Add("Item Pro 2");
            enemyTree.Nodes.Add("Speedy Item");
            enemyTree.Nodes.Add("In Step");
            enemyTree.Nodes.Add("Backstep");
            enemyTree.Nodes.Add("Landing Step");
            enemyTree.Nodes.Add("Long Step");
            enemyTree.Nodes.Add("Step Cancel");
            enemyTree.Nodes.Add("Step Cancel F");
            enemyTree.Nodes.Add("Recover");
            enemyTree.Nodes.Add("Recovery Artes");
            enemyTree.Nodes.Add("Form Selection");
            enemyTree.Nodes.Add("Form Hold");
            enemyTree.Nodes.Add("Dash");
            enemyTree.Nodes.Add("Dash Cancel");
            enemyTree.Nodes.Add("Quick Turn");
            enemyTree.Nodes.Add("Runners");
            enemyTree.Nodes.Add("Runners 2");
            enemyTree.Nodes.Add("Run");
            enemyTree.Nodes.Add("Aerial Jump");
            enemyTree.Nodes.Add("Aerial Jump 2");
            enemyTree.Nodes.Add("Jump Cancel");
            enemyTree.Nodes.Add("Aerial OVL");
            enemyTree.Nodes.Add("Aerial Step");
            enemyTree.Nodes.Add("Aerial Dash");
            enemyTree.Nodes.Add("Touch Down");
            enemyTree.Nodes.Add("Landing");
            enemyTree.Nodes.Add("Levitation");
            enemyTree.Nodes.Add("Combo Force");
            enemyTree.Nodes.Add("Extra Combo I");
            enemyTree.Nodes.Add("Extra Combo II");
            enemyTree.Nodes.Add("Extra Combo III");
            enemyTree.Nodes.Add("Aerial Combo");
            enemyTree.Nodes.Add("Aerial Combo 2");
            enemyTree.Nodes.Add("Aerial Combo 3");
            enemyTree.Nodes.Add("Quick Arrow");
            enemyTree.Nodes.Add("Long Range");
            enemyTree.Nodes.Add("Headhunter");
            enemyTree.Nodes.Add("Magic Combo");
            enemyTree.Nodes.Add("Liner Shot");
            enemyTree.Nodes.Add("Spell Charge");
            enemyTree.Nodes.Add("Spell Charge 2");
            enemyTree.Nodes.Add("Spell Charge 3");
            enemyTree.Nodes.Add("Rhythm");
            enemyTree.Nodes.Add("Randomize");
            enemyTree.Nodes.Add("Recast");
            enemyTree.Nodes.Add("Overheat");
            enemyTree.Nodes.Add("Speed Cast");
            enemyTree.Nodes.Add("Brainiac Speed Cast");
            enemyTree.Nodes.Add("Lucky End");
            enemyTree.Nodes.Add("Spell End");
            enemyTree.Nodes.Add("Pow Hammer Revenge");
            enemyTree.Nodes.Add("Revenge Spell");
            enemyTree.Nodes.Add("Super Chain 4");
            enemyTree.Nodes.Add("Super Chain 5");
            enemyTree.Nodes.Add("Combo Magic");
            enemyTree.Nodes.Add("Combo Magic 2");
            enemyTree.Nodes.Add("Brainiac Combo Magic");
            enemyTree.Nodes.Add("Brainiac Combo Magic 2");
            enemyTree.Nodes.Add("Super Chain");
            enemyTree.Nodes.Add("Super Chain 2");
            enemyTree.Nodes.Add("Super Chain 3");
            enemyTree.Nodes.Add("Ability Plus");
            enemyTree.Nodes.Add("High Ability Plus");
            enemyTree.Nodes.Add("Hyper Ability Plus");
            enemyTree.Nodes.Add("Aerial Ability Plus");
            enemyTree.Nodes.Add("Aerial High Ability Plus");
            enemyTree.Nodes.Add("Aerial Hyper Ability Plus");
            enemyTree.Nodes.Add("Rallying Cast");
            enemyTree.Nodes.Add("O.L. Boost");
            enemyTree.Nodes.Add("High Tension");
            enemyTree.Nodes.Add("High Taunt");
            enemyTree.Nodes.Add("Taunt & Evade");
            enemyTree.Nodes.Add("Taunt Gamble");
            enemyTree.Nodes.Add("Member Taunt");
            enemyTree.Nodes.Add("Double Appeal");
            enemyTree.Nodes.Add("Fatal Finish");
            enemyTree.Nodes.Add("Fatal Finish Plus");
            enemyTree.Nodes.Add("Speed Up");
            enemyTree.Nodes.Add("Speed Up 2");
            enemyTree.Nodes.Add("High Mobility");
            enemyTree.Nodes.Add("Link Slash");
            enemyTree.Nodes.Add("Motion Change");
            enemyTree.Nodes.Add("Play Dead");
            enemyTree.Nodes.Add("Holy Breath");
            enemyTree.Nodes.Add("Dark Breath");
            enemyTree.Nodes.Add("Encounter Bonus");
            enemyTree.Nodes.Add("OVL Boost Area");
            enemyTree.Nodes.Add("S. Spell Area");
            enemyTree.Nodes.Add("Critical Upgrade");
            enemyTree.Nodes.Add("Critical Upgrade 2");
            enemyTree.Nodes.Add("High Form Change");
            enemyTree.Nodes.Add("Hyper Form Change");
            enemyTree.Nodes.Add("Advance Ability Plus");
            enemyTree.Nodes.Add("Brainiac Magic Combo");
            enemyTree.Nodes.Add("Brainiac Magic Selection");
            enemyTree.Nodes.Add("OVL Gamble");
            enemyTree.Nodes.Add("Female Company");
            enemyTree.Nodes.Add("Kids' Association");
            enemyTree.Nodes.Add("Marksmen's Society");
            enemyTree.Nodes.Add("Blonde Universe");
            enemyTree.Nodes.Add("Dream Couple");
            enemyTree.Nodes.Add("Mascot Soul");
            enemyTree.Nodes.Add("Alembic");
            enemyTree.Nodes.Add("Gale");
            enemyTree.Nodes.Add("Vitality");
            enemyTree.Nodes.Add("Vitality 2");
            enemyTree.Nodes.Add("Vitality 3");
            enemyTree.Nodes.Add("Vitality 4");
            enemyTree.Nodes.Add("Spirits");
            enemyTree.Nodes.Add("Spirits 2");
            enemyTree.Nodes.Add("Spirits 3");
            enemyTree.Nodes.Add("Spirits 4");
            enemyTree.Nodes.Add("Lucky Plus");
            enemyTree.Nodes.Add("Lucky Plus 2");
            enemyTree.Nodes.Add("Defend Conversion");
            enemyTree.Nodes.Add("Resist Conversion");
            enemyTree.Nodes.Add("Combat Force");
            enemyTree.Nodes.Add("Item Amplifier");
            enemyTree.Nodes.Add("Item Amplifier 2");
            enemyTree.Nodes.Add("Lucky Item");
            enemyTree.Nodes.Add("Multi-Item");
            enemyTree.Nodes.Add("Full Check");
            enemyTree.Nodes.Add("Scanning");
            enemyTree.Nodes.Add("Inspector");
            enemyTree.Nodes.Add("Aerial Tension");
            enemyTree.Nodes.Add("Medical Boost");
            enemyTree.Nodes.Add("Medical Smash");
            enemyTree.Nodes.Add("Heal Supply");
            enemyTree.Nodes.Add("Eternal Support");
            enemyTree.Nodes.Add("Eternal Weakness");
            enemyTree.Nodes.Add("Support Arte Charge");
            enemyTree.Nodes.Add("Critical Recover");
            enemyTree.Nodes.Add("Convert Absorption");
            enemyTree.Nodes.Add("Healing Artes");
            enemyTree.Nodes.Add("Lucky Magic");
            enemyTree.Nodes.Add("Reducer");
            enemyTree.Nodes.Add("HP Recover");
            enemyTree.Nodes.Add("TP Recover");
            enemyTree.Nodes.Add("Rebirth");
            enemyTree.Nodes.Add("Rebirth 2");
            enemyTree.Nodes.Add("Healing Arrow");
            enemyTree.Nodes.Add("Healing Arrow 2");
            enemyTree.Nodes.Add("Lucky Soul");
            enemyTree.Nodes.Add("Burst Security");
            enemyTree.Nodes.Add("Stat Boost");
            enemyTree.Nodes.Add("OVL Roulette: HP");
            enemyTree.Nodes.Add("OVL Roulette: TP");
            enemyTree.Nodes.Add("OVL Roulette: OVL");
            enemyTree.Nodes.Add("Sleep 'n Heal");
            enemyTree.Nodes.Add("Auto Medicine");
            enemyTree.Nodes.Add("Auto Medicine 2");
            enemyTree.Nodes.Add("Spirit Absorb");
            enemyTree.Nodes.Add("Lucky Call");
            enemyTree.Nodes.Add("Resurrect");
            enemyTree.Nodes.Add("Angel's Tear");
            enemyTree.Nodes.Add("Reincarnation");
            enemyTree.Nodes.Add("HP Surge");
            enemyTree.Nodes.Add("TP Surge");
            enemyTree.Nodes.Add("Loner");
            enemyTree.Nodes.Add("Lovely Dog");
            enemyTree.Nodes.Add("Chivalry");
            enemyTree.Nodes.Add("Hunter 2");
            enemyTree.Nodes.Add("Rod");
            enemyTree.Nodes.Add("Lucky Spear");
            enemyTree.Nodes.Add("OVL Bonus");
            enemyTree.Nodes.Add("OVL Bonus 2");
            enemyTree.Nodes.Add("OVL Plus");
            enemyTree.Nodes.Add("OVL Plus 2");
            enemyTree.Nodes.Add("OVL Plus 3");
            enemyTree.Nodes.Add("OVL Team");
            enemyTree.Nodes.Add("OVL Team 2");
            enemyTree.Nodes.Add("OVL Team 3");
            enemyTree.Nodes.Add("High Heal");
            enemyTree.Nodes.Add("Hyper Heal");
            enemyTree.Nodes.Add("OVL Recover");
            enemyTree.Nodes.Add("Natural Recover");
            enemyTree.Nodes.Add("HP Relax");
            enemyTree.Nodes.Add("OVL Relax");
            enemyTree.Nodes.Add("Taunt");
            enemyTree.Nodes.Add("Taunt 2");
            enemyTree.Nodes.Add("OVL Taunt");
            enemyTree.Nodes.Add("OVL Taunt 2");
            enemyTree.Nodes.Add("Appeal Target");
            enemyTree.Nodes.Add("Temptation");
            enemyTree.Nodes.Add("Bark");
            enemyTree.Nodes.Add("Life Healer");
            enemyTree.Nodes.Add("Spirit Healer");
            enemyTree.Nodes.Add("Life Up");
            enemyTree.Nodes.Add("Mental Up");
            enemyTree.Nodes.Add("Happiness");
            enemyTree.Nodes.Add("Happiness 2");
            enemyTree.Nodes.Add("Happiness 3");
            enemyTree.Nodes.Add("Safety");
            enemyTree.Nodes.Add("Technical Half");
            enemyTree.Nodes.Add("Vacance");
            enemyTree.Nodes.Add("EXP Share");
            enemyTree.Nodes.Add("Coward");
            enemyTree.Nodes.Add("Cooking Plus");
            enemyTree.Nodes.Add("Treasure Fangs");
            enemyTree.Nodes.Add("TP Support");
            enemyTree.Nodes.Add("No Artes Plus");
            enemyTree.Nodes.Add("Sticky Fingers");
            enemyTree.Nodes.Add("Stand Alone");
            enemyTree.Nodes.Add("Dispersion");
            enemyTree.Nodes.Add("Great Deluge");
            enemyTree.Nodes.Add("Bastion");
            enemyTree.Nodes.Add("COS_YUR");
            enemyTree.Nodes.Add("COS_EST");
            enemyTree.Nodes.Add("COS_KAR");
            enemyTree.Nodes.Add("COS_RIT");
            enemyTree.Nodes.Add("COS_RAV");
            enemyTree.Nodes.Add("COS_JUD");
            enemyTree.Nodes.Add("COS_RAP");
            enemyTree.Nodes.Add("COS_FRE");
            enemyTree.Nodes.Add("COS_PAT");
            enemyTree.Nodes.Add("HEAL_DOWN");

            TreeNodeCollection nodeCollect = enemyTree.Nodes;
            enemyTree.SelectedNode = nodeCollect[0];
        }

        private void enemyTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            richTextBoxSortID.Text = BitConverter.ToUInt32(enemydata_array, 86672669 + (enemyTree.SelectedNode.Index * 68) + 4).ToString("D");
            richTextBoxSP.Text = BitConverter.ToUInt32(enemydata_array, 86672669 + (enemyTree.SelectedNode.Index * 68) + 36).ToString("D");
            richTextBoxLP.Text = BitConverter.ToUInt32(enemydata_array, 86672669 + (enemyTree.SelectedNode.Index * 68) + 40).ToString("D");
            richTextBoxWeight.Text = BitConverter.ToUInt32(enemydata_array, 86672669 + (enemyTree.SelectedNode.Index * 68) + 48).ToString("D");
        }

        private void button1_Click(object sender, EventArgs e) //Save Button
        {
            UInt32.TryParse(richTextBoxSortID.Text, out uint value32); { Form1.ByteWriter(value32, enemydata_array, 86672669 + (enemyTree.SelectedNode.Index * 68) + 4); } //First 4 byte save
            UInt32.TryParse(richTextBoxSP.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 86672669 + (enemyTree.SelectedNode.Index * 68) + 36); } 
            UInt32.TryParse(richTextBoxLP.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 86672669 + (enemyTree.SelectedNode.Index * 68) + 40); } 
            UInt32.TryParse(richTextBoxWeight.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 86672669 + (enemyTree.SelectedNode.Index * 68) + 48); }

            File.WriteAllBytes(Properties.Settings.Default.VesperiaData64 + "\\Data64\\btl.svo", enemydata_array); //saves to the path i set, everything in the array/
        }

        private void button4_Click(object sender, EventArgs e) //Arte Editor
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

        private void button2_Click(object sender, EventArgs e) //Items and equipment editor
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
    }
}
