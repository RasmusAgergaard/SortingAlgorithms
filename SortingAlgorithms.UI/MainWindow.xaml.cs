using SortingAlgorithms.BL;
using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace SortingAlgorithms.UI
{
    public partial class MainWindow : Window
    {
        BubbleSort bubbleSort = new BubbleSort();
        MergeSort mergeSort = new MergeSort();
        int[] bubbleNumbers;
        int[] mergeNumbers;

        public MainWindow()
        {
            InitializeComponent();

            System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(1);
            dispatcherTimer.Start();
        }

        public void DrawLinesBubble(int startDrawX, int startDrawY)
        {
            for (int i = 0; i < bubbleNumbers.Length; i++)
            {
                Line line = new Line();
                line.X1 = startDrawX + i * 6;
                line.Y1 = startDrawY;
                line.X2 = startDrawX + i * 6;
                line.Y2 = startDrawY - (bubbleNumbers[i] * 5);

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

        public void DrawLinesMerge(int startDrawX, int startDrawY)
        {
            for (int i = 0; i < mergeNumbers.Length; i++)
            {
                Line line = new Line();
                line.X1 = startDrawX + i * 6;
                line.Y1 = startDrawY;
                line.X2 = startDrawX + i * 6;
                line.Y2 = startDrawY - (mergeNumbers[i] * 5);

                SolidColorBrush brush = new SolidColorBrush();
                brush.Color = Colors.DarkGray;

                line.StrokeThickness = 5;
                line.Stroke = brush;

                grid1.Children.Add(line);
            }
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            bubbleSort.SortArrayOneStep();
            bubbleNumbers = bubbleSort.numbers;

            mergeSort.SortArrayOneStep();
            mergeNumbers = mergeSort.numbers;

            grid1.Children.Clear();
            DrawLinesBubble(20, 490);
            DrawLinesMerge(510, 490);
        }
    }
}
