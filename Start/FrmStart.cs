using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculator;

namespace Start
{
    public partial class FrmStart : Form
    {
        public FrmStart() { InitializeComponent(); }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCalculator calc = new FrmCalculator();
            calc.Show();
            //this.Close();
        }
    }
}
