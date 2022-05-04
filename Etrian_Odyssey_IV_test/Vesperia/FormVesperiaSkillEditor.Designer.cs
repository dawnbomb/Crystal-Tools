
namespace Etrian_Odyssey_IV_test
{
    partial class FormVesperiaSkillEditor
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
            this.enemyTree = new System.Windows.Forms.TreeView();
            this.label17 = new System.Windows.Forms.Label();
            this.richTextBoxSP = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBoxLP = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBoxWeight = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBoxSortID = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // enemyTree
            // 
            this.enemyTree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.enemyTree.Dock = System.Windows.Forms.DockStyle.Left;
            this.enemyTree.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.enemyTree.FullRowSelect = true;
            this.enemyTree.HideSelection = false;
            this.enemyTree.Location = new System.Drawing.Point(0, 0);
            this.enemyTree.Name = "enemyTree";
            this.enemyTree.ShowLines = false;
            this.enemyTree.ShowRootLines = false;
            this.enemyTree.Size = new System.Drawing.Size(219, 860);
            this.enemyTree.TabIndex = 25;
            this.enemyTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.enemyTree_AfterSelect);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label17.Location = new System.Drawing.Point(19, 47);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(34, 24);
            this.label17.TabIndex = 58;
            this.label17.Text = "SP";
            // 
            // richTextBoxSP
            // 
            this.richTextBoxSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.richTextBoxSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.richTextBoxSP.Location = new System.Drawing.Point(78, 40);
            this.richTextBoxSP.Name = "richTextBoxSP";
            this.richTextBoxSP.Size = new System.Drawing.Size(123, 37);
            this.richTextBoxSP.TabIndex = 59;
            this.richTextBoxSP.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(19, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 24);
            this.label1.TabIndex = 60;
            this.label1.Text = "LP";
            // 
            // richTextBoxLP
            // 
            this.richTextBoxLP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.richTextBoxLP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.richTextBoxLP.Location = new System.Drawing.Point(78, 96);
            this.richTextBoxLP.Name = "richTextBoxLP";
            this.richTextBoxLP.Size = new System.Drawing.Size(123, 37);
            this.richTextBoxLP.TabIndex = 61;
            this.richTextBoxLP.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(5, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 24);
            this.label2.TabIndex = 62;
            this.label2.Text = "Weight";
            // 
            // richTextBoxWeight
            // 
            this.richTextBoxWeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.richTextBoxWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.richTextBoxWeight.Location = new System.Drawing.Point(78, 153);
            this.richTextBoxWeight.Name = "richTextBoxWeight";
            this.richTextBoxWeight.Size = new System.Drawing.Size(123, 37);
            this.richTextBoxWeight.TabIndex = 63;
            this.richTextBoxWeight.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(8, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 24);
            this.label3.TabIndex = 64;
            this.label3.Text = "SortID";
            // 
            // richTextBoxSortID
            // 
            this.richTextBoxSortID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.richTextBoxSortID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.richTextBoxSortID.Location = new System.Drawing.Point(77, 34);
            this.richTextBoxSortID.Name = "richTextBoxSortID";
            this.richTextBoxSortID.Size = new System.Drawing.Size(123, 37);
            this.richTextBoxSortID.TabIndex = 65;
            this.richTextBoxSortID.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(610, 658);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 89);
            this.button1.TabIndex = 138;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBoxWeight);
            this.groupBox1.Controls.Add(this.richTextBoxSP);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.richTextBoxLP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(268, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 263);
            this.groupBox1.TabIndex = 139;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Confirmed Working and safe";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richTextBoxSortID);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(522, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 151);
            this.groupBox2.TabIndex = 140;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Unconfirmed if working, but you can edit them and save";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button4.Location = new System.Drawing.Point(873, 41);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(137, 128);
            this.button4.TabIndex = 143;
            this.button4.Text = "Arte Editor";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.Location = new System.Drawing.Point(873, 180);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 128);
            this.button2.TabIndex = 142;
            this.button2.Text = "Items and Equipment Editor";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button3.Location = new System.Drawing.Point(873, 314);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(137, 128);
            this.button3.TabIndex = 141;
            this.button3.Text = "Enemy Editor";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FormVesperiaSkillEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1531, 860);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.enemyTree);
            this.Name = "FormVesperiaSkillEditor";
            this.Text = "FormVesperiaSkillEditor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView enemyTree;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.RichTextBox richTextBoxSP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBoxLP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBoxWeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBoxSortID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}