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
    public partial class FrmLevelSelect : Form
    {
        public FrmLevelSelect()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnlvl1_Click(object sender, EventArgs e)
        {
            FrmDDrop fdd = new FrmDDrop();
            ActiveForm.Hide();
            fdd.Show();
        }

        private void btnlvl5_Click(object sender, EventArgs e)
        {
            
        }

        private void btnlvl2_Click(object sender, EventArgs e)
        {
            FrmEnter fls = new FrmEnter();
            ActiveForm.Hide();
            fls.Show();
            fls.Size = new Size(798, 545);
        }

        private void btnlvl3_Click(object sender, EventArgs e)
        {
            FrmRadio frd = new FrmRadio();
            ActiveForm.Hide();
            frd.Show();
        }

        private void btnlvl4_Click(object sender, EventArgs e)
        {
            FrmLetter frl = new FrmLetter();
            ActiveForm.Hide();
            frl.Show();
        }
    }
}
