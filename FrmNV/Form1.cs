using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FrmNV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnno_Click(object sender, EventArgs e)
        {

        }

        public void MoveRamdon()
        {
            Random rd = new Random();
            int x = rd.Next(0, this.Width - btnno.Width);
            int y = rd.Next(0, this.Height - btnno.Height);

            btnno.Location = new Point(x, y);


        }


        private void btnno_MouseMove(object sender, MouseEventArgs e)
        {

            MoveRamdon();
            if (btnno.Location == btnsi.Location || btnno.Location == label1.Location)
            {
                MoveRamdon();
            }

        }

        private void Btnno_MouseHover(object sender, EventArgs e)
        {

        }

        private void btnno_MouseEnter(object sender, EventArgs e)
        {
            

        }

        private void btnsi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sabia que me querias!! :D Te quiero bb");
        }
    }
}
