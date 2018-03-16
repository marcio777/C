using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediadasIdades
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idadaMae = 52;
            int idadePai = 60;
            int idadeAmanda = 33;
            int media;

            media = (idadaMae + idadePai + idadeAmanda) / 3;

            MessageBox.Show("A media das idades e : " + media);

            


        }
    }
}
