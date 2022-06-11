using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;


namespace IncursionTimer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public TimeSpan TimerOneH { get; set; }
        public TimeSpan TimerTwoH { get; set; }
        public TimeSpan TimerThreeH { get; set; }
        public TimeSpan TimerFourH { get; set; }
        public TimeSpan TimerFiveH { get; set; }

        public DispatcherTimer TimerOneG { get; set; }
        public DispatcherTimer TimerTwoG { get; set; }
        public DispatcherTimer TimerThreeG { get; set; }
        public DispatcherTimer TimerFourG { get; set; }
        public DispatcherTimer TimerFiveG { get; set; }


        public MainWindow()
        {
            InitializeComponent();
            this.Topmost = true;

        }
        private void Window_PreviewLostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            var window = (Window)sender;
            window.Topmost = true;
        }

        private void SiteOne_Click(object sender, RoutedEventArgs e)
        {
            TimerOneH = TimeSpan.FromSeconds(420);
            TimerOne.Background = Brushes.Firebrick;
            TimerOneG = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
            {
                TimerOne.Text = TimerOneH.ToString("c");
                if (TimerOneH == TimeSpan.FromSeconds(60)) TimerOne.Background = Brushes.Yellow;
                if (TimerOneH == TimeSpan.Zero) TimerOne.Background = Brushes.Green;
                if (TimerOneH == TimeSpan.Zero) TimerOneG.Stop();
                
                TimerOneH = TimerOneH.Add(TimeSpan.FromSeconds(-1));
            }, Application.Current.Dispatcher);

            TimerOneG.Start();
        }

        private void SiteTwo_Click(object sender, RoutedEventArgs e)
        {
            TimerTwoH = TimeSpan.FromSeconds(420);
            TimerTwo.Background = Brushes.Firebrick;
            TimerTwoG = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
            {
                TimerTwo.Text = TimerTwoH.ToString("c");
                if (TimerTwoH == TimeSpan.FromSeconds(60)) TimerTwo.Background = Brushes.Yellow;
                if (TimerTwoH == TimeSpan.Zero) TimerTwo.Background = Brushes.Green;
                if (TimerTwoH == TimeSpan.Zero) TimerTwoG.Stop();

                TimerTwoH = TimerTwoH.Add(TimeSpan.FromSeconds(-1));
            }, Application.Current.Dispatcher);

            TimerTwoG.Start();
        }

        private void SiteThree_Click(object sender, RoutedEventArgs e)
        {
            TimerThreeH = TimeSpan.FromSeconds(420);
            TimerThree.Background = Brushes.Firebrick;
            TimerThreeG = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
            {
                TimerThree.Text = TimerThreeH.ToString("c");
                if (TimerThreeH == TimeSpan.FromSeconds(60)) TimerThree.Background = Brushes.Yellow;
                if (TimerThreeH == TimeSpan.Zero) TimerThree.Background = Brushes.Green;
                if (TimerThreeH == TimeSpan.Zero) TimerThreeG.Stop();

                TimerThreeH = TimerThreeH.Add(TimeSpan.FromSeconds(-1));
            }, Application.Current.Dispatcher);

            TimerThreeG.Start();
        }

        private void SiteFour_Click(object sender, RoutedEventArgs e)
        {
            TimerFourH = TimeSpan.FromSeconds(420);
            TimerFour.Background = Brushes.Firebrick;
            TimerFourG = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
            {
                TimerFour.Text = TimerFourH.ToString("c");
                if (TimerFourH == TimeSpan.FromSeconds(60)) TimerFour.Background = Brushes.Yellow;
                if (TimerFourH == TimeSpan.Zero) TimerFour.Background = Brushes.Green;
                if (TimerFourH == TimeSpan.Zero) TimerFourG.Stop();

                TimerFourH = TimerFourH.Add(TimeSpan.FromSeconds(-1));
            }, Application.Current.Dispatcher);

            TimerFourG.Start();
        }

        private void SiteFive_Click(object sender, RoutedEventArgs e)
        {
            TimerFiveH = TimeSpan.FromSeconds(420);
            TimerFive.Background = Brushes.Firebrick;
            TimerFiveG = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
            {
                TimerFive.Text = TimerFiveH.ToString("c");
                if (TimerFiveH == TimeSpan.FromSeconds(60)) TimerFive.Background = Brushes.Yellow;
                if (TimerFiveH == TimeSpan.Zero) TimerFive.Background = Brushes.Green;
                if (TimerFiveH == TimeSpan.Zero) TimerFiveG.Stop();

                TimerFiveH = TimerFiveH.Add(TimeSpan.FromSeconds(-1));
            }, Application.Current.Dispatcher);

            TimerFiveG.Start();
        }
    }
}
