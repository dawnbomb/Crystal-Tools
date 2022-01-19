
namespace Etrian_Odyssey_IV_test
{
    partial class FormIWep
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.weaponTree = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelLuc = new System.Windows.Forms.Label();
            this.labelTec = new System.Windows.Forms.Label();
            this.textBoxTec = new System.Windows.Forms.TextBox();
            this.pictureBoxTec = new System.Windows.Forms.PictureBox();
            this.textBoxLuc = new System.Windows.Forms.TextBox();
            this.pictureBoxLuc = new System.Windows.Forms.PictureBox();
            this.labelAgi = new System.Windows.Forms.Label();
            this.textBoxAgi = new System.Windows.Forms.TextBox();
            this.pictureBoxAgi = new System.Windows.Forms.PictureBox();
            this.labelVit = new System.Windows.Forms.Label();
            this.textBoxVit = new System.Windows.Forms.TextBox();
            this.pictureBoxVit = new System.Windows.Forms.PictureBox();
            this.labelStr = new System.Windows.Forms.Label();
            this.textBoxStr = new System.Windows.Forms.TextBox();
            this.pictureBoxStr = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.labelBuy = new System.Windows.Forms.Label();
            this.textBoxBuy = new System.Windows.Forms.TextBox();
            this.pictureBoxBuy = new System.Windows.Forms.PictureBox();
            this.labelSell = new System.Windows.Forms.Label();
            this.textBoxSell = new System.Windows.Forms.TextBox();
            this.pictureBoxSell = new System.Windows.Forms.PictureBox();
            this.labelAtk = new System.Windows.Forms.Label();
            this.textBoxAtk = new System.Windows.Forms.TextBox();
            this.pictureBoxAtk = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAgi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAtk)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(638, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 80);
            this.button1.TabIndex = 1;
            this.button1.Text = "Etrian I";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // weaponTree
            // 
            this.weaponTree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.weaponTree.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.weaponTree.FullRowSelect = true;
            this.weaponTree.HideSelection = false;
            this.weaponTree.Location = new System.Drawing.Point(12, 62);
            this.weaponTree.Name = "weaponTree";
            this.weaponTree.Size = new System.Drawing.Size(150, 787);
            this.weaponTree.TabIndex = 21;
            this.weaponTree.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.weaponTree_BeforeSelect);
            this.weaponTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.weaponTree_AfterSelect);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.labelLuc);
            this.groupBox1.Controls.Add(this.labelTec);
            this.groupBox1.Controls.Add(this.textBoxTec);
            this.groupBox1.Controls.Add(this.pictureBoxTec);
            this.groupBox1.Controls.Add(this.textBoxLuc);
            this.groupBox1.Controls.Add(this.pictureBoxLuc);
            this.groupBox1.Controls.Add(this.labelAgi);
            this.groupBox1.Controls.Add(this.textBoxAgi);
            this.groupBox1.Controls.Add(this.pictureBoxAgi);
            this.groupBox1.Controls.Add(this.labelVit);
            this.groupBox1.Controls.Add(this.textBoxVit);
            this.groupBox1.Controls.Add(this.pictureBoxVit);
            this.groupBox1.Controls.Add(this.labelStr);
            this.groupBox1.Controls.Add(this.textBoxStr);
            this.groupBox1.Controls.Add(this.pictureBoxStr);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.groupBox1.Location = new System.Drawing.Point(180, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(151, 226);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stats";
            // 
            // labelLuc
            // 
            this.labelLuc.AutoSize = true;
            this.labelLuc.BackColor = System.Drawing.Color.Transparent;
            this.labelLuc.Font = new System.Drawing.Font("Calibri", 13.75F, System.Drawing.FontStyle.Bold);
            this.labelLuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(186)))), ((int)(((byte)(186)))));
            this.labelLuc.Location = new System.Drawing.Point(17, 125);
            this.labelLuc.Name = "labelLuc";
            this.labelLuc.Size = new System.Drawing.Size(36, 23);
            this.labelLuc.TabIndex = 37;
            this.labelLuc.Text = "Luc";
            // 
            // labelTec
            // 
            this.labelTec.AutoSize = true;
            this.labelTec.BackColor = System.Drawing.Color.Transparent;
            this.labelTec.Font = new System.Drawing.Font("Calibri", 13.75F, System.Drawing.FontStyle.Bold);
            this.labelTec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(186)))), ((int)(((byte)(186)))));
            this.labelTec.Location = new System.Drawing.Point(17, 159);
            this.labelTec.Name = "labelTec";
            this.labelTec.Size = new System.Drawing.Size(35, 23);
            this.labelTec.TabIndex = 40;
            this.labelTec.Text = "Tec";
            // 
            // textBoxTec
            // 
            this.textBoxTec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(80)))), ((int)(((byte)(144)))));
            this.textBoxTec.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTec.Font = new System.Drawing.Font("Calibri", 13.75F, System.Drawing.FontStyle.Bold);
            this.textBoxTec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(232)))), ((int)(((byte)(201)))));
            this.textBoxTec.Location = new System.Drawing.Point(58, 160);
            this.textBoxTec.Name = "textBoxTec";
            this.textBoxTec.Size = new System.Drawing.Size(52, 23);
            this.textBoxTec.TabIndex = 38;
            this.textBoxTec.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pictureBoxTec
            // 
            this.pictureBoxTec.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxTec.BackgroundImage = global::Etrian_Odyssey_IV_test.Properties.Resources.EO1_Text_Box_XL4_Chunk;
            this.pictureBoxTec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxTec.Location = new System.Drawing.Point(9, 156);
            this.pictureBoxTec.Name = "pictureBoxTec";
            this.pictureBoxTec.Size = new System.Drawing.Size(115, 32);
            this.pictureBoxTec.TabIndex = 39;
            this.pictureBoxTec.TabStop = false;
            // 
            // textBoxLuc
            // 
            this.textBoxLuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(80)))), ((int)(((byte)(144)))));
            this.textBoxLuc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLuc.Font = new System.Drawing.Font("Calibri", 13.75F, System.Drawing.FontStyle.Bold);
            this.textBoxLuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(232)))), ((int)(((byte)(201)))));
            this.textBoxLuc.Location = new System.Drawing.Point(58, 126);
            this.textBoxLuc.Name = "textBoxLuc";
            this.textBoxLuc.Size = new System.Drawing.Size(52, 23);
            this.textBoxLuc.TabIndex = 35;
            this.textBoxLuc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pictureBoxLuc
            // 
            this.pictureBoxLuc.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLuc.BackgroundImage = global::Etrian_Odyssey_IV_test.Properties.Resources.EO1_Text_Box_XL4_Chunk;
            this.pictureBoxLuc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxLuc.Location = new System.Drawing.Point(9, 122);
            this.pictureBoxLuc.Name = "pictureBoxLuc";
            this.pictureBoxLuc.Size = new System.Drawing.Size(115, 32);
            this.pictureBoxLuc.TabIndex = 36;
            this.pictureBoxLuc.TabStop = false;
            // 
            // labelAgi
            // 
            this.labelAgi.AutoSize = true;
            this.labelAgi.BackColor = System.Drawing.Color.Transparent;
            this.labelAgi.Font = new System.Drawing.Font("Calibri", 13.75F, System.Drawing.FontStyle.Bold);
            this.labelAgi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(186)))), ((int)(((byte)(186)))));
            this.labelAgi.Location = new System.Drawing.Point(17, 91);
            this.labelAgi.Name = "labelAgi";
            this.labelAgi.Size = new System.Drawing.Size(36, 23);
            this.labelAgi.TabIndex = 34;
            this.labelAgi.Text = "Agi";
            // 
            // textBoxAgi
            // 
            this.textBoxAgi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(80)))), ((int)(((byte)(144)))));
            this.textBoxAgi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAgi.Font = new System.Drawing.Font("Calibri", 13.75F, System.Drawing.FontStyle.Bold);
            this.textBoxAgi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(232)))), ((int)(((byte)(201)))));
            this.textBoxAgi.Location = new System.Drawing.Point(58, 92);
            this.textBoxAgi.Name = "textBoxAgi";
            this.textBoxAgi.Size = new System.Drawing.Size(52, 23);
            this.textBoxAgi.TabIndex = 32;
            this.textBoxAgi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pictureBoxAgi
            // 
            this.pictureBoxAgi.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxAgi.BackgroundImage = global::Etrian_Odyssey_IV_test.Properties.Resources.EO1_Text_Box_XL4_Chunk;
            this.pictureBoxAgi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxAgi.Location = new System.Drawing.Point(9, 88);
            this.pictureBoxAgi.Name = "pictureBoxAgi";
            this.pictureBoxAgi.Size = new System.Drawing.Size(115, 32);
            this.pictureBoxAgi.TabIndex = 33;
            this.pictureBoxAgi.TabStop = false;
            // 
            // labelVit
            // 
            this.labelVit.AutoSize = true;
            this.labelVit.BackColor = System.Drawing.Color.Transparent;
            this.labelVit.Font = new System.Drawing.Font("Calibri", 13.75F, System.Drawing.FontStyle.Bold);
            this.labelVit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(186)))), ((int)(((byte)(186)))));
            this.labelVit.Location = new System.Drawing.Point(17, 57);
            this.labelVit.Name = "labelVit";
            this.labelVit.Size = new System.Drawing.Size(33, 23);
            this.labelVit.TabIndex = 31;
            this.labelVit.Text = "Vit";
            // 
            // textBoxVit
            // 
            this.textBoxVit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(80)))), ((int)(((byte)(144)))));
            this.textBoxVit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxVit.Font = new System.Drawing.Font("Calibri", 13.75F, System.Drawing.FontStyle.Bold);
            this.textBoxVit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(232)))), ((int)(((byte)(201)))));
            this.textBoxVit.Location = new System.Drawing.Point(58, 58);
            this.textBoxVit.Name = "textBoxVit";
            this.textBoxVit.Size = new System.Drawing.Size(52, 23);
            this.textBoxVit.TabIndex = 29;
            this.textBoxVit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pictureBoxVit
            // 
            this.pictureBoxVit.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxVit.BackgroundImage = global::Etrian_Odyssey_IV_test.Properties.Resources.EO1_Text_Box_XL4_Chunk;
            this.pictureBoxVit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxVit.Location = new System.Drawing.Point(9, 54);
            this.pictureBoxVit.Name = "pictureBoxVit";
            this.pictureBoxVit.Size = new System.Drawing.Size(115, 32);
            this.pictureBoxVit.TabIndex = 30;
            this.pictureBoxVit.TabStop = false;
            // 
            // labelStr
            // 
            this.labelStr.AutoSize = true;
            this.labelStr.BackColor = System.Drawing.Color.Transparent;
            this.labelStr.Font = new System.Drawing.Font("Calibri", 13.75F, System.Drawing.FontStyle.Bold);
            this.labelStr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(186)))), ((int)(((byte)(186)))));
            this.labelStr.Location = new System.Drawing.Point(17, 23);
            this.labelStr.Name = "labelStr";
            this.labelStr.Size = new System.Drawing.Size(33, 23);
            this.labelStr.TabIndex = 28;
            this.labelStr.Text = "Str";
            // 
            // textBoxStr
            // 
            this.textBoxStr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(80)))), ((int)(((byte)(144)))));
            this.textBoxStr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxStr.Font = new System.Drawing.Font("Calibri", 13.75F, System.Drawing.FontStyle.Bold);
            this.textBoxStr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(232)))), ((int)(((byte)(201)))));
            this.textBoxStr.Location = new System.Drawing.Point(58, 24);
            this.textBoxStr.Name = "textBoxStr";
            this.textBoxStr.Size = new System.Drawing.Size(52, 23);
            this.textBoxStr.TabIndex = 21;
            this.textBoxStr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pictureBoxStr
            // 
            this.pictureBoxStr.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxStr.BackgroundImage = global::Etrian_Odyssey_IV_test.Properties.Resources.EO1_Text_Box_XL4_Chunk;
            this.pictureBoxStr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxStr.Location = new System.Drawing.Point(9, 20);
            this.pictureBoxStr.Name = "pictureBoxStr";
            this.pictureBoxStr.Size = new System.Drawing.Size(115, 32);
            this.pictureBoxStr.TabIndex = 22;
            this.pictureBoxStr.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(430, 459);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(158, 70);
            this.button3.TabIndex = 28;
            this.button3.Text = "Save Button";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // labelBuy
            // 
            this.labelBuy.AutoSize = true;
            this.labelBuy.BackColor = System.Drawing.Color.Transparent;
            this.labelBuy.Font = new System.Drawing.Font("Calibri", 13.75F, System.Drawing.FontStyle.Bold);
            this.labelBuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(186)))), ((int)(((byte)(186)))));
            this.labelBuy.Location = new System.Drawing.Point(358, 85);
            this.labelBuy.Name = "labelBuy";
            this.labelBuy.Size = new System.Drawing.Size(40, 23);
            this.labelBuy.TabIndex = 43;
            this.labelBuy.Text = "Buy";
            // 
            // textBoxBuy
            // 
            this.textBoxBuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(80)))), ((int)(((byte)(144)))));
            this.textBoxBuy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBuy.Font = new System.Drawing.Font("Calibri", 13.75F, System.Drawing.FontStyle.Bold);
            this.textBoxBuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(232)))), ((int)(((byte)(201)))));
            this.textBoxBuy.Location = new System.Drawing.Point(399, 86);
            this.textBoxBuy.Name = "textBoxBuy";
            this.textBoxBuy.Size = new System.Drawing.Size(52, 23);
            this.textBoxBuy.TabIndex = 41;
            this.textBoxBuy.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pictureBoxBuy
            // 
            this.pictureBoxBuy.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBuy.BackgroundImage = global::Etrian_Odyssey_IV_test.Properties.Resources.EO1_Text_Box_XL4_Chunk;
            this.pictureBoxBuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxBuy.Location = new System.Drawing.Point(350, 82);
            this.pictureBoxBuy.Name = "pictureBoxBuy";
            this.pictureBoxBuy.Size = new System.Drawing.Size(115, 32);
            this.pictureBoxBuy.TabIndex = 42;
            this.pictureBoxBuy.TabStop = false;
            // 
            // labelSell
            // 
            this.labelSell.AutoSize = true;
            this.labelSell.BackColor = System.Drawing.Color.Transparent;
            this.labelSell.Font = new System.Drawing.Font("Calibri", 13.75F, System.Drawing.FontStyle.Bold);
            this.labelSell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(186)))), ((int)(((byte)(186)))));
            this.labelSell.Location = new System.Drawing.Point(358, 124);
            this.labelSell.Name = "labelSell";
            this.labelSell.Size = new System.Drawing.Size(39, 23);
            this.labelSell.TabIndex = 46;
            this.labelSell.Text = "Sell";
            // 
            // textBoxSell
            // 
            this.textBoxSell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(80)))), ((int)(((byte)(144)))));
            this.textBoxSell.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSell.Font = new System.Drawing.Font("Calibri", 13.75F, System.Drawing.FontStyle.Bold);
            this.textBoxSell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(232)))), ((int)(((byte)(201)))));
            this.textBoxSell.Location = new System.Drawing.Point(399, 125);
            this.textBoxSell.Name = "textBoxSell";
            this.textBoxSell.Size = new System.Drawing.Size(52, 23);
            this.textBoxSell.TabIndex = 44;
            this.textBoxSell.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pictureBoxSell
            // 
            this.pictureBoxSell.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSell.BackgroundImage = global::Etrian_Odyssey_IV_test.Properties.Resources.EO1_Text_Box_XL4_Chunk;
            this.pictureBoxSell.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxSell.Location = new System.Drawing.Point(350, 121);
            this.pictureBoxSell.Name = "pictureBoxSell";
            this.pictureBoxSell.Size = new System.Drawing.Size(115, 32);
            this.pictureBoxSell.TabIndex = 45;
            this.pictureBoxSell.TabStop = false;
            // 
            // labelAtk
            // 
            this.labelAtk.AutoSize = true;
            this.labelAtk.BackColor = System.Drawing.Color.Transparent;
            this.labelAtk.Font = new System.Drawing.Font("Calibri", 13.75F, System.Drawing.FontStyle.Bold);
            this.labelAtk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(186)))), ((int)(((byte)(186)))));
            this.labelAtk.Location = new System.Drawing.Point(358, 170);
            this.labelAtk.Name = "labelAtk";
            this.labelAtk.Size = new System.Drawing.Size(37, 23);
            this.labelAtk.TabIndex = 49;
            this.labelAtk.Text = "Atk";
            // 
            // textBoxAtk
            // 
            this.textBoxAtk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(80)))), ((int)(((byte)(144)))));
            this.textBoxAtk.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAtk.Font = new System.Drawing.Font("Calibri", 13.75F, System.Drawing.FontStyle.Bold);
            this.textBoxAtk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(232)))), ((int)(((byte)(201)))));
            this.textBoxAtk.Location = new System.Drawing.Point(399, 171);
            this.textBoxAtk.Name = "textBoxAtk";
            this.textBoxAtk.Size = new System.Drawing.Size(52, 23);
            this.textBoxAtk.TabIndex = 47;
            this.textBoxAtk.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pictureBoxAtk
            // 
            this.pictureBoxAtk.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxAtk.BackgroundImage = global::Etrian_Odyssey_IV_test.Properties.Resources.EO1_Text_Box_XL4_Chunk;
            this.pictureBoxAtk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxAtk.Location = new System.Drawing.Point(350, 167);
            this.pictureBoxAtk.Name = "pictureBoxAtk";
            this.pictureBoxAtk.Size = new System.Drawing.Size(115, 32);
            this.pictureBoxAtk.TabIndex = 48;
            this.pictureBoxAtk.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(504, 255);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 50;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(128)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(180, 322);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(175, 229);
            this.checkedListBox1.TabIndex = 51;
            // 
            // FormIWep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Etrian_Odyssey_IV_test.Properties.Resources.EO1_Unknown_Screen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(764, 861);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelAtk);
            this.Controls.Add(this.textBoxAtk);
            this.Controls.Add(this.pictureBoxAtk);
            this.Controls.Add(this.labelSell);
            this.Controls.Add(this.textBoxSell);
            this.Controls.Add(this.pictureBoxSell);
            this.Controls.Add(this.labelBuy);
            this.Controls.Add(this.textBoxBuy);
            this.Controls.Add(this.pictureBoxBuy);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.weaponTree);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Name = "FormIWep";
            this.Text = "Etrian I Weapon Editor";
            this.Load += new System.EventHandler(this.FormIWep_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAgi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAtk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TreeView weaponTree;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelLuc;
        private System.Windows.Forms.Label labelTec;
        private System.Windows.Forms.TextBox textBoxTec;
        private System.Windows.Forms.PictureBox pictureBoxTec;
        private System.Windows.Forms.TextBox textBoxLuc;
        private System.Windows.Forms.PictureBox pictureBoxLuc;
        private System.Windows.Forms.Label labelAgi;
        private System.Windows.Forms.TextBox textBoxAgi;
        private System.Windows.Forms.PictureBox pictureBoxAgi;
        private System.Windows.Forms.Label labelVit;
        private System.Windows.Forms.TextBox textBoxVit;
        private System.Windows.Forms.PictureBox pictureBoxVit;
        private System.Windows.Forms.Label labelStr;
        private System.Windows.Forms.TextBox textBoxStr;
        private System.Windows.Forms.PictureBox pictureBoxStr;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label labelBuy;
        private System.Windows.Forms.TextBox textBoxBuy;
        private System.Windows.Forms.PictureBox pictureBoxBuy;
        private System.Windows.Forms.Label labelSell;
        private System.Windows.Forms.TextBox textBoxSell;
        private System.Windows.Forms.PictureBox pictureBoxSell;
        private System.Windows.Forms.Label labelAtk;
        private System.Windows.Forms.TextBox textBoxAtk;
        private System.Windows.Forms.PictureBox pictureBoxAtk;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}