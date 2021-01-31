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
    public partial class FrmLetter : Form
    {
        Random rand = new Random();
        int quNumber = 0;
        List<int> questions = new List<int>();

        int BoeingWrong = 0;
        int BTWrong = 0;
        int EtihadWrong = 0;
        int GatoradeWrong = 0;
        int HankookWrong = 0;
        int IsuzuWrong = 0;
        int KappaWrong = 0;
        int MontBlancWrong = 0;
        int SoundCloudWrong = 0;
        int StaedtlerWrong = 0;
        

        public FrmLetter()
        {
            InitializeComponent();
            loadLogos();
        }
        private void hideAllGroupBoxes()
        {
            gBoxBoeing1.Visible = false;
            gBoxBT2.Visible = false;
            gBoxEtihad3.Visible = false;
            gBoxGatorade4.Visible = false;
            gBoxHankook5.Visible = false;
            gBoxIsuzu6.Visible = false;
            gBoxKappa7.Visible = false;
            gBoxMontBlanc8.Visible = false;
            gBoxSoundCloud9.Visible = false;
            gBoxStaedtler10.Visible = false;
        }

        bool BoeingB = false;
        bool BoeingO = false;
        bool BoeingE = false;
        bool BoeingI = false;
        bool BoeingN = false;
        bool BoeingG = false;

        bool btB = false;
        bool btT = false;

        bool EtihadE = false;
        bool EtihadT = false;
        bool EtihadI = false;
        bool EtihadH = false;
        bool EtihadA = false;
        bool EtihadD = false;

        bool GatoradeG = false;
        bool GatoradeA = false;
        bool GatoradeT = false;
        bool GatoradeO = false;
        bool GatoradeR = false;
        bool GatoradeA2 = false;
        bool GatoradeD = false;
        bool GatoradeE = false;

        bool HankookH = false;
        bool HankookA = false;
        bool HankookN = false;
        bool HankookK = false;
        bool HankookO = false;
        bool HankookO2 = false;
        bool HankookK2 = false;

        bool IsuzuI = false;
        bool IsuzuS = false;
        bool IsuzuU = false;
        bool IsuzuZ = false;
        bool IsuzuU2 = false;

        bool KappaK = false;
        bool KappaA = false;
        bool KappaP = false;
        bool KappaP2 = false;
        bool KappaA2 = false;

        bool MontBlancM = false;
        bool MontBlancO = false;
        bool MontBlancN = false;
        bool MontBlancT = false;
        bool MontBlancB = false;
        bool MontBlancL = false;
        bool MontBlancA = false;
        bool MontBlancN2 = false;
        bool MontBlancC = false;

        bool SoundCloudS = false;
        bool SoundCloudO = false;
        bool SoundCloudU = false;
        bool SoundCloudN = false;
        bool SoundCloudD = false;
        bool SoundCloudC = false;
        bool SoundCloudL = false;
        bool SoundCloudO2 = false;
        bool SoundCloudU2 = false;
        bool SoundCloudD2 = false;

        bool StaedtlerS = false;
        bool StaedtlerT = false;
        bool StaedtlerA = false;
        bool StaedtlerE = false;
        bool StaedtlerD = false;
        bool StaedtlerT2 = false;
        bool StaedtlerL = false;
        bool StaedtlerE2 = false;
        bool StaedtlerR = false;




        private void loadLogos()
        {
            do
            {
               quNumber = rand.Next(1, 11);
            }
            while (questions.Contains(quNumber));
            questions.Add(quNumber);

            switch (quNumber)
            {
                case 1:
                    hideAllGroupBoxes();
                    gBoxBoeing1.Visible = true;
                    gBoxBoeing1.Size = new Size(416, 386);
                    gBoxBoeing1.Location = new Point(180, 100);
                    break;
                case 2:
                    hideAllGroupBoxes();
                    gBoxBT2.Visible = true;
                    gBoxBT2.Size = new Size(416, 386);
                    gBoxBT2.Location = new Point(180, 100);
                    break;
                case 3:
                    hideAllGroupBoxes();
                    gBoxEtihad3.Visible = true;
                    gBoxEtihad3.Size = new Size(416, 386);
                    gBoxEtihad3.Location = new Point(180, 100);
                    break;
                case 4:
                    hideAllGroupBoxes();
                    gBoxGatorade4.Visible = true;
                    gBoxGatorade4.Size = new Size(416, 386);
                    gBoxGatorade4.Location = new Point(180, 100);
                    break;
                case 5:
                    hideAllGroupBoxes();
                    gBoxHankook5.Visible = true;
                    gBoxHankook5.Size = new Size(416, 386);
                    gBoxHankook5.Location = new Point(180, 100);
                    break;
                case 6:
                    hideAllGroupBoxes();
                    gBoxIsuzu6.Visible = true;
                    gBoxIsuzu6.Size = new Size(416, 261);
                    gBoxIsuzu6.Location = new Point(180, 106);
                    break;
                case 7:
                    hideAllGroupBoxes();
                    gBoxKappa7.Visible = true;
                    gBoxKappa7.Size = new Size(416, 386);
                    gBoxKappa7.Location = new Point(180, 100);
                    break;
                case 8:
                    hideAllGroupBoxes();
                    gBoxMontBlanc8.Visible = true;
                    gBoxMontBlanc8.Size = new Size(416, 386);
                    gBoxMontBlanc8.Location = new Point(180, 100);
                    break;
                case 9:
                    hideAllGroupBoxes();
                    gBoxSoundCloud9.Visible = true;
                    gBoxSoundCloud9.Size = new Size(416, 386);
                    gBoxSoundCloud9.Location = new Point(180, 100);
                    break;
                case 10:
                    hideAllGroupBoxes();
                    gBoxStaedtler10.Visible = true;
                    gBoxStaedtler10.Size = new Size(416, 386);
                    gBoxStaedtler10.Location = new Point(180, 100);
                    break;
            }
            if(quNumber == 6)
            {
                FrmLevelSelect fls = new FrmLevelSelect();
                ActiveForm.Hide();
                fls.Show();
            }
        }
            
        private void checkgBoxBoeing()
        {
            if(BoeingB == true && BoeingO == true && BoeingE == true &&  BoeingI == true && BoeingN == true && BoeingG == true)
            {
                quNumber++;
                MessageBox.Show("Correct");
                loadLogos();
            }
            if(BoeingWrong == 3)
            {
                MessageBox.Show("Too many incorrect answers!");
                quNumber++;                    
                loadLogos();
            }
        }
        private void checkgBoxBT()
        {
            if(btB == true && btT == true)
            {
                quNumber++;
                MessageBox.Show("Correct");
                loadLogos();
            }
            if(BTWrong == 3)
            {
                MessageBox.Show("Too many incorrect answers!");
                quNumber++;
                loadLogos();
            }
        }
        private void checkgBoxEtihad()
        {
            if (EtihadE == true && EtihadT == true && EtihadI == true && EtihadH == true && EtihadA == true && EtihadD == true)
            {
                quNumber++;
                MessageBox.Show("Correct");
                loadLogos();
            }
            if(EtihadWrong == 3)
            {
                MessageBox.Show("Too many incorrect answers!");
                loadLogos();
                quNumber++;
            }
        }
        private void checkgBoxGatorade()
        {
            if(GatoradeG == true && GatoradeA == true && GatoradeT == true && GatoradeO == true && GatoradeR == true && GatoradeA2 == true && GatoradeD == true && GatoradeE == true)
            {
                MessageBox.Show("Correct");
                loadLogos();
                quNumber++;
            }
            if(GatoradeWrong == 3)
            {
                MessageBox.Show("Too many incorrect answers!");
                quNumber++;
                loadLogos();
            }
        }
        private void checkgBoxHankook()
        {
            if(HankookH == true && HankookA == true && HankookN == true && HankookK == true && HankookO == true && HankookO2 == true && HankookK2 == true)
            {
                quNumber++;
                MessageBox.Show("Correct");
                loadLogos();
            }
            if(HankookWrong == 3)
            {
                MessageBox.Show("Too many incorrect answers!");
                quNumber++;
                loadLogos();
            }
        }
        private void checkgBoxIsuzu()
        {
            if(IsuzuI == true && IsuzuS == true && IsuzuU == true && IsuzuZ == true && IsuzuU2 == true)
            {
                quNumber++;
                MessageBox.Show("Correct!");
                loadLogos();
            }
            if(IsuzuWrong == 3)
            {
                MessageBox.Show("Too many incorrect answers!");
                quNumber++;
                loadLogos();
            }
        }
        private void checkgBoxKappa()
        {
            if(KappaK == true && KappaA == true && KappaP == true && KappaP2 == true && KappaA2 == true)
            {
                quNumber++;
                MessageBox.Show("Correct!");
                loadLogos();
            }
            if(KappaWrong == 3)
            {
                MessageBox.Show("Too many incorrect answers!");
                quNumber++;
                loadLogos();
            }
        }
        private void checkgBoxMontBlanc()
        {
            if(MontBlancM == true && MontBlancO == true && MontBlancN== true && MontBlancT == true && MontBlancB == true && MontBlancL == true && MontBlancA == true && MontBlancN2 == true && MontBlancC== true)
            {
                quNumber++;
                MessageBox.Show("Correct!");
                loadLogos();
            }
            if(MontBlancWrong == 3)
            {
                MessageBox.Show("Too many incorrect answers!");
                quNumber++;
                loadLogos();
            }
        }
        private void checkgBoxSoundCloud()
        {
            if (SoundCloudS == true && SoundCloudO == true && SoundCloudU== true && SoundCloudN == true && SoundCloudD == true && SoundCloudC == true && SoundCloudL == true && SoundCloudO2 == true && SoundCloudU2 == true && SoundCloudD2 == true)
            {
                quNumber++;
                MessageBox.Show("Correct!");
                loadLogos();
            }
            if (SoundCloudWrong == 3)
            {
                MessageBox.Show("Too many incorrect answers!");
                quNumber++;
                loadLogos();
            }
        }
        private void checkgBoxStaedtler()
        {
            if (StaedtlerS == true && StaedtlerT == true && StaedtlerA == true && StaedtlerE == true && StaedtlerD == true && StaedtlerT2 == true && StaedtlerL == true && StaedtlerE2 == true && StaedtlerR == true)
            {
                quNumber++;
                MessageBox.Show("Correct!");
                loadLogos();
            }
            if (StaedtlerWrong == 3)
            {
                MessageBox.Show("Too many incorrect answers!");
                quNumber++;
                loadLogos();
            }
        }

        private void FrmLetter_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void gBox_Enter(object sender, EventArgs e)
        {

        }

        private void lblD4_Click(object sender, EventArgs e)
        {

        }

        private void lblGd_Click(object sender, EventArgs e)
        {
            lblG4.Visible = true;
            lblGd.Visible = false;
            GatoradeG = true;
            checkgBoxGatorade();
        }

        private void lblDd_Click(object sender, EventArgs e)
        {
            lblD4.Visible = true;
            lblDd.Visible = false;
            GatoradeD = true;
            checkgBoxGatorade();
        }

        private void lblSd_Click(object sender, EventArgs e)
        {
            lblSd.Visible = false;
            MessageBox.Show("Incorrect!");
            GatoradeWrong++;
            checkgBoxGatorade();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblMj_Click(object sender, EventArgs e)
        {
            lblM10.Visible = true;
            lblMj.Visible = false;
            MontBlancM = true;
            checkgBoxMontBlanc();
        }

        private void lblPj_Click(object sender, EventArgs e)
        {
            lblPj.Visible = false;
            MessageBox.Show("Incorrect!");
            MontBlancWrong++;
            checkgBoxMontBlanc();
        }

        private void lblNj_Click(object sender, EventArgs e)
        {
            lblN10.Visible = true;
            lblNj.Visible = false;
            MontBlancN = true;
            checkgBoxMontBlanc();
        }

        private void lblKj_Click(object sender, EventArgs e)
        {
            lblKj.Visible = false;
            MessageBox.Show("Incorrect!");
            MontBlancWrong++;
            checkgBoxMontBlanc();
        }

        private void lblEj_Click(object sender, EventArgs e)
        {
            lblEj.Visible = false;
            MessageBox.Show("Incorrect!");
            MontBlancWrong++;
            checkgBoxMontBlanc();
        }

        private void lblAj_Click(object sender, EventArgs e)
        {
            lblA10.Visible = true;
            lblAj.Visible = false;
            MontBlancA = true;
            checkgBoxMontBlanc();
        }

        private void lblLj_Click(object sender, EventArgs e)
        {
            lblL10.Visible = true;
            lblLj.Visible = false;
            MontBlancL = true;
            checkgBoxMontBlanc();
        }

        private void lblBj_Click(object sender, EventArgs e)
        {
            lblB10.Visible = true;
            lblBj.Visible = false;
            MontBlancB = true;
            checkgBoxMontBlanc();
        }

        private void lblNja_Click(object sender, EventArgs e)
        {
            lblN10a.Visible = true;
            lblNja.Visible = false;
            MontBlancN2 = true;
            checkgBoxMontBlanc();
        }

        private void lblCj_Click(object sender, EventArgs e)
        {
            lblC10.Visible = true;
            lblCj.Visible = false;
            MontBlancC = true;
            checkgBoxMontBlanc();
        }

        private void lblTj_Click(object sender, EventArgs e)
        {
            lblT10.Visible = true;
            lblTj.Visible = false;
            MontBlancT = true;
            checkgBoxMontBlanc();
        }

        private void lblOj_Click(object sender, EventArgs e)
        {
            lblO10.Visible = true;
            lblOj.Visible = false;
            MontBlancO = true;
            checkgBoxMontBlanc();
        }

        private void lblM10_Click(object sender, EventArgs e)
        {

        }

        private void lblSi_Click(object sender, EventArgs e)
        {
            lblS9.Visible = true;
            lblSi.Visible = false;
            StaedtlerS = true;
            checkgBoxStaedtler();
        }

        private void lblTi_Click(object sender, EventArgs e)
        {
            lblT9.Visible = true;
            lblTi.Visible = false;
            StaedtlerT = true;
            checkgBoxStaedtler();
        }

        private void lblAi_Click(object sender, EventArgs e)
        {
            lblA9.Visible = true;
            lblAi.Visible = false;
            StaedtlerA = true;
            checkgBoxStaedtler();
        }

        private void lblEi_Click(object sender, EventArgs e)
        {
            lblE9.Visible = true;
            lblEi.Visible = false;
            StaedtlerE = true;
            checkgBoxStaedtler();
        }

        private void lblDi_Click(object sender, EventArgs e)
        {
            lblD9.Visible = true;
            lblDi.Visible = false;
            StaedtlerD = true;
            checkgBoxStaedtler();
        }

        private void lblTia_Click(object sender, EventArgs e)
        {
            lblT9a.Visible = true;
            lblTia.Visible = false;
            StaedtlerT2 = true;
            checkgBoxStaedtler();
        }

        private void lblLi_Click(object sender, EventArgs e)
        {
            lblL9.Visible = true;
            lblLi.Visible = false;
            StaedtlerL = true;
            checkgBoxStaedtler();
        }

        private void lblEia_Click(object sender, EventArgs e)
        {
            lblE9a.Visible = true;
            lblEia.Visible = false;
            StaedtlerE2 = true;
            checkgBoxStaedtler();
        }

        private void lblRi_Click(object sender, EventArgs e)
        {
            lblR9.Visible = true;
            lblRi.Visible = false;
            StaedtlerR = true;
            checkgBoxStaedtler();
        }

        private void lblVi_Click(object sender, EventArgs e)
        {
            lblVi.Visible = false;
            MessageBox.Show("Incorrect!");
            StaedtlerWrong++;
            checkgBoxStaedtler();
        }

        private void lblHi_Click(object sender, EventArgs e)
        {
            lblHi.Visible = false;
            MessageBox.Show("Incorrect!");
            StaedtlerWrong++;
            checkgBoxStaedtler();
        }

        private void lblBi_Click(object sender, EventArgs e)
        {
            lblBi.Visible = false;
            MessageBox.Show("Incorrect!");
            StaedtlerWrong++;
            checkgBoxStaedtler();
        }

        private void lblMi_Click(object sender, EventArgs e)
        {
            lblMi.Visible = false;
            MessageBox.Show("Incorrect!");
            StaedtlerWrong++;
            checkgBoxStaedtler();
        }

        private void lblIi_Click(object sender, EventArgs e)
        {
            lblIi.Visible = false;
            MessageBox.Show("Incorrect!");
            StaedtlerWrong++;
            checkgBoxStaedtler();
        }

        private void lblLc_Click(object sender, EventArgs e)
        {
            lblLc.Visible = false;
            MessageBox.Show("Incorrect!");
            EtihadWrong++;
            checkgBoxEtihad();
        }

        private void lblTc_Click(object sender, EventArgs e)
        {
            lblT3.Visible = true;
            lblTc.Visible = false;
            EtihadT = true;
            checkgBoxEtihad();
        }

        private void lblAc_Click(object sender, EventArgs e)
        {
            lblA3.Visible = true;
            lblAc.Visible = false;
            EtihadA = true;
            checkgBoxEtihad();
        }

        private void lblIc_Click(object sender, EventArgs e)
        {
            lblI3.Visible = true;
            lblIc.Visible = false;
            EtihadI = true;
            checkgBoxEtihad();
        }

        private void lblHc_Click(object sender, EventArgs e)
        {
            lblH3.Visible = true;
            lblHc.Visible = false;
            EtihadH = true;
            checkgBoxEtihad();
        }

        private void lblOc_Click(object sender, EventArgs e)
        {
            lblOc.Visible = false;
            MessageBox.Show("Incorrect!");
            EtihadWrong++;
            checkgBoxEtihad();
        }

        private void lblDc_Click(object sender, EventArgs e)
        {
            lblD3.Visible = true;
            lblDc.Visible = false;
            EtihadD = true;
            checkgBoxEtihad();
        }

        private void lblKc_Click(object sender, EventArgs e)
        {
            lblKc.Visible = false;
            MessageBox.Show("Incorrect!");
            EtihadWrong++;
            checkgBoxEtihad();
        }

        private void lblFc_Click(object sender, EventArgs e)
        {
            lblFc.Visible = false;
            MessageBox.Show("Incorrect!");
            EtihadWrong++;
            checkgBoxEtihad();
        }

        private void lblBc_Click(object sender, EventArgs e)
        {
            lblBc.Visible = false;
            MessageBox.Show("Incorrect!");
            EtihadWrong++;
            checkgBoxEtihad();
        }

        private void lblSc_Click(object sender, EventArgs e)
        {
            lblSc.Visible = false;
            MessageBox.Show("Incorrect!");
            EtihadWrong++;
            checkgBoxEtihad();
        }

        private void lblEc_Click(object sender, EventArgs e)
        {
            lblE3.Visible = true;
            lblEc.Visible = false;
            EtihadE = true;
            checkgBoxEtihad();
        }

        private void lblNc_Click(object sender, EventArgs e)
        {
            lblNc.Visible = false;
            MessageBox.Show("Incorrect!");
            EtihadWrong++;
            checkgBoxEtihad();
        }

        private void lblJc_Click(object sender, EventArgs e)
        {
            lblJc.Visible = false;
            MessageBox.Show("Incorrect!");
            EtihadWrong++;
            checkgBoxEtihad();
        }

        private void lblL8_Click(object sender, EventArgs e)
        {

        }

        private void lblSh_Click(object sender, EventArgs e)
        {
            lblS8.Visible = true;
            lblSh.Visible = false;
            SoundCloudS = true;
            checkgBoxSoundCloud();
        }

        private void lblOh_Click(object sender, EventArgs e)
        {
            lblO8.Visible = true;
            lblOh.Visible = false;
            SoundCloudO = true;
            checkgBoxSoundCloud();
        }

        private void lblNh_Click(object sender, EventArgs e)
        {
            lblN8.Visible = true;
            lblNh.Visible = false;
            SoundCloudN = true;
            checkgBoxSoundCloud();
        }

        private void lblPh_Click(object sender, EventArgs e)
        {
            lblPh.Visible = false;
            MessageBox.Show("Incorrect!");
            SoundCloudWrong++;
            checkgBoxSoundCloud();
        }

        private void lblDha_Click(object sender, EventArgs e)
        {
            lblD8a.Visible = true;
            lblDha.Visible = false;
            SoundCloudD2 = true;
            checkgBoxSoundCloud();
        }

        private void lblUh_Click(object sender, EventArgs e)
        {
            lblU8.Visible = true;
            lblUh.Visible = false;
            SoundCloudU = true;
            checkgBoxSoundCloud();
        }

        private void lblOha_Click(object sender, EventArgs e)
        {
            lblO8a.Visible = true;
            lblOha.Visible = false;
            SoundCloudO2 = true;
            checkgBoxSoundCloud();
        }

        private void lblEh_Click(object sender, EventArgs e)
        {
            lblEh.Visible = false;
            MessageBox.Show("Incorrect!");
            SoundCloudWrong++;
            checkgBoxSoundCloud();
        }

        private void lblDh_Click(object sender, EventArgs e)
        {
            lblD8.Visible = true;
            lblDh.Visible = false;
            SoundCloudD = true;
            checkgBoxSoundCloud();
        }

        private void lblAh_Click(object sender, EventArgs e)
        {
            lblAh.Visible = false;
            MessageBox.Show("Incorrect!");
            SoundCloudWrong++;
            checkgBoxSoundCloud();
        }

        private void lblCh_Click(object sender, EventArgs e)
        {
            lblC8.Visible = true;
            lblCh.Visible = false;
            SoundCloudC = true;
            checkgBoxSoundCloud();
        }

        private void lblUha_Click(object sender, EventArgs e)
        {
            lblU8a.Visible = true;
            lblUha.Visible = false;
            SoundCloudU2 = true;
            checkgBoxSoundCloud();
        }

        private void lblLh_Click(object sender, EventArgs e)
        {
            lblL8.Visible = true;
            lblLh.Visible = false;
            SoundCloudL = true;
            checkgBoxSoundCloud();
        }

        private void lblKh_Click(object sender, EventArgs e)
        {
            lblKh.Visible = false;
            MessageBox.Show("Incorrect!");
            SoundCloudWrong++;
            checkgBoxSoundCloud();
        }

        private void lblBb_Click(object sender, EventArgs e)
        {
            lblB2.Visible = true;
            lblBb.Visible = false;
            btB = true;
            checkgBoxBT();
        }

        private void lblTb_Click(object sender, EventArgs e)
        {
            lblT2.Visible = true;
            lblTb.Visible = false;
            btT = true;
            checkgBoxBT();
        }

        private void lblSb_Click(object sender, EventArgs e)
        {
            lblSb.Visible = false;
            MessageBox.Show("Incorrect!");
            BTWrong++;
            checkgBoxBT();
        }

        private void lblLb_Click(object sender, EventArgs e)
        {
            lblLb.Visible = false;
            MessageBox.Show("Incorrect!");
            BTWrong++;
            checkgBoxBT();
        }

        private void lblVb_Click(object sender, EventArgs e)
        {
            lblVb.Visible = false;
            MessageBox.Show("Incorrect!");
            BTWrong++;
            checkgBoxBT();
        }

        private void lblPb_Click(object sender, EventArgs e)
        {
            lblPb.Visible = false;
            MessageBox.Show("Incorrect!");
            BTWrong++;
            checkgBoxBT();
        }

        private void lblCb_Click(object sender, EventArgs e)
        {
            lblCb.Visible = false;
            MessageBox.Show("Incorrect!");
            BTWrong++;
            checkgBoxBT();
        }

        private void lblQb_Click(object sender, EventArgs e)
        {
            lblQb.Visible = false;
            MessageBox.Show("Incorrect!");
            BTWrong++;
            checkgBoxBT();
        }

        private void lblRb_Click(object sender, EventArgs e)
        {
            lblRb.Visible = false;
            MessageBox.Show("Incorrect!");
            BTWrong++;
            checkgBoxBT();
        }

        private void lblFb_Click(object sender, EventArgs e)
        {
            lblFb.Visible = false;
            MessageBox.Show("Incorrect!");
            BTWrong++;
            checkgBoxBT();
        }

        private void lblKg_Click(object sender, EventArgs e)
        {
            lblK7.Visible = true;
            lblKg.Visible = false;
            KappaK = true;
            checkgBoxKappa();
        }

        private void lblAga_Click(object sender, EventArgs e)
        {
            lblA7a.Visible = true;
            lblAga.Visible = false;
            KappaA2 = true;
            checkgBoxKappa();
        }

        private void lblPg_Click(object sender, EventArgs e)
        {
            lblP7.Visible = true;
            lblPg.Visible = false;
            KappaP = true;
            checkgBoxKappa();
        }

        private void lblPga_Click(object sender, EventArgs e)
        {
            lblP7a.Visible = true;
            lblPga.Visible = false;
            KappaP2 = true;
            checkgBoxKappa();
        }

        private void lblAg_Click(object sender, EventArgs e)
        {
            lblA7.Visible = true;
            lblAg.Visible = false;
            KappaA = true;
            checkgBoxKappa();
        }

        private void lblDg_Click(object sender, EventArgs e)
        {
            lblDg.Visible = false;
            MessageBox.Show("Incorrect!");
            KappaWrong++;
            checkgBoxKappa();
        }

        private void lblUg_Click(object sender, EventArgs e)
        {
            lblUg.Visible = false;
            MessageBox.Show("Incorrect!");
            KappaWrong++;
            checkgBoxKappa();
        }

        private void lblLg_Click(object sender, EventArgs e)
        {
            lblLg.Visible = false;
            MessageBox.Show("Incorrect!");
            KappaWrong++;
            checkgBoxKappa();
        }

        private void lblNg_Click(object sender, EventArgs e)
        {
            lblNg.Visible = false;
            MessageBox.Show("Incorrect!");
            KappaWrong++;
            checkgBoxKappa();
        }

        private void lblSg_Click(object sender, EventArgs e)
        {
            lblSg.Visible = false;
            MessageBox.Show("Incorrect!");
            KappaWrong++;
            checkgBoxKappa();
        }

        private void lblBg_Click(object sender, EventArgs e)
        {
            lblBg.Visible = false;
            MessageBox.Show("Incorrect!");
            KappaWrong++;
            checkgBoxKappa();
        }

        private void lblCg_Click(object sender, EventArgs e)
        {
            lblCg.Visible = false;
            MessageBox.Show("Incorrect!");
            KappaWrong++;
            checkgBoxKappa();
        }

        private void lblGg_Click(object sender, EventArgs e)
        {
            lblGg.Visible = false;
            MessageBox.Show("Incorrect!");
            KappaWrong++;
            checkgBoxKappa();
        }

        private void lblJg_Click(object sender, EventArgs e)
        {
            lblJg.Visible = false;
            MessageBox.Show("Incorrect!");
            KappaWrong++;
            checkgBoxKappa();
        }

        private void lblBa_Click(object sender, EventArgs e)
        {
            lblB1.Visible = true;
            lblBa.Visible = false;
            BoeingB = true;
            checkgBoxBoeing();
        }

        private void lblOa_Click(object sender, EventArgs e)
        {
            lblO1.Visible = true;
            lblOa.Visible = false;
            BoeingO = true;
            checkgBoxBoeing();
        }

        private void lblEa_Click(object sender, EventArgs e)
        {
            lblE1.Visible = true;
            lblEa.Visible = false;
            BoeingE = true;
            checkgBoxBoeing();
        }

        private void lblIa_Click(object sender, EventArgs e)
        {
            lblI1.Visible = true;
            lblIa.Visible = false;
            BoeingI = true;
            checkgBoxBoeing();
        }

        private void lblNa_Click(object sender, EventArgs e)
        {
            lblN1.Visible = true;
            lblNa.Visible = false;
            BoeingN = true;
            checkgBoxBoeing();
        }

        private void lblGa_Click(object sender, EventArgs e)
        {
            lblG1.Visible = true;
            lblGa.Visible = false;
            BoeingG = true;
            checkgBoxBoeing();
        }

        private void lblFa_Click(object sender, EventArgs e)
        {
            lblFa.Visible = false;
            MessageBox.Show("Incorrect!");
            BoeingWrong++;
            checkgBoxBoeing();
        }

        private void lblCa_Click(object sender, EventArgs e)
        {
            lblCa.Visible = false;
            MessageBox.Show("Incorrect!");
            BoeingWrong++;
            checkgBoxBoeing();
        }

        private void lblAa_Click(object sender, EventArgs e)
        {
            lblAa.Visible = false;
            MessageBox.Show("Incorrect!");
            BoeingWrong++;
            checkgBoxBoeing();
        }

        private void lblKa_Click(object sender, EventArgs e)
        {
            lblKa.Visible = false;
            MessageBox.Show("Incorrect!");
            BoeingWrong++;
            checkgBoxBoeing();
        }

        private void lblUa_Click(object sender, EventArgs e)
        {
            lblUa.Visible = false;
            MessageBox.Show("Incorrect!");
            BoeingWrong++;
            checkgBoxBoeing();
        }

        private void lblTa_Click(object sender, EventArgs e)
        {
            lblTa.Visible = false;
            MessageBox.Show("Incorrect!");
            BoeingWrong++;
            checkgBoxBoeing();
        }

        private void lblHa_Click(object sender, EventArgs e)
        {
            lblHa.Visible = false;
            MessageBox.Show("Incorrect!");
            BoeingWrong++;
            checkgBoxBoeing();
        }

        private void lblZa_Click(object sender, EventArgs e)
        {
            lblZa.Visible = false;
            MessageBox.Show("Incorrect!");
            BoeingWrong++;
            checkgBoxBoeing();
        }

        private void lblHe_Click(object sender, EventArgs e)
        {
            lblH5.Visible = true;
            lblHe.Visible = false;
            HankookH = true;
            checkgBoxHankook();
        }

        private void lblAe_Click(object sender, EventArgs e)
        {
            lblA5.Visible = true;
            lblAe.Visible = false;
            HankookA = true;
            checkgBoxHankook();
        }

        private void lblNe_Click(object sender, EventArgs e)
        {
            lblN5.Visible = true;
            lblNe.Visible = false;
            HankookN = true;
            checkgBoxHankook();
        }

        private void lblKe_Click(object sender, EventArgs e)
        {
            lblK5.Visible = true;
            lblKe.Visible = false;
            HankookK = true;
            checkgBoxHankook();
        }

        private void lblOe_Click(object sender, EventArgs e)
        {
            lblO5.Visible = true;
            lblOe.Visible = false;
            HankookO = true;
            checkgBoxHankook();
        }

        private void lblOea_Click(object sender, EventArgs e)
        {
            lblO5a.Visible = true;
            lblOea.Visible = false;
            HankookO2 = true;
            checkgBoxHankook();
        }

        private void lblKea_Click(object sender, EventArgs e)
        {
            lblK5a.Visible = true;
            lblKea.Visible = false;
            HankookK2 = true;
            checkgBoxHankook();
        }

        private void lblJe_Click(object sender, EventArgs e)
        {
            lblJe.Visible = false;
            MessageBox.Show("Incorrect!");
            HankookWrong++;
            checkgBoxHankook();
        }

        private void lblFe_Click(object sender, EventArgs e)
        {
            lblFe.Visible = false;
            MessageBox.Show("Incorrect!");
            HankookWrong++;
            checkgBoxHankook();
        }

        private void lblBe_Click(object sender, EventArgs e)
        {
            lblBe.Visible = false;
            MessageBox.Show("Incorrect!");
            HankookWrong++;
            checkgBoxHankook();
        }

        private void lblXe_Click(object sender, EventArgs e)
        {
            lblXe.Visible = false;
            MessageBox.Show("Incorrect!");
            HankookWrong++;
            checkgBoxHankook();
        }

        private void lblTe_Click(object sender, EventArgs e)
        {
            lblTe.Visible = false;
            MessageBox.Show("Incorrect!");
            HankookWrong++;
            checkgBoxHankook();
        }

        private void lblWe_Click(object sender, EventArgs e)
        {
            lblWe.Visible = false;
            MessageBox.Show("Incorrect!");
            HankookWrong++;
            checkgBoxHankook();
        }

        private void lblMe_Click(object sender, EventArgs e)
        {
            lblMe.Visible = false;
            MessageBox.Show("Incorrect!");
            HankookWrong++;
            checkgBoxHankook();
        }

        private void lblAd_Click(object sender, EventArgs e)
        {
            lblA4.Visible = true;
            lblAd.Visible = false;
            GatoradeA = true;
            checkgBoxGatorade();
        }

        private void lblTd_Click(object sender, EventArgs e)
        {
            lblT4.Visible = true;
            lblTd.Visible = false;
            GatoradeT = true;
            checkgBoxGatorade();
        }

        private void lblOd_Click(object sender, EventArgs e)
        {
            lblO4.Visible = true;
            lblOd.Visible = false;
            GatoradeO = true;
            checkgBoxGatorade();
        }

        private void lblRd_Click(object sender, EventArgs e)
        {
            lblR4.Visible = true;
            lblRd.Visible = false;
            GatoradeR = true;
            checkgBoxGatorade();
        }

        private void lblAda_Click(object sender, EventArgs e)
        {
            lblA4a.Visible = true;
            lblAda.Visible = false;
            GatoradeA2 = true;
            checkgBoxGatorade();
        }

        private void lblEd_Click(object sender, EventArgs e)
        {
            lblE4.Visible = true;
            lblEd.Visible = false;
            GatoradeE = true;
            checkgBoxGatorade();
        }

        private void lblFd_Click(object sender, EventArgs e)
        {
            lblFd.Visible = false;
            MessageBox.Show("Incorrect!");
            GatoradeWrong++;
            checkgBoxGatorade();
        }

        private void lblUd_Click(object sender, EventArgs e)
        {
            lblUd.Visible = false;
            MessageBox.Show("Incorrect!");
            GatoradeWrong++;
            checkgBoxGatorade();
        }

        private void lblHd_Click(object sender, EventArgs e)
        {
            lblHd.Visible = false;
            MessageBox.Show("Incorrect!");
            GatoradeWrong++;
            checkgBoxGatorade();
        }

        private void lblId_Click(object sender, EventArgs e)
        {
            lblId.Visible = false;
            MessageBox.Show("Incorrect!");
            GatoradeWrong++;
            checkgBoxGatorade();
        }

        private void lblNd_Click(object sender, EventArgs e)
        {
            lblNd.Visible = false;
            MessageBox.Show("Incorrect!");
            GatoradeWrong++;
            checkgBoxGatorade();
        }

        private void lblIf_Click(object sender, EventArgs e)
        {
            lblI6.Visible = true;
            lblIf.Visible = false;
            IsuzuI = true;
            checkgBoxIsuzu();
        }

        private void lblSf_Click(object sender, EventArgs e)
        {
            lblS6.Visible = true;
            lblSf.Visible = false;
            IsuzuS = true;
            checkgBoxIsuzu();
        }

        private void lblUf_Click(object sender, EventArgs e)
        {
            lblU6.Visible = true;
            lblUf.Visible = false;
            IsuzuU = true;
            checkgBoxIsuzu();
        }

        private void lblZf_Click(object sender, EventArgs e)
        {
            lblZ6.Visible = true;
            lblZf.Visible = false;
            IsuzuZ = true;
            checkgBoxIsuzu();
        }

        private void lblUfa_Click(object sender, EventArgs e)
        {
            lblU6a.Visible = true;
            lblUfa.Visible = false;
            IsuzuU2 = true;
            checkgBoxIsuzu();
        }

        private void lblOf_Click(object sender, EventArgs e)
        {
            lblOf.Visible = false;
            MessageBox.Show("Incorrect!");
            IsuzuWrong++;
            checkgBoxIsuzu();
        }

        private void lblAf_Click(object sender, EventArgs e)
        {
            lblAf.Visible = false;
            MessageBox.Show("Incorrect!");
            IsuzuWrong++;
            checkgBoxIsuzu();
        }

        private void lblNf_Click(object sender, EventArgs e)
        {
            lblNf.Visible = false;
            MessageBox.Show("Incorrect!");
            IsuzuWrong++;
            checkgBoxIsuzu();
        }

        private void lblRf_Click(object sender, EventArgs e)
        {
            lblRf.Visible = false;
            MessageBox.Show("Incorrect!");
            IsuzuWrong++;
            checkgBoxIsuzu();
        }

        private void lblHf_Click(object sender, EventArgs e)
        {
            lblHf.Visible = false;
            MessageBox.Show("Incorrect!");
            IsuzuWrong++;
            checkgBoxIsuzu();
        }

        private void lblDf_Click(object sender, EventArgs e)
        {
            lblDf.Visible = false;
            MessageBox.Show("Incorrect!");
            IsuzuWrong++;
            checkgBoxIsuzu();
        }

        private void lblYf_Click(object sender, EventArgs e)
        {
            lblYf.Visible = false;
            MessageBox.Show("Incorrect!");
            IsuzuWrong++;
            checkgBoxIsuzu();
        }

        private void lblA4_Click(object sender, EventArgs e)
        {
            lblA4.Visible = true;
            lblAd.Visible = false;
            GatoradeA = true;
            checkgBoxGatorade();
        }

        private void pBoxKappa_Click(object sender, EventArgs e)
        {

        }

        private void lblA7a_Click(object sender, EventArgs e)
        {

        }

        private void lblP7a_Click(object sender, EventArgs e)
        {

        }

        private void lblP7_Click(object sender, EventArgs e)
        {

        }

        private void lblA7_Click(object sender, EventArgs e)
        {

        }

        private void lblK7_Click(object sender, EventArgs e)
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
   