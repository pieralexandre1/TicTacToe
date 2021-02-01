namespace TicTacToe
{
    partial class difficulty
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
            this.grbDifficulty = new System.Windows.Forms.GroupBox();
            this.rob3 = new System.Windows.Forms.RadioButton();
            this.rob2 = new System.Windows.Forms.RadioButton();
            this.rob1 = new System.Windows.Forms.RadioButton();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grbDifficulty.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDifficulty
            // 
            this.grbDifficulty.Controls.Add(this.rob3);
            this.grbDifficulty.Controls.Add(this.rob2);
            this.grbDifficulty.Controls.Add(this.rob1);
            this.grbDifficulty.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDifficulty.Location = new System.Drawing.Point(12, 12);
            this.grbDifficulty.Name = "grbDifficulty";
            this.grbDifficulty.Size = new System.Drawing.Size(442, 82);
            this.grbDifficulty.TabIndex = 0;
            this.grbDifficulty.TabStop = false;
            this.grbDifficulty.Text = "Choose your difficulty";
            // 
            // rob3
            // 
            this.rob3.AutoSize = true;
            this.rob3.Location = new System.Drawing.Point(317, 37);
            this.rob3.Name = "rob3";
            this.rob3.Size = new System.Drawing.Size(82, 37);
            this.rob3.TabIndex = 2;
            this.rob3.TabStop = true;
            this.rob3.Text = "Hard";
            this.rob3.UseVisualStyleBackColor = true;
            // 
            // rob2
            // 
            this.rob2.AutoSize = true;
            this.rob2.Location = new System.Drawing.Point(151, 37);
            this.rob2.Name = "rob2";
            this.rob2.Size = new System.Drawing.Size(113, 37);
            this.rob2.TabIndex = 1;
            this.rob2.TabStop = true;
            this.rob2.Text = "Medium";
            this.rob2.UseVisualStyleBackColor = true;
            // 
            // rob1
            // 
            this.rob1.AutoSize = true;
            this.rob1.Location = new System.Drawing.Point(6, 37);
            this.rob1.Name = "rob1";
            this.rob1.Size = new System.Drawing.Size(81, 37);
            this.rob1.TabIndex = 0;
            this.rob1.TabStop = true;
            this.rob1.Text = "Easy";
            this.rob1.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(12, 100);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(185, 46);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(273, 100);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(181, 46);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // difficulty
            // 
            this.AcceptButton = this.btnConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(470, 158);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.grbDifficulty);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "difficulty";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Difficulty";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.difficulty_FormClosing);
            this.Load += new System.EventHandler(this.difficulty_Load);
            this.grbDifficulty.ResumeLayout(false);
            this.grbDifficulty.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDifficulty;
        private System.Windows.Forms.RadioButton rob3;
        private System.Windows.Forms.RadioButton rob2;
        private System.Windows.Forms.RadioButton rob1;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
    }
}