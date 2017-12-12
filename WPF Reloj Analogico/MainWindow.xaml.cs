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

namespace WPF_Reloj_Analogico
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.AgujaSegundosRotateTransform.Angle = DateTime.Now.Second * 6;
            this.AgujaMinutosRotateTransform.Angle = DateTime.Now.Minute * 6;
            this.AgujaHorasRotateTransform.Angle = (DateTime.Now.Hour * 30) + (DateTime.Now.Minute * 0.5);
        }

        private void OnMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}
