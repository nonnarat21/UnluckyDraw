using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using S = UnluckyDraw.Properties;

namespace UnluckyDraw
{
    /// <summary>
    /// Interaction logic for SettingWindow.xaml
    /// </summary>
    public partial class SettingWindow : Window
    {
        public SettingWindow()
        {
            InitializeComponent();
        }

        private List<TextBox> playerNameSettingList = new List<TextBox>();
        private List<TextBox> cardScoreSettingList = new List<TextBox>();
        private List<ComboBox> cardTypeSettingList = new List<ComboBox>();

        #region Event
        private void Window_Initialized(object sender, EventArgs e)
        {
            InitialSetting();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < cardScoreSettingList.Count; i++)
            {
                if (!ValidateCardScore(cardScoreSettingList[i].Text))
                {
                    var errorValue = cardScoreSettingList[i].Text == string.Empty ? "Empty" : cardScoreSettingList[i].Text;
                    MessageBox.Show(string.Format("Invalid Card Value!!!\nCard NO {0} = {1}", i + 1, errorValue), "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
            }

            if (ValidatePlayerNumber())
            {
                MessageBox.Show("Not have player", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            SavePlayerName();
            SaveCardData();
            S.Settings.Default.ExportPath = txbExportPath.Text;
            S.Settings.Default.Save();

            MessageBox.Show("Save Successful!!!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void CbxCard1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UnableFreeTypeScore(0);
        }

        private void CbxCard2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UnableFreeTypeScore(1);
        }

        private void CbxCard3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UnableFreeTypeScore(2);
        }

        private void CbxCard4_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UnableFreeTypeScore(3);
        }

        private void CbxCard5_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UnableFreeTypeScore(4);
        }

        private void CbxCard6_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UnableFreeTypeScore(5);
        }

        private void CbxCard7_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UnableFreeTypeScore(6);
        }

        private void CbxCard8_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UnableFreeTypeScore(7);
        }

        private void CbxCard9_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UnableFreeTypeScore(8);
        }

        private void CbxCard10_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UnableFreeTypeScore(9);
        }

        private void CbxCard11_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UnableFreeTypeScore(10);
        }

        private void CbxCard12_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UnableFreeTypeScore(11);
        }

        private void CbxCard13_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UnableFreeTypeScore(12);
        }

        private void CbxCard14_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UnableFreeTypeScore(13);
        }

        private void CbxCard15_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UnableFreeTypeScore(14);
        }

        private void CbxCard16_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UnableFreeTypeScore(15);
        }

        private void CbxCard17_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UnableFreeTypeScore(16);
        }

        private void CbxCard18_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UnableFreeTypeScore(17);
        }

        private void CbxCard19_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UnableFreeTypeScore(18);
        }

        private void CbxCard20_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UnableFreeTypeScore(19);
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            foreach (var playerNameSetting in playerNameSettingList)
            {
                playerNameSetting.Text = string.Empty;
            }

            for (int i = 0; i < cardScoreSettingList.Count; i++)
            {
                cardScoreSettingList[i].Text = "0";
                cardScoreSettingList[i].IsEnabled = true;
                cardTypeSettingList[i].SelectedIndex = 0;
            }

            txbExportPath.Text = string.Empty;
        }

        #endregion

        #region Function
        private void InitialSetting()
        {
            PreparePlayerNameSetting();
            PrepareCardScoreSetting();
            PrepareCardTypeSetting();

            InitialSettingPlayerName();
            InitialSettingCard();

            txbExportPath.Text = S.Settings.Default.ExportPath;
        }

        private void PreparePlayerNameSetting()
        {
            playerNameSettingList.Clear();
            playerNameSettingList.Add(txbPlayer1);
            playerNameSettingList.Add(txbPlayer2);
            playerNameSettingList.Add(txbPlayer3);
            playerNameSettingList.Add(txbPlayer4);
            playerNameSettingList.Add(txbPlayer5);
            playerNameSettingList.Add(txbPlayer6);
            playerNameSettingList.Add(txbPlayer7);
            playerNameSettingList.Add(txbPlayer8);
            playerNameSettingList.Add(txbPlayer9);
            playerNameSettingList.Add(txbPlayer10);

            foreach (var playerNameSetting in playerNameSettingList)
            {
                playerNameSetting.Text = string.Empty;
            }
        }

        private void PrepareCardScoreSetting()
        {
            cardScoreSettingList.Clear();
            cardScoreSettingList.Add(txbCard1);
            cardScoreSettingList.Add(txbCard2);
            cardScoreSettingList.Add(txbCard3);
            cardScoreSettingList.Add(txbCard4);
            cardScoreSettingList.Add(txbCard5);
            cardScoreSettingList.Add(txbCard6);
            cardScoreSettingList.Add(txbCard7);
            cardScoreSettingList.Add(txbCard8);
            cardScoreSettingList.Add(txbCard9);
            cardScoreSettingList.Add(txbCard10);
            cardScoreSettingList.Add(txbCard11);
            cardScoreSettingList.Add(txbCard12);
            cardScoreSettingList.Add(txbCard13);
            cardScoreSettingList.Add(txbCard14);
            cardScoreSettingList.Add(txbCard15);
            cardScoreSettingList.Add(txbCard16);
            cardScoreSettingList.Add(txbCard17);
            cardScoreSettingList.Add(txbCard18);
            cardScoreSettingList.Add(txbCard19);
            cardScoreSettingList.Add(txbCard20);

            foreach (var cardScoreSetting in cardScoreSettingList)
            {
                cardScoreSetting.Text = string.Empty;
            }
        }

        private void PrepareCardTypeSetting()
        {
            cardTypeSettingList.Clear();
            cardTypeSettingList.Add(cbxCard1);
            cardTypeSettingList.Add(cbxCard2);
            cardTypeSettingList.Add(cbxCard3);
            cardTypeSettingList.Add(cbxCard4);
            cardTypeSettingList.Add(cbxCard5);
            cardTypeSettingList.Add(cbxCard6);
            cardTypeSettingList.Add(cbxCard7);
            cardTypeSettingList.Add(cbxCard8);
            cardTypeSettingList.Add(cbxCard9);
            cardTypeSettingList.Add(cbxCard10);
            cardTypeSettingList.Add(cbxCard11);
            cardTypeSettingList.Add(cbxCard12);
            cardTypeSettingList.Add(cbxCard13);
            cardTypeSettingList.Add(cbxCard14);
            cardTypeSettingList.Add(cbxCard15);
            cardTypeSettingList.Add(cbxCard16);
            cardTypeSettingList.Add(cbxCard17);
            cardTypeSettingList.Add(cbxCard18);
            cardTypeSettingList.Add(cbxCard19);
            cardTypeSettingList.Add(cbxCard20);

            foreach (var cardTypeSetting in cardTypeSettingList)
            {
                cardTypeSetting.Text = string.Empty;
            }
        }

        private void InitialSettingPlayerName()
        {
            var players = S.Settings.Default.PlayerList.Split(',').ToList();

            int i = 0;
            foreach (var player in players)
            {
                playerNameSettingList[i].Text = player;
                i++;
            }
        }

        private void InitialSettingCard()
        {
            var cards = S.Settings.Default.CardList.Split(',').ToList();

            int i = 0;
            foreach (var card in cards)
            {
                var cardData = card.Split('/');
                cardScoreSettingList[i].Text = cardData[0];

                if (cardData[1] == "P") cardTypeSettingList[i].SelectedIndex = 0;
                else if (cardData[1] == "S") cardTypeSettingList[i].SelectedIndex = 1;
                else if (cardData[1] == "F")
                {
                    cardTypeSettingList[i].SelectedIndex = 2;
                    cardScoreSettingList[i].IsEnabled = false;
                }

                i++;
            }
        }

        private void SavePlayerName()
        {
            S.Settings.Default.PlayerList = string.Empty;

            for (int i = 0; i < playerNameSettingList.Count; i++)
            {
                if (playerNameSettingList[i].Text != string.Empty && i == 0)
                {
                    S.Settings.Default.PlayerList = S.Settings.Default.PlayerList + playerNameSettingList[i].Text;
                }
                else if (playerNameSettingList[i].Text != string.Empty)
                {
                    S.Settings.Default.PlayerList = S.Settings.Default.PlayerList + "," + playerNameSettingList[i].Text;
                }
            }
        }

        private void SaveCardData()
        {
            S.Settings.Default.CardList = string.Empty;

            for (int i = 0; i < cardScoreSettingList.Count; i++)
            {
                var cardType = cardTypeSettingList[i].Text.Substring(0, 1);

                if (i != cardScoreSettingList.Count - 1)
                {
                    S.Settings.Default.CardList = S.Settings.Default.CardList + cardScoreSettingList[i].Text + "/" + cardType + ",";
                }
                else
                {
                    S.Settings.Default.CardList = S.Settings.Default.CardList + cardScoreSettingList[i].Text + "/" + cardType;
                }
            }
        }

        private void UnableFreeTypeScore(int cardNo)
        {
            if (cardTypeSettingList[cardNo].SelectedIndex == 2)
            {
                cardScoreSettingList[cardNo].IsEnabled = false;
                cardScoreSettingList[cardNo].Text = "0";
            }
            else cardScoreSettingList[cardNo].IsEnabled = true;
        }

        private bool ValidateCardScore(string cardScore)
        {
            return (int.TryParse(cardScore, out _));
        }

        private bool ValidatePlayerNumber()
        {
            var maxPlayerName = 0;
            for (int j = 0; j < playerNameSettingList.Count; j++)
            {
                var name = playerNameSettingList[j].Text.Trim();
                maxPlayerName = maxPlayerName < name.Length ? name.Length : maxPlayerName;
            }

            return (maxPlayerName == 0);
        }
        #endregion

    }
}
