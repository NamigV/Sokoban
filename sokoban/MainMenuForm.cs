using System;
using System.Linq;
using System.Windows.Forms;

namespace sokoban
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
            GameData.LoadData();
        }

        private static void PanelSwitch(Panel fromPanel, Panel toPanel)
        {
            fromPanel.Visible = false;
            toPanel.Visible = true;
        }
        
        private static bool IsProfileExist(string profileName) => 
            ProfileManager.Profiles.Any(profile => profileName == profile.ProfileName);
        
        private void StartNewGameButtonClickEvent(object sender, EventArgs e) =>
            PanelSwitch(_mainMenuPanel, _createProfilePanel);
        
        private void ProfileContinueGameButtonClickEvent(object sender, EventArgs e) => 
            ContinueGame();

        private void ProfileNameTextBoxKeyPressEvent(object sender, KeyPressEventArgs e) => 
            e.Handled = char.IsWhiteSpace(e.KeyChar);
        
        private void ProfileNameTextBoxTextChangedEvent(object sender, EventArgs e) => 
            ((TextBox) sender).Text = string.Concat(((TextBox) sender)?.Text.Where(c => !char.IsWhiteSpace(c)) ?? Array.Empty<char>());
        
        private void CreateProfileBackButtonClickEvent(object sender, EventArgs e)
        {
            PanelSwitch(_createProfilePanel, _mainMenuPanel);
            _profileNameTextBox.Clear();
        }

        private void LoginBackButtonClickEvent(object sender, EventArgs e)
        {
            PanelSwitch(_loginPanel, _mainMenuPanel);
            _loginCheckedListBox.Items.Clear();
        }

        private void GlobalStatsButtonClickEvent(object sender, EventArgs e)
        {
            PanelSwitch(_mainMenuPanel, _globalStatsPanel);
            FillGlobalStatsTreeView();
        }
        
        private void GlobalStatsBackButtonClickEvent(object sender, EventArgs e)
        {
            PanelSwitch(_globalStatsPanel, _mainMenuPanel);
            _globalStatsTreeView.Nodes.Clear();
        }
        
        private void LoginButtonClickEvent(object sender, EventArgs e)
        {
            PanelSwitch(_mainMenuPanel, _loginPanel);
            FillLoginCheckedListBox();
        }

        private void LoginCheckedListBoxItemCheckEvent(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue != CheckState.Checked || !(sender is CheckedListBox list)) return;
            foreach (int listCheckedIndex in list.CheckedIndices)
            {
                if (listCheckedIndex != e.Index)
                {
                    list.SetItemChecked(listCheckedIndex, false);
                }
            }
        }

        private void LoginCheckedListBoxMouseClickEvent(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < _loginCheckedListBox.Items.Count; ++i)
            {
                if (_loginCheckedListBox.GetItemRectangle(i).Contains(_loginCheckedListBox.PointToClient(MousePosition)))
                {
                    switch (_loginCheckedListBox.GetItemCheckState(i))
                    {
                        case CheckState.Checked:
                            _loginCheckedListBox.SetItemCheckState(i, CheckState.Unchecked);
                            break;
                        default:
                            _loginCheckedListBox.SetItemCheckState(i, CheckState.Checked);
                            break;
                    }
                }
            }
        }

        private void ContinueButtonClickEvent(object sender, EventArgs e)
        {
            if (_loginCheckedListBox.Items.Count == decimal.Zero) return;
            for (int i = 0; i < _loginCheckedListBox.Items.Count; ++i)
            {
                if (!_loginCheckedListBox.GetItemChecked(i)) continue;
                if (!ProfileManager.Login(_loginCheckedListBox.Items[i].ToString().ToLower())) return;
                PanelSwitch(_loginPanel, _profileMenuPanel);
                _profileNameTitle.Text = _loginCheckedListBox.Items[i].ToString();
                _loginCheckedListBox.Items.Clear();
                break;
            }
        }

        private void ProfileMenuBackButtonClickEvent(object sender, EventArgs e)
        {
            PanelSwitch(_profileMenuPanel, _loginPanel);
            FillLoginCheckedListBox();
        }

        private void ViewProfileStatsButtonClickEvent(object sender, EventArgs e)
        {
            PanelSwitch(_profileMenuPanel, _profileStatsPanel);
            FillProfileStatsTreeView();
        }

        private void ProfileStartNewGameButtonClickEvent(object sender, EventArgs e)
        {
            GameData.ResetData(_profileNameTitle.Text.ToLower());
            StartNewGame();
        }

        private void StartGameButtonClickEvent(object sender, EventArgs e)
        {
            if (!_profileNameTextBox.Text.Any()) return;
            if (IsProfileExist(_profileNameTextBox.Text.ToLower()))
            {
                MessageBox.Show("Профиль с таким именем уже существует!", "Ошибка!");
                return;
            }
            
            StartNewGame(true);
        }
        
        private void ProfileStatsBackButtonClickEvent(object sender, EventArgs e)
        {
            PanelSwitch(_profileStatsPanel, _profileMenuPanel);
            _profileStatsTreeView.Nodes.Clear();
        }
        
        private void MainMenuForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.F4) return;
            AdvancedSettingsForm advancedSettingsForm = new AdvancedSettingsForm();
            advancedSettingsForm.ShowDialog();
        }
        
        private void StartNewGame(bool isNewProfile = false)
        {
            SokobanForm sokobanForm = new SokobanForm();

            if (!LevelManager.StartGame())
            {
                sokobanForm.Close();
                return;
            }
            if (isNewProfile) ProfileManager.CreateProfile(_profileNameTextBox.Text.ToLower());
            this.Visible = false;
            sokobanForm.ShowDialog();
            ProfileManager.RecordLevelState();
            GameData.SaveData();
            this.Close();
        }

        private void ContinueGame()
        {
            SokobanForm sokobanForm = new SokobanForm();
            
            if (!LevelManager.StartGame(ProfileManager.GetCurrentProfile().CurrentLevel))
            {
                sokobanForm.Close();
                return;
            }
            Level.LoadLevelState(ProfileManager.GetCurrentProfile().CurrentLevelStateList);
            this.Visible = false;
            sokobanForm.ShowDialog();
            ProfileManager.RecordLevelState();
            GameData.SaveData();
            this.Close();
        }
        
        
        private void FillLoginCheckedListBox()
        {
            foreach (Profile profile in ProfileManager.Profiles)
            {
                _loginCheckedListBox.Items.Add(profile.ProfileName);
            }
        }
        
        private void FillGlobalStatsTreeView()
        {
            int countOfLevels = 0;

            _globalStatsTreeView.Nodes.Add("Profiles", "Профили");
            foreach (Profile profile in ProfileManager.Profiles)
            {
                _globalStatsTreeView.Nodes["Profiles"].Nodes.Add(profile.ProfileName, profile.ProfileName);

                foreach (Stats stats in profile.LevelsStatsList)
                {
                    countOfLevels++;
                    
                    _globalStatsTreeView.Nodes["Profiles"].Nodes[profile.ProfileName].Nodes.Add(countOfLevels.ToString(), countOfLevels.ToString());
                    _globalStatsTreeView.Nodes["Profiles"].Nodes[profile.ProfileName].Nodes[countOfLevels.ToString()].Nodes.Add("Количество шагов").Nodes.Add($"{stats.CountOfSteps}");
                    _globalStatsTreeView.Nodes["Profiles"].Nodes[profile.ProfileName].Nodes[countOfLevels.ToString()].Nodes.Add("Количество толчков ящика").Nodes.Add($"{stats.CountOfCrateBumps}");
                }

                countOfLevels = 0;
            }
        }
        
        private void FillProfileStatsTreeView()
        {
            int countOfLevels = 0;
            
            _profileStatsTreeView.Nodes.Add("Levels", "Уровни");
            foreach (Stats stats in ProfileManager.GetCurrentProfile().LevelsStatsList)
            {
                countOfLevels++;

                _profileStatsTreeView.Nodes["Levels"].Nodes.Add(countOfLevels.ToString(), countOfLevels.ToString());
                _profileStatsTreeView.Nodes["Levels"].Nodes[countOfLevels.ToString()].Nodes.Add("Количество шагов").Nodes.Add($"{stats.CountOfSteps}");
                _profileStatsTreeView.Nodes["Levels"].Nodes[countOfLevels.ToString()].Nodes.Add("Количество толчков ящика").Nodes.Add($"{stats.CountOfCrateBumps}");
            }
        }
        
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) => keyData == Keys.Space || base.ProcessCmdKey(ref msg, keyData);
    }
}