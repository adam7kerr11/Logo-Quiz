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
    public partial class FrmMainPg : Form
    {
        string username;

        public FrmMainPg(string username)
        {
            this.username = username;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmLevelSelect fls = new FrmLevelSelect();
            ActiveForm.Hide();
            fls.Show();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            FrmHelp frs = new FrmHelp();
            ActiveForm.Hide();
            frs.Show();
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        
    }
}
