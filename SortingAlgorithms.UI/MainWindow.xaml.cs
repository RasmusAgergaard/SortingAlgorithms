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

            numbers = bubbleSort.numbers;

            DrawLines();
        }

        public void DrawLines()
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                // Create a Line  
                Line redLine = new Line();
                redLine.X1 = i * 5;
                redLine.Y1 = 0;
                redLine.X2 = i * 5;
                redLine.Y2 = numbers[i] * 3;

                // Create a red Brush  
                SolidColorBrush redBrush = new SolidColorBrush();
                redBrush.Color = Colors.Red;

                // Set Line's width and color  
                redLine.StrokeThickness = 4;
                redLine.Stroke = redBrush;

                // Add line to the Grid.  
                grid1.Children.Add(redLine);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}
