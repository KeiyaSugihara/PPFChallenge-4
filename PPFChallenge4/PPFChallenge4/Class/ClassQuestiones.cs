using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPFChallenge4
{
    class ClassQuestiones
    {
        #region Field
        public string QuestionPass { get; set; }
        public string Question { get; set; }
        public string RomajiText { get; set; }
        public string RomajiTextUpper { get; set; }
        public string EnemyPass { get; set; }
        #endregion

        #region Constructor
        /// <summary>
        /// コンストラクター
        /// </summary>
        /// <param name="questionpass">問題背景画像のパス</param>
        /// <param name="question">問題</param>
        /// <param name="romaji">ローマ字表記</param>
        /// <param name="enemyPass">敵画像のパス</param>
        public ClassQuestiones(string questionpass, string question, string romaji, string enemyPass)
        {
            QuestionPass = questionpass;
            Question = question;
            RomajiText = romaji;
            RomajiTextUpper = romaji.ToUpper();
            EnemyPass = enemyPass;
        }
        #endregion
    }
}
