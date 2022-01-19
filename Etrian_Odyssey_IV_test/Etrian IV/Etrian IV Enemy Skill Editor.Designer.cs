
namespace Etrian_Odyssey_IV_test
{
    partial class FormIVEnemySkill
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
            this.skillTree = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // skillTree
            // 
            this.skillTree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.skillTree.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.skillTree.FullRowSelect = true;
            this.skillTree.HideSelection = false;
            this.skillTree.Location = new System.Drawing.Point(-1, 0);
            this.skillTree.Name = "skillTree";
            this.skillTree.Size = new System.Drawing.Size(195, 861);
            this.skillTree.TabIndex = 23;
            this.skillTree.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.skillTree_BeforeSelect);
            this.skillTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.skillTree_AfterSelect);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(668, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 93);
            this.button1.TabIndex = 24;
            this.button1.Text = "Etrian IV";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormIVEnemySkill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Etrian_Odyssey_IV_test.Properties.Resources.Menu_Backround_2x;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(764, 861);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.skillTree);
            this.Name = "FormIVEnemySkill";
            this.Text = "Etrian IV Enemy Skill";
            this.Load += new System.EventHandler(this.FormIVEnemySkill_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView skillTree;
        private System.Windows.Forms.Button button1;
    }
}