
namespace A22_Ex05
{
    partial class ColorPaletteForm
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
            this.buttonBrown = new System.Windows.Forms.Button();
            this.buttonDarkBlue = new System.Windows.Forms.Button();
            this.buttonYellow = new System.Windows.Forms.Button();
            this.buttonWhite = new System.Windows.Forms.Button();
            this.buttonPurple = new System.Windows.Forms.Button();
            this.buttonRed = new System.Windows.Forms.Button();
            this.buttonGreen = new System.Windows.Forms.Button();
            this.buttonLightBlue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBrown
            // 
            this.buttonBrown.BackColor = System.Drawing.Color.Brown;
            this.buttonBrown.Location = new System.Drawing.Point(115, 56);
            this.buttonBrown.Name = "buttonBrown";
            this.buttonBrown.Size = new System.Drawing.Size(45, 41);
            this.buttonBrown.TabIndex = 6;
            this.buttonBrown.Click += Button_Click;
            this.buttonBrown.UseVisualStyleBackColor = false;
            // 
            // buttonDarkBlue
            // 
            this.buttonDarkBlue.BackColor = System.Drawing.Color.Blue;
            this.buttonDarkBlue.Location = new System.Drawing.Point(12, 56);
            this.buttonDarkBlue.Name = "buttonDarkBlue";
            this.buttonDarkBlue.Size = new System.Drawing.Size(45, 41);
            this.buttonDarkBlue.TabIndex = 7;
            this.buttonDarkBlue.Click += Button_Click;
            this.buttonDarkBlue.UseVisualStyleBackColor = false;
            // 
            // buttonYellow
            // 
            this.buttonYellow.BackColor = System.Drawing.Color.Yellow;
            this.buttonYellow.Location = new System.Drawing.Point(64, 56);
            this.buttonYellow.Name = "buttonYellow";
            this.buttonYellow.Size = new System.Drawing.Size(45, 41);
            this.buttonYellow.TabIndex = 8;
            this.buttonYellow.Click += Button_Click;

            this.buttonYellow.UseVisualStyleBackColor = false;
            // 
            // buttonWhite
            // 
            this.buttonWhite.BackColor = System.Drawing.Color.White;
            this.buttonWhite.Location = new System.Drawing.Point(166, 57);
            this.buttonWhite.Name = "buttonWhite";
            this.buttonWhite.Size = new System.Drawing.Size(45, 41);
            this.buttonWhite.TabIndex = 9;
            this.buttonWhite.Click += Button_Click;
            this.buttonWhite.UseVisualStyleBackColor = false;
            // 
            // buttonPurple
            // 
            this.buttonPurple.BackColor = System.Drawing.Color.Purple;
            this.buttonPurple.Location = new System.Drawing.Point(12, 12);
            this.buttonPurple.Name = "buttonPurple";
            this.buttonPurple.Size = new System.Drawing.Size(45, 41);
            this.buttonPurple.TabIndex = 10;
            this.buttonPurple.Click += Button_Click;

            this.buttonPurple.UseVisualStyleBackColor = false;
            // 
            // buttonRed
            // 
            this.buttonRed.BackColor = System.Drawing.Color.Red;
            this.buttonRed.Location = new System.Drawing.Point(64, 12);
            this.buttonRed.Name = "buttonRed";
            this.buttonRed.Size = new System.Drawing.Size(45, 41);
            this.buttonRed.TabIndex = 11;
            this.buttonRed.Click += Button_Click;
            this.buttonRed.UseVisualStyleBackColor = false;
            // 
            // buttonGreen
            // 
            this.buttonGreen.BackColor = System.Drawing.Color.Green;
            this.buttonGreen.Location = new System.Drawing.Point(115, 12);
            this.buttonGreen.Name = "buttonGreen";
            this.buttonGreen.Size = new System.Drawing.Size(45, 41);
            this.buttonGreen.TabIndex = 12;
            this.buttonGreen.Click += Button_Click;
            this.buttonGreen.UseVisualStyleBackColor = false;
            // 
            // buttonLightBlue
            // 
            this.buttonLightBlue.BackColor = System.Drawing.Color.Aqua;
            this.buttonLightBlue.Location = new System.Drawing.Point(166, 12);
            this.buttonLightBlue.Name = "buttonLightBlue";
            this.buttonLightBlue.Size = new System.Drawing.Size(45, 41);
            this.buttonLightBlue.TabIndex = 13;
            this.buttonLightBlue.Click += Button_Click;

            this.buttonLightBlue.UseVisualStyleBackColor = false;
            // 
            // ColorPaletteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 106);
            this.Controls.Add(this.buttonLightBlue);
            this.Controls.Add(this.buttonGreen);
            this.Controls.Add(this.buttonRed);
            this.Controls.Add(this.buttonPurple);
            this.Controls.Add(this.buttonWhite);
            this.Controls.Add(this.buttonYellow);
            this.Controls.Add(this.buttonDarkBlue);
            this.Controls.Add(this.buttonBrown);
            this.Name = "ColorPaletteForm";
            this.Text = "Pick A Color:";
            this.ResumeLayout(false);

        }




        #endregion

        private System.Windows.Forms.Button buttonBrown;
        private System.Windows.Forms.Button buttonDarkBlue;
        private System.Windows.Forms.Button buttonYellow;
        private System.Windows.Forms.Button buttonWhite;
        private System.Windows.Forms.Button buttonPurple;
        private System.Windows.Forms.Button buttonRed;
        private System.Windows.Forms.Button buttonGreen;
        private System.Windows.Forms.Button buttonLightBlue;
    }
}