using AxWMPLib;
using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Fall2020_CSC403_Project
{
    public partial class FrmBattle : Form
    {
        public static FrmBattle instance = null;
        private Enemy enemy;
        private Player player;
        private static int characterbattle;
        private List<string> texts = new List<string> { "5", "4", "3", "2", "X" };
        private int currentIndex = 0;
        private bool ad3start = false;
        string urlToOpen = "";
        private FrmBattle()
        {
            InitializeComponent();
            player = Game.player;
        }

        public void Setup()
        {

            // update for this enemy
            picEnemy.BackgroundImage = enemy.Img;
            picEnemy.Refresh();
            BackColor = enemy.Color;
            picBossBattle.Visible = false;
            //To display the character choosen from skin on the battle screeen
            getThePlayer();
            string val = BackColor.Name.ToString();
            if (val == "Green")
            {
                AdVisible(val);
            }
            else if (val == "Orange")
            {
                AdVisible(val);
            }

            // Observer pattern
            enemy.AttackEvent += PlayerDamage;
            player.AttackEvent += EnemyDamage;

            // show health
            UpdateHealthBars();
        }
        //To get the player from the skins
        private void getThePlayer()
        {
            switch (characterbattle)
            {
                case 1:

                    picPlayer.BackgroundImage = Properties.Resources.char1;
                    break;
                case 2:
                    picPlayer.BackgroundImage = Properties.Resources.char2;
                    break;
                case 0:
                    picPlayer.BackgroundImage = Properties.Resources.player;

                    break;
            }
        }

        public void SetupForBossBattle()
        {
            picBossBattle.Location = Point.Empty;
            picBossBattle.Size = ClientSize;
            picBossBattle.Visible = true;

            SoundPlayer simpleSound = new SoundPlayer(Resources.final_battle);
            simpleSound.Play();

            tmrFinalBattle.Enabled = true;

        }

        public static FrmBattle GetInstance(Enemy enemy, int charchoice)
        {
            characterbattle = charchoice;
            if (instance == null)
            {
                instance = new FrmBattle();
                instance.enemy = enemy;
                instance.Setup();
            }
            return instance;
        }

        private void UpdateHealthBars()
        {
            float playerHealthPer = player.Health / (float)player.MaxHealth;
            float enemyHealthPer = enemy.Health / (float)enemy.MaxHealth;

            const int MAX_HEALTHBAR_WIDTH = 226;
            lblPlayerHealthFull.Width = (int)(MAX_HEALTHBAR_WIDTH * playerHealthPer);
            lblEnemyHealthFull.Width = (int)(MAX_HEALTHBAR_WIDTH * enemyHealthPer);

            lblPlayerHealthFull.Text = player.Health.ToString();
            lblEnemyHealthFull.Text = enemy.Health.ToString();
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            player.OnAttack(-4);
            if (enemy.Health > 0)
            {
                enemy.OnAttack(-2);
            }



            UpdateHealthBars();
            if (player.Health <= 0 || enemy.Health <= 0)
            {
                instance = null;
                Close();
            }
        }

        private void EnemyDamage(int amount)
        {
            enemy.AlterHealth(amount);
        }

        private void PlayerDamage(int amount)
        {
            player.AlterHealth(amount);
        }

        private void tmrFinalBattle_Tick(object sender, EventArgs e)
        {
            picBossBattle.Visible = false;
            tmrFinalBattle.Enabled = false;
            string val = BackColor.Name.ToString();
            if (val == "Red")
            {
                AdVisible(val);
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (currentIndex < texts.Count)
            {
                AdClose.Text = texts[currentIndex];
                currentIndex++;
            }
            else
            {
                // When you reach the end of the list, reset the index to start over.
                currentIndex = 0;
            }
            if (AdClose.Text == "X")
            {
                timer1.Stop();
            }
        }

        /*        private void AdVisible(string color)
                {//Update the URL path with the videos you are looking to and put those in the same data folder which is being used for pictures previosly.
                    //Assign unique url for all three stages make sure those are 30 sec long
                    //Try doing Random picup handling differnt video/pictures/url for attacks on given session play.

                    axWindowsMediaPlayer1.uiMode = "none";
                    timer1.Start();
                    if (color == "Green")
                    {
                        axWindowsMediaPlayer1.URL = "C:\\Users\\user_\\OneDrive\\Documents\\Dileep.SE\\Fall2020_CSC403_Project_ByteClub\\Project\\Fall2020_CSC403_Project\\data\\ADV1.mp4";
                        urlToOpen = "https://latechsports.com/sports/football"; // Replace with your desired URL
                        advertisingPanel.BackgroundImage = Resources.AD1;
                    }
                    else if (color == "Orange")
                    {
                        axWindowsMediaPlayer1.URL = "C:\\Users\\user_\\OneDrive\\Documents\\Dileep.SE\\Fall2020_CSC403_Project_ByteClub\\Project\\Fall2020_CSC403_Project\\data\\ADV2.mp4";
                        urlToOpen = "https://www.chick-fil-a.com/"; // Replace with your desired URL
                        advertisingPanel.BackgroundImage = Resources.AD2;
                    }
                    else if (color == "Red")
                    {
                        axWindowsMediaPlayer1.URL = "C:\\Users\\user_\\OneDrive\\Documents\\Dileep.SE\\Fall2020_CSC403_Project_ByteClub\\Project\\Fall2020_CSC403_Project\\data\\ADV3.mp4";
                        urlToOpen = "https://www.adidas.com/us"; // Replace with your desired URL
                        advertisingPanel.BackgroundImage = Resources.AD3;
                    }

                    advertisingPanel.Visible = true;
                    advertisingPanel.Enabled = true;
                }
        */
        private void AdClose_Click(object sender, EventArgs e)
        {
            if (AdClose.Text == "X")
            {
                axWindowsMediaPlayer1.close();
                advertisingPanel.Visible = false;
                advertisingPanel.Enabled = false;
                ad3start = false;
                timer1.Stop();
            }
        }

        private void advertisingPanel_Click(object sender, EventArgs e)
        {
            // Specify the URL you want to open in the default web browser


            try
            {
                // Open the default web browser with the specified URL
                System.Diagnostics.Process.Start(urlToOpen);
            }
            catch (Exception ex)
            {
                // Handle any exceptions that might occur when opening the web browser
                MessageBox.Show("An error occurred while opening the web browser: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                axWindowsMediaPlayer1.Visible = false;

            }
        }
        private void AdVisible(string color)
        {
            axWindowsMediaPlayer1.uiMode = "none";
            timer1.Start();

            // Initialize arrays or lists containing the available videos, pictures, and URLs
            string[] videos = { "C:\\Users\\user_\\OneDrive\\Documents\\Dileep.SE\\Fall2020_CSC403_Project_ByteClub\\Project\\Fall2020_CSC403_Project\\data\\ADV1.mp4",
                                "C:\\Users\\user_\\OneDrive\\Documents\\Dileep.SE\\Fall2020_CSC403_Project_ByteClub\\Project\\Fall2020_CSC403_Project\\data\\ADV2.mp4",
                                "C:\\Users\\user_\\OneDrive\\Documents\\Dileep.SE\\Fall2020_CSC403_Project_ByteClub\\Project\\Fall2020_CSC403_Project\\data\\ADV3.mp4"};
            string[] pictures = { "Resources.AD1", "Resources.AD2", "Resources.AD3" };
            string[] urls = { "https://latechsports.com/sports/football", "https://www.chick-fil-a.com/", "https://www.adidas.com/us", "https://www.apple.com/" };

            /*    // Generate random indexes for selecting a video, picture, and URL
                Random random = new Random();
                int videoIndex = random.Next(videos.Length);
                int pictureIndex = random.Next(pictures.Length);
                int urlIndex = random.Next(urls.Length);

                // Assign the selected video, picture, and URL
                axWindowsMediaPlayer1.URL = videos[videoIndex];
                advertisingPanel.BackgroundImage = Resources.ResourceManager.GetObject(pictures[pictureIndex]) as Image;
                urlToOpen = urls[urlIndex];

                advertisingPanel.Visible = true;
                advertisingPanel.Enabled = true;
            }*/
            // Initialize a list to store generated indexes
            List<int> generatedIndexes = new List<int>();

            // Use a loop to generate random indexes without repetition
            for (int i = 0; i < 3; i++) // Assuming you want to generate 3 random indexes
            {
                // Keep generating until a unique index is obtained
                while (true)
                {
                    Random random = new Random();
                    int index = random.Next(0, 3); // Assuming the length of your arrays is always 3

                    if (!generatedIndexes.Contains(index))
                    {
                        generatedIndexes.Add(index);
                        // Use the generated index as needed in your code
                        string selectedVideo = videos[index];
                        string selectedPicture = pictures[index];
                        string selectedUrl = urls[index];

                        axWindowsMediaPlayer1.URL = selectedVideo;
                        advertisingPanel.BackgroundImage = Resources.ResourceManager.GetObject(selectedPicture) as Image;
                        urlToOpen = selectedUrl;

                        advertisingPanel.Visible = true;
                        advertisingPanel.Enabled = true;
                        break;
                    }
                }
            }
        }
    }
}

