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
    public partial class FrmDDrop : Form
    {
        class score
        {
            public static int getScore
            {
                get
                {
                    return uscore;
                }
                set
                {
                    uscore = value;
                }
            }
        }

















        string selectedAnswer = "";
        string username;
        int quNumber = 0;
        Random rand = new Random();
        List<int> questions = new List<int>();
        static int uscore = 0;
        public FrmDDrop()
        {
            InitializeComponent();
            loadLogos();
        }
        private void loadLogos()
        {
            do
            {
               quNumber = rand.Next(1, 17);
            }
            while (questions.Contains(quNumber));
            questions.Add(quNumber);

            switch (quNumber)
            {
                case 1:
                    GboxFirefox.Visible = true;
                    GboxFirefox.Location = new Point(226, 128);
                    GboxFirefox.Size = new Size(563, 317);
                    GboxWWF.Visible = false;
                    GboxKFC.Visible = false;
                    GboxAllianz.Visible = false;
                    GboxWindows.Visible = false;
                    GboxFarah.Visible = false;
                    GboxYoutube.Visible = false;
                    GboxNBC.Visible = false;
                    GboxDreamworks.Visible = false;
                    GboxConverse.Visible = false;
                    GboxUnilever.Visible = false;
                    GboxChanel.Visible = false;
                    GboxDisney.Visible = false;
                    GboxAdidas.Visible = false;
                    GboxChrome.Visible = false;
                    GboxPuma.Visible = false;
                    GboxDunlop.Visible = false;
                    break;
                case 2:
                    GboxWWF.Visible = true;
                    GboxWWF.Location = new Point(208, 124);
                    GboxWWF.Size = new Size(589, 284);
                    GboxFirefox.Visible = false;
                    GboxKFC.Visible = false;
                    GboxAllianz.Visible = false;
                    GboxWindows.Visible = false;
                    GboxFarah.Visible = false;
                    GboxYoutube.Visible = false;
                    GboxNBC.Visible = false;
                    GboxDreamworks.Visible = false;
                    GboxConverse.Visible = false;
                    GboxUnilever.Visible = false;
                    GboxChanel.Visible = false;
                    GboxDisney.Visible = false;
                    GboxAdidas.Visible = false;
                    GboxChrome.Visible = false;
                    GboxPuma.Visible = false;
                    GboxDunlop.Visible = false;
                    break;

                case 3:
                    GboxAllianz.Visible = true;
                    GboxAllianz.Location = new Point(173, 106);
                    GboxAllianz.Size = new Size(413, 245);
                    GboxFirefox.Visible = false;
                    GboxWWF.Visible = false;
                    GboxKFC.Visible = false;
                    GboxWindows.Visible = false;
                    GboxFarah.Visible = false;
                    GboxYoutube.Visible = false;
                    GboxNBC.Visible = false;
                    GboxDreamworks.Visible = false;
                    GboxConverse.Visible = false;
                    GboxUnilever.Visible = false;
                    GboxChanel.Visible = false;
                    GboxDisney.Visible = false;
                    GboxAdidas.Visible = false;
                    GboxChrome.Visible = false;
                    GboxPuma.Visible = false;
                    GboxDunlop.Visible = false;
                    break;
                case 4:
                    GboxWindows.Visible = true;
                    GboxWindows.Location = new Point(204, 128);
                    GboxWindows.Size = new Size(597, 311);
                    GboxFirefox.Visible = false;
                    GboxWWF.Visible = false;
                    GboxKFC.Visible = false;
                    GboxAllianz.Visible = false;
                    GboxFarah.Visible = false;
                    GboxYoutube.Visible = false;
                    GboxNBC.Visible = false;
                    GboxDreamworks.Visible = false;
                    GboxConverse.Visible = false;
                    GboxUnilever.Visible = false;
                    GboxChanel.Visible = false;
                    GboxDisney.Visible = false;
                    GboxAdidas.Visible = false;
                    GboxChrome.Visible = false;
                    GboxPuma.Visible = false;
                    GboxDunlop.Visible = false;
                    break;
                case 5:
                    GboxFarah.Visible = true;
                    GboxFarah.Location = new Point(208, 137);
                    GboxFarah.Size = new Size(568, 294);
                    GboxFirefox.Visible = false;
                    GboxWWF.Visible = false;
                    GboxKFC.Visible = false;
                    GboxWindows.Visible = false;
                    GboxAllianz.Visible = false;
                    GboxYoutube.Visible = false;
                    GboxNBC.Visible = false;
                    GboxDreamworks.Visible = false;
                    GboxConverse.Visible = false;
                    GboxUnilever.Visible = false;
                    GboxChanel.Visible = false;
                    GboxDisney.Visible = false;
                    GboxAdidas.Visible = false;
                    GboxChrome.Visible = false;
                    GboxPuma.Visible = false;
                    GboxDunlop.Visible = false;
                    break;
                case 6:
                    GboxYoutube.Visible = true;
                    GboxYoutube.Location = new Point(173, 106);
                    GboxYoutube.Size = new Size(413, 245);
                    GboxFirefox.Visible = false;
                    GboxWWF.Visible = false;
                    GboxKFC.Visible = false;
                    GboxWindows.Visible = false;
                    GboxFarah.Visible = false;
                    GboxAllianz.Visible = false;
                    GboxNBC.Visible = false;
                    GboxDreamworks.Visible = false;
                    GboxConverse.Visible = false;
                    GboxUnilever.Visible = false;
                    GboxChanel.Visible = false;
                    GboxDisney.Visible = false;
                    GboxAdidas.Visible = false;
                    GboxChrome.Visible = false;
                    GboxPuma.Visible = false;
                    GboxDunlop.Visible = false;
                    break;
                case 7:
                    GboxNBC.Visible = true;
                    GboxNBC.Location = new Point(241, 128);
                    GboxNBC.Size = new Size(553, 248);
                    GboxFirefox.Visible = false;
                    GboxWWF.Visible = false;
                    GboxKFC.Visible = false;
                    GboxWindows.Visible = false;
                    GboxFarah.Visible = false;
                    GboxYoutube.Visible = false;
                    GboxAllianz.Visible = false;
                    GboxDreamworks.Visible = false;
                    GboxConverse.Visible = false;
                    GboxUnilever.Visible = false;
                    GboxChanel.Visible = false;
                    GboxDisney.Visible = false;
                    GboxAdidas.Visible = false;
                    GboxChrome.Visible = false;
                    GboxPuma.Visible = false;
                    GboxDunlop.Visible = false;
                    break;
                case 8:
                    GboxDreamworks.Visible = true;
                    GboxDreamworks.Location = new Point(173, 106);
                    GboxDreamworks.Size = new Size(413, 245);
                    GboxFirefox.Visible = false;
                    GboxWWF.Visible = false;
                    GboxKFC.Visible = false;
                    GboxWindows.Visible = false;
                    GboxFarah.Visible = false;
                    GboxYoutube.Visible = false;
                    GboxNBC.Visible = false;
                    GboxAllianz.Visible = false;
                    GboxConverse.Visible = false;
                    GboxUnilever.Visible = false;
                    GboxChanel.Visible = false;
                    GboxDisney.Visible = false;
                    GboxAdidas.Visible = false;
                    GboxChrome.Visible = false;
                    GboxPuma.Visible = false;
                    GboxDunlop.Visible = false;
                    break;
                case 9:
                    GboxConverse.Visible = true;
                    GboxConverse.Location = new Point(205, 139);
                    GboxConverse.Size = new Size(593, 313);
                    GboxFirefox.Visible = false;
                    GboxWWF.Visible = false;
                    GboxKFC.Visible = false;
                    GboxWindows.Visible = false;
                    GboxFarah.Visible = false;
                    GboxYoutube.Visible = false;
                    GboxNBC.Visible = false;
                    GboxDreamworks.Visible = false;
                    GboxAllianz.Visible = false;
                    GboxUnilever.Visible = false;
                    GboxChanel.Visible = false;
                    GboxDisney.Visible = false;
                    GboxAdidas.Visible = false;
                    GboxChrome.Visible = false;
                    GboxPuma.Visible = false;
                    GboxDunlop.Visible = false;
                    break;
                case 10:
                    GboxUnilever.Visible = true;
                    GboxUnilever.Location = new Point(173, 106);
                    GboxUnilever.Size = new Size(413, 245);
                    GboxFirefox.Visible = false;
                    GboxWWF.Visible = false;
                    GboxKFC.Visible = false;
                    GboxWindows.Visible = false;
                    GboxFarah.Visible = false;
                    GboxYoutube.Visible = false;
                    GboxNBC.Visible = false;
                    GboxDreamworks.Visible = false;
                    GboxConverse.Visible = false;
                    GboxAllianz.Visible = false;
                    GboxChanel.Visible = false;
                    GboxDisney.Visible = false;
                    GboxAdidas.Visible = false;
                    GboxChrome.Visible = false;
                    GboxPuma.Visible = false;
                    GboxDunlop.Visible = false;
                    break;
                case 11:
                    GboxChanel.Visible = true;
                    GboxChanel.Location = new Point(173, 106);
                    GboxChanel.Size = new Size(413, 245);
                    GboxFirefox.Visible = false;
                    GboxWWF.Visible = false;
                    GboxKFC.Visible = false;
                    GboxWindows.Visible = false;
                    GboxFarah.Visible = false;
                    GboxYoutube.Visible = false;
                    GboxNBC.Visible = false;
                    GboxDreamworks.Visible = false;
                    GboxConverse.Visible = false;
                    GboxUnilever.Visible = false;
                    GboxAllianz.Visible = false;
                    GboxDisney.Visible = false;
                    GboxAdidas.Visible = false;
                    GboxChrome.Visible = false;
                    GboxPuma.Visible = false;
                    GboxDunlop.Visible = false;
                    break;
                case 12:
                    GboxDisney.Visible = true;
                    GboxDisney.Location = new Point(173, 106);
                    GboxDisney.Size = new Size(413, 245);
                    GboxFirefox.Visible = false;
                    GboxWWF.Visible = false;
                    GboxKFC.Visible = false;
                    GboxWindows.Visible = false;
                    GboxFarah.Visible = false;
                    GboxYoutube.Visible = false;
                    GboxNBC.Visible = false;
                    GboxDreamworks.Visible = false;
                    GboxConverse.Visible = false;
                    GboxUnilever.Visible = false;
                    GboxChanel.Visible = false;
                    GboxAllianz.Visible = false;
                    GboxAdidas.Visible = false;
                    GboxChrome.Visible = false;
                    GboxPuma.Visible = false;
                    GboxDunlop.Visible = false;
                    break;
                case 13:
                    GboxAdidas.Visible = true;
                    GboxAdidas.Location = new Point(208, 139);
                    GboxAdidas.Size = new Size(581, 279);
                    GboxFirefox.Visible = false;
                    GboxWWF.Visible = false;
                    GboxKFC.Visible = false;
                    GboxWindows.Visible = false;
                    GboxFarah.Visible = false;
                    GboxYoutube.Visible = false;
                    GboxNBC.Visible = false;
                    GboxDreamworks.Visible = false;
                    GboxConverse.Visible = false;
                    GboxUnilever.Visible = false;
                    GboxChanel.Visible = false;
                    GboxDisney.Visible = false;
                    GboxAllianz.Visible = false;
                    GboxChrome.Visible = false;
                    GboxPuma.Visible = false;
                    GboxDunlop.Visible = false;
                    break;
                case 14:
                    GboxChrome.Visible = true;
                    GboxChrome.Location = new Point(223, 128);
                    GboxChrome.Size = new Size(527, 304);
                    GboxFirefox.Visible = false;
                    GboxWWF.Visible = false;
                    GboxKFC.Visible = false;
                    GboxWindows.Visible = false;
                    GboxFarah.Visible = false;
                    GboxYoutube.Visible = false;
                    GboxNBC.Visible = false;
                    GboxDreamworks.Visible = false;
                    GboxConverse.Visible = false;
                    GboxUnilever.Visible = false;
                    GboxChanel.Visible = false;
                    GboxDisney.Visible = false;
                    GboxAdidas.Visible = false;
                    GboxAllianz.Visible = false;
                    GboxPuma.Visible = false;
                    GboxDunlop.Visible = false;
                    break;
                case 15:
                    GboxPuma.Visible = true;
                    GboxPuma.Location = new Point(173, 106);
                    GboxPuma.Size = new Size(413, 245);
                    GboxFirefox.Visible = false;
                    GboxWWF.Visible = false;
                    GboxKFC.Visible = false;
                    GboxWindows.Visible = false;
                    GboxFarah.Visible = false;
                    GboxYoutube.Visible = false;
                    GboxNBC.Visible = false;
                    GboxDreamworks.Visible = false;
                    GboxConverse.Visible = false;
                    GboxUnilever.Visible = false;
                    GboxChanel.Visible = false;
                    GboxDisney.Visible = false;
                    GboxAdidas.Visible = false;
                    GboxChrome.Visible = false;
                    GboxAllianz.Visible = false;
                    GboxDunlop.Visible = false;
                    break;
                case 16:
                    GboxDunlop.Visible = true;
                    GboxDunlop.Location = new Point(223, 128);
                    GboxDunlop.Size = new Size(571, 290);
                    GboxFirefox.Visible = false;
                    GboxWWF.Visible = false;
                    GboxKFC.Visible = false;
                    GboxWindows.Visible = false;
                    GboxFarah.Visible = false;
                    GboxYoutube.Visible = false;
                    GboxNBC.Visible = false;
                    GboxDreamworks.Visible = false;
                    GboxConverse.Visible = false;
                    GboxUnilever.Visible = false;
                    GboxChanel.Visible = false;
                    GboxDisney.Visible = false;
                    GboxAdidas.Visible = false;
                    GboxChrome.Visible = false;
                    GboxPuma.Visible = false;
                    GboxAllianz.Visible = false;
                    break;
                case 17:
                    GboxKFC.Visible = true;
                    GboxKFC.Location = new Point(173, 106);
                    GboxKFC.Size = new Size(413, 245);
                    GboxFirefox.Visible = false;
                    GboxWWF.Visible = false;
                    GboxAllianz.Visible = false;
                    GboxWindows.Visible = false;
                    GboxFarah.Visible = false;
                    GboxYoutube.Visible = false;
                    GboxNBC.Visible = false;
                    GboxDreamworks.Visible = false;
                    GboxConverse.Visible = false;
                    GboxUnilever.Visible = false;
                    GboxChanel.Visible = false;
                    GboxDisney.Visible = false;
                    GboxAdidas.Visible = false;
                    GboxChrome.Visible = false;
                    GboxPuma.Visible = false;
                    GboxDunlop.Visible = false;
                    break;


            }
            if(quNumber == 10)
            {
                FrmLevelSelect fls = new FrmLevelSelect();
                ActiveForm.Hide();
                fls.Show();
            }
        }

        private void GboxPepsi_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lblMcDonalds_MouseDown(object sender, MouseEventArgs e)
        {
            selectedAnswer = "McDonalds";
            Label lblMcDonalds = (Label)sender;
            lblMcDonalds.DoDragDrop(lblMcDonalds.Text, DragDropEffects.Copy);
            lblMcDonalds.Text = "";
        }

        private void pictureBox8_DragDrop(object sender, DragEventArgs e)
        {
            if (selectedAnswer.Equals("KFC"))
            {
                MessageBox.Show("Correct!");
                score.getScore++;
            }
            else
            {
                MessageBox.Show("Incorrect!");
            }
            loadLogos();
        }

        private void GboxKFC_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
                e.Effect = DragDropEffects.Copy;
        }

        private void lblKFC_MouseDown(object sender, MouseEventArgs e)
        {
            selectedAnswer = "KFC";
            Label lblKFC = (Label)sender;
            lblKFC.DoDragDrop(lblKFC.Text, DragDropEffects.Copy);
            lblKFC.Text = "";
        }


        private void lblKFC_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void frmLabDrag_Load(object sender, EventArgs e)
        {
            pBoxUnilever.AllowDrop = true;
            pBoxAdidas.AllowDrop = true;
            pBoxChanel.AllowDrop = true;
            pBoxDunlop.AllowDrop = true;
            pBoxChrome.AllowDrop = true;
            pBoxPuma.AllowDrop = true;
            pBoxDisney.AllowDrop = true;
            pBoxAllianz.AllowDrop = true;
            pBoxConverse.AllowDrop = true;
            pBoxDreamworks.AllowDrop = true;
            pBoxFarah.AllowDrop = true;
            pBoxFirefox.AllowDrop = true;
            pBoxKFC.AllowDrop = true;
            pBoxNBC.AllowDrop = true;
            pBoxWindows.AllowDrop = true;
            pBoxWWF.AllowDrop = true;
            pBoxYoutube.AllowDrop = true;
        }

        private void GboxReebok_Enter(object sender, EventArgs e)
        {

        }

        private void lblDunlop_MouseDown(object sender, MouseEventArgs e)
        {
            selectedAnswer = "Dunlop";
            Label lblDunlop = (Label)sender;
            lblDunlop.DoDragDrop(lblDunlop.Text, DragDropEffects.Copy);
            lblDunlop.Text = "";
        }

        private void pBoxDunlop_DragDrop(object sender, DragEventArgs e)
        {
            if (selectedAnswer.Equals("Dunlop"))
            {
                MessageBox.Show("Correct!");
                score.getScore++;
            }
            else
            {
                MessageBox.Show("Incorrect!");
            }
            loadLogos();
        }

        private void pBoxDunlop_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
                e.Effect = DragDropEffects.Copy;
        }

        private void lblDaxon_MouseDown(object sender, MouseEventArgs e)
        {
            selectedAnswer = "Daxon";
            Label lblDaxon = (Label)sender;
            lblDaxon.DoDragDrop(lblDaxon.Text, DragDropEffects.Copy);
            lblDaxon.Text = "";
        }

        private void lblLonsdale_MouseDown(object sender, MouseEventArgs e)
        {
            selectedAnswer = "Lonsdale";
            Label lblLonsdale = (Label)sender;
            lblLonsdale.DoDragDrop(lblLonsdale.Text, DragDropEffects.Copy);
            lblLonsdale.Text = "";
        }

        private void lblPuma_MouseDown(object sender, MouseEventArgs e)
        {
            selectedAnswer = "Puma";
            Label lblPuma = (Label)sender;
            lblPuma.DoDragDrop(lblPuma.Text, DragDropEffects.Copy);
            lblPuma.Text = "";
        }

        private void pBoxPuma_DragDrop(object sender, DragEventArgs e)
        {
            if (selectedAnswer.Equals("Puma"))
            {
                MessageBox.Show("Correct!");
                score.getScore++;
            }
            else
            {
                MessageBox.Show("Incorrect!");
            }
            loadLogos();
        }

        private void pBoxPuma_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
                e.Effect = DragDropEffects.Copy;
        }

        private void lblMSN_MouseDown(object sender, MouseEventArgs e)
        {
            selectedAnswer = "MSN";
            Label lblMSN = (Label)sender;
            lblMSN.DoDragDrop(lblMSN.Text, DragDropEffects.Copy);
            lblMSN.Text = "";
        }

        private void lblChrome_MouseDown(object sender, MouseEventArgs e)
        {
            selectedAnswer = "Chrome";
            Label lblChrome = (Label)sender;
            lblChrome.DoDragDrop(lblChrome.Text, DragDropEffects.Copy);
            lblChrome.Text = "";
        }

        private void pBoxChrome_DragDrop(object sender, DragEventArgs e)
        {
            if (selectedAnswer.Equals("Chrome"))
            {
                MessageBox.Show("Correct!");
                score.getScore++;
            }
            else
            {
                MessageBox.Show("Incorrect!");
            }
            loadLogos();
        }

        private void pBoxChrome_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
                e.Effect = DragDropEffects.Copy;
        }

        private void lblReebok_MouseDown(object sender, MouseEventArgs e)
        {
            selectedAnswer = "Reebok";
            Label lblReebok = (Label)sender;
            lblReebok.DoDragDrop(lblReebok.Text, DragDropEffects.Copy);
            lblReebok.Text = "";
        }

        private void lblAdidas_MouseDown(object sender, MouseEventArgs e)
        {
            selectedAnswer = "Adidas";
            Label lblAdidas = (Label)sender;
            lblAdidas.DoDragDrop(lblAdidas.Text, DragDropEffects.Copy);
            lblAdidas.Text = "";
        }

        private void pBoxAdidas_DragDrop(object sender, DragEventArgs e)
        {
            if (selectedAnswer.Equals("Adidas"))
            {
                MessageBox.Show("Correct!");
                score.getScore++;
            }
            else
            {
                MessageBox.Show("Incorrect!");
            }
            loadLogos();
        }

        private void pBoxAdidas_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
                e.Effect = DragDropEffects.Copy;
        }

        private void pBoxDisney_DragDrop(object sender, DragEventArgs e)
        {
            if (selectedAnswer.Equals("Disney"))
            {
                MessageBox.Show("Correct!");
                score.getScore++;
            }
            else
            {
                MessageBox.Show("Incorrect!");
            }
            loadLogos();
        }

        private void pBoxDisney_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
                e.Effect = DragDropEffects.Copy;
        }

        private void lblDolby_MouseDown(object sender, MouseEventArgs e)
        {
            selectedAnswer = "Dolby";
            Label lblDolby = (Label)sender;
            lblDolby.DoDragDrop(lblDolby.Text, DragDropEffects.Copy);
            lblDolby.Text = "";
        }

        private void lblDisney_MouseDown(object sender, MouseEventArgs e)
        {
            selectedAnswer = "Disney";
            Label lblDisney = (Label)sender;
            lblDisney.DoDragDrop(lblDisney.Text, DragDropEffects.Copy);
            lblDisney.Text = "";
        }

        private void lblChanel_MouseDown(object sender, MouseEventArgs e)
        {
            selectedAnswer = "Chanel";
            Label lblChanel = (Label)sender;
            lblChanel.DoDragDrop(lblChanel.Text, DragDropEffects.Copy);
            lblChanel.Text = "";
        }

        private void lblCadillac_MouseDown(object sender, MouseEventArgs e)
        {
            selectedAnswer = "Cadillac";
            Label lblCadillac = (Label)sender;
            lblCadillac.DoDragDrop(lblCadillac.Text, DragDropEffects.Copy);
            lblCadillac.Text = "";
        }

        private void pBoxChanel_DragDrop(object sender, DragEventArgs e)
        {
            if (selectedAnswer.Equals("Chanel"))
            {
                MessageBox.Show("Correct!");
                score.getScore++;
            }
            else
            {
                MessageBox.Show("Incorrect!");
            }
            loadLogos();
        }

        private void pBoxChanel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
                e.Effect = DragDropEffects.Copy;
        }

        private void lblUbisoft_MouseDown(object sender, MouseEventArgs e)
        {
            selectedAnswer = "Ubisoft";
            Label lblUbisoft = (Label)sender;
            lblUbisoft.DoDragDrop(lblUbisoft.Text, DragDropEffects.Copy);
            lblUbisoft.Text = "";
        }

        private void lblUnilever_MouseDown(object sender, MouseEventArgs e)
        {
            selectedAnswer = "Unilever";
            Label lblUnilver = (Label)sender;
            lblUnilver.DoDragDrop(lblUnilver.Text, DragDropEffects.Copy);
            lblUnilver.Text = "";
        }

        private void pBoxUnilever_DragDrop(object sender, DragEventArgs e)
        {
            if (selectedAnswer.Equals("Unilever"))
            {
                MessageBox.Show("Correct!");
                score.getScore++;
            }
            else
            {
                MessageBox.Show("Incorrect!");
            }
            loadLogos();
        }

        private void pBoxUnilever_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
                e.Effect = DragDropEffects.Copy;
        }

        private void lblMizuno_MouseDown(object sender, MouseEventArgs e)
        {
            selectedAnswer = "Mizuno";
            Label lblMizuno = (Label)sender;
            lblMizuno.DoDragDrop(lblMizuno.Text, DragDropEffects.Copy);
            lblMizuno.Text = "";
        }

        private void lblConverse_MouseDown(object sender, MouseEventArgs e)
        {
            selectedAnswer = "Converse";
            Label lblConverse = (Label)sender;
            lblConverse.DoDragDrop(lblConverse.Text, DragDropEffects.Copy);
            lblConverse.Text = "";
        }

        private void pBoxConverse_DragDrop(object sender, DragEventArgs e)
        {
            if (selectedAnswer.Equals("Converse"))
            {
                MessageBox.Show("Correct!");
                score.getScore++;
            }
            else
            {
                MessageBox.Show("Incorrect!");
            }
            loadLogos();
        }

        private void pBoxConverse_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
                e.Effect = DragDropEffects.Copy;
        }

        private void lblPixar_MouseDown(object sender, MouseEventArgs e)
        {
            selectedAnswer = "Pixar";
            Label lblPixar = (Label)sender;
            lblPixar.DoDragDrop(lblPixar.Text, DragDropEffects.Copy);
            lblPixar.Text = "";
        }

        private void lblDreamworks_MouseDown(object sender, MouseEventArgs e)
        {
            selectedAnswer = "Dreamworks";
            Label lblDreamworks = (Label)sender;
            lblDreamworks.DoDragDrop(lblDreamworks.Text, DragDropEffects.Copy);
            lblDreamworks.Text = "";
        }

        private void pBoxDreamworks_DragDrop(object sender, DragEventArgs e)
        {
            if (selectedAnswer.Equals("Dreamworks"))
            {
                MessageBox.Show("Correct!");
                score.getScore++;
            }
            else
            {
                MessageBox.Show("Incorrect!");
            }
            loadLogos();
        }

        private void pBoxDreamworks_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
                e.Effect = DragDropEffects.Copy;
        }

        private void lblCNN_MouseDown(object sender, MouseEventArgs e)
        {
            selectedAnswer = "CNN";
            Label lblCNN = (Label)sender;
            lblCNN.DoDragDrop(lblCNN.Text, DragDropEffects.Copy);
            lblCNN.Text = "";
        }

        private void lblNBC_MouseDown(object sender, MouseEventArgs e)
        {
            selectedAnswer = "NBC";
            Label lblNBC = (Label)sender;
            lblNBC.DoDragDrop(lblNBC.Text, DragDropEffects.Copy);
            lblNBC.Text = "";
        }

        private void pBoxNBC_DragDrop(object sender, DragEventArgs e)
        {
            if (selectedAnswer.Equals("NBC"))
            {
                MessageBox.Show("Correct!");
                score.getScore++;
            }
            else
            {
                MessageBox.Show("Incorrect!");
            }
            loadLogos();
        }

        private void pBoxNBC_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
                e.Effect = DragDropEffects.Copy;
        }

        private void lblSafari_MouseDown(object sender, MouseEventArgs e)
        {
            selectedAnswer = "Safari";
            Label lblSafari = (Label)sender;
            lblSafari.DoDragDrop(lblSafari.Text, DragDropEffects.Copy);
            lblSafari.Text = "";
        }

        private void lblFirefox_MouseDown(object sender, MouseEventArgs e)
        {
            selectedAnswer = "Firefox";
            Label lblFirefox = (Label)sender;
            lblFirefox.DoDragDrop(lblFirefox.Text, DragDropEffects.Copy);
            lblFirefox.Text = "";
        }

        private void pBoxFirefox_DragDrop(object sender, DragEventArgs e)
        {
            if (selectedAnswer.Equals("Firefox"))
            {
                MessageBox.Show("Correct!");
                score.getScore++;
            }
            else
            {
                MessageBox.Show("Incorrect!");
            }
            loadLogos();
        }

        private void pBoxFirefox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
                e.Effect = DragDropEffects.Copy;
        }

        private void lblYoutube_MouseDown(object sender, MouseEventArgs e)
        {
            selectedAnswer = "Youtube";
            Label lblYoutube = (Label)sender;
            lblYoutube.DoDragDrop(lblYoutube.Text, DragDropEffects.Copy);
            lblYoutube.Text = "";
        }

        private void lblPlaytube_MouseDown(object sender, MouseEventArgs e)
        {
            selectedAnswer = "Playtube";
            Label lblPlaytube = (Label)sender;
            lblPlaytube.DoDragDrop(lblPlaytube.Text, DragDropEffects.Copy);
            lblPlaytube.Text = "";
        }

        private void pBoxYoutube_DragDrop(object sender, DragEventArgs e)
        {
            if (selectedAnswer.Equals("Youtube"))
            {
                MessageBox.Show("Correct!");
                score.getScore++;
            }
            else
            {
                MessageBox.Show("Incorrect!");
            }
            loadLogos();
        }

        private void pBoxYoutube_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
                e.Effect = DragDropEffects.Copy;
        }

        private void lblFiat_MouseDown(object sender, MouseEventArgs e)
        {
            selectedAnswer = "Fiat";
            Label lblFiat = (Label)sender;
            lblFiat.DoDragDrop(lblFiat.Text, DragDropEffects.Copy);
            lblFiat.Text = "";
        }

        private void lblFarah_MouseDown(object sender, MouseEventArgs e)
        {
            selectedAnswer = "Farah";
            Label lblFarah = (Label)sender;
            lblFarah.DoDragDrop(lblFarah.Text, DragDropEffects.Copy);
            lblFarah.Text = "";
        }

        private void pBoxFarah_DragDrop(object sender, DragEventArgs e)
        {
            if (selectedAnswer.Equals("Farah"))
            {
                MessageBox.Show("Correct!");
                score.getScore++;
            }
            else
            {
                MessageBox.Show("Incorrect!");
            }
            loadLogos();
        }

        private void pBoxFarah_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
                e.Effect = DragDropEffects.Copy;
        }

        private void pBoxWindows_DragDrop(object sender, DragEventArgs e)
        {
            if (selectedAnswer.Equals("Windows"))
            {
                MessageBox.Show("Correct!");
                score.getScore++;
            }
            else
            {
                MessageBox.Show("Incorrect!");
            }
            loadLogos();
        }

        private void pBoxWindows_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
                e.Effect = DragDropEffects.Copy;
        }

        private void lblMicrosoft_MouseDown(object sender, MouseEventArgs e)
        {
            selectedAnswer = "Microsoft";
            Label lblMicrosoft = (Label)sender;
            lblMicrosoft.DoDragDrop(lblMicrosoft.Text, DragDropEffects.Copy);
            lblMicrosoft.Text = "";
        }

        private void lblWindows_MouseDown(object sender, MouseEventArgs e)
        {
            selectedAnswer = "Windows";
            Label lblWindows = (Label)sender;
            lblWindows.DoDragDrop(lblWindows.Text, DragDropEffects.Copy);
            lblWindows.Text = "";
        }

        private void lblAllianz_MouseDown(object sender, MouseEventArgs e)
        {
            selectedAnswer = "Allianz";
            Label lblAllianz = (Label)sender;
            lblAllianz.DoDragDrop(lblAllianz.Text, DragDropEffects.Copy);
            lblAllianz.Text = "";
        }

        private void lblHalifax_MouseDown(object sender, MouseEventArgs e)
        {
            selectedAnswer = "Halifax";
            Label lblhalifax = (Label)sender;
            lblhalifax.DoDragDrop(lblhalifax.Text, DragDropEffects.Copy);
            lblhalifax.Text = "";
        }

        private void pBoxAllianz_DragDrop(object sender, DragEventArgs e)
        {
            if (selectedAnswer.Equals("Allianz"))
            {
                MessageBox.Show("Correct!");
                score.getScore++;
            }
            else
            {
                MessageBox.Show("Incorrect!");
            }
            loadLogos();
        }

        private void pBoxAllianz_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
                e.Effect = DragDropEffects.Copy;
        }

        private void pBoxKFC_DragDrop(object sender, DragEventArgs e)
        {
            if (selectedAnswer.Equals("KFC"))
            {
                MessageBox.Show("Correct!");
                score.getScore++;
            }
            else
            {
                MessageBox.Show("Incorrect!");
            }
            loadLogos();
        }

        private void pBoxKFC_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
                e.Effect = DragDropEffects.Copy;
        }

        private void lblWWF_MouseDown(object sender, MouseEventArgs e)
        {
            selectedAnswer = "WWF";
            Label lblWWF = (Label)sender;
            lblWWF.DoDragDrop(lblWWF.Text, DragDropEffects.Copy);
            lblWWF.Text = "";
        }

        private void lblPPA_MouseDown(object sender, MouseEventArgs e)
        {
            selectedAnswer = "PPA";
            Label lblPPA = (Label)sender;
            lblPPA.DoDragDrop(lblPPA.Text, DragDropEffects.Copy);
            lblPPA.Text = "";
        }

        private void pBoxWWF_DragDrop(object sender, DragEventArgs e)
        {
            if (selectedAnswer.Equals("WWF"))
            {
                MessageBox.Show("Correct!");
                score.getScore++;
            }
            else
            {
                MessageBox.Show("Incorrect!");
            }
            loadLogos();
        }                                        

        private void pBoxWWF_DragLeave(object sender, EventArgs e)
        {
            
        }

        private void pBoxWWF_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
                e.Effect = DragDropEffects.Copy;
        }

        private void pBoxUnilever_Click(object sender, EventArgs e)
        {

        }

        private void pBoxFirefox_Click(object sender, EventArgs e)
        {

        }

        private void lblFirefox_Click(object sender, EventArgs e)
        {

        }

        private void lblMicrosoft_Click(object sender, EventArgs e)
        {

        }

        private void pBoxWWF_Click(object sender, EventArgs e)
        {

        }

        private void GboxDunlop_Enter(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            FrmMainPg fmp = new FrmMainPg(username);
            ActiveForm.Hide();
            fmp.Show();
            fmp.Size = new Size(798, 545);
        }

        private void lblChanel_Click(object sender, EventArgs e)
        {
            
        }

    }
}
