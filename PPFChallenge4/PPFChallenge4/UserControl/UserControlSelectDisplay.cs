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
    public partial class UserControlSelectDisplay : UserControl
    {
        #region Field
        public int StageCount = 1;
        public int DisplayCount;
        public int Exit;
        #endregion

        #region Constructor
        /// <summary>
        /// コンストラクター
        /// </summary>
        public UserControlSelectDisplay()
        {
            InitializeComponent();
        }
        #endregion

        #region Event
        /// <summary>
        /// 画面のロード
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void UserControlSelectDisplay_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"C:..\..\Resources\titlr.png");
        }

        /// <summary>
        /// イージーモード説明
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void buttonEasy_MouseEnter(object sender, EventArgs e)
        {
            labelDescription.Text = "初心者モードです。\nウォーミングアップに素早く\n" +
                "敵を倒して上位をめざそう！";
        }

        /// <summary>
        /// イージーモード説明非表示
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void buttonEasy_MouseLeave(object sender, EventArgs e)
        {
            labelDescription.Text = null;
        }

        /// <summary>
        /// ノーマルモード説明
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void buttonNormal_MouseEnter(object sender, EventArgs e)
        {
            labelDescription.Text = "標準モードです。\nウォーミングアップが終わったら\n" +
                "早く打てる様に練習しましょう";
        }

        /// <summary>
        /// ノーマルモード説明非表示
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void buttonNormal_MouseLeave(object sender, EventArgs e)
        {
            labelDescription.Text = null;
        }

        /// <summary>
        /// ハードモード説明
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void buttonHard_MouseEnter(object sender, EventArgs e)
        {
            labelDescription.Text = "難しいモードです。\n自身のある方はこのモード\n" +
                                    "少し長めの文章を素早く打ち込みランキング上位をめざそう！\n";
        }

        /// <summary>
        /// ハードモード説明非表示
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void buttonHard_MouseLeave(object sender, EventArgs e)
        {
            labelDescription.Text = null;
        }

        /// <summary>
        /// ベリーハードモード説明
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void buttonBerryHard_MouseEnter(object sender, EventArgs e)
        {
            labelDescription.Text = "とても難しいモードです。\n最後の問題の読み方に気をつけて\n" +
                "早く敵を倒してランキング上位をめざそう！\n" +
                                    "ヒント：ある漫画に出てくる言葉だよ！";
        }

        /// <summary>
        /// ベリーハードモード説明非表示
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void buttonBerryHard_MouseLeave(object sender, EventArgs e)
        {
            labelDescription.Text = null;
        }

        /// <summary>
        /// カスタムモード説明
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void buttonCustom_MouseEnter(object sender, EventArgs e)
        {
            labelDescription.Text = "カスタムモードです。\n問題を自分で作って遊ぶ事ができます。\n未実装";
        }

        /// <summary>
        /// カスタムモード説明非表示
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void buttonCustom_MouseLeave(object sender, EventArgs e)
        {
            labelDescription.Text = null;
        }

        /// <summary>
        /// イージーモード選択
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void buttonEasy_Click(object sender, EventArgs e)
        {
            StageCount = 0;
            FormTipngGame.SelectDisplay.Visible = false;
        }

        /// <summary>
        /// ノーマルモード選択
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void buttonNormal_Click(object sender, EventArgs e)
        {
            StageCount = 3;
            FormTipngGame.SelectDisplay.Visible = false;
        }

        /// <summary>
        /// ハードモード選択
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void buttonHard_Click(object sender, EventArgs e)
        {
            StageCount = 6;
            FormTipngGame.SelectDisplay.Visible = false;
        }

        /// <summary>
        /// ベリーハードモード選択
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void buttonBerryHard_Click(object sender, EventArgs e)
        {
            StageCount = 9;
            FormTipngGame.SelectDisplay.Visible = false;
        }

        /// <summary>
        /// カスタムモード選択
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void buttonCustom_Click(object sender, EventArgs e)
        {
            StageCount = 12;
            FormTipngGame.SelectDisplay.Visible = false;
        }

        /// <summary>
        /// 終了ボタン選択
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Exit = 1;
            FormTipngGame.SelectDisplay.Visible = false;
        }
        #endregion
    }
}
