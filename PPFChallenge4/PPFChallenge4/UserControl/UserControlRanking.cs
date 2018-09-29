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
    public partial class UserControlRanking : UserControl
    {
        #region Field
        public int DisplayCount;
        const int EasyNumber = 3;
        const int NormalNumber = 6;
        const int HardNumber = 9;
        const int BerryHardNumber = 12;
        const int CustomNumber = 15;
        public int NowMordNumber;
        public int ReturnNumber = 0;
        #endregion

        #region Constructor
        /// <summary>
        /// コンストラクター
        /// </summary>
        public UserControlRanking()
        {
            InitializeComponent();
        }
        #endregion

        #region Event
        /// <summary>
        /// 選択画面に戻る
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void buttonSelect_Click(object sender, EventArgs e)
        {
            ReturnNumber++;
            dataGridViewRanking.Rows.Clear();
            FormTipngGame.Ranking.Visible = false;
            FormTipngGame.GameScreen.DisplayCount = 2;
            FormTipngGame.SelectDisplay.StageCount = 1;
        }

        /// <summary>
        /// ロード時にモードの取得
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void UserControlRanking_Load(object sender, EventArgs e)
        {
            if (NowMordNumber == EasyNumber) labelMord.Text = "Easy Ranking";
            else if (NowMordNumber == NormalNumber) labelMord.Text = "Normal Ranking";
            else if (NowMordNumber == HardNumber) labelMord.Text = "Hard Ranking";
            else if (NowMordNumber == BerryHardNumber) labelMord.Text = "BerryHard Ranking";
        }
        #endregion
    }
}
