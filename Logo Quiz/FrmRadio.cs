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
    public partial class FrmRadio : Form
    {
        public FrmRadio()
        {
            InitializeComponent();
            loadLogos();
        }
        int quNumber = 1;
        int score = 0;
        Random rand = new Random();
        List<int> questions = new List<int>();
        int quCounter = 1;


        private void hideAllGroupBoxes()
        {
            gBoxAstonMartin.Visible = false;
            gBoxBarclays.Visible = false;
            gBoxBlockBuster.Visible = false;
            gBoxCartoonNetwork.Visible = false;
            gBoxFila.Visible = false;
            gBoxHolidayInn.Visible = false;
            gBoxJohnDeere.Visible = false;
            gBoxLinkedIn.Visible = false;
            gBoxMorrisons.Visible = false;
            gBoxOpel.Visible = false;
            gBoxPremierLeague.Visible = false;
            gBoxRBS.Visible = false;
            gBoxSamsung.Visible = false;
        }
        private void loadLogos()
        {
            quNumber++;
            do
            {
                quNumber = rand.Next(1, 13);
                hideAllGroupBoxes();
            }
            while (questions.Contains(quNumber));
            questions.Add(quNumber);


            switch (quNumber)
            {
                case 1:
                    gBoxAstonMartin.Visible = true;
                    gBoxAstonMartin.Location = new Point(138, 105);
                    gBoxAstonMartin.Size = new Size(553, 219);
                    break;
                case 2:
                    gBoxBarclays.Visible = true;
                    gBoxBarclays.Location = new Point(138, 105);
                    gBoxBarclays.Size = new Size(553, 219);
                    break;
                case 3:
                    gBoxBlockBuster.Visible = true;
                    gBoxBlockBuster.Location = new Point(138, 105);
                    gBoxBlockBuster.Size = new Size(553, 219);
                    break;
                case 4:
                    gBoxCartoonNetwork.Visible = true;
                    gBoxCartoonNetwork.Location = new Point(138, 105);
                    gBoxCartoonNetwork.Size = new Size(553, 219);
                    break;
                case 5:
                    gBoxFila.Visible = true;
                    gBoxFila.Location = new Point(138, 105);
                    gBoxFila.Size = new Size(553, 219);
                    break;
                case 6:
                    gBoxHolidayInn.Visible = true;
                    gBoxHolidayInn.Location = new Point(138, 105);
                    gBoxHolidayInn.Size = new Size(553, 219);
                    break;
                case 7:
                    gBoxJohnDeere.Visible = true;
                    gBoxJohnDeere.Location = new Point(138, 105);
                    gBoxJohnDeere.Size = new Size(553, 219);
                    break;
                case 8:
                    gBoxLinkedIn.Visible = true;
                    gBoxLinkedIn.Location = new Point(138, 105);
                    gBoxLinkedIn.Size = new Size(553, 219);
                    break;
                case 9:
                    gBoxMorrisons.Visible = true;
                    gBoxMorrisons.Location = new Point(138, 105);
                    gBoxMorrisons.Size = new Size(553, 219);
                    break;
                case 10:
                    gBoxOpel.Visible = true;
                    gBoxOpel.Location = new Point(138, 105);
                    gBoxOpel.Size = new Size(553, 219);
                    break;
                case 11:
                    gBoxPremierLeague.Visible = true;
                    gBoxPremierLeague.Location = new Point(138, 105);
                    gBoxPremierLeague.Size = new Size(553, 219);
                    break;
                case 12:
                    gBoxRBS.Visible = true;
                    gBoxRBS.Location = new Point(138, 105);
                    gBoxRBS.Size = new Size(553, 219);
                    break;
                case 13:
                    gBoxSamsung.Visible = true;
                    gBoxSamsung.Location = new Point(138, 105);
                    gBoxSamsung.Size = new Size(553, 219);
                    break;
            }
            //quCounter++;
            if (quNumber == 5)
            {
                hideAllGroupBoxes();
                FrmLevelSelect fls = new FrmLevelSelect();
                ActiveForm.Hide();
                fls.Show();
            }
        }


        private void btnEnter_Click(object sender, EventArgs e)
        {
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            //rbtnAbsa.AutoCheck = false;
            //rbtnAbbey.AutoCheck = false;
        }

     

        private void rbtnMorrisons_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Correct");
            loadLogos();
        }

        private void rbtnMaplin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Incorrect");
            loadLogos();
        }

        private void rbtnFarah_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Incorrect");
            loadLogos();
        }

        private void rbtnFila_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Correct");
            loadLogos();
        }

        private void rbtnSamsung_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Correct");
            loadLogos();
        }

        private void rbtnSurrounding_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Incorrect");
            loadLogos();
        }

        private void rbtnAbsa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Correct");
            loadLogos();
        }

        private void rbtnAbbey_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Incorrect");
            loadLogos();
        }

        private void rbtnCAR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Incorrect");
            loadLogos();
        }

        private void rbtnCAT_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Correct");
            loadLogos();
        }

        private void rbtnLinkedIn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Correct");
            loadLogos();
        }

        private void rbtnLoggedIn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Incorrect");
            loadLogos();
        }

        private void rbtnFujitsu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Correct");
            loadLogos();
        }

        private void rbtnJinx_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Incorrect");
            loadLogos();
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Incorrect");
            loadLogos();
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Correct");
            loadLogos();
        }

        private void rbtnJohnDeere_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Correct");
            loadLogos();
        }

        private void rbtnDeerHouse_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Incorrect");
            loadLogos();
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Incorrect");
            loadLogos();
        }

        private void rbtnAstonMartin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Correct");
            loadLogos();
        }

        private void rbtnOpel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Correct");
            loadLogos();
        }

        private void rbtnRover_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Incorrect");
            loadLogos();
        }

        private void rbtnBlockBuster_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Correct");
            loadLogos();
        }

        private void rbtnOdeon_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Incorrect");
            loadLogos();
        }

        private void rbtnHolidayInn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Correct");
            loadLogos();
        }

        private void rbtnHalliday_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Incorrect");
            loadLogos();
        }

        private void rbtnRBS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Correct");
            loadLogos();
        }

        private void rbtnDFS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Incorrect");
            loadLogos();
        }

        private void rbtnCartoonNetwork_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Correct"); 
            loadLogos();
        }

        private void rbtnNickelodeon_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Incorrect"); 
            loadLogos();
        }

        private void rbtnBarclays_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Correct");
            loadLogos();
        }

        private void rbtnNationwide_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Incorrect");
            loadLogos();
        }

        private void radioButton5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Correct");
            loadLogos();
        }

        private void rbtnLionBar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Incorrect");
            loadLogos();
        }

        private void rbtnAbbey_CheckedChanged(object sender, EventArgs e)
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

