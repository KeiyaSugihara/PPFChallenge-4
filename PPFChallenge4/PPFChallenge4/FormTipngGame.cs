using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPFChallenge4
{
    public partial class FormTipngGame : Form
    {

        #region Field
        List<ClassRankingDate> RankingDate = new List<ClassRankingDate>();
        public static UserControlSelectDisplay SelectDisplay;
        public static UserControlGameScreen GameScreen;
        public static UserControlRanking Ranking;
        WMPLib.WindowsMediaPlayer mediaPlayer;
        public TimeSpan Result;
        public int StageCount;
        public int DisplayCount;
        const int EasyNumber = 0;
        const int NormalNumber = 3;
        const int HardNumber = 6;
        const int BerryHardNumber = 9;
        const int CustomNumber = 12;
        const int RankingPageNumber = 1;
        const int MeinDisplayNumber = 1;
        public int EasyRankingNumber = 0;
        public int NormalRankingNumber = 0;
        public int HardRankingNumber = 0;
        public int BerryHardRankingNumber = 0;
        public int ReturnNumber;
        #endregion

        #region Constructor
        /// <summary>
        /// コンストラクター
        /// </summary>
        public FormTipngGame()
        {
            InitializeComponent();
            SelectDisplay = new UserControlSelectDisplay();
            GameScreen = new UserControlGameScreen();
            Ranking = new UserControlRanking();
            mediaPlayer = new WMPLib.WindowsMediaPlayer();
        }
        #endregion

        #region Event
        /// <summary>
        /// ロードで画面のを描写
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void FormTipngGame_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"C:..\..\Resources\titlr.png");
            labelClick.BackColor = Color.Transparent;
            textBoxName.Visible = false;
            labelGetName.Visible = false;
            buttonOk.Visible = false;
            //mediaPlayer.URL = @"C:..\..\Resources\bgm_maoudamashii_cyber41.mp3";
            mediaPlayer.controls.play();
        }

        /// <summary>
        /// フォームクリックで画面切り替え
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void FormTipngGame_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            panelMain.Visible = true;
            panelMain.Enabled = true;
            labelClick.Visible = false;
            panelMain.Controls.Add(SelectDisplay);
        }

        /// <summary>
        /// 再描写で画面の切り替え
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void panelMain_Paint(object sender, PaintEventArgs e)
        {
            StageCount = SelectDisplay.StageCount;
            DisplayCount = GameScreen.DisplayCount;
            Result = GameScreen.Result;
            ReturnNumber = Ranking.ReturnNumber;
            if (StageCount == EasyNumber && DisplayCount != RankingPageNumber) GameScreenReDepiction();
            else if (StageCount == NormalNumber && DisplayCount != RankingPageNumber) GameScreenReDepiction();
            else if (StageCount == HardNumber && DisplayCount != RankingPageNumber) GameScreenReDepiction();
            else if (StageCount == BerryHardNumber && DisplayCount != RankingPageNumber) GameScreenReDepiction();
            else if (StageCount == CustomNumber && DisplayCount != RankingPageNumber) GameScreenReDepiction();
            else if (DisplayCount == RankingPageNumber && ReturnNumber != MeinDisplayNumber) RankingPageReDepiction();
            else if (SelectDisplay.Exit == 1) this.Close();
            else if (ReturnNumber == MeinDisplayNumber) SelectDisplayReDepiction();
        }

        /// <summary>
        /// モード別のランキング描写
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void buttonOk_Click(object sender, EventArgs e)
        {
            RankingSort();
            EasyRankingNumber = 0;
            NormalRankingNumber = 0;
            HardRankingNumber = 0;
            BerryHardRankingNumber = 0;
            panelMain.Controls.Add(Ranking);
            textBoxName.Visible = false;
            labelGetName.Visible = false;
            buttonOk.Visible = false;
        }
        #endregion

        #region ChangeScreen
        /// <summary>
        /// 選択画面からゲーム画面に切り替え
        /// </summary>
        public void GameScreenReDepiction()
        {
            mediaPlayer.controls.stop();
            Ranking.Dispose();
            SelectDisplay.Dispose();
            GameScreen = new UserControlGameScreen();
            GameScreen.StageCount = StageCount;
            panelMain.Controls.Add(GameScreen);
        }

        /// <summary>
        /// ゲーム画面からランキング画面に切り替え
        /// </summary>
        public void RankingPageReDepiction()
        {
            Ranking = new UserControlRanking();
            Ranking.NowMordNumber = GameScreen.NowMordNumber;
            GameScreen.Dispose();
            textBoxName.Visible = true;
            labelGetName.Visible = true;
            buttonOk.Visible = true;
        }

        /// <summary>
        /// ランキング画面から選択画面に切り替え
        /// </summary>
        public void SelectDisplayReDepiction()
        {
            Ranking.ReturnNumber = 0;
            Ranking.Dispose();
            SelectDisplay = new UserControlSelectDisplay();
            panelMain.Controls.Add(SelectDisplay);
        }
        #endregion

        #region ProcesInternal
        /// <summary>
        /// 指定時間処理を止める
        /// </summary>
        /// <param name="msec">インターバル</param>
        private void Sleep(long msec)
        {
            for (int i = 0; i < msec / 100; i++)
            {
                System.Threading.Thread.Sleep(100);
                Application.DoEvents();
            }
        }

        /// <summary>
        /// ランキングの並び替え
        /// </summary>
        public void RankingSort()
        {
            RankingDate.Add(new ClassRankingDate(textBoxName.Text, Result, GameScreen.NowMordNumber));
            RankingDate.Sort((a, b) => (a.Result.CompareTo(b.Result)));
            for (int i = 0; i < RankingDate.Count; i++)
            {
                switch (RankingDate[i].MordNumber)
                {
                    case 3:
                        EasyRankingNumber++;
                        Ranking.dataGridViewRanking.Rows.Add(EasyRankingNumber, RankingDate[i].UserName, RankingDate[i].Result);
                        break;
                    case 6:
                        NormalRankingNumber++;
                        Ranking.dataGridViewRanking.Rows.Add(NormalRankingNumber, RankingDate[i].UserName, RankingDate[i].Result);
                        break;
                    case 9:
                        HardRankingNumber++;
                        Ranking.dataGridViewRanking.Rows.Add(HardRankingNumber, RankingDate[i].UserName, RankingDate[i].Result);
                        break;
                    case 12:
                        BerryHardRankingNumber++;
                        Ranking.dataGridViewRanking.Rows.Add(BerryHardRankingNumber, RankingDate[i].UserName, RankingDate[i].Result);
                        break;
                }
            }
        }
        #endregion

    }
}
