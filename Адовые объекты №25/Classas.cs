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

namespace Адовые_объекты__25
{
    class Line
    {
        //Переменные для координат и невероятного рисунка карандашом
        private int x;
        private int y;
        protected Polygon treug;
        private Brush color;

        public Line(int x1, int y1)
        {
            //Невероятный рисунок карандашом
            x = x1;
            y = y1;
            treug = new Polygon();
            treug.Stroke = Brushes.Aquamarine;
            treug.StrokeThickness = 5;
            treug.Margin = new Thickness(x, y, 0, 0);
            treug.Points.Add(new Point(100, 200));
            treug.Points.Add(new Point(400, 200));
            treug.Points.Add(new Point(200, 100));



        }
        public void XYZ(ref Canvas cvas) 
        {
            cvas.Children.Add(treug);
        }
        public int x1 //Первая координата
        {
            get { return x; }
            set { x = value; }
        }
        public int y1 //Вторая координата
        {
            get { return y; }
            set { x = value; }
        }
        public void Show() //Показать
        {
            treug.Visibility = Visibility.Visible;
        }
        public void Hide() //Спрятать
        {
            treug.Visibility = Visibility.Hidden;
        }
        public void MoveXY(int newx, int newy) //LET`SSSSSSS GOOOOOOOOO
        {
            x = newx; y = newy;
            treug.Margin = new Thickness(x, y, 0, 0);
        }

    }
}
