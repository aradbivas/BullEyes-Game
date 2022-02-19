
namespace A22_Ex05
{
    partial class BullEyesBoardForm
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
            this.buttonGuess4 = new System.Windows.Forms.Button();
            this.buttonGuess3 = new System.Windows.Forms.Button();
            this.buttonGuess2 = new System.Windows.Forms.Button();
            this.buttonGuess1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonGuess4
            // 
            this.buttonGuess4.BackColor = System.Drawing.Color.Black;
            this.buttonGuess4.Enabled = false;
            this.buttonGuess4.Location = new System.Drawing.Point(138, 12);
            this.buttonGuess4.Name = "buttonGuess4";
            this.buttonGuess4.Size = new System.Drawing.Size(36, 36);
            this.buttonGuess4.TabIndex = 3;
            this.buttonGuess4.UseVisualStyleBackColor = false;
            // 
            // buttonGuess3
            // 
            this.buttonGuess3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonGuess3.Enabled = false;
            this.buttonGuess3.Location = new System.Drawing.Point(96, 12);
            this.buttonGuess3.Name = "buttonGuess3";
            this.buttonGuess3.Size = new System.Drawing.Size(36, 36);
            this.buttonGuess3.TabIndex = 4;
            this.buttonGuess3.UseVisualStyleBackColor = false;
            // 
            // buttonGuess2
            // 
            this.buttonGuess2.BackColor = System.Drawing.Color.Black;
            this.buttonGuess2.Enabled = false;
            this.buttonGuess2.Location = new System.Drawing.Point(54, 12);
            this.buttonGuess2.Name = "buttonGuess2";
            this.buttonGuess2.Size = new System.Drawing.Size(36, 36);
            this.buttonGuess2.TabIndex = 5;
            this.buttonGuess2.UseVisualStyleBackColor = false;
            // 
            // buttonGuess1
            // 
            this.buttonGuess1.BackColor = System.Drawing.Color.Black;
            this.buttonGuess1.Enabled = false;
            this.buttonGuess1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonGuess1.Location = new System.Drawing.Point(12, 12);
            this.buttonGuess1.Name = "buttonGuess1";
            this.buttonGuess1.Size = new System.Drawing.Size(36, 36);
            this.buttonGuess1.TabIndex = 6;
            this.buttonGuess1.UseVisualStyleBackColor = false;
            // 
            // BullEyesBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 545);
            this.Controls.Add(this.buttonGuess1);
            this.Controls.Add(this.buttonGuess2);
            this.Controls.Add(this.buttonGuess3);
            this.Controls.Add(this.buttonGuess4);
            this.Name = "BullEyesBoard";
            this.Text = "BullEyesBoard";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonGuess4;
        private System.Windows.Forms.Button buttonGuess3;
        private System.Windows.Forms.Button buttonGuess2;
        private System.Windows.Forms.Button buttonGuess1;
    }
}