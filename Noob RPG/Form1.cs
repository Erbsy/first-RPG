using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Noob_RPG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int PlayerHP = 100;
        int PlayerAttack = 10;
        int PlayerMaxHP = 100;
        int PlayerGold;

        int EnemyMaxHP = 100;
        int EnemyHP = 100;


        //private int _enemyHp;
        //public int EnemyHp
        //{
        //    get
        //    {
        //        return _enemyHp;
        //    }
        //    set
        //    {
        //        _enemyHp = value;
        //        ShowEnemyHP();
        //    }

        //}


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowEnemyHP();
            LblAnzeigeHPSpieler.Text = PlayerHP + "/" + PlayerMaxHP;
            ShowPlayerGold();
        }

        private void ShowPlayerGold()
        {
            LblAnzeigeGold.Text = "Gold " + PlayerGold.ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void CmdAngriff_Click(object sender, EventArgs e)
        {
            //  , Gegner tut nichtss
            // Gegener greift danach an, Schaden senkt Spieler Hp um: , Spieler tut nichts
            // LblAnzeige beider sinkt und wird direkt angezeigt 95/100
            EnemyHP = EnemyHP - PlayerAttack;

            ShowEnemyHP();

            if (EnemyHP <= 0)
            {
                pictureBox1.Visible = false;
                LblAnzeigeHPGegner.Visible = false;
                CmdAngriff.Enabled = false;

                MessageBox.Show("Gewonnen !", "Gegner Besiegt");

                PlayerGold += 10;
                ShowPlayerGold();

                NewEnemy();
            }
        }

        private void NewEnemy()
        {
            EnemyHP = EnemyMaxHP;
            pictureBox1.Visible = true;
            LblAnzeigeHPGegner.Visible = true;
            CmdAngriff.Enabled = true;

            ShowEnemyHP ();

        }

        private void ShowEnemyHP()
        {
            LblAnzeigeHPGegner.Text = EnemyHP + "/" + EnemyMaxHP;
        }


    }
}
