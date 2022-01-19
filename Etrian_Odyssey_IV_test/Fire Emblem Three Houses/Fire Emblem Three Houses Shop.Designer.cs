
namespace Etrian_Odyssey_IV_test
{
    partial class FormFETHShop
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.shopTree = new System.Windows.Forms.TreeView();
            this.button3 = new System.Windows.Forms.Button();
            this.richTextBoxBuy = new System.Windows.Forms.RichTextBox();
            this.richTextBoxSell = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBoxAvailability = new System.Windows.Forms.RichTextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button2.Location = new System.Drawing.Point(922, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(204, 96);
            this.button2.TabIndex = 7;
            this.button2.Text = "Weapon Editor";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(922, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 96);
            this.button1.TabIndex = 8;
            this.button1.Text = "Items Editor";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // shopTree
            // 
            this.shopTree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.shopTree.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.shopTree.FullRowSelect = true;
            this.shopTree.HideSelection = false;
            this.shopTree.Location = new System.Drawing.Point(12, 12);
            this.shopTree.Name = "shopTree";
            this.shopTree.ShowLines = false;
            this.shopTree.ShowPlusMinus = false;
            this.shopTree.Size = new System.Drawing.Size(177, 861);
            this.shopTree.TabIndex = 23;
            this.shopTree.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.shopTree_BeforeSelect);
            this.shopTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.shopTree_AfterSelect);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button3.Location = new System.Drawing.Point(638, 131);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(204, 96);
            this.button3.TabIndex = 24;
            this.button3.Text = "SAVE and Empty The List";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // richTextBoxBuy
            // 
            this.richTextBoxBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.richTextBoxBuy.Location = new System.Drawing.Point(288, 296);
            this.richTextBoxBuy.Name = "richTextBoxBuy";
            this.richTextBoxBuy.Size = new System.Drawing.Size(77, 29);
            this.richTextBoxBuy.TabIndex = 25;
            this.richTextBoxBuy.Text = "";
            // 
            // richTextBoxSell
            // 
            this.richTextBoxSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.richTextBoxSell.Location = new System.Drawing.Point(288, 331);
            this.richTextBoxSell.Name = "richTextBoxSell";
            this.richTextBoxSell.Size = new System.Drawing.Size(77, 29);
            this.richTextBoxSell.TabIndex = 26;
            this.richTextBoxSell.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(371, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 26);
            this.label1.TabIndex = 27;
            this.label1.Text = "Buy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(371, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 26);
            this.label2.TabIndex = 28;
            this.label2.Text = "Sell";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(371, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(336, 26);
            this.label3.TabIndex = 30;
            this.label3.Text = "0No 1Yes 2Limited 3Unlimited";
            // 
            // richTextBoxAvailability
            // 
            this.richTextBoxAvailability.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.richTextBoxAvailability.Location = new System.Drawing.Point(288, 366);
            this.richTextBoxAvailability.Name = "richTextBoxAvailability";
            this.richTextBoxAvailability.Size = new System.Drawing.Size(77, 29);
            this.richTextBoxAvailability.TabIndex = 29;
            this.richTextBoxAvailability.Text = "";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button4.Location = new System.Drawing.Point(922, 420);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(204, 96);
            this.button4.TabIndex = 31;
            this.button4.Text = "Battalion Editor";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button5.Location = new System.Drawing.Point(922, 178);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(204, 96);
            this.button5.TabIndex = 32;
            this.button5.Text = "Equipment Editor";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button6.Location = new System.Drawing.Point(922, 541);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(204, 96);
            this.button6.TabIndex = 33;
            this.button6.Text = "Forge Editor";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button7.Location = new System.Drawing.Point(483, 594);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(204, 96);
            this.button7.TabIndex = 34;
            this.button7.Text = "Clear Tree";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // FormFETHShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1138, 934);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBoxAvailability);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBoxSell);
            this.Controls.Add(this.richTextBoxBuy);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.shopTree);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Name = "FormFETHShop";
            this.Text = "Fire Emblem Three Houses Shop Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TreeView shopTree;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox richTextBoxBuy;
        private System.Windows.Forms.RichTextBox richTextBoxSell;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBoxAvailability;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}