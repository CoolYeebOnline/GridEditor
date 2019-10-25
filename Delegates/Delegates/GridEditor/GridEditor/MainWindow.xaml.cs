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


namespace GridEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {

        private int GridWidth = 5;
        private int GridHeight = 5;

        private Image[,] images;

        private ImageSource penImageSource;

        public MainWindow()
        {
            penImageSource = new BitmapImage(new Uri("pack://application:,,,/NewFolder1/dirt.png"));
            InitializeComponent();

            images = new Image[GridWidth, GridHeight];

            for (int x = 0; x < GridWidth; x++)
            {
                for (int y = 0; y < GridHeight; y++)
                {
                    Image image = new Image();
                    Grid.SetColumn(image, x);
                    Grid.SetRow(image, y);

                    grid.Children.Add(image);

                    images[x, y] = image;
                }
            }

            grid.MouseDown += OnMouseDown;
        }
        private void OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            int x = (int)e.GetPosition(grid).X / 32;
            int y = (int)e.GetPosition(grid).Y / 32;

            UseTool(x, y);
        }

        private void UseTool(int gridX, int gridY)
        {
            if (gridX > 4 || gridY > 4) return;
            switch (selectedTool)
            {
                case Tool.Pen:
                    images[gridX, gridY].Source = penImageSource;
                    break;
                case Tool.Erase:
                    images[gridX, gridY].Source = null;
                    break;
            }
            
        }
        private void HandleNew(object sender, RoutedEventArgs e)
        {

        }

        private void HandleClose(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void HandlePen(object sender, RoutedEventArgs e)
        {
            selectedTool = Tool.Pen;
        }

        private void HandleErase(object sender, RoutedEventArgs e)
        {
            selectedTool = Tool.Erase;
        }

        public enum Tool
        {
            Pen,
            Erase
        }
        private Tool selectedTool = Tool.Pen;

        
    }

    

}
