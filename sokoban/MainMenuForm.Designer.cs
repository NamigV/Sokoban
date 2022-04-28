using System.ComponentModel;
using System.Windows.Forms;

namespace sokoban
{
    partial class MainMenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._mainMenuPanel = new System.Windows.Forms.Panel();
            this._globalStatsButton = new System.Windows.Forms.Button();
            this._loginButton = new System.Windows.Forms.Button();
            this._startNewGameButton = new System.Windows.Forms.Button();
            this._gameTitleLabel = new System.Windows.Forms.Label();
            this._createProfilePanel = new System.Windows.Forms.Panel();
            this._enterProfileNameLabel = new System.Windows.Forms.Label();
            this._profileNameTextBox = new System.Windows.Forms.TextBox();
            this._createProfileBackButton = new System.Windows.Forms.Button();
            this._startGameButton = new System.Windows.Forms.Button();
            this._createProfileTitleLabel = new System.Windows.Forms.Label();
            this._loginPanel = new System.Windows.Forms.Panel();
            this._loginCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this._chooseProfileLabel = new System.Windows.Forms.Label();
            this._loginBackButton = new System.Windows.Forms.Button();
            this._continueButton = new System.Windows.Forms.Button();
            this._loginTitleLabel = new System.Windows.Forms.Label();
            this._profileMenuPanel = new System.Windows.Forms.Panel();
            this._profileStartNewGameButton = new System.Windows.Forms.Button();
            this._profileMenuBackButton = new System.Windows.Forms.Button();
            this._profileContinueGameButton = new System.Windows.Forms.Button();
            this._viewProfileStatsButton = new System.Windows.Forms.Button();
            this._profileNameTitle = new System.Windows.Forms.Label();
            this._profileStatsPanel = new System.Windows.Forms.Panel();
            this._profileStatsTreeViewPanel = new System.Windows.Forms.Panel();
            this._profileStatsTreeView = new System.Windows.Forms.TreeView();
            this._profileStatsBackButton = new System.Windows.Forms.Button();
            this._profileStatsTitleLabel = new System.Windows.Forms.Label();
            this._globalStatsPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this._globalStatsTreeView = new System.Windows.Forms.TreeView();
            this._globalStatsBackButton = new System.Windows.Forms.Button();
            this._globslStatsTitleLabel = new System.Windows.Forms.Label();
            this._mainMenuPanel.SuspendLayout();
            this._createProfilePanel.SuspendLayout();
            this._loginPanel.SuspendLayout();
            this._profileMenuPanel.SuspendLayout();
            this._profileStatsPanel.SuspendLayout();
            this._profileStatsTreeViewPanel.SuspendLayout();
            this._globalStatsPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // _mainMenuPanel
            // 
            this._mainMenuPanel.Controls.Add(this._globalStatsButton);
            this._mainMenuPanel.Controls.Add(this._loginButton);
            this._mainMenuPanel.Controls.Add(this._startNewGameButton);
            this._mainMenuPanel.Controls.Add(this._gameTitleLabel);
            this._mainMenuPanel.Location = new System.Drawing.Point(0, 0);
            this._mainMenuPanel.Name = "_mainMenuPanel";
            this._mainMenuPanel.Size = new System.Drawing.Size(640, 635);
            this._mainMenuPanel.TabIndex = 0;
            // 
            // _globalStatsButton
            // 
            this._globalStatsButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this._globalStatsButton.FlatAppearance.BorderSize = 0;
            this._globalStatsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._globalStatsButton.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this._globalStatsButton.ForeColor = System.Drawing.Color.PaleTurquoise;
            this._globalStatsButton.Location = new System.Drawing.Point(150, 328);
            this._globalStatsButton.Margin = new System.Windows.Forms.Padding(0);
            this._globalStatsButton.Name = "_globalStatsButton";
            this._globalStatsButton.Size = new System.Drawing.Size(340, 64);
            this._globalStatsButton.TabIndex = 1;
            this._globalStatsButton.Text = "Общая статистика";
            this._globalStatsButton.UseVisualStyleBackColor = false;
            this._globalStatsButton.Click += new System.EventHandler(this.GlobalStatsButtonClickEvent);
            // 
            // _loginButton
            // 
            this._loginButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this._loginButton.FlatAppearance.BorderSize = 0;
            this._loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._loginButton.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this._loginButton.ForeColor = System.Drawing.Color.PaleTurquoise;
            this._loginButton.Location = new System.Drawing.Point(150, 260);
            this._loginButton.Margin = new System.Windows.Forms.Padding(0);
            this._loginButton.Name = "_loginButton";
            this._loginButton.Size = new System.Drawing.Size(340, 64);
            this._loginButton.TabIndex = 1;
            this._loginButton.Text = "Войти";
            this._loginButton.UseVisualStyleBackColor = false;
            this._loginButton.Click += new System.EventHandler(this.LoginButtonClickEvent);
            // 
            // _startNewGameButton
            // 
            this._startNewGameButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this._startNewGameButton.FlatAppearance.BorderSize = 0;
            this._startNewGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._startNewGameButton.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this._startNewGameButton.ForeColor = System.Drawing.Color.PaleTurquoise;
            this._startNewGameButton.Location = new System.Drawing.Point(150, 192);
            this._startNewGameButton.Margin = new System.Windows.Forms.Padding(0);
            this._startNewGameButton.Name = "_startNewGameButton";
            this._startNewGameButton.Size = new System.Drawing.Size(340, 64);
            this._startNewGameButton.TabIndex = 1;
            this._startNewGameButton.Text = "Начать новую игру";
            this._startNewGameButton.UseVisualStyleBackColor = false;
            this._startNewGameButton.Click += new System.EventHandler(this.StartNewGameButtonClickEvent);
            // 
            // _gameTitleLabel
            // 
            this._gameTitleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this._gameTitleLabel.Font = new System.Drawing.Font("Times New Roman", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this._gameTitleLabel.ForeColor = System.Drawing.Color.LightSeaGreen;
            this._gameTitleLabel.Location = new System.Drawing.Point(0, 0);
            this._gameTitleLabel.Name = "_gameTitleLabel";
            this._gameTitleLabel.Size = new System.Drawing.Size(640, 128);
            this._gameTitleLabel.TabIndex = 0;
            this._gameTitleLabel.Text = "Sokoban";
            this._gameTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _createProfilePanel
            // 
            this._createProfilePanel.Controls.Add(this._enterProfileNameLabel);
            this._createProfilePanel.Controls.Add(this._profileNameTextBox);
            this._createProfilePanel.Controls.Add(this._createProfileBackButton);
            this._createProfilePanel.Controls.Add(this._startGameButton);
            this._createProfilePanel.Controls.Add(this._createProfileTitleLabel);
            this._createProfilePanel.Location = new System.Drawing.Point(0, 0);
            this._createProfilePanel.Name = "_createProfilePanel";
            this._createProfilePanel.Size = new System.Drawing.Size(640, 635);
            this._createProfilePanel.TabIndex = 0;
            this._createProfilePanel.Visible = false;
            // 
            // _enterProfileNameLabel
            // 
            this._enterProfileNameLabel.Font = new System.Drawing.Font("Times New Roman", 27.75F, ((System.Drawing.FontStyle) ((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this._enterProfileNameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this._enterProfileNameLabel.Location = new System.Drawing.Point(150, 128);
            this._enterProfileNameLabel.Name = "_enterProfileNameLabel";
            this._enterProfileNameLabel.Size = new System.Drawing.Size(340, 64);
            this._enterProfileNameLabel.TabIndex = 3;
            this._enterProfileNameLabel.Text = "Введите имя:";
            this._enterProfileNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _profileNameTextBox
            // 
            this._profileNameTextBox.BackColor = System.Drawing.Color.CadetBlue;
            this._profileNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._profileNameTextBox.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this._profileNameTextBox.ForeColor = System.Drawing.Color.Aquamarine;
            this._profileNameTextBox.Location = new System.Drawing.Point(150, 203);
            this._profileNameTextBox.MaxLength = 18;
            this._profileNameTextBox.Name = "_profileNameTextBox";
            this._profileNameTextBox.Size = new System.Drawing.Size(340, 43);
            this._profileNameTextBox.TabIndex = 2;
            this._profileNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._profileNameTextBox.TextChanged += new System.EventHandler(this.ProfileNameTextBoxTextChangedEvent);
            this._profileNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProfileNameTextBoxKeyPressEvent);
            // 
            // _createProfileBackButton
            // 
            this._createProfileBackButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this._createProfileBackButton.FlatAppearance.BorderSize = 0;
            this._createProfileBackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._createProfileBackButton.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this._createProfileBackButton.ForeColor = System.Drawing.Color.PaleTurquoise;
            this._createProfileBackButton.Location = new System.Drawing.Point(150, 328);
            this._createProfileBackButton.Margin = new System.Windows.Forms.Padding(0);
            this._createProfileBackButton.Name = "_createProfileBackButton";
            this._createProfileBackButton.Size = new System.Drawing.Size(340, 64);
            this._createProfileBackButton.TabIndex = 1;
            this._createProfileBackButton.Text = "Назад";
            this._createProfileBackButton.UseVisualStyleBackColor = false;
            this._createProfileBackButton.Click += new System.EventHandler(this.CreateProfileBackButtonClickEvent);
            // 
            // _startGameButton
            // 
            this._startGameButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this._startGameButton.FlatAppearance.BorderSize = 0;
            this._startGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._startGameButton.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this._startGameButton.ForeColor = System.Drawing.Color.PaleTurquoise;
            this._startGameButton.Location = new System.Drawing.Point(150, 260);
            this._startGameButton.Margin = new System.Windows.Forms.Padding(0);
            this._startGameButton.Name = "_startGameButton";
            this._startGameButton.Size = new System.Drawing.Size(340, 64);
            this._startGameButton.TabIndex = 1;
            this._startGameButton.Text = "Начать игру";
            this._startGameButton.UseVisualStyleBackColor = false;
            this._startGameButton.Click += new System.EventHandler(this.StartGameButtonClickEvent);
            // 
            // _createProfileTitleLabel
            // 
            this._createProfileTitleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this._createProfileTitleLabel.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this._createProfileTitleLabel.ForeColor = System.Drawing.Color.LightSeaGreen;
            this._createProfileTitleLabel.Location = new System.Drawing.Point(0, 0);
            this._createProfileTitleLabel.Name = "_createProfileTitleLabel";
            this._createProfileTitleLabel.Size = new System.Drawing.Size(640, 128);
            this._createProfileTitleLabel.TabIndex = 0;
            this._createProfileTitleLabel.Text = "Создать профиль";
            this._createProfileTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _loginPanel
            // 
            this._loginPanel.Controls.Add(this._loginCheckedListBox);
            this._loginPanel.Controls.Add(this._chooseProfileLabel);
            this._loginPanel.Controls.Add(this._loginBackButton);
            this._loginPanel.Controls.Add(this._continueButton);
            this._loginPanel.Controls.Add(this._loginTitleLabel);
            this._loginPanel.Location = new System.Drawing.Point(0, 0);
            this._loginPanel.Name = "_loginPanel";
            this._loginPanel.Size = new System.Drawing.Size(640, 635);
            this._loginPanel.TabIndex = 4;
            this._loginPanel.Visible = false;
            // 
            // _loginCheckedListBox
            // 
            this._loginCheckedListBox.BackColor = System.Drawing.Color.CadetBlue;
            this._loginCheckedListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._loginCheckedListBox.CheckOnClick = true;
            this._loginCheckedListBox.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this._loginCheckedListBox.FormattingEnabled = true;
            this._loginCheckedListBox.Location = new System.Drawing.Point(150, 203);
            this._loginCheckedListBox.Name = "_loginCheckedListBox";
            this._loginCheckedListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this._loginCheckedListBox.Size = new System.Drawing.Size(340, 156);
            this._loginCheckedListBox.Sorted = true;
            this._loginCheckedListBox.TabIndex = 5;
            this._loginCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.LoginCheckedListBoxItemCheckEvent);
            this._loginCheckedListBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LoginCheckedListBoxMouseClickEvent);
            // 
            // _chooseProfileLabel
            // 
            this._chooseProfileLabel.Font = new System.Drawing.Font("Times New Roman", 27.75F, ((System.Drawing.FontStyle) ((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this._chooseProfileLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this._chooseProfileLabel.Location = new System.Drawing.Point(125, 128);
            this._chooseProfileLabel.Name = "_chooseProfileLabel";
            this._chooseProfileLabel.Size = new System.Drawing.Size(390, 64);
            this._chooseProfileLabel.TabIndex = 3;
            this._chooseProfileLabel.Text = "Выберите профиль:";
            this._chooseProfileLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _loginBackButton
            // 
            this._loginBackButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this._loginBackButton.FlatAppearance.BorderSize = 0;
            this._loginBackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._loginBackButton.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this._loginBackButton.ForeColor = System.Drawing.Color.PaleTurquoise;
            this._loginBackButton.Location = new System.Drawing.Point(150, 442);
            this._loginBackButton.Margin = new System.Windows.Forms.Padding(0);
            this._loginBackButton.Name = "_loginBackButton";
            this._loginBackButton.Size = new System.Drawing.Size(340, 64);
            this._loginBackButton.TabIndex = 1;
            this._loginBackButton.Text = "Назад";
            this._loginBackButton.UseVisualStyleBackColor = false;
            this._loginBackButton.Click += new System.EventHandler(this.LoginBackButtonClickEvent);
            // 
            // _continueButton
            // 
            this._continueButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this._continueButton.FlatAppearance.BorderSize = 0;
            this._continueButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._continueButton.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this._continueButton.ForeColor = System.Drawing.Color.PaleTurquoise;
            this._continueButton.Location = new System.Drawing.Point(150, 374);
            this._continueButton.Margin = new System.Windows.Forms.Padding(0);
            this._continueButton.Name = "_continueButton";
            this._continueButton.Size = new System.Drawing.Size(340, 64);
            this._continueButton.TabIndex = 1;
            this._continueButton.Text = "Продолжить";
            this._continueButton.UseVisualStyleBackColor = false;
            this._continueButton.Click += new System.EventHandler(this.ContinueButtonClickEvent);
            // 
            // _loginTitleLabel
            // 
            this._loginTitleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this._loginTitleLabel.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this._loginTitleLabel.ForeColor = System.Drawing.Color.LightSeaGreen;
            this._loginTitleLabel.Location = new System.Drawing.Point(0, 0);
            this._loginTitleLabel.Name = "_loginTitleLabel";
            this._loginTitleLabel.Size = new System.Drawing.Size(640, 128);
            this._loginTitleLabel.TabIndex = 0;
            this._loginTitleLabel.Text = "Войти";
            this._loginTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _profileMenuPanel
            // 
            this._profileMenuPanel.Controls.Add(this._profileStartNewGameButton);
            this._profileMenuPanel.Controls.Add(this._profileMenuBackButton);
            this._profileMenuPanel.Controls.Add(this._profileContinueGameButton);
            this._profileMenuPanel.Controls.Add(this._viewProfileStatsButton);
            this._profileMenuPanel.Controls.Add(this._profileNameTitle);
            this._profileMenuPanel.Location = new System.Drawing.Point(0, 0);
            this._profileMenuPanel.Name = "_profileMenuPanel";
            this._profileMenuPanel.Size = new System.Drawing.Size(640, 635);
            this._profileMenuPanel.TabIndex = 6;
            this._profileMenuPanel.Visible = false;
            // 
            // _profileStartNewGameButton
            // 
            this._profileStartNewGameButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this._profileStartNewGameButton.FlatAppearance.BorderSize = 0;
            this._profileStartNewGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._profileStartNewGameButton.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this._profileStartNewGameButton.ForeColor = System.Drawing.Color.PaleTurquoise;
            this._profileStartNewGameButton.Location = new System.Drawing.Point(150, 271);
            this._profileStartNewGameButton.Margin = new System.Windows.Forms.Padding(0);
            this._profileStartNewGameButton.Name = "_profileStartNewGameButton";
            this._profileStartNewGameButton.Size = new System.Drawing.Size(340, 64);
            this._profileStartNewGameButton.TabIndex = 1;
            this._profileStartNewGameButton.Text = "Начать новую игру";
            this._profileStartNewGameButton.UseVisualStyleBackColor = false;
            this._profileStartNewGameButton.Click += new System.EventHandler(this.ProfileStartNewGameButtonClickEvent);
            // 
            // _profileMenuBackButton
            // 
            this._profileMenuBackButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this._profileMenuBackButton.FlatAppearance.BorderSize = 0;
            this._profileMenuBackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._profileMenuBackButton.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this._profileMenuBackButton.ForeColor = System.Drawing.Color.PaleTurquoise;
            this._profileMenuBackButton.Location = new System.Drawing.Point(150, 407);
            this._profileMenuBackButton.Margin = new System.Windows.Forms.Padding(0);
            this._profileMenuBackButton.Name = "_profileMenuBackButton";
            this._profileMenuBackButton.Size = new System.Drawing.Size(340, 64);
            this._profileMenuBackButton.TabIndex = 1;
            this._profileMenuBackButton.Text = "Назад";
            this._profileMenuBackButton.UseVisualStyleBackColor = false;
            this._profileMenuBackButton.Click += new System.EventHandler(this.ProfileMenuBackButtonClickEvent);
            // 
            // _profileContinueGameButton
            // 
            this._profileContinueGameButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this._profileContinueGameButton.FlatAppearance.BorderSize = 0;
            this._profileContinueGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._profileContinueGameButton.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this._profileContinueGameButton.ForeColor = System.Drawing.Color.PaleTurquoise;
            this._profileContinueGameButton.Location = new System.Drawing.Point(150, 203);
            this._profileContinueGameButton.Margin = new System.Windows.Forms.Padding(0);
            this._profileContinueGameButton.Name = "_profileContinueGameButton";
            this._profileContinueGameButton.Size = new System.Drawing.Size(340, 64);
            this._profileContinueGameButton.TabIndex = 1;
            this._profileContinueGameButton.Text = "Продолжить";
            this._profileContinueGameButton.UseVisualStyleBackColor = false;
            this._profileContinueGameButton.Click += new System.EventHandler(this.ProfileContinueGameButtonClickEvent);
            // 
            // _viewProfileStatsButton
            // 
            this._viewProfileStatsButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this._viewProfileStatsButton.FlatAppearance.BorderSize = 0;
            this._viewProfileStatsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._viewProfileStatsButton.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this._viewProfileStatsButton.ForeColor = System.Drawing.Color.PaleTurquoise;
            this._viewProfileStatsButton.Location = new System.Drawing.Point(150, 339);
            this._viewProfileStatsButton.Margin = new System.Windows.Forms.Padding(0);
            this._viewProfileStatsButton.Name = "_viewProfileStatsButton";
            this._viewProfileStatsButton.Size = new System.Drawing.Size(340, 64);
            this._viewProfileStatsButton.TabIndex = 1;
            this._viewProfileStatsButton.Text = "Статистика";
            this._viewProfileStatsButton.UseVisualStyleBackColor = false;
            this._viewProfileStatsButton.Click += new System.EventHandler(this.ViewProfileStatsButtonClickEvent);
            // 
            // _profileNameTitle
            // 
            this._profileNameTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this._profileNameTitle.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this._profileNameTitle.ForeColor = System.Drawing.Color.LightSeaGreen;
            this._profileNameTitle.Location = new System.Drawing.Point(0, 0);
            this._profileNameTitle.Name = "_profileNameTitle";
            this._profileNameTitle.Size = new System.Drawing.Size(640, 128);
            this._profileNameTitle.TabIndex = 0;
            this._profileNameTitle.Text = "[ProfileName]";
            this._profileNameTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _profileStatsPanel
            // 
            this._profileStatsPanel.Controls.Add(this._profileStatsTreeViewPanel);
            this._profileStatsPanel.Controls.Add(this._profileStatsBackButton);
            this._profileStatsPanel.Controls.Add(this._profileStatsTitleLabel);
            this._profileStatsPanel.Location = new System.Drawing.Point(0, 0);
            this._profileStatsPanel.Name = "_profileStatsPanel";
            this._profileStatsPanel.Size = new System.Drawing.Size(640, 778);
            this._profileStatsPanel.TabIndex = 7;
            this._profileStatsPanel.Visible = false;
            // 
            // _profileStatsTreeViewPanel
            // 
            this._profileStatsTreeViewPanel.AutoScroll = true;
            this._profileStatsTreeViewPanel.Controls.Add(this._profileStatsTreeView);
            this._profileStatsTreeViewPanel.Location = new System.Drawing.Point(12, 128);
            this._profileStatsTreeViewPanel.Name = "_profileStatsTreeViewPanel";
            this._profileStatsTreeViewPanel.Size = new System.Drawing.Size(610, 264);
            this._profileStatsTreeViewPanel.TabIndex = 2;
            // 
            // _profileStatsTreeView
            // 
            this._profileStatsTreeView.BackColor = System.Drawing.Color.DarkSlateGray;
            this._profileStatsTreeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._profileStatsTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._profileStatsTreeView.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this._profileStatsTreeView.ForeColor = System.Drawing.Color.MediumAquamarine;
            this._profileStatsTreeView.Location = new System.Drawing.Point(0, 0);
            this._profileStatsTreeView.Name = "_profileStatsTreeView";
            this._profileStatsTreeView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._profileStatsTreeView.Size = new System.Drawing.Size(610, 264);
            this._profileStatsTreeView.TabIndex = 0;
            // 
            // _profileStatsBackButton
            // 
            this._profileStatsBackButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this._profileStatsBackButton.FlatAppearance.BorderSize = 0;
            this._profileStatsBackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._profileStatsBackButton.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this._profileStatsBackButton.ForeColor = System.Drawing.Color.PaleTurquoise;
            this._profileStatsBackButton.Location = new System.Drawing.Point(150, 407);
            this._profileStatsBackButton.Margin = new System.Windows.Forms.Padding(0);
            this._profileStatsBackButton.Name = "_profileStatsBackButton";
            this._profileStatsBackButton.Size = new System.Drawing.Size(340, 64);
            this._profileStatsBackButton.TabIndex = 1;
            this._profileStatsBackButton.Text = "Назад";
            this._profileStatsBackButton.UseVisualStyleBackColor = false;
            this._profileStatsBackButton.Click += new System.EventHandler(this.ProfileStatsBackButtonClickEvent);
            // 
            // _profileStatsTitleLabel
            // 
            this._profileStatsTitleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this._profileStatsTitleLabel.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this._profileStatsTitleLabel.ForeColor = System.Drawing.Color.LightSeaGreen;
            this._profileStatsTitleLabel.Location = new System.Drawing.Point(0, 0);
            this._profileStatsTitleLabel.Name = "_profileStatsTitleLabel";
            this._profileStatsTitleLabel.Size = new System.Drawing.Size(640, 128);
            this._profileStatsTitleLabel.TabIndex = 0;
            this._profileStatsTitleLabel.Text = "Статистика";
            this._profileStatsTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _globalStatsPanel
            // 
            this._globalStatsPanel.Controls.Add(this.panel2);
            this._globalStatsPanel.Controls.Add(this._globalStatsBackButton);
            this._globalStatsPanel.Controls.Add(this._globslStatsTitleLabel);
            this._globalStatsPanel.Location = new System.Drawing.Point(0, 0);
            this._globalStatsPanel.Name = "_globalStatsPanel";
            this._globalStatsPanel.Size = new System.Drawing.Size(640, 778);
            this._globalStatsPanel.TabIndex = 8;
            this._globalStatsPanel.Visible = false;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this._globalStatsTreeView);
            this.panel2.Location = new System.Drawing.Point(12, 128);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(610, 264);
            this.panel2.TabIndex = 2;
            // 
            // _globalStatsTreeView
            // 
            this._globalStatsTreeView.BackColor = System.Drawing.Color.DarkSlateGray;
            this._globalStatsTreeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._globalStatsTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._globalStatsTreeView.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this._globalStatsTreeView.ForeColor = System.Drawing.Color.MediumAquamarine;
            this._globalStatsTreeView.Location = new System.Drawing.Point(0, 0);
            this._globalStatsTreeView.Name = "_globalStatsTreeView";
            this._globalStatsTreeView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._globalStatsTreeView.Size = new System.Drawing.Size(610, 264);
            this._globalStatsTreeView.TabIndex = 0;
            // 
            // _globalStatsBackButton
            // 
            this._globalStatsBackButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this._globalStatsBackButton.FlatAppearance.BorderSize = 0;
            this._globalStatsBackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._globalStatsBackButton.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this._globalStatsBackButton.ForeColor = System.Drawing.Color.PaleTurquoise;
            this._globalStatsBackButton.Location = new System.Drawing.Point(150, 407);
            this._globalStatsBackButton.Margin = new System.Windows.Forms.Padding(0);
            this._globalStatsBackButton.Name = "_globalStatsBackButton";
            this._globalStatsBackButton.Size = new System.Drawing.Size(340, 64);
            this._globalStatsBackButton.TabIndex = 1;
            this._globalStatsBackButton.Text = "Назад";
            this._globalStatsBackButton.UseVisualStyleBackColor = false;
            this._globalStatsBackButton.Click += new System.EventHandler(this.GlobalStatsBackButtonClickEvent);
            // 
            // _globslStatsTitleLabel
            // 
            this._globslStatsTitleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this._globslStatsTitleLabel.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this._globslStatsTitleLabel.ForeColor = System.Drawing.Color.LightSeaGreen;
            this._globslStatsTitleLabel.Location = new System.Drawing.Point(0, 0);
            this._globslStatsTitleLabel.Name = "_globslStatsTitleLabel";
            this._globslStatsTitleLabel.Size = new System.Drawing.Size(640, 128);
            this._globslStatsTitleLabel.TabIndex = 0;
            this._globslStatsTitleLabel.Text = "Общая статистика";
            this._globslStatsTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(644, 635);
            this.Controls.Add(this._globalStatsPanel);
            this.Controls.Add(this._profileStatsPanel);
            this.Controls.Add(this._profileMenuPanel);
            this.Controls.Add(this._loginPanel);
            this.Controls.Add(this._createProfilePanel);
            this.Controls.Add(this._mainMenuPanel);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "MainMenuForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sokoban";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainMenuForm_KeyUp);
            this._mainMenuPanel.ResumeLayout(false);
            this._createProfilePanel.ResumeLayout(false);
            this._createProfilePanel.PerformLayout();
            this._loginPanel.ResumeLayout(false);
            this._profileMenuPanel.ResumeLayout(false);
            this._profileStatsPanel.ResumeLayout(false);
            this._profileStatsTreeViewPanel.ResumeLayout(false);
            this._globalStatsPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel _globalStatsPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TreeView _globalStatsTreeView;
        private System.Windows.Forms.Button _globalStatsBackButton;
        private System.Windows.Forms.Label _globslStatsTitleLabel;

        private System.Windows.Forms.Button _globalStatsButton;

        private System.Windows.Forms.TreeView _profileStatsTreeView;
        private System.Windows.Forms.Panel _profileStatsTreeViewPanel;
        private System.Windows.Forms.Panel _profileStatsPanel;
        private System.Windows.Forms.Label _profileStatsTitleLabel;
        private System.Windows.Forms.Button _profileStatsBackButton;

        private System.Windows.Forms.Panel _profileMenuPanel;
        private System.Windows.Forms.Button _profileMenuBackButton;
        private System.Windows.Forms.Button _viewProfileStatsButton;
        private System.Windows.Forms.Label _profileNameTitle;
        private System.Windows.Forms.Button _profileContinueGameButton;
        private System.Windows.Forms.Button _profileStartNewGameButton;

        private System.Windows.Forms.CheckedListBox _loginCheckedListBox;

        private System.Windows.Forms.Label _createProfileTitleLabel;

        private System.Windows.Forms.Panel _loginPanel;
        private System.Windows.Forms.Label _chooseProfileLabel;
        private System.Windows.Forms.Button _loginBackButton;
        private System.Windows.Forms.Button _continueButton;
        private System.Windows.Forms.Label _loginTitleLabel;

        private System.Windows.Forms.Button _createProfileBackButton;

        private System.Windows.Forms.Label _enterProfileNameLabel;

        private System.Windows.Forms.TextBox _profileNameTextBox;

        private System.Windows.Forms.Button _startGameButton;
        
        private System.Windows.Forms.Panel _createProfilePanel;
        
        private System.Windows.Forms.Button _loginButton;

        private System.Windows.Forms.Button _startNewGameButton;

        private System.Windows.Forms.Label _gameTitleLabel;

        private System.Windows.Forms.Panel _mainMenuPanel;

        #endregion
    }
}