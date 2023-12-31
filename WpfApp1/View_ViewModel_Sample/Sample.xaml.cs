﻿using System.ComponentModel;
using System.Windows;
using Domain.Sample;
using Reactive.Bindings.Extensions;

namespace WpfApp1
{
    /// <summary>
    /// SampleのView責務コード記述部
    /// </summary>
    public partial class Sample : Window
    {
        #region Fields ----------------------------------------------------------------------------------------

        #endregion --------------------------------------------------------------------------------------------

        #region Constants -------------------------------------------------------------------------------------

        #endregion --------------------------------------------------------------------------------------------

        #region Properties ------------------------------------------------------------------------------------

        #endregion --------------------------------------------------------------------------------------------

        #region Events ----------------------------------------------------------------------------------------

        #endregion --------------------------------------------------------------------------------------------

        #region Constructor -----------------------------------------------------------------------------------

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="model">モデル</param>
        public Sample(SampleModel model)
        {
            #region init View Members

            #endregion

            #region init ViewModel Members

            _model = model;

            Text = _model.Text.ToReactivePropertySlimAsSynchronized(
                x => x.Value,            // Selector
                x => x.Text,             // Convert
                x => new SampleTextVO(x)) // ConvertBack
                .AddTo(_disposables);

            #endregion

            InitializeComponent();
        }

        #endregion --------------------------------------------------------------------------------------------

        #region Methods ---------------------------------------------------------------------------------------

        #region Methods - public ------------------------------------------------------------------------------

        #endregion --------------------------------------------------------------------------------------------

        #region Methods - protected ---------------------------------------------------------------------------

        #endregion --------------------------------------------------------------------------------------------

        #region Methods - private -----------------------------------------------------------------------------

        #endregion --------------------------------------------------------------------------------------------

        #region Methods - override ----------------------------------------------------------------------------

        /// <summary>
        /// Close時処理
        /// </summary>
        /// <param name="e">キャンセルイベントデータ</param>
        protected override void OnClosing(CancelEventArgs e)
        {
            _disposables.Dispose();

            base.OnClosing(e);
        }

        #endregion --------------------------------------------------------------------------------------------

        #endregion --------------------------------------------------------------------------------------------
    }
}
