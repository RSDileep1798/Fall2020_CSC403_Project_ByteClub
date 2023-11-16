using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Threading;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class FrmLevel : Form
    {
        private Player player;

        private Enemy enemyPoisonPacket;
        private Enemy bossKoolaid;
        private Enemy enemyCheeto;
        private Character[] walls;
        private int scores;
        private bool playerflag = false;
        List<int> generatedIndexes = new List<int>();
        private int charchoice = 0;
        private DateTime timeBegin;
        private FrmBattle frmBattle;
        private bool pause = true;
        private int advertiseId;
        //backgroundScore
        private SoundPlayer gameBackgroundScore;
        public FrmLevel()
        {
            InitializeComponent();
            //Background Score
            gameBackgroundScore = new SoundPlayer("data/myGameBackgroundScore.wav");
        }

        private void FrmLevel_Load(object sender, EventArgs e)
        {
            const int PADDING = 7;
            const int NUM_WALLS = 13;
            //player = new Player(CreatePosition(picPlayer), CreateCollider(picPlayer, PADDING));

            player = new Player(CreatePosition(picPlayer), CreateCollider(picPlayer, PADDING));
            bossKoolaid = new Enemy(CreatePosition(picBossKoolAid), CreateCollider(picBossKoolAid, PADDING));
            enemyPoisonPacket = new Enemy(CreatePosition(picEnemyPoisonPacket), CreateCollider(picEnemyPoisonPacket, PADDING));
            enemyCheeto = new Enemy(CreatePosition(picEnemyCheeto), CreateCollider(picEnemyCheeto, PADDING));

            bossKoolaid.Img = picBossKoolAid.BackgroundImage;
            enemyPoisonPacket.Img = picEnemyPoisonPacket.BackgroundImage;
            enemyCheeto.Img = picEnemyCheeto.BackgroundImage;

            bossKoolaid.Color = Color.Red;
            enemyPoisonPacket.Color = Color.Green;
            enemyCheeto.Color = Color.Orange;

            walls = new Character[NUM_WALLS];
            //gameBackgroundScore
            PlayBlackgroundScore();

            walls = new Character[NUM_WALLS];
            for (int w = 0; w < NUM_WALLS; w++)
            {
                PictureBox pic = Controls.Find("picWall" + w.ToString(), true)[0] as PictureBox;
                walls[w] = new Character(CreatePosition(pic), CreateCollider(pic, PADDING));
            }

            Game.player = player;
            timeBegin = DateTime.Now;
        }

        //gameBackgroundScore
        public void PlayBlackgroundScore()
        {
            //gameBackgroundScore.PlayLooping();
            try
            {
                // Play the sound file in a loop
                gameBackgroundScore.PlayLooping();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                // Handle other exceptions if needed
            }
        }

        private Vector2 CreatePosition(PictureBox pic)
        {
            return new Vector2(pic.Location.X, pic.Location.Y);
        }

        private Collider CreateCollider(PictureBox pic, int padding)
        {
            Rectangle rect = new Rectangle(pic.Location, new Size(pic.Size.Width - padding, pic.Size.Height - padding));
            return new Collider(rect);
        }

        private void FrmLevel_KeyUp(object sender, KeyEventArgs e)
        {
            player.ResetMoveSpeed();
        }

        private void tmrUpdateInGameTime_Tick(object sender, EventArgs e)
        {
            TimeSpan span = DateTime.Now - timeBegin;
            string time = span.ToString(@"hh\:mm\:ss");
            lblInGameTime.Text = "Time: " + time.ToString();
        }

        private void tmrPlayerMove_Tick(object sender, EventArgs e)
        {
            // move player
            player.Move();
            // check collision with walls
            if (HitAWall(player))
            {
                player.MoveBack();
            }
            if (enemyPoisonPacket.Health <= 0) { disableenemy(enemyPoisonPacket); }
            if (enemyCheeto.Health <= 0) { disableenemy(enemyCheeto); }
            if (bossKoolaid.Health <= 0) { disableenemy(bossKoolaid); }

            // check collision with enemies
            if (HitAChar(player, enemyPoisonPacket) && enemyPoisonPacket.Health > 0)
            {
                Fight(enemyPoisonPacket);
            }
            else if (HitAChar(player, enemyCheeto) && enemyCheeto.Health > 0)
            {
                Fight(enemyCheeto);
            }
            if (HitAChar(player, bossKoolaid) && bossKoolaid.Health > 0)
            {
                Fight(bossKoolaid);
            }
            Scoreboard.Text = "SCORE ==>" + scores;
            Scoreboard.ForeColor = Color.Green; // You can replace Color.White with your desired color


            // update player's picture box
            picPlayer.Location = new Point((int)player.Position.x, (int)player.Position.y);
        }

        private void speed()
        {
            player.GO_INC = 9;
        }

        private void disableenemy(Enemy enemy)
        {
            if (enemy == bossKoolaid)
            {
                picBossKoolAid.Enabled = false;
                picBossKoolAid.Visible = false;
            }
            if (enemy == enemyCheeto)
            {
                picEnemyCheeto.Enabled = false;
                picEnemyCheeto.Visible = false;
            }
            if (enemy == enemyPoisonPacket)
            {
                picEnemyPoisonPacket.Enabled = false;
                picEnemyPoisonPacket.Visible = false;
            }


        }


        private bool HitAWall(Character c)
        {
            bool hitAWall = false;
            for (int w = 0; w < walls.Length; w++)
            {
                if (c.Collider.Intersects(walls[w].Collider))
                {
                    hitAWall = true;
                    break;
                }
            }
            return hitAWall;
        }

        private bool HitAChar(Character you, Character other)
        {
            return you.Collider.Intersects(other.Collider);
        }

        private void Fight(Enemy enemy)
        {
            // Pause the background music
            PauseBackgroundScore();

            // Keep generating until a unique index for advertising
            while (true)
            {
                Random random = new Random();
                int index = random.Next(0, 3); // Assuming the length of your arrays is always 3

                if (!generatedIndexes.Contains(index))
                {
                    generatedIndexes.Add(index);
                    // Use the generated index as needed in your code
                    advertiseId = index;
                    break;

                }
            }

            // Pause the background music
           // PauseBackgroundScore();

            player.ResetMoveSpeed();
            player.MoveBack();
            frmBattle = FrmBattle.GetInstance(enemy, charchoice, advertiseId);
            if (frmBattle != null)
            {
                frmBattle.FormClosed += (s, e) => ResumeBackgroundScore(); // Resume music when the battle form is closed
                frmBattle.Show();
            }

            if (enemy == bossKoolaid)
            {
                frmBattle.SetupForBossBattle();
            }
        }

        // Pause background music
        private void PauseBackgroundScore()
        {
            try
            {
                gameBackgroundScore.Stop();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                // Handle other exceptions if needed
            }
        }

        // Resume background music
        private void ResumeBackgroundScore()
        {
            try
            {
                gameBackgroundScore.PlayLooping();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                // Handle other exceptions if needed
            }
        }

        private void FrmLevel_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    scores += 1;
                    player.GoLeft();
                    break;

                case Keys.Right:
                    scores += 1;
                    player.GoRight();
                    break;

                case Keys.Up:
                    scores += 1;
                    player.GoUp();
                    break;

                case Keys.Down:
                    scores += 1;
                    player.GoDown();
                    break;

                //main menu
                case Keys.C:
                    pause = true;
                    Control_menu();
                    break;
                case Keys.S:
                    speed();
                    break;
                case Keys.R:
                    Reset_speed();
                    break;
                default:
                    player.ResetMoveSpeed();
                    break;
            }

        }

        private void Reset_speed()
        {
            player.GO_INC = 3;
        }


        //main menu
        private void Control_menu()
        {

            if (my_game_control_menu.Visible == false)
            {
                my_game_control_menu.Enabled = true;
                my_game_control_menu.Visible = true;
            }
            else
            {
                my_game_control_menu.Enabled = false;
                my_game_control_menu.Visible = false;

            }
        }
        private void ninja_Click(object sender, EventArgs e)
        {
            this.picPlayer.BackgroundImage = Properties.Resources.char2;
            charchoice = 2;

        }

        private void wizard_Click(object sender, EventArgs e)
        {
            this.picPlayer.BackgroundImage = Properties.Resources.char1;
            charchoice = 1;

        }

        private void player_Click(object sender, EventArgs e)
        {

            this.picPlayer.BackgroundImage = Properties.Resources.player;
            charchoice = 0;
        }
        private void character_Click(object sender, EventArgs e)
        {
            if (flowLayPan.Visible != true)
            {
                flowLayPan.Visible = true;
                flowLayPan.Enabled = true;
            }
            else
            {
                flowLayPan.Visible = false;
                flowLayPan.Enabled = false;
            }
        }
        //Control menu
        //menu
        private void on_click_control_menu(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            Point control_menu_image_coordinates = me.Location;
            if (120 < control_menu_image_coordinates.X && control_menu_image_coordinates.X < 290
                && 240 < control_menu_image_coordinates.Y && control_menu_image_coordinates.Y < 290)
            {
                pause = false;
                Control_menu();
            }
            else if (120 < control_menu_image_coordinates.X && control_menu_image_coordinates.X < 295 &&
                290 < control_menu_image_coordinates.Y && control_menu_image_coordinates.Y < 340)
            {

                this.Close();
            }
        }



        private void lblInGameTime_Click(object sender, EventArgs e)
        {

        }

    }
}

