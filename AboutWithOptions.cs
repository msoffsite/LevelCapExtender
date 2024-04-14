using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace LevelCapExtender
{
    public partial class AboutForm : Form
    {
        private const string _gameName = "Baldur's Gate 3";
        private string _gameLocation = string.Empty;
        private const string _dataFolder = "Data";
        private string _modLocation = @"\Public\SharedDev\Stats\Generated\Data\";
        private string _levelCapExtenderDirectory = string.Empty;
        public AboutForm()
        {
            InitializeComponent();

            CenterToScreen();

            TextBoxAboutExtender.ReadOnly = true;

            ChooseLevelCapExtenderPanel.Visible = false;

            _levelCapExtenderDirectory = AppDomain.CurrentDomain.BaseDirectory;

            playBaldursGate3LinkLabel.LinkClicked += new LinkLabelLinkClickedEventHandler(playBaldursGate3LinkLabel_LinkClicked);

            eclecticXAtYouTubeChannelLinkLabel.LinkClicked += new LinkLabelLinkClickedEventHandler(eclecticXAtYouTubeChannelLinkLabel_LinkClicked);
        }

        private void TextBoxAboutExtender_TextChanged(object sender, EventArgs e)
        {

        }

        private void GameInstallationFolderExample_Click(object sender, EventArgs e)
        {

        }

        private async void SelectGameInstallationFolderButton_Click(object sender, EventArgs e)
        {
            ChooseLevelCapExtenderPanel.Visible = false;

            openGameLocation.ShowDialog();

            string filePath = openGameLocation.FileName;

            int binIndex = filePath.IndexOf("bin", StringComparison.InvariantCultureIgnoreCase);
            if (binIndex == -1)
            {
                await ShowMessageBox("Cannot continue. The bin subfolder was not found.");
            }
            else
            {
                _gameLocation = filePath[..binIndex];
                _gameLocation += _dataFolder;

                if (!Path.Exists(_gameLocation))
                {
                    await ShowMessageBox("Cannot continue. The data subfolder was not found.");
                }
                else
                {
                    _modLocation = _gameLocation + _modLocation;

                    if (!Directory.Exists(_modLocation))
                    {
                        Directory.CreateDirectory(_modLocation);
                    }

                    List<string> files = new();

                    await Task.Run(() =>
                    {
                        files = Directory.GetFiles(_modLocation, "*.txt-bak").ToList();
                    });

                    LevelCapExtenderUninstallButton.Enabled = files.Any();

                    await Task.Run(() =>
                    {
                        files = Directory.GetFiles(_modLocation, "*Data.txt").ToList();
                    });

                    if (files.Count > 0)
                    {
                        MessageBox.Show("Existing files for XP have been detected. " +
                            "Changes are recommended for new playthroughs only. " +
                            "In-game changes to XP files can have adverse level effects. " +
                            "You should be fine if you aren't past level 3 and wish to increase " +
                            "the level cap. Otherwise, proceed with caution. This is ESPECIALLY true " +
                            "if you intend to decrease the level cap.");
                    }

                    ChooseLevelCapExtenderPanel.Visible = true;
                }
            }
        }

        private async Task CopyXpFiles(string chosenExtender)
        {
            string chosenLevelCapExtenderDirectory = _levelCapExtenderDirectory + $@"\LevelCaps\{chosenExtender}";
            List<string> files = [];

            await Task.Run(() =>
            {
                files = Directory.GetFiles(chosenLevelCapExtenderDirectory, "*.txt").ToList();
            });

            string modFilePath = string.Empty;
            foreach (string file in files)
            {
                await Task.Run(() =>
                {
                    string fileName = Path.GetFileName(file);
                    modFilePath = _modLocation + fileName;
                    if (File.Exists(modFilePath))
                    {
                        string destinationFilename = modFilePath.Replace(".txt", $" - {DateTime.Now:yyyy-MM-dd_HH-mm-ss-fff}" + ".txt");
                        destinationFilename = destinationFilename.Replace(".txt", ".txt-bak", StringComparison.InvariantCultureIgnoreCase);
                        File.Copy(modFilePath, destinationFilename, true);
                    }
                });

                await Task.Run(() =>
                {
                    File.Copy(file, modFilePath, true);
                });
            }
        }

        private async Task DeleteBakFiles()
        {
            List<string> files = [];

            await Task.Run(() =>
            {
                files = Directory.GetFiles(_modLocation, "*.txt-bak").ToList();
            });

            foreach (string file in files)
            {
                await Task.Run(() =>
                {
                    File.Delete(file);
                });
            }
        }

        private static async Task ShowMessageBox(string message)
        {
            DialogResult dialogResult = DialogResult.None;
            await Task.Run(() =>
            {
                dialogResult = MessageBox.Show(message);

            });

            if (dialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private async void LevelCapExtender2xButton_Click(object sender, EventArgs e)
        {
            string newLevelCap = "2x";
            await CopyXpFiles(newLevelCap);
            await ShowMessageBox($"{_gameName} now using {newLevelCap} level cap extender.");
        }

        private async void LevelCapExtender3xButton_Click(object sender, EventArgs e)
        {
            string newLevelCap = "3x";
            await CopyXpFiles(newLevelCap);
            await ShowMessageBox($"{_gameName} now using {newLevelCap} level cap extender."); ;
        }

        private async void LevelCapExtender4xButton_Click(object sender, EventArgs e)
        {
            string newLevelCap = "4x";
            await CopyXpFiles(newLevelCap);
            await ShowMessageBox($"{_gameName} now using {newLevelCap} level cap extender.");
        }

        private async void LevelCapExtender5xButton_Click(object sender, EventArgs e)
        {
            string newLevelCap = "5x";
            await CopyXpFiles(newLevelCap);
            await ShowMessageBox($"{_gameName} now using {newLevelCap} level cap extender.");
        }

        private async void LevelCapExtender6xButton_Click(object sender, EventArgs e)
        {
            string newLevelCap = "6x";
            await CopyXpFiles(newLevelCap);
            await ShowMessageBox($"{_gameName} now using {newLevelCap} level cap extender.");
        }

        private async void LevelCapExtenderUninstallButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = DialogResult.None;

            await Task.Run(() =>
            {
                dialogResult = MessageBox.Show("This will use the original leveling system of 100K MAX XP. Are you sure you wish to continue?",
                    null, MessageBoxButtons.OKCancel);

            });

            if (dialogResult == DialogResult.OK)
            {
                await CopyXpFiles("1x");
                await DeleteBakFiles();
                await ShowMessageBox($"{_gameName} now using original leveling system.");
            }
        }

        private void playBaldursGate3LinkLabel_LinkClicked(object? sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo("http://www.playbaldursgate3.com") { UseShellExecute = true});
        }

        private void eclecticXAtYouTubeChannelLinkLabel_LinkClicked(object? sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo("https://www.youtube.com/channel/UCoSGwhk4Ql18r4WNb-p5JLQ") { UseShellExecute = true });
        }
    }
}
