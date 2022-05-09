using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace SpriteWPFTS95
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            AnalyzeArgs();

            InitializeComponent();

            SetFormAttribute();
            SetCanvasAttribute();

            // フォームを天翔記ウィンドウに追従させるためのタイマー構築などなど
            ResetFollowPosition();
            SetPositionTimerAttribute();
        }

        private void SetFormAttribute()
        {
            this.Width = 1;
            this.Height = 1;
            this.Top = 0;
            this.Left = 0;

            SetFormNoActiveAttribute();
        }

        List<DispatcherTimer> timerList = new List<DispatcherTimer>();

        // やめ。
        private void StopAndClose()
        {
            // タイマーをストップ
            foreach (var t in timerList)
            {
                t.Stop();
            }
            this.Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ConsumeFadeTime();
        }
    }

}
