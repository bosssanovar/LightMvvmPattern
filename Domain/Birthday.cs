﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    /// <summary>
    /// 誕生日クラス
    /// </summary>
    public class Birthday
    {
        #region Fields ----------------------------------------------------------------------------------------

        private readonly int _year = 1980;
        private readonly int _month = 1;
        private readonly int _day = 1;

        #endregion --------------------------------------------------------------------------------------------

        #region Constants -------------------------------------------------------------------------------------

        #endregion --------------------------------------------------------------------------------------------

        #region Properties ------------------------------------------------------------------------------------

        /// <summary>
        /// 年齢を取得します。
        /// </summary>
        public int Age
        {
            get
            {
                DateTime today = DateTime.Today;
                int age = today.Year - _year;

                // 誕生日がまだ来ていなければ、1引く
                if (today.Month < _month ||
                    (today.Month == _month &&
                    today.Day < _day))
                {
                    age--;
                }

                return age;
            }
        }

        /// <summary>
        /// 生年月日の文字列を取得します。
        /// </summary>
        public string Text
        {
            get
            {
                return $"{_year}/{_month}/{_day}";
            }
        }

        #endregion --------------------------------------------------------------------------------------------

        #region Events ----------------------------------------------------------------------------------------

        #endregion --------------------------------------------------------------------------------------------

        #region Constructor -----------------------------------------------------------------------------------

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="year">誕生年</param>
        /// <param name="month">誕生月</param>
        /// <param name="day">誕生日</param>
        public Birthday(int year, int month, int day)
        {
            _year = year;
            _month = month;
            _day = day;
        }

        #endregion --------------------------------------------------------------------------------------------

        #region Methods ---------------------------------------------------------------------------------------

        #region Methods - public ------------------------------------------------------------------------------

        #endregion --------------------------------------------------------------------------------------------

        #region Methods - private -----------------------------------------------------------------------------

        #endregion --------------------------------------------------------------------------------------------

        #endregion --------------------------------------------------------------------------------------------
    }
}
