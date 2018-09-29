using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPFChallenge4
{
    public partial class UserControlGameScreen : UserControl
    {
        #region Field
        List<ClassQuestiones> Questiones = new List<ClassQuestiones>();
        System.Diagnostics.Stopwatch Stopwatch = new System.Diagnostics.Stopwatch();
        public static FormTipngGame Main = new FormTipngGame();
        public static UserControlSelectDisplay SelectDisplay;
        public int TextCount = 0;
        public string QuestionText;
        public string ReplyText;
        public string RomajiText;
        public int MistakeCount = 0;
        public int RemoveCount;
        public int StageCount;
        public int QuestionesDataCount;
        public TimeSpan Result;
        public int DisplayCount;
        public int NowMordNumber;
        #endregion

        #region Constructor
        /// <summary>
        /// コンストラクター
        /// </summary>
        public UserControlGameScreen()
        {
            InitializeComponent();
            QuestionesData();
        }
        #endregion

        #region Event
        /// <summary>
        /// 画面のロード
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void UserControlGameScreen_Load(object sender, EventArgs e)
        {
            labelStart.Focus();
            labelStart.BackColor = Color.Transparent;
            labelCongraturation.BackColor = Color.Transparent;
        }

        /// <summary>
        /// 一時停止
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void checkBoxPause_CheckedChanged(object sender, EventArgs e)
        {
            Stopwatch.Stop();
            if (checkBoxPause.Checked)
            {
                pictureBoxGameScreen.Enabled = false;
                while (true)
                {
                    Sleep(500);
                    if (!(checkBoxPause.Checked)) break;
                }
                Stopwatch.Start();
                pictureBoxGameScreen.Enabled = true;
                labelReply.Focus();
            }
        }

        /// <summary>
        /// メニューに戻る
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void checkBoxDiscontinuation_CheckedChanged(object sender, EventArgs e)
        {
            Stopwatch.Reset();
            ScreenReset();
            FormTipngGame.GameScreen.Visible = false;
            FormTipngGame.SelectDisplay.Visible = true;
        }

        /// <summary>
        /// キー取得でゲームスタート
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void labelStart_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            Stopwatch.Start();
            labelStart.Visible = false;
            labelReply.Focus();
            Question();
        }

        /// <summary>
        /// ユーザーのキー入力を取得
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void labelReply_PreviewKeyDown_1(object sender, PreviewKeyDownEventArgs e)
        {
            if (MistakeCount == 1)
            {
                ReplyText = labelReply.Text;
                RemoveCount = ReplyText.Length - 1;
                labelReply.Text = ReplyText.Remove(RemoveCount, 1);
                MistakeCount--;
            }
            string key = e.KeyCode.ToString();
            string s = RomajiText[TextCount].ToString();
            if (key.Length == 1) labelReply.Text += e.KeyCode.ToString();
            else
            {
                System.Media.SystemSounds.Beep.Play();
                MistakeCount--;
            }

            if (s == key) TextCount++;
            else
            {
                System.Media.SystemSounds.Beep.Play();
                MistakeCount++;
            }

            if (RomajiText == labelReply.Text)
            {
                this.pictureBoxEnemy.Focus();
                pictureBoxEnemy.Image = Image.FromFile(@"C:..\..\Resources\pipo-btleffect164_sample.gif");
                Sleep(1300);
                ScreenReset();
                if (StageCount % 3 != 0) Question();
                else Clear();
            }
        }

        /// <summary>
        /// 画面移行前の処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void buttonClear_Click_1(object sender, EventArgs e)
        {
            buttonClear.Visible = false;
            buttonClear.Enabled = false;
            labelStart.Visible = false;
            checkBoxDiscontinuation.Visible = false;
            checkBoxPause.Visible = false;
            labelStart.Text = "スペースキーでスタート";
            DisplayCount = 1;
            FormTipngGame.GameScreen.Visible = false;
        }

        /// <summary>
        /// ラベルにフォーカスをあてる
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void UserControlGameScreen_Click(object sender, EventArgs e)
        {
            labelReply.Focus();
        }
        #endregion

        #region ChangeScreen
        /// <summary>
        /// 問題の描写
        /// </summary>
        public void Question()
        {
            pictureBoxGameScreen.Image = Image.FromFile(@"C:..\..\Resources\" + Questiones[StageCount].QuestionPass);
            Sleep(2000);
            ControlDisplayOn();
            pictureBoxEnemy.BackgroundImage = Image.FromFile(@"C:..\..\Resources\" + Questiones[StageCount].EnemyPass);
            pictureBoxEnemy.BackColor = Color.Transparent;
            pictureBoxGameScreen.Controls.Add(pictureBoxEnemy);
            this.labelReply.Focus();
            RomajiText = Questiones[StageCount].RomajiTextUpper;
            QuestionText = Questiones[StageCount].Question;
            labelQuestion.Text = QuestionText + "\n" + RomajiText;
        }

        /// <summary>
        /// 画面のリセット
        /// </summary>
        public void ScreenReset()
        {
            pictureBoxEnemy.Image = null;
            pictureBoxEnemy.BackgroundImage = null;
            pictureBoxGameScreen.Image = null;
            labelReply.Text = null;
            TextCount = 0;
            pictureBoxEnemy.Visible = false;
            labelReply.Visible = false;
            labelQuestion.Visible = false;
            StageCount++;
        }

        /// <summary>
        /// ロード時の描写の切り替え
        /// </summary>
        public void ControlDisplayOn()
        {
            checkBoxDiscontinuation.Visible = true;
            checkBoxDiscontinuation.Enabled = true;
            checkBoxPause.Visible = true;
            checkBoxPause.Enabled = true;
            labelReply.Visible = true;
            pictureBoxEnemy.Visible = true;
            labelQuestion.Visible = true;
        }

        /// <summary>
        /// クリア時の描写の切り替え
        /// </summary>
        public void ClearControlDisplayOn()
        {
            labelCongraturation.Visible = true;
            buttonClear.Visible = true;
            buttonClear.Enabled = true;
            checkBoxDiscontinuation.Visible = false;
            checkBoxDiscontinuation.Enabled = false;
            checkBoxPause.Visible = false;
            checkBoxPause.Enabled = false;
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
        /// クリア後の処理
        /// </summary>
        public void Clear()
        {
            checkBoxDiscontinuation.Visible = false;
            checkBoxPause.Visible = false;
            Stopwatch.Stop();
            pictureBoxGameScreen.Image = null;
            pictureBoxGameScreen.Image = Image.FromFile(@"C:..\..\Resources\017203583c085fa801219c77ba5704.jpg.gif");
            ClearControlDisplayOn();
            Result = Stopwatch.Elapsed;
            NowMordNumber = StageCount;
            StageCount = 1;
            DisplayCount = 1;
            Stopwatch.Reset();
        }

        /// <summary>
        ///ファイルから問題を読み込みインスタンスに
        /// </summary>
        private void QuestionesData()
        {
            System.IO.StreamReader sr = new System.IO.StreamReader(@"C:..\..\Resources\Questiones.csv", Encoding.GetEncoding("UTF-8"));
            string stResult = string.Empty;
            while (sr.Peek() >= 0)
            {
                string stBuffer = sr.ReadLine();
                stResult += stBuffer + Environment.NewLine;
            }
            sr.Close();

            string[] del = { "\r\n" };
            // 段らく区切りで分割して配列に格納する
            string[] QuestionesData = stResult.Split(del, StringSplitOptions.None);
            QuestionesDataCount = QuestionesData.Length;
            string QuestionesConfiguration;
            string[] eachQuestiones;

            for (int i = 0; i < QuestionesDataCount - 1; i++)
            {
                QuestionesConfiguration = QuestionesData[i];
                eachQuestiones = QuestionesConfiguration.Split(',');
                Questiones.Add(new ClassQuestiones(eachQuestiones[0], eachQuestiones[1], eachQuestiones[2], eachQuestiones[3]));
            }
        }
        #endregion
    }
}
