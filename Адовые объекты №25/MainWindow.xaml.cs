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
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private Line line;
        private void Sozidat_Initialized(object sender, EventArgs e)
        {
            line = new Line(25, 30);
            line.XYZ(ref cvas);
        }



        private void skyrim_Click(object sender, RoutedEventArgs e) //Показываю невероятный рисунок карандашом
        {
            line.Show();

        }

        private void stels_Click(object sender, RoutedEventArgs e) //Прячу невероятный рисунок карандашом
        {
            line.Hide();
        }
        private void Letsgo_PreviewKeyDown(object sender, KeyEventArgs e) //Двигаю на "WASD" невероятный рисунок карандашом
        {
            int x = line.x1;
            int y = line.y1;
            if (e.Key == Key.W)
            {
                if (y - 5 >= -201) line.MoveXY(x, y - 3);
            }
            if (e.Key == Key.S)
            {
                if (y + 250 <= 460) line.MoveXY(x, y + 3);
            }
            if (e.Key == Key.A)
            {
                if (x - 5 >= -83) line.MoveXY(x - 3, y);
            }
            if (e.Key == Key.D)
            {
                if (x + 5 <= 225) line.MoveXY(x + 3, y);
            }
            if (e.Key == Key.Up)
            {
                if (y - 5 >= -201) line.MoveXY(x, y - 3);
            }
            if (e.Key == Key.Down)
            {
                if (y + 250 <= 460) line.MoveXY(x, y + 3);
            }
            if (e.Key == Key.Left)
            {
                if (x - 5 >= -83) line.MoveXY(x - 3, y);
            }
            if (e.Key == Key.Right)
            {
                if (x + 5 <= 225) line.MoveXY(x + 3, y);
            }

        }

        private void teleport_Click(object sender, RoutedEventArgs e) //Перемещаю невероятный рисунок карандашом на заданные координаты
        {
            line.MoveXY(Convert.ToInt32(coord_X.Text), Convert.ToInt32(coord_Y.Text));
        }

        private void Exit_Click(object sender, RoutedEventArgs e) //Выходим из галерии с невероятным рисунком карандашом
        {
            this.Close();
        }

        private void coord_X_TextChanged(object sender, TextChangedEventArgs e) //Ограничение кнопки
        {
            {
                if (coord_X.Text.Length == 0)
                    tp.IsEnabled = false;
                else
                    tp.IsEnabled = true;
            }
        }

        private void coord_Y_TextChanged(object sender, TextChangedEventArgs e) //Ограничение кнопки
        {
            {
                if (coord_Y.Text.Length == 0)
                    tp.IsEnabled = false;
                else
                    tp.IsEnabled = true;
            }

            
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ваш друг черканул вам в тетради? Не беда! Ведь вы обладаете возможностью двигать рисунки и прятать их. Разработка от горе-дизайнера Бирюкова Георгия ИСП-23");
        }

        private void Anek_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Едут три парня на одном мотоцикле. Один из них заикался. Едут. Парень начинет *Б-б-бб*. Друго спрашивает:*Быстрее?* Ускорились. Парень снова:*Б-б*. *Ещё быстрее?* Парень еле-еле выговаривает *Б-БОРЯ ВЫПАЛ!");
        }
    }
}
