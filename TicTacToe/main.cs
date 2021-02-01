using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            //Custom Message
            MessageBoxEx.Show(this,"Created by Pier-Alexandre Yale.","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            difficulty difficultyForm = new difficulty(this);
            this.Enabled = false;
            difficultyForm.Show(this);
        }
    }
}
