using SortingAlgorithms.BL;
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

namespace SortingAlgorithms.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BubbleSort bubbleSort = new BubbleSort();
        int[] numbers;

        public MainWindow()
        {
            InitializeComponent();

            System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, 100);
            dispatcherTimer.Start();

            numbers = bubbleSort.numbers;

            DrawLines();
        }

        public void DrawLines()
        {
            var startDrawX = 20;
            var startDrawY = 490;

            for (int i = 0; i < numbers.Length; i++)
            {
                // Create a Line  
                Line redLine = new Line();
                redLine.X1 = startDrawX + i * 6;
                redLine.Y1 = startDrawY;
                redLine.X2 = startDrawX + i * 6;
                redLine.Y2 = startDrawY - (numbers[i] * 3);

                // Create a red Brush  
                SolidColorBrush redBrush = new SolidColorBrush();
                redBrush.Color = Colors.Red;

                // Set Line's width and color  
                redLine.StrokeThickness = 5;
                redLine.Stroke = redBrush;

                // Add line to the Grid.  
                grid1.Children.Add(redLine);
            }
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            bubbleSort.SortArrayOneStep();
            numbers = bubbleSort.numbers;

            grid1.Children.Clear();
            DrawLines();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bubbleSort = new BubbleSort();
            numbers = bubbleSort.numbers;
            grid1.Children.Clear();
            DrawLines();
        }
    }
}
