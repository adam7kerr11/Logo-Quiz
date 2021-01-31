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
    public partial class FrmScore : Form
    {
        public FrmScore()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMainPg fmp = new FrmMainPg(username);
            ActiveForm.Hide();
            fmp.Show();
        }

        private void FrmScore_Load(object sender, EventArgs e)
        {

        }

        public string username { get; set; }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
