using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;
using Behance_Natalia_La_Valle.ViewModel;

namespace Behance_Natalia_La_Valle
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            juntar = new ClassView();
            DataContext = juntar;
            juntar.ValueCanvasRight = 348;
        }
        public ClassView juntar;
        public int X = 0;
        public Button Btn;
        private void BtnBranding_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            Btn = btn;
            switch (btn.Name)
            {
                case "BtnBranding":
                    DispatcherTimer Timer = new DispatcherTimer();
                    Timer.Interval = new TimeSpan(0, 0, 0, 0, 1);
                    Timer.Tick += (a, b) =>
                    {
                        RotateBranding.Angle = RotateBranding.Angle + 4;
                        if (PT() == BtnPieces)
                        {
                            RotateBranding.Angle = 19.820;
                            Timer.Stop();
                        }

                    };
                    Timer.Start();
                    
                    break;
                case "BtnPieces":
                    DispatcherTimer Timer1 = new DispatcherTimer();
                    Timer1.Interval = new TimeSpan(0, 0, 0, 0, 1);
                    Timer1.Tick += (a, b) =>
                    {
                        RotatePieces.Angle = RotatePieces.Angle + 4;

                        if (PT() == BtnBranding)
                        {
                            RotatePieces.Angle = 361.929; ;
                            Timer1.Stop();
                        }
                    };
                    Timer1.Start();
                    break;


            }
        }
        private void BtnPieces_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            if (BtnPieces == btn)
            {
               
            }
        }
        public Button PT()
        {
            return Btn;
        }


        private void BtnPortfolio_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            juntar.MoveRectangle(btn);
        }

    }
    
}
