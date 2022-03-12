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
using WindowsDesktopClock.src.Model;
using System.Threading;

namespace WindowsDesktopClock
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Date _date;
        private Timer _timer;

        public MainWindow()
        {
            InitializeComponent();

            initializeDateText();
            startTimer();
        }

        private void initializeDateText()
        {
            _date = new Date();
            this.DataContext = _date;
            _date.update();
        }

        private void startTimer()
        {
            TimerCallback timerCallback = state =>
            {
                _date.update();
            };

            _timer = new Timer(timerCallback, null, 0, 1000);
        }
    }
}
