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
            dispatcherTimer.Interval = new TimeSpan(1);
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
                Line line = new Line();
                line.X1 = startDrawX + i * 6;
                line.Y1 = startDrawY;
                line.X2 = startDrawX + i * 6;
                line.Y2 = startDrawY - (numbers[i] * 3);

                SolidColorBrush brush = new SolidColorBrush();

                if (i == bubbleSort.check || i == bubbleSort.check + 1)
                {
                    brush.Color = Colors.Red;
                }
                else if (i > (bubbleSort.numbers.Length - 1) - bubbleSort.reduce)
                {
                    brush.Color = Colors.Black;
                }
                else
                {
                    brush.Color = Colors.DarkGray;
                }

                line.StrokeThickness = 5;
                line.Stroke = brush;

                grid1.Children.Add(line);
            }
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            bubbleSort.SortArrayOneStep();
            numbers = bubbleSort.numbers;

            grid1.Children.Clear();
            DrawLines();
        }
    }
}
