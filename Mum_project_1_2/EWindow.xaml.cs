using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Mum_project_1_2
{
    /// <summary>
    /// Логика взаимодействия для EWindow.xaml
    /// </summary>
    public partial class EWindow : Window
    {
        public EWindow(int mis, int times, string username)
        {
            InitializeComponent();
            //------------------------------------ошибки и время------------------
            string time_itog = Convert.ToString(times / 60) + ':' + Convert.ToString(times % 60);
            Time_w.Text = time_itog;
            mis_w.Text = Convert.ToString(mis);
            //----------------------------------вывод в файл----------

            using (StreamWriter writer = new StreamWriter("Resoults.txt", true))
            {
                DateTime dateT = new DateTime();
                dateT = DateTime.Now;
                string date = Convert.ToString(dateT);
                string text = "------------------------------------------" + "\nИмя: " + username + "\nДата: " + date + "\nВремя: " + time_itog + "\nОшибки: " + mis + "\n";
                writer.WriteLineAsync(text);
            }

        }


    }


}
