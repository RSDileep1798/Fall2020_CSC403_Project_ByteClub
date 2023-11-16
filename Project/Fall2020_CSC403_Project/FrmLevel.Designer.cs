namespace Fall2020_CSC403_Project {
  partial class FrmLevel {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLevel));
            this.lblInGameTime = new System.Windows.Forms.Label();
            this.tmrUpdateInGameTime = new System.Windows.Forms.Timer(this.components);
            this.tmrPlayerMove = new System.Windows.Forms.Timer(this.components);
            this.flowLayPan = new System.Windows.Forms.FlowLayoutPanel();
            this.wizardicon = new System.Windows.Forms.PictureBox();
            this.playericon = new System.Windows.Forms.PictureBox();
            this.ninjaicon = new System.Windows.Forms.PictureBox();
            this.playerlayout = new System.Windows.Forms.FlowLayoutPanel();
            this.Scoreboard = new System.Windows.Forms.Label();
            this.minHeal = new System.Windows.Forms.PictureBox();
            this.my_game_control_menu = new System.Windows.Forms.PictureBox();
            this.picWall11 = new System.Windows.Forms.PictureBox();
            this.picWall2 = new System.Windows.Forms.PictureBox();
            this.picWall8 = new System.Windows.Forms.PictureBox();
            this.picWall7 = new System.Windows.Forms.PictureBox();
            this.charactericon = new System.Windows.Forms.PictureBox();
            this.picWall1 = new System.Windows.Forms.PictureBox();
            this.picWall0 = new System.Windows.Forms.PictureBox();
            this.picWall10 = new System.Windows.Forms.PictureBox();
            this.picWall9 = new System.Windows.Forms.PictureBox();
            this.picWall6 = new System.Windows.Forms.PictureBox();
            this.picWall12 = new System.Windows.Forms.PictureBox();
            this.picWall4 = new System.Windows.Forms.PictureBox();
            this.picWall5 = new System.Windows.Forms.PictureBox();
            this.picEnemyCheeto = new System.Windows.Forms.PictureBox();
            this.picEnemyPoisonPacket = new System.Windows.Forms.PictureBox();
            this.picWall3 = new System.Windows.Forms.PictureBox();
            this.picBossKoolAid = new System.Windows.Forms.PictureBox();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.winlosspopup = new System.Windows.Forms.PictureBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.fullHeal = new System.Windows.Forms.PictureBox();
            this.flowLayPan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wizardicon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playericon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ninjaicon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minHeal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.my_game_control_menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.charactericon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyCheeto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyPoisonPacket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBossKoolAid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winlosspopup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullHeal)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInGameTime
            // 
            this.lblInGameTime.AutoSize = true;
            this.lblInGameTime.BackColor = System.Drawing.Color.Black;
            this.lblInGameTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInGameTime.ForeColor = System.Drawing.Color.White;
            this.lblInGameTime.Location = new System.Drawing.Point(12, 9);
            this.lblInGameTime.Name = "lblInGameTime";
            this.lblInGameTime.Size = new System.Drawing.Size(53, 20);
            this.lblInGameTime.TabIndex = 2;
            this.lblInGameTime.Text = "label1";
            this.lblInGameTime.Click += new System.EventHandler(this.lblInGameTime_Click);
            // 
            // tmrUpdateInGameTime
            // 
            this.tmrUpdateInGameTime.Enabled = true;
            this.tmrUpdateInGameTime.Tick += new System.EventHandler(this.tmrUpdateInGameTime_Tick);
            // 
            // tmrPlayerMove
            // 
            this.tmrPlayerMove.Enabled = true;
            this.tmrPlayerMove.Interval = 10;
            this.tmrPlayerMove.Tick += new System.EventHandler(this.tmrPlayerMove_Tick);
            // 
            // flowLayPan
            // 
            this.flowLayPan.BackColor = System.Drawing.Color.Transparent;
            this.flowLayPan.Controls.Add(this.wizardicon);
            this.flowLayPan.Controls.Add(this.playericon);
            this.flowLayPan.Controls.Add(this.ninjaicon);
            this.flowLayPan.Enabled = false;
            this.flowLayPan.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayPan.Location = new System.Drawing.Point(2, 65);
            this.flowLayPan.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayPan.Name = "flowLayPan";
            this.flowLayPan.Size = new System.Drawing.Size(82, 211);
            this.flowLayPan.TabIndex = 19;
            this.flowLayPan.Visible = false;
            // 
            // wizardicon
            // 
            this.wizardicon.BackColor = System.Drawing.Color.Transparent;
            this.wizardicon.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.char1ic;
            this.wizardicon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.wizardicon.Location = new System.Drawing.Point(2, 2);
            this.wizardicon.Margin = new System.Windows.Forms.Padding(2);
            this.wizardicon.Name = "wizardicon";
            this.wizardicon.Size = new System.Drawing.Size(73, 68);
            this.wizardicon.TabIndex = 4;
            this.wizardicon.TabStop = false;
            this.wizardicon.Click += new System.EventHandler(this.wizard_Click);
            // 
            // playericon
            // 
            this.playericon.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.playeric;
            this.playericon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.playericon.Location = new System.Drawing.Point(2, 74);
            this.playericon.Margin = new System.Windows.Forms.Padding(2);
            this.playericon.Name = "playericon";
            this.playericon.Size = new System.Drawing.Size(73, 66);
            this.playericon.TabIndex = 5;
            this.playericon.TabStop = false;
            this.playericon.Click += new System.EventHandler(this.player_Click);
            // 
            // ninjaicon
            // 
            this.ninjaicon.BackColor = System.Drawing.Color.Transparent;
            this.ninjaicon.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.char2ic;
            this.ninjaicon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ninjaicon.Dock = System.Windows.Forms.DockStyle.Top;
            this.ninjaicon.Location = new System.Drawing.Point(2, 144);
            this.ninjaicon.Margin = new System.Windows.Forms.Padding(2);
            this.ninjaicon.Name = "ninjaicon";
            this.ninjaicon.Size = new System.Drawing.Size(73, 53);
            this.ninjaicon.TabIndex = 0;
            this.ninjaicon.TabStop = false;
            this.ninjaicon.Click += new System.EventHandler(this.ninja_Click);
            // 
            // playerlayout
            // 
            this.playerlayout.AutoSize = true;
            this.playerlayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.playerlayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.playerlayout.Location = new System.Drawing.Point(147, 567);
            this.playerlayout.Name = "playerlayout";
            this.playerlayout.Size = new System.Drawing.Size(118, 111);
            this.playerlayout.TabIndex = 23;
            // 
            // Scoreboard
            // 
            this.Scoreboard.AutoSize = true;
            this.Scoreboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scoreboard.ForeColor = System.Drawing.Color.Orange;
            this.Scoreboard.Location = new System.Drawing.Point(407, 1);
            this.Scoreboard.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Scoreboard.Name = "Scoreboard";
            this.Scoreboard.Size = new System.Drawing.Size(71, 29);
            this.Scoreboard.TabIndex = 28;
            this.Scoreboard.Text = "label";
            // 
            // minHeal
            // 
            this.minHeal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minHeal.BackgroundImage")));
            this.minHeal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minHeal.Location = new System.Drawing.Point(521, 98);
            this.minHeal.Name = "minHeal";
            this.minHeal.Size = new System.Drawing.Size(80, 71);
            this.minHeal.TabIndex = 29;
            this.minHeal.TabStop = false;
            // 
            // my_game_control_menu
            // 
            this.my_game_control_menu.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.control_menu_image;
            this.my_game_control_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.my_game_control_menu.Location = new System.Drawing.Point(266, 209);
            this.my_game_control_menu.Name = "my_game_control_menu";
            this.my_game_control_menu.Size = new System.Drawing.Size(549, 382);
            this.my_game_control_menu.TabIndex = 24;
            this.my_game_control_menu.TabStop = false;
            this.my_game_control_menu.Click += new System.EventHandler(this.on_click_control_menu);
            // 
            // picWall11
            // 
            this.picWall11.BackColor = System.Drawing.Color.Transparent;
            this.picWall11.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall11.Location = new System.Drawing.Point(551, 425);
            this.picWall11.Name = "picWall11";
            this.picWall11.Size = new System.Drawing.Size(164, 232);
            this.picWall11.TabIndex = 17;
            this.picWall11.TabStop = false;
            // 
            // picWall2
            // 
            this.picWall2.BackColor = System.Drawing.Color.Transparent;
            this.picWall2.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall2.Location = new System.Drawing.Point(551, 1);
            this.picWall2.Name = "picWall2";
            this.picWall2.Size = new System.Drawing.Size(469, 67);
            this.picWall2.TabIndex = 16;
            this.picWall2.TabStop = false;
            // 
            // picWall8
            // 
            this.picWall8.BackColor = System.Drawing.Color.Transparent;
            this.picWall8.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall8.Location = new System.Drawing.Point(1093, 274);
            this.picWall8.Name = "picWall8";
            this.picWall8.Size = new System.Drawing.Size(82, 449);
            this.picWall8.TabIndex = 15;
            this.picWall8.TabStop = false;
            // 
            // picWall7
            // 
            this.picWall7.BackColor = System.Drawing.Color.Transparent;
            this.picWall7.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall7.Location = new System.Drawing.Point(714, 656);
            this.picWall7.Name = "picWall7";
            this.picWall7.Size = new System.Drawing.Size(380, 67);
            this.picWall7.TabIndex = 14;
            this.picWall7.TabStop = false;
            // 
            // charactericon
            // 
            this.charactericon.BackColor = System.Drawing.Color.Transparent;
            this.charactericon.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.cloth;
            this.charactericon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.charactericon.Location = new System.Drawing.Point(2, 1);
            this.charactericon.Margin = new System.Windows.Forms.Padding(2);
            this.charactericon.Name = "charactericon";
            this.charactericon.Size = new System.Drawing.Size(82, 67);
            this.charactericon.TabIndex = 18;
            this.charactericon.TabStop = false;
            this.charactericon.Click += new System.EventHandler(this.character_Click);
            // 
            // picWall1
            // 
            this.picWall1.BackColor = System.Drawing.Color.Transparent;
            this.picWall1.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall1.Location = new System.Drawing.Point(83, 1);
            this.picWall1.Name = "picWall1";
            this.picWall1.Size = new System.Drawing.Size(469, 67);
            this.picWall1.TabIndex = 13;
            this.picWall1.TabStop = false;
            // 
            // picWall0
            // 
            this.picWall0.BackColor = System.Drawing.Color.Transparent;
            this.picWall0.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall0.Location = new System.Drawing.Point(2, 1);
            this.picWall0.Name = "picWall0";
            this.picWall0.Size = new System.Drawing.Size(82, 388);
            this.picWall0.TabIndex = 12;
            this.picWall0.TabStop = false;
            // 
            // picWall10
            // 
            this.picWall10.BackColor = System.Drawing.Color.Transparent;
            this.picWall10.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall10.Location = new System.Drawing.Point(653, 89);
            this.picWall10.Name = "picWall10";
            this.picWall10.Size = new System.Drawing.Size(228, 162);
            this.picWall10.TabIndex = 11;
            this.picWall10.TabStop = false;
            // 
            // picWall9
            // 
            this.picWall9.BackColor = System.Drawing.Color.Transparent;
            this.picWall9.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall9.Location = new System.Drawing.Point(266, 154);
            this.picWall9.Name = "picWall9";
            this.picWall9.Size = new System.Drawing.Size(197, 118);
            this.picWall9.TabIndex = 10;
            this.picWall9.TabStop = false;
            // 
            // picWall6
            // 
            this.picWall6.BackColor = System.Drawing.Color.Transparent;
            this.picWall6.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall6.Location = new System.Drawing.Point(357, 656);
            this.picWall6.Name = "picWall6";
            this.picWall6.Size = new System.Drawing.Size(358, 67);
            this.picWall6.TabIndex = 9;
            this.picWall6.TabStop = false;
            // 
            // picWall12
            // 
            this.picWall12.BackColor = System.Drawing.Color.Transparent;
            this.picWall12.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall12.Location = new System.Drawing.Point(890, 397);
            this.picWall12.Name = "picWall12";
            this.picWall12.Size = new System.Drawing.Size(203, 113);
            this.picWall12.TabIndex = 8;
            this.picWall12.TabStop = false;
            // 
            // picWall4
            // 
            this.picWall4.BackColor = System.Drawing.Color.Transparent;
            this.picWall4.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall4.Location = new System.Drawing.Point(2, 454);
            this.picWall4.Name = "picWall4";
            this.picWall4.Size = new System.Drawing.Size(82, 203);
            this.picWall4.TabIndex = 7;
            this.picWall4.TabStop = false;
            // 
            // picWall5
            // 
            this.picWall5.BackColor = System.Drawing.Color.Transparent;
            this.picWall5.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall5.Location = new System.Drawing.Point(2, 656);
            this.picWall5.Name = "picWall5";
            this.picWall5.Size = new System.Drawing.Size(358, 67);
            this.picWall5.TabIndex = 6;
            this.picWall5.TabStop = false;
            // 
            // picEnemyCheeto
            // 
            this.picEnemyCheeto.BackColor = System.Drawing.Color.Transparent;
            this.picEnemyCheeto.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.enemy_cheetos;
            this.picEnemyCheeto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEnemyCheeto.Location = new System.Drawing.Point(838, 540);
            this.picEnemyCheeto.Name = "picEnemyCheeto";
            this.picEnemyCheeto.Size = new System.Drawing.Size(64, 107);
            this.picEnemyCheeto.TabIndex = 5;
            this.picEnemyCheeto.TabStop = false;
            // 
            // picEnemyPoisonPacket
            // 
            this.picEnemyPoisonPacket.BackColor = System.Drawing.Color.Transparent;
            this.picEnemyPoisonPacket.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.enemy_poisonpacket;
            this.picEnemyPoisonPacket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEnemyPoisonPacket.Location = new System.Drawing.Point(110, 98);
            this.picEnemyPoisonPacket.Name = "picEnemyPoisonPacket";
            this.picEnemyPoisonPacket.Size = new System.Drawing.Size(63, 96);
            this.picEnemyPoisonPacket.TabIndex = 4;
            this.picEnemyPoisonPacket.TabStop = false;
            // 
            // picWall3
            // 
            this.picWall3.BackColor = System.Drawing.Color.Transparent;
            this.picWall3.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall3.Location = new System.Drawing.Point(2, 388);
            this.picWall3.Name = "picWall3";
            this.picWall3.Size = new System.Drawing.Size(358, 67);
            this.picWall3.TabIndex = 3;
            this.picWall3.TabStop = false;
            // 
            // picBossKoolAid
            // 
            this.picBossKoolAid.BackColor = System.Drawing.Color.Transparent;
            this.picBossKoolAid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBossKoolAid.BackgroundImage")));
            this.picBossKoolAid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBossKoolAid.Location = new System.Drawing.Point(971, 74);
            this.picBossKoolAid.Name = "picBossKoolAid";
            this.picBossKoolAid.Size = new System.Drawing.Size(193, 194);
            this.picBossKoolAid.TabIndex = 1;
            this.picBossKoolAid.TabStop = false;
            // 
            // picPlayer
            // 
            this.picPlayer.BackColor = System.Drawing.Color.Transparent;
            this.picPlayer.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.player;
            this.picPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPlayer.Location = new System.Drawing.Point(119, 510);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(54, 106);
            this.picPlayer.TabIndex = 0;
            this.picPlayer.TabStop = false;
            // 
            // winlosspopup
            // 
            this.winlosspopup.BackColor = System.Drawing.Color.Transparent;
            this.winlosspopup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.winlosspopup.Enabled = false;
            this.winlosspopup.Location = new System.Drawing.Point(335, 222);
            this.winlosspopup.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.winlosspopup.Name = "winlosspopup";
            this.winlosspopup.Size = new System.Drawing.Size(397, 113);
            this.winlosspopup.TabIndex = 20;
            this.winlosspopup.TabStop = false;
            this.winlosspopup.Visible = false;
            // 
            // fullHeal
            // 
            this.fullHeal.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.medical_pack;
            this.fullHeal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fullHeal.Location = new System.Drawing.Point(987, 574);
            this.fullHeal.Name = "fullHeal";
            this.fullHeal.Size = new System.Drawing.Size(71, 50);
            this.fullHeal.TabIndex = 30;
            this.fullHeal.TabStop = false;
            // 
            // FrmLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1176, 682);
            this.Controls.Add(this.fullHeal);
            this.Controls.Add(this.minHeal);
            this.Controls.Add(this.my_game_control_menu);
            this.Controls.Add(this.Scoreboard);
            this.Controls.Add(this.picWall11);
            this.Controls.Add(this.picWall2);
            this.Controls.Add(this.picWall8);
            this.Controls.Add(this.picWall7);
            this.Controls.Add(this.lblInGameTime);
            this.Controls.Add(this.flowLayPan);
            this.Controls.Add(this.charactericon);
            this.Controls.Add(this.picWall1);
            this.Controls.Add(this.picWall0);
            this.Controls.Add(this.picWall10);
            this.Controls.Add(this.picWall9);
            this.Controls.Add(this.picWall6);
            this.Controls.Add(this.picWall12);
            this.Controls.Add(this.picWall4);
            this.Controls.Add(this.picWall5);
            this.Controls.Add(this.picEnemyCheeto);
            this.Controls.Add(this.picEnemyPoisonPacket);
            this.Controls.Add(this.picWall3);
            this.Controls.Add(this.picBossKoolAid);
            this.Controls.Add(this.picPlayer);
            this.Controls.Add(this.winlosspopup);
            this.DoubleBuffered = true;
            this.Name = "FrmLevel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Explore";
            this.Load += new System.EventHandler(this.FrmLevel_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmLevel_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmLevel_KeyUp);
            this.flowLayPan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wizardicon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playericon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ninjaicon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minHeal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.my_game_control_menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.charactericon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyCheeto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyPoisonPacket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBossKoolAid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winlosspopup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullHeal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox picPlayer;
    private System.Windows.Forms.PictureBox picBossKoolAid;
    private System.Windows.Forms.Label lblInGameTime;
    private System.Windows.Forms.Timer tmrUpdateInGameTime;
    private System.Windows.Forms.Timer tmrPlayerMove;
    private System.Windows.Forms.PictureBox picWall3;
    private System.Windows.Forms.PictureBox picEnemyPoisonPacket;
    private System.Windows.Forms.PictureBox picEnemyCheeto;
    private System.Windows.Forms.PictureBox picWall5;
    private System.Windows.Forms.PictureBox picWall4;
    private System.Windows.Forms.PictureBox picWall12;
    private System.Windows.Forms.PictureBox picWall6;
    private System.Windows.Forms.PictureBox picWall9;
    private System.Windows.Forms.PictureBox picWall10;
    private System.Windows.Forms.PictureBox picWall0;
    private System.Windows.Forms.PictureBox picWall7;
    private System.Windows.Forms.PictureBox picWall8;
    private System.Windows.Forms.PictureBox picWall1;
    private System.Windows.Forms.PictureBox picWall2;
    private System.Windows.Forms.PictureBox picWall11;
        private System.Windows.Forms.PictureBox charactericon;
        private System.Windows.Forms.PictureBox ninjaicon;
        private System.Windows.Forms.PictureBox playericon;
        private System.Windows.Forms.PictureBox wizardicon;
        private System.Windows.Forms.FlowLayoutPanel flowLayPan;
        private System.Windows.Forms.PictureBox winlosspopup;
        private System.Windows.Forms.FlowLayoutPanel playerlayout;

        //main menu
        private System.Windows.Forms.PictureBox my_game_control_menu;
        private System.Windows.Forms.Label Scoreboard;
        private System.Windows.Forms.PictureBox minHeal;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.PictureBox fullHeal;
    }
}

