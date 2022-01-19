
namespace Etrian_Odyssey_IV_test
{
    partial class PatchNotes
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
            this.richTextBoxPatchNotes = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBoxPatchNotes
            // 
            this.richTextBoxPatchNotes.Location = new System.Drawing.Point(12, 12);
            this.richTextBoxPatchNotes.Name = "richTextBoxPatchNotes";
            this.richTextBoxPatchNotes.Size = new System.Drawing.Size(760, 837);
            this.richTextBoxPatchNotes.TabIndex = 0;
            this.richTextBoxPatchNotes.Text = "";
            this.richTextBoxPatchNotes.TextChanged += new System.EventHandler(this.richTextBoxPatchNotes_TextChanged);
            // 
            // PatchNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 861);
            this.Controls.Add(this.richTextBoxPatchNotes);
            this.Name = "PatchNotes";
            this.Text = "Patch Notes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxPatchNotes;
    }
}