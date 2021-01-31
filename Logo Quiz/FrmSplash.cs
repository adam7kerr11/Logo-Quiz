using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class FrmSplash : Form
    {
        public FrmSplash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(progBarSplash.Value < 1000)
            {
                progBarSplash.Value += 100;
            }
            else
            {
                timer1.Stop();
                FrmLogin frm1 = new FrmLogin();
                ActiveForm.Hide();
                frm1.Show();
            }
        }

        private void progBarSplash_Click(object sender, EventArgs e)
        {

        }

        private void FrmSplash_Load(object sender, EventArgs e)
        {

        }
    }
}
