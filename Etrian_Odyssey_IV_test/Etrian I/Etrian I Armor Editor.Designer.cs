
namespace Etrian_Odyssey_IV_test
{
    partial class FormIArmor
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
            this.enemyTree = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(642, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 86);
            this.button1.TabIndex = 1;
            this.button1.Text = "Etrian I";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // enemyTree
            // 
            this.enemyTree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.enemyTree.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.enemyTree.FullRowSelect = true;
            this.enemyTree.HideSelection = false;
            this.enemyTree.Location = new System.Drawing.Point(12, 62);
            this.enemyTree.Name = "enemyTree";
            this.enemyTree.Size = new System.Drawing.Size(137, 787);
            this.enemyTree.TabIndex = 21;
            // 
            // FormIArmor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Etrian_Odyssey_IV_test.Properties.Resources.EO1_Unknown_Screen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(764, 861);
            this.Controls.Add(this.enemyTree);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Name = "FormIArmor";
            this.Text = "Etrian I Armor Editor";
            this.Load += new System.EventHandler(this.FormIArmor_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TreeView enemyTree;
    }
}