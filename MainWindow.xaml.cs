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
using System.Windows.Navigation;
using System.Windows.Shapes;
using S = UnluckyDraw.Properties.Settings;
using UnluckyDraw.Implement;
using System.IO;

namespace UnluckyDraw
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private List<Player> playerList = new List<Player>();
        private List<string> cardList = new List<string>();
        private List<Label> playerScoreList = new List<Label>();
        private List<Label> playerNameList = new List<Label>();
        private List<Button> cardForDrawList = new List<Button>();
        private int playerSequence = 0;

        #region Event
        private void FrmMain_Initialized(object sender, EventArgs e)
        {
            var rea = new RoutedEventArgs();
            BtnNewGame_Click(sender, rea);
        }

        private void BtnNewGame_Click(object sender, RoutedEventArgs e)
        {
            InitialGame();

            var players = ShuffleList(S.Default.PlayerList.Split(',').ToList());
            cardList = ShuffleList(S.Default.CardList.Split(',').ToList());

            int i = 0;
            foreach (var player in players)
            {
                playerList.Add(new Player(player));
                playerNameList[i].Content = playerList[i].GetPlayerName();
                playerNameList[i].Visibility = Visibility.Visible;
                playerScoreList[i].Visibility = Visibility.Visible;

                i++;
            }
        }

        private void BtnCardA_Click(object sender, RoutedEventArgs e)
        {
            DrawCard(0);
        }

        private void BtnCardB_Click(object sender, RoutedEventArgs e)
        {
            DrawCard(1);
        }

        private void BtnCardC_Click(object sender, RoutedEventArgs e)
        {
            DrawCard(2);
        }

        private void BtnCardD_Click(object sender, RoutedEventArgs e)
        {
            DrawCard(3);
        }

        private void BtnCardE_Click(object sender, RoutedEventArgs e)
        {
            DrawCard(4);
        }

        private void BtnCardF_Click(object sender, RoutedEventArgs e)
        {
            DrawCard(5);
        }

        private void BtnCardG_Click(object sender, RoutedEventArgs e)
        {
            DrawCard(6);
        }

        private void BtnCardH_Click(object sender, RoutedEventArgs e)
        {
            DrawCard(7);
        }

        private void BtnCardI_Click(object sender, RoutedEventArgs e)
        {
            DrawCard(8);
        }

        private void BtnCardJ_Click(object sender, RoutedEventArgs e)
        {
            DrawCard(9);
        }

        private void BtnCardK_Click(object sender, RoutedEventArgs e)
        {
            DrawCard(10);
        }

        private void BtnCardL_Click(object sender, RoutedEventArgs e)
        {
            DrawCard(11);
        }

        private void BtnCardM_Click(object sender, RoutedEventArgs e)
        {
            DrawCard(12);
        }

        private void BtnCardN_Click(object sender, RoutedEventArgs e)
        {
            DrawCard(13);
        }

        private void BtnCardO_Click(object sender, RoutedEventArgs e)
        {
            DrawCard(14);
        }

        private void BtnCardP_Click(object sender, RoutedEventArgs e)
        {
            DrawCard(15);
        }

        private void BtnCardQ_Click(object sender, RoutedEventArgs e)
        {
            DrawCard(16);
        }

        private void BtnCardR_Click(object sender, RoutedEventArgs e)
        {
            DrawCard(17);
        }

        private void BtnCardS_Click(object sender, RoutedEventArgs e)
        {
            DrawCard(18);
        }

        private void BtnCardT_Click(object sender, RoutedEventArgs e)
        {
            DrawCard(19);
        }

        private void BtnSetting_Click(object sender, RoutedEventArgs e)
        {
            var settingWindow = new SettingWindow();
            settingWindow.ShowDialog();

            var rea = new RoutedEventArgs();
            BtnNewGame_Click(sender, rea);
        }

        private void BtnExport_Click(object sender, RoutedEventArgs e)
        {
            var result = WriteToXls(ScoreToCSV());

            if (result != "Success")
            {
                MessageBox.Show(string.Format("Export error: {0}", result), "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                MessageBox.Show("Export success!!!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
        #endregion

        #region Function
        private List<string> ShuffleList(List<string> list)
        {
            List<string> result = new List<string>();
            var listCount = list.Count();

            for (int i = 0; i < listCount; i++)
            {
                Random rnd = new Random();
                var randomItem = rnd.Next(0, listCount - i);

                result.Add(list[randomItem]);
                list.RemoveAt(randomItem);
            }

            return result;
        }

        private void InitialGame()
        {
            playerSequence = 0;
            playerList.Clear();

            playerNameList.Clear();
            playerNameList.Add(lblPlayer1);
            playerNameList.Add(lblPlayer2);
            playerNameList.Add(lblPlayer3);
            playerNameList.Add(lblPlayer4);
            playerNameList.Add(lblPlayer5);
            playerNameList.Add(lblPlayer6);
            playerNameList.Add(lblPlayer7);
            playerNameList.Add(lblPlayer8);
            playerNameList.Add(lblPlayer9);
            playerNameList.Add(lblPlayer10);

            playerScoreList.Clear();
            playerScoreList.Add(lblScore1);
            playerScoreList.Add(lblScore2);
            playerScoreList.Add(lblScore3);
            playerScoreList.Add(lblScore4);
            playerScoreList.Add(lblScore5);
            playerScoreList.Add(lblScore6);
            playerScoreList.Add(lblScore7);
            playerScoreList.Add(lblScore8);
            playerScoreList.Add(lblScore9);
            playerScoreList.Add(lblScore10);

            cardForDrawList.Clear();
            cardForDrawList.Add(btnCardA);
            cardForDrawList.Add(btnCardB);
            cardForDrawList.Add(btnCardC);
            cardForDrawList.Add(btnCardD);
            cardForDrawList.Add(btnCardE);
            cardForDrawList.Add(btnCardF);
            cardForDrawList.Add(btnCardG);
            cardForDrawList.Add(btnCardH);
            cardForDrawList.Add(btnCardI);
            cardForDrawList.Add(btnCardJ);
            cardForDrawList.Add(btnCardK);
            cardForDrawList.Add(btnCardL);
            cardForDrawList.Add(btnCardM);
            cardForDrawList.Add(btnCardN);
            cardForDrawList.Add(btnCardO);
            cardForDrawList.Add(btnCardP);
            cardForDrawList.Add(btnCardQ);
            cardForDrawList.Add(btnCardR);
            cardForDrawList.Add(btnCardS);
            cardForDrawList.Add(btnCardT);

            for (int i = 0; i < playerNameList.Count; i++)
            {
                playerNameList[i].Visibility = Visibility.Hidden;
                playerScoreList[i].Content = "0";
                playerScoreList[i].Visibility = Visibility.Hidden;

                if (i == 0) playerNameList[i].BorderBrush = System.Windows.Media.Brushes.Orange;
                else playerNameList[i].BorderBrush = System.Windows.Media.Brushes.Transparent;
            }

            var cardName = 'A';
            foreach (var cardForDraw in cardForDrawList)
            {
                cardForDraw.IsEnabled = true;
                cardForDraw.Content = cardName;

                cardName++;
            }

            btnExport.IsEnabled = false;
        }

        private void DrawCard(int cardNo)
        {
            var cardData = cardList[cardNo].Split('/');
            var factory = CardFactoryProvider.GetCardFactory(cardData[1]);
            var drawCard = factory.CreateDrawCard(int.Parse(cardData[0]));
            var stateCard = factory.CreateChangePlayerState();

            playerList[playerSequence].AddScore(drawCard.GetPlayerScore(playerList[playerSequence].GetPlayerScore()));
            playerScoreList[playerSequence].Content = playerList[playerSequence].GetPlayerScore();

            if (cardData[1] == "F") cardForDrawList[cardNo].Content = "Free";
            else if (cardData[1] == "S") cardForDrawList[cardNo].Content = "+" + cardData[0];
            else cardForDrawList[cardNo].Content = cardData[0];

            cardForDrawList[cardNo].IsEnabled = false;

            if (stateCard.ChangePlayerState() == "Stop")
            {
                playerNameList[playerSequence].BorderBrush = System.Windows.Media.Brushes.Transparent;
                playerSequence++;              
                playerNameList[playerSequence].BorderBrush = System.Windows.Media.Brushes.Orange;
            }

            if (playerSequence == playerList.Count)
            {
                foreach (var cardForDraw in cardForDrawList)
                {
                    cardForDraw.IsEnabled = false;
                }

                btnExport.IsEnabled = true;
            }
        }

        public string ScoreToCSV(string separator = ",")
        {
            StringBuilder builder = new StringBuilder(Convert.ToString((char)65279));

            for (int i = -1; i <= playerSequence - 1; i++)
            {
                List<string> tempList = new List<string>();

                if (i == -1)
                {
                    tempList.Add("Player");
                    tempList.Add("Score");
                    tempList.Add("Pay");
                }
                else
                {
                    tempList.Add(playerNameList[i].Content.ToString());
                    tempList.Add(playerScoreList[i].Content.ToString());
                    tempList.Add(string.Empty);
                }

                builder.Append(string.Join(separator, tempList)).Append(Environment.NewLine);
            }
            return builder.ToString();
        }

        private string WriteToXls(string dataToWrite)
        {
            try
            {
                string destination = "Scoreboard_" + DateTime.Now.ToString("yyyyMMdd");

                if (S.Default.ExportPath.EndsWith("\\"))
                {
                    destination = S.Default.ExportPath + destination + ".xls";
                }
                else
                {
                    destination = S.Default.ExportPath + "\\" + destination + ".xls";
                }
                
                FileStream fs = new FileStream(destination, FileMode.Create, FileAccess.Write);
                StreamWriter objWrite = new StreamWriter(fs);
                objWrite.Write(dataToWrite);
                objWrite.Close();

                return "Success";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        #endregion

        
    }
}
