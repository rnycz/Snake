namespace Snake
{
    partial class SnakeGame
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.easyBTN = new System.Windows.Forms.Button();
            this.mediumBTN = new System.Windows.Forms.Button();
            this.hardBTN = new System.Windows.Forms.Button();
            this.diffLvlLBL = new System.Windows.Forms.Label();
            this.controlLBL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // easyBTN
            // 
            this.easyBTN.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.easyBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.easyBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.easyBTN.Location = new System.Drawing.Point(105, 70);
            this.easyBTN.Name = "easyBTN";
            this.easyBTN.Size = new System.Drawing.Size(80, 32);
            this.easyBTN.TabIndex = 0;
            this.easyBTN.Text = "Easy";
            this.easyBTN.UseVisualStyleBackColor = false;
            this.easyBTN.Click += new System.EventHandler(this.easyBTN_Click);
            // 
            // mediumBTN
            // 
            this.mediumBTN.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.mediumBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mediumBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mediumBTN.Location = new System.Drawing.Point(105, 108);
            this.mediumBTN.Name = "mediumBTN";
            this.mediumBTN.Size = new System.Drawing.Size(80, 32);
            this.mediumBTN.TabIndex = 1;
            this.mediumBTN.Text = "Medium";
            this.mediumBTN.UseVisualStyleBackColor = false;
            this.mediumBTN.Click += new System.EventHandler(this.mediumBTN_Click);
            // 
            // hardBTN
            // 
            this.hardBTN.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.hardBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hardBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hardBTN.Location = new System.Drawing.Point(105, 146);
            this.hardBTN.Name = "hardBTN";
            this.hardBTN.Size = new System.Drawing.Size(80, 32);
            this.hardBTN.TabIndex = 2;
            this.hardBTN.Text = "Hard";
            this.hardBTN.UseVisualStyleBackColor = false;
            this.hardBTN.Click += new System.EventHandler(this.hardBTN_Click);
            // 
            // diffLvlLBL
            // 
            this.diffLvlLBL.AutoSize = true;
            this.diffLvlLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.diffLvlLBL.Location = new System.Drawing.Point(95, 38);
            this.diffLvlLBL.Name = "diffLvlLBL";
            this.diffLvlLBL.Size = new System.Drawing.Size(100, 18);
            this.diffLvlLBL.TabIndex = 3;
            this.diffLvlLBL.Text = "Difficulty level:";
            // 
            // controlLBL
            // 
            this.controlLBL.AutoSize = true;
            this.controlLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.controlLBL.Location = new System.Drawing.Point(34, 195);
            this.controlLBL.Name = "controlLBL";
            this.controlLBL.Size = new System.Drawing.Size(0, 15);
            this.controlLBL.TabIndex = 4;
            this.controlLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SnakeGame
            // 
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.controlLBL);
            this.Controls.Add(this.diffLvlLBL);
            this.Controls.Add(this.hardBTN);
            this.Controls.Add(this.mediumBTN);
            this.Controls.Add(this.easyBTN);
            this.Name = "SnakeGame";
            this.Text = "Snake ";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.SnakeGame_Paint);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SnakeGame_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button easyBTN;
        private System.Windows.Forms.Button mediumBTN;
        private System.Windows.Forms.Button hardBTN;
        private System.Windows.Forms.Label diffLvlLBL;
        private System.Windows.Forms.Label controlLBL;
    }
}

