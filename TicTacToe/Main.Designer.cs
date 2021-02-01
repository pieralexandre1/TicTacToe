namespace TicTacToe
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.imgMain = new System.Windows.Forms.PictureBox();
            this.mainTitle = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgMain)).BeginInit();
            this.SuspendLayout();
            // 
            // imgMain
            // 
            this.imgMain.Image = global::TicTacToe.Properties.Resources._2000px_Tic_tac_toe_svg;
            this.imgMain.Location = new System.Drawing.Point(269, 12);
            this.imgMain.Name = "imgMain";
            this.imgMain.Size = new System.Drawing.Size(275, 273);
            this.imgMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgMain.TabIndex = 0;
            this.imgMain.TabStop = false;
            // 
            // mainTitle
            // 
            this.mainTitle.AutoSize = true;
            this.mainTitle.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTitle.Location = new System.Drawing.Point(12, 9);
            this.mainTitle.Name = "mainTitle";
            this.mainTitle.Size = new System.Drawing.Size(222, 57);
            this.mainTitle.TabIndex = 1;
            this.mainTitle.Text = "Tic-Tac-Toe";
            // 
            // btnNewGame
            // 
            this.btnNewGame.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.Location = new System.Drawing.Point(22, 100);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(212, 75);
            this.btnNewGame.TabIndex = 2;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.Location = new System.Drawing.Point(22, 210);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(212, 75);
            this.btnInfo.TabIndex = 3;
            this.btnInfo.Text = "Info";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // main
            // 
            this.AcceptButton = this.btnNewGame;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(578, 307);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.mainTitle);
            this.Controls.Add(this.imgMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main";
            this.Text = "Tic-Tac-Toe";
            ((System.ComponentModel.ISupportInitialize)(this.imgMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgMain;
        private System.Windows.Forms.Label mainTitle;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnInfo;
    }
}

