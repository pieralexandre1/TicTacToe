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
    public partial class difficulty : Form
    {

        public difficulty(Form mainForm)
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void difficulty_FormClosing(object sender, FormClosingEventArgs e)
        {
            Owner.Enabled = true;
        }

        private void difficulty_Load(object sender, EventArgs e)
        {
            //Center the message box of difficulty
            if (Owner != null)
                Location = new Point(Owner.Location.X + Owner.Width / 2 - Width / 2,
                    Owner.Location.Y + Owner.Height / 2 - Height / 2);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            int diff;
            string diffName;
            if (rob1.Checked)
            {
                diff = 0;
                diffName = rob1.Text;
            }else if (rob2.Checked)
            {
                diff = 1;
                diffName = rob2.Text;
            }
            else
            {
                diff = 2;
                diffName = rob3.Text;
            }
            Tictactoe tictactoe = new Tictactoe(diff,diffName);
            tictactoe.MaximizeBox = false;
            tictactoe.Show(Owner);
            Owner.Visible = false;
            this.Close();

        }
    }
}
