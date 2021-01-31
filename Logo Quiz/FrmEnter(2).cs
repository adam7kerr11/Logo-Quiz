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
    public partial class FrmEnter : Form
    {
        public FrmEnter()
        {
            InitializeComponent();
            loadLogos();
        }
        int quNumber = 0;
        int score = 0;
        Random rand = new Random();
        List<int> questions = new List<int>();
        int quCounter = 1;
        
        
        private void hideAllGroupBoxes()
        {
            GboxApple.Visible = false;
            GboxFacebook.Visible = false;
            GboxFanta.Visible = false;
            GboxDominos.Visible = false;
            GboxExplorer.Visible = false;
            GboxTacoBell.Visible = false;
            GboxHP.Visible = false;
            GboxAndroid.Visible = false;
            GboxLG.Visible = false;
            GboxTwitter.Visible = false;
            GboxTesco.Visible = false;
            GboxStarbucks.Visible = false;
            GboxPlaystation.Visible = false;
            GboxNike.Visible = false;
            GboxBeats.Visible = false;
            GboxPepsi.Visible = false;
            GboxAdobe.Visible = false;
            GboxMcds.Visible = false;
        }
        private void loadLogos()
        {
            do
            {
               quNumber = rand.Next(1, 17);
               hideAllGroupBoxes();
            }
            while (questions.Contains(quNumber));
            questions.Add(quNumber);


            switch (quNumber)
            {
                case 1:
                    GboxApple.Visible = true;
                    GboxApple.Location = new Point(185, 85);
                    GboxApple.Size = new Size(344, 324);
                    break;
                case 2:
                    GboxFacebook.Visible = true;
                    GboxFacebook.Location = new Point(185, 85);
                    GboxFacebook.Size = new Size(372, 327);
                    break;
                case 3:
                    GboxFanta.Visible = true;
                    GboxFanta.Location = new Point(185, 85);
                    GboxFanta.Size = new Size(352, 327);
                    break;
                case 4:
                    GboxDominos.Visible = true;
                    GboxDominos.Location = new Point(185, 85);
                    GboxDominos.Size = new Size(430, 320);
                    break;
                case 5:
                    GboxExplorer.Visible = true;
                    GboxExplorer.Location = new Point(185, 85);
                    GboxExplorer.Size = new Size(331, 352);
                    break;
                case 6:
                    GboxTacoBell.Visible = true;
                    GboxTacoBell.Location = new Point(185, 85);
                    GboxTacoBell.Size = new Size(344, 272);
                    break;
                case 7:
                    GboxHP.Visible = true;
                    GboxHP.Location = new Point(185, 85);
                    GboxHP.Size = new Size(344, 273);
                    break;
                case 8:
                    GboxAndroid.Visible = true;
                    GboxAndroid.Location = new Point(185, 85);
                    GboxAndroid.Size = new Size(344, 290);
                    break;
                case 9:
                    GboxLG.Visible = true;
                    GboxLG.Location = new Point(185, 85);
                    GboxLG.Size = new Size(344, 271);
                    break;
                case 10:
                    GboxTwitter.Visible = true;
                    GboxTwitter.Location = new Point(366, 131);
                    GboxTwitter.Size = new Size(386, 274);
                    break;
                case 11:
                    GboxTesco.Visible = true;
                    GboxTesco.Location = new Point(185, 85);
                    GboxTesco.Size = new Size(391, 232);
                    break;
                case 12:
                    GboxStarbucks.Visible = true;
                    GboxStarbucks.Location = new Point(185, 85);
                    GboxStarbucks.Size = new Size(344, 292);
                    break;
                case 13:
                    GboxPlaystation.Visible = true;
                    GboxPlaystation.Location = new Point(185, 85);
                    GboxPlaystation.Size = new Size(344, 266);
                    break;
                case 14:
                    GboxNike.Visible = true;
                    GboxNike.Location = new Point(185, 85);
                    GboxNike.Size = new Size(344, 270);
                    break;
                case 15:
                    GboxBeats.Visible = true;
                    GboxBeats.Location = new Point(185, 85);
                    GboxBeats.Size = new Size(344, 278);
                    break;
                case 16:
                    GboxPepsi.Visible = true;
                    GboxPepsi.Location = new Point(185, 85);
                    GboxPepsi.Size = new Size(344, 306);
                    break;
                case 17:
                    GboxAdobe.Visible = true;
                    GboxAdobe.Location = new Point(185, 85);
                    GboxAdobe.Size = new Size(344, 287);
                    break;
                case 18:
                    GboxMcds.Visible = true;
                    GboxMcds.Location = new Point(185, 85);
                    GboxMcds.Size = new Size(344, 274);
                    break;
            }
            quCounter++;
            if (quCounter == 10)
            {
                hideAllGroupBoxes();
                FrmLevelSelect fls = new FrmLevelSelect();
                ActiveForm.Hide();
                fls.Show();
            }
        }
       
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
        
        }

        private void pBoxBP_Click(object sender, EventArgs e)
        {
        
        }

        private void pBoxApple_Click(object sender, EventArgs e)
        {
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void pBoxDominos_Click(object sender, EventArgs e)
        {
        
        }

        private void GboxNike_Enter(object sender, EventArgs e)
        {
        
        }

        private void poxTacoBell_Click(object sender, EventArgs e)
        {

        }

        private void tboxLG_TextChanged(object sender, EventArgs e)
        {

        }

        private void pBoxTwitter_Click(object sender, EventArgs e)
        {

        }

        private void tboxBP_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmEnter_Load(object sender, EventArgs e)
        {

        }

        private void tboxBP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void GboxTacoBell_Enter(object sender, EventArgs e)
        {

        }

        private void tboxTacoBell_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void tboxBeats_TextChanged(object sender, EventArgs e)
        {

        }

        private void tboxBeats_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void tboxAndroid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void GboxFanta_Enter(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void tboxLG_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void GboxLG_Enter(object sender, EventArgs e)
        {

        }

        private void tboxTwitter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void tBoxApple_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void tboxDominos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void tboxPepsi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
            }

        }

        private void tboxNike_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void tboxAdobe_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void tboxPlaystation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
        
        }

        private void tboxStarbucks_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            switch (quNumber)
            {
                case 1:
                    if (tboxEnter.Text.Equals("APPLE"))
                    {
                        MessageBox.Show("Correct");
                        score++;
                    }
                    else
                    {
                        MessageBox.Show("Incorrect");
                    }
                    loadLogos();
                    tboxEnter.Text = string.Empty;
                    break;
                case 2:
                    if (tboxEnter.Text.Equals("FACEBOOK"))
                    {
                        MessageBox.Show("Correct");
                        score++;
                    }
                    else
                    {
                        MessageBox.Show("Incorrect");
                    }
                    loadLogos();
                    tboxEnter.Text = string.Empty;
                    break;
                case 3:
                    if (tboxEnter.Text.Equals("FANTA"))
                    {
                        MessageBox.Show("Correct");
                       score++;
                    }
                    else
                    {
                        MessageBox.Show("Incorrect");
                    }
                    loadLogos();
                    tboxEnter.Text = string.Empty;
                    break;
                case 4:
                    if (tboxEnter.Text.Equals("DOMINOS"))
                    {
                        MessageBox.Show("Correct");
                        score++;
                    }
                    else
                    {
                        MessageBox.Show("Incorrect");
                    }
                    loadLogos();
                    tboxEnter.Text = string.Empty;
                    break;
                case 5:
                    if (tboxEnter.Text.Equals("EXPLORER"))
                    {
                        MessageBox.Show("Correct");
                        score++;
                    }
                    else
                    {
                        MessageBox.Show("Incorrect");
                    }
                    loadLogos();
                    tboxEnter.Text = string.Empty;
                    break;
                case 6:
                    if (tboxEnter.Text.Equals("TACO BELL"))
                    {
                        MessageBox.Show("Correct");
                        score++;
                    }
                    else
                    {
                        MessageBox.Show("Incorrect");
                    }
                    loadLogos();
                    tboxEnter.Text = string.Empty;
                    break;
                case 7:
                    if (tboxEnter.Text.Equals("HP"))
                    {
                        MessageBox.Show("Correct");
                        score++;
                    }
                    else
                    {
                        MessageBox.Show("Incorrect");
                    }
                    loadLogos();
                    tboxEnter.Text = string.Empty;
                    break;
                case 8:
                    if (tboxEnter.Text.Equals("ANDROID"))
                    {
                        MessageBox.Show("Correct");
                        score++;
                    }
                    else
                    {
                        MessageBox.Show("Incorrect");
                    }
                    loadLogos();
                    tboxEnter.Text = string.Empty;
                    break;
                case 9:
                    if (tboxEnter.Text.Equals("LG"))
                    {
                        MessageBox.Show("Correct");
                        score++;
                    }
                    else
                    {
                        MessageBox.Show("Incorrect");
                    }
                    loadLogos();
                    tboxEnter.Text = string.Empty;
                    break;
                case 10:
                    if (tboxEnter.Text.Equals("TWITTER"))
                    {
                        MessageBox.Show("Correct");
                        score++;
                    }
                    else
                    {
                        MessageBox.Show("Incorrect");
                    }
                    loadLogos();
                    tboxEnter.Text = string.Empty;
                    break;
                case 11:
                    if (tboxEnter.Text.Equals("TESCO"))
                    {
                        MessageBox.Show("Correct");
                        score++;
                    }
                    else
                    {
                        MessageBox.Show("Incorrect");
                    }
                    loadLogos();
                    tboxEnter.Text = string.Empty;
                    break;
                case 12:
                    if (tboxEnter.Text.Equals("STARBUCKS"))
                    {
                        MessageBox.Show("Correct");
                        score++;
                    }
                    else
                    {
                        MessageBox.Show("Incorrect");
                    }
                    loadLogos();
                    tboxEnter.Text = string.Empty;
                    break;
                case 13:
                    if (tboxEnter.Text.Equals("PLAYSTATION"))
                    {
                        MessageBox.Show("Correct");
                        score++;
                    }
                    else
                    {
                        MessageBox.Show("Incorrect");
                    }
                    loadLogos();
                    tboxEnter.Text = string.Empty;
                    break;
                case 14:
                    if (tboxEnter.Text.Equals("NIKE"))
                    {
                        MessageBox.Show("Correct");
                        score++;
                    }
                    else
                    {
                        MessageBox.Show("Incorrect");
                    }
                    loadLogos();
                    tboxEnter.Text = string.Empty;
                    break;
                case 15:
                    if (tboxEnter.Text.Equals("BEATS"))
                    {
                        MessageBox.Show("Correct");
                        score++;
                    }
                    else
                    {
                        MessageBox.Show("Incorrect");
                    }
                    loadLogos();
                    tboxEnter.Text = string.Empty;
                    break;
                case 16:
                    if (tboxEnter.Text.Equals("PEPSI"))
                    {
                        MessageBox.Show("Correct");
                        score++;
                    }
                    else
                    {
                        MessageBox.Show("Incorrect");
                    }
                    loadLogos();
                    tboxEnter.Text = string.Empty;
                    break;
                case 17:
                    if (tboxEnter.Text.Equals("ADOBE"))
                    {
                        MessageBox.Show("Correct");
                        score++;
                    }
                    else
                    {
                        MessageBox.Show("Incorrect");
                    }
                    loadLogos();
                    tboxEnter.Text = string.Empty;
                    break;
                case 18:
                    if (tboxEnter.Text.Equals("MCDONALDS"))
                    {
                        MessageBox.Show("Correct");
                        score++;
                    }
                    else
                    {
                        MessageBox.Show("Incorrect");
                    }
                    loadLogos();
                    tboxEnter.Text = string.Empty;
                    break;
            }
        }

        private void tboxEnter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEnter.PerformClick();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void GboxTwitter_Enter(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            FrmMainPg fmp = new FrmMainPg(username);
            ActiveForm.Hide();
            fmp.Show();
        }

        public string username { get; set; }
    }
    
}
