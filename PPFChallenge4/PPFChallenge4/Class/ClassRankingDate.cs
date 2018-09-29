using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPFChallenge4
{
    class ClassRankingDate
    {
        #region Field
        public TimeSpan Result { get; set; }
        public string UserName { get; set; }
        public int MordNumber { get; set; }
        #endregion

        #region Constructor
        /// <summary>
        /// コンストラクター
        /// </summary>
        /// <param name="userName">名前</param>
        /// <param name="result">クリア時間</param>
        /// <param name="mordNumber">モード判別番号</param>
        public ClassRankingDate(string userName, TimeSpan result, int mordNumber)
        {
            Result = result;
            UserName = userName;
            MordNumber = mordNumber;
        }
        #endregion
    }
}
