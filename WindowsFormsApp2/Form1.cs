using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Threading;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;
using System.Media;
using System.Deployment.Application;

namespace WindowsFormsApp2
{
    public partial class PointAndClickGame : Form
    {
        int arrowSize = 60;
        int page = 1;
        int monsterSide;
        int lockNum1 = 0;
        int lockNum2 = 0;
        int lockNum3 = 0;
        int lockNum4 = 0;

        bool attacked = false;
        Random randGen = new Random();

        public PointAndClickGame()
        {
            InitializeComponent();

            #region initializedVisibility
            monsterImage.Visible = false;
            noButton.Visible = false;
            yesButton.Visible = false;
            gameOverText.Visible = false;
            computerText.Visible = false;

            lock1.Visible = false;
            lock2.Visible = false;
            lock3.Visible = false;
            lock4.Visible = false;

            arrowLeft.Visible = false;
            arrowDown.Visible = false;
            arrowRight.Visible = false;
            arrowUp.Visible = true;

            passwordInput.Visible = false;
            enterButton.Visible = false;
            flowerImage.Visible = false;
            #endregion
            this.BackgroundImage = Properties.Resources.page1;
            monsterSide = randGen.Next(1, 3);
        }
        #region comboLock
        private void lock1_Click(object sender, EventArgs e)
        {
            SoundPlayer lockdSound = new SoundPlayer(Properties.Resources.lockSound);
            lockdSound.Play();
            lockNum1++;
            if (lockNum1 > 9)
            {
                lockNum1 = 0;
            }
            lock1.Text = $"{lockNum1}";
            if (lockNum1 == 1 && lockNum2 == 1 && lockNum3 == 3 && lockNum4 == 0)
            {
                SoundPlayer unlockSound = new SoundPlayer(Properties.Resources.unlockSound);
                unlockSound.Play();
                showUp();
            }
        }
        private void lock2_Click(object sender, EventArgs e)
        {
            SoundPlayer lockdSound = new SoundPlayer(Properties.Resources.lockSound);
            lockdSound.Play();
            lockNum2++;
            if (lockNum2 > 9)
            {
                lockNum2 = 0;
            }
            lock2.Text = $"{lockNum2}";
            if (lockNum1 == 1 && lockNum2 == 1 && lockNum3 == 3 && lockNum4 == 0)
            {
                SoundPlayer unlockSound = new SoundPlayer(Properties.Resources.unlockSound);
                unlockSound.Play();
                showUp();
            }
        }
        private void lock3_Click(object sender, EventArgs e)
        {
            SoundPlayer lockdSound = new SoundPlayer(Properties.Resources.lockSound);
            lockdSound.Play();
            lockNum3++;
            if (lockNum3 > 9)
            {
                lockNum3 = 0;
            }
            lock3.Text = $"{lockNum3}";
            if (lockNum1 == 1 && lockNum2 == 1 && lockNum3 == 3 && lockNum4 == 0)
            {
                SoundPlayer unlockSound = new SoundPlayer(Properties.Resources.unlockSound);
                unlockSound.Play();
                showUp();
            }
        }
        private void lock4_Click(object sender, EventArgs e)
        {
            SoundPlayer lockdSound = new SoundPlayer(Properties.Resources.lockSound);
            lockdSound.Play();
            lockNum4++;
            if (lockNum4 > 9)
            {
                lockNum4 = 0;
            }
            lock4.Text = $"{lockNum4}";
            if (lockNum1 == 1 && lockNum2 == 1 && lockNum3 == 3 && lockNum4 == 0)
            {
                SoundPlayer unlockSound = new SoundPlayer(Properties.Resources.unlockSound);
                unlockSound.Play();
                showUp();
            }
        }
        void lockReset()
        {
            lockNum1 = 0;
            lockNum2 = 0;
            lockNum3 = 0;
            lockNum4 = 0;
            lock1.Text = $"{lockNum1}";
            lock2.Text = $"{lockNum2}";
            lock3.Text = $"{lockNum3}";
            lock4.Text = $"{lockNum4}";
        }
        #endregion
        #region triggeredNavigation
        private void arrowUp_Click(object sender, EventArgs e)
        {
            SoundPlayer clickSound = new SoundPlayer(Properties.Resources.clickSound);
            clickSound.Play();

            if (page == 1)
            {
                page = 2;
            }
            else if (page == 2)
            {
                page = 3;
            }
            else if (page == 3)
            {
                page = 12;
            }
            else if (page == 5)
            {
                page = 6;
            }
            else if (page == 8)
            {
                page = 9;
            }
            else if (page == 10)
            {
                page = 5;
            } 
            else if (page == 11)
            {
                page = 8;
            }
            switchCase();
        }
        private void arrowDown_Click(object sender, EventArgs e)
        {
            SoundPlayer clickSound = new SoundPlayer(Properties.Resources.clickSound);
            clickSound.Play();
            if (page == 3)
            {
                page = 2;
            }
            else if (page == 5)
            {
                page = 10;
            }
            else if (page == 6)
            {
                page = 5;
            }
            else if (page == 8)
            {
                page = 11;
            }
            else if (page == 9)
            {
                page = 8;
            }
            switchCase();
        }
        private void arrowRight_Click(object sender, EventArgs e)
        {
            SoundPlayer clickSound = new SoundPlayer(Properties.Resources.clickSound);
            clickSound.Play();

            if (page == 2)
            {
                page = 7;
            }
            else if (page == 4)
            {
                page = 2; 
            }
            else if (page == 5)
            {
                page = 4;
            }
            else if (page == 7)
            {
                page = 8;
            }
            switchCase();
        }
        private void arrowLeft_Click(object sender, EventArgs e)
        {
            SoundPlayer clickSound = new SoundPlayer(Properties.Resources.clickSound);
            clickSound.Play();

            if (page == 2)
            {
                page = 4;
            }
            else if (page == 4)
            {
                page = 5;
            }
            if (page == 7)
            {
                page = 2;
            }
            else if (page == 8)
            {
                page = 7;
            }
            switchCase();
        }
        #endregion
        #region arrowVisibility
        void showUp()
        {
            arrowUp.Visible = true;
        }
        void hideUp()
        {
            arrowUp.Visible = false;
        }
        void showDown()
        {
            arrowDown.Visible = true;
        }
        void hideDown()
        {
            arrowDown.Visible = false;
        }
        void showLeft()
        {
            arrowLeft.Visible = true;
        }
        void hideLeft()
        {
            arrowLeft.Visible = false;
        }
        void showRight()
        {
            arrowRight.Visible = true;
        }
        void hideRight()
        {
            arrowRight.Visible = false;
        }
        #endregion
        #region pageSetup
        void page1Setup()
        {
            page = 1;
            BackgroundImage = Properties.Resources.page1;
            showUp();
            hideDown();
            hideRight();
            hideLeft();
            noButton.Visible = false;
            yesButton.Visible = false;
            gameOverText.Visible = false;
            passwordInput.Text = "";
        }
        void page2Setup()
        {
            page = 2;
            BackgroundImage = Properties.Resources.page2;
            showUp();
            hideDown();
            showRight();
            showLeft();
            lock1.Visible = false;
            lock2.Visible = false;
            lock3.Visible = false;
            lock4.Visible = false;
        }
        void page3Setup()
        {
            page = 3;
            BackgroundImage = Properties.Resources.page3;
            lock1.Visible = true;
            lock2.Visible = true;
            lock3.Visible = true;
            lock4.Visible = true;
            hideUp();
            showDown();
            hideRight();
            hideLeft();
        }
        void page4Setup()
        {
            page = 4;
            BackgroundImage = Properties.Resources.page4;
            hideUp();
            hideDown();
            showRight();
            showLeft();
        }
        void page5Setup()
        {
            if (monsterSide == 2)
            {
                SoundPlayer backgroundSound = new SoundPlayer(Properties.Resources.backgroundSound);
                backgroundSound.Play();
            }
            page = 5;
            BackgroundImage = Properties.Resources.page5;
            showUp();
            showDown();
            showRight();
            hideLeft();
        }
        void page6Setup()
        {
            page = 6;
            BackgroundImage = Properties.Resources.page6;
            hideUp();
            showDown();
            hideRight();
            hideLeft();
            Thread.Sleep(700);

            SoundPlayer alarmSound = new SoundPlayer(Properties.Resources.alarmSound);
            alarmSound.Play();
        }
        void page7Setup()
        {
            page = 7;
            BackgroundImage = Properties.Resources.page7;
            hideUp();
            hideDown();
            showRight();
            showLeft();
        }
        void page8Setup()
        { if (monsterSide == 1)
            {
               SoundPlayer backgroundSound = new SoundPlayer(Properties.Resources.backgroundSound);
               backgroundSound.Play();
            }
            page = 8;
            BackgroundImage = Properties.Resources.page8;
            passwordInput.Visible = false;
            enterButton.Visible = false;
            flowerImage.Visible = false;
            computerText.Visible = false;
            showUp();
            showDown();
            hideRight();
            showLeft();
        }
        void page9Setup()
        {
            passwordInput.Visible = true;
            enterButton.Visible = true;
            page = 9;
            BackgroundImage = Properties.Resources.page9;
            hideUp();
            showDown();
            hideRight();
            hideLeft();
        }
        void page10Setup()
        {
            page = 10;
            if (monsterSide == 1)
            {
                BackgroundImage = Properties.Resources.page10;
                showUp();
                hideDown();
                hideRight();
                hideLeft();
            }
            else
            {
                BackgroundImage = Properties.Resources.page10_monster;
                monsterAttack1();
            }
        }
        void page11Setup()
        {
            page = 11;
            if (monsterSide == 2)
            {
                BackgroundImage = Properties.Resources.page11;
                showUp();
                hideDown();
                hideRight();
                hideLeft();
            }
            else
            {
                BackgroundImage = Properties.Resources.page11_monster;
                monsterAttack1();
            }
        }
        void page12Setup()
        {
            page = 12;
            BackgroundImage = Properties.Resources.page12;
            lock1.Visible = false;
            lock2.Visible = false;
            lock3.Visible = false;
            lock4.Visible = false;
            hideUp();
            hideDown();
            hideRight();
            hideLeft();
            SoundPlayer backgroundSound = new SoundPlayer(Properties.Resources.backgroundSound);
            backgroundSound.Play();
            Thread.Sleep(6000);
            this.Close();
            
        }
        void page99Setup()
        {
            page = 99;
            BackgroundImage = Properties.Resources.gameOver;
            monsterImage.Visible = false;
            hideUp();
            hideDown();
            hideRight();
            hideLeft();
            noButton.Visible = true;
            yesButton.Visible = true;
            gameOverText.Visible = true;
        }
        #endregion
        #region monsterAttack
        void monsterAttack1()
        {
            hideUp();
            hideDown();
            hideRight();
            hideLeft();

            Thread.Sleep(2000);
            SoundPlayer monsterSound = new SoundPlayer(Properties.Resources.monsterSound);
            monsterSound.Play();
            monsterImage.Visible = true;
            Refresh();

            Thread.Sleep(500);
            page99Setup();
        }
        void monsterAttack2()
        {

        }
        #endregion
        #region gameOver
        private void noButton_Click(object sender, EventArgs e)
        {
            Thread.Sleep(1000);
            this.Close();
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            Thread.Sleep(1000);
            page1Setup();
            lockReset();
        }
        #endregion
        #region computerPuzzle
        private void enterButton_Click(object sender, EventArgs e)
        {
            if (passwordInput.Text == "Dog" || passwordInput.Text == "dog" || passwordInput.Text == "DOG")
            {
                SoundPlayer computerSound = new SoundPlayer(Properties.Resources.computerSound);
                computerSound.Play();
                passwordInput.Visible = false;
                enterButton.Visible = false;
                flowerImage.Visible = true;
                computerText.Visible = true;
            }
            else
            {

            }
        }
        #endregion

        #region switchCase
        void switchCase()
        {
            switch (page)
            {
                case 1:
                    page1Setup();
                    break;
                case 2:
                    page2Setup();
                    break;
                case 3:
                    page3Setup();
                    break;
                case 4:
                    page4Setup();
                    break;
                case 5:
                    page5Setup();
                    break;
                case 6:
                    page6Setup();
                    break;
                case 7:
                    page7Setup();
                    break;
                case 8:
                    page8Setup();
                    break;
                case 9:
                    page9Setup();
                    break;
                case 10:
                    page10Setup();
                    break;
                case 11:
                    page11Setup();
                    break;
                case 12:
                    page12Setup();
                    break;
                case 99:
                    page99Setup();
                    break;
            }
        }
        #endregion 

        #region mistakeFunctions
        private void Form1_Load(object sender, EventArgs e) {}
        private void attackTimer_Tick(object sender, EventArgs e) {}
        private void monsterLabel_Click(object sender, EventArgs e) {}
        private void passwordInput_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) {}
        private void monsterImage_Click(object sender, EventArgs e) { }
        #endregion
    }
}