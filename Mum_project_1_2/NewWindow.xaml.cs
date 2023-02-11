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
using System.Windows.Shapes;

namespace Mum_project_1_2
{
    /// <summary>
    /// Логика взаимодействия для NewWindow.xaml
    /// </summary>
    public partial class NewWindow : Window
    {
        int[] checker = new int[100]; //массив, где хранятся нажатия юзера
        int posi = 0; //кол-во нажатий
        int[] nums_1 = new int[25]; //глобальный массив, где хранятся случайные номера кнопок из прошлого окна

        public int mistakes = 0;

        string username;

        DateTime date1 = new DateTime(); //время, когда юзер начал
        DateTime date2 = new DateTime(); //время, когда юзер нажал 25

        TimeSpan spent_time_fake = new TimeSpan(); //временная переменная для подсчёта времени

        int spent_time; //подсчёт врмемени

        public NewWindow(int[] nums, string userName)
        {
            InitializeComponent();

            date1 = DateTime.Now; // считываем время начала

            for(int i = 0; i < 25; i++) //----переносим рандом из прошлого окна в глобальный массив----
            {
                //Console.Write(nums[i]);
                //Console.Write(' ');

                nums_1[i] = nums[i];
            }

            username = userName;

            //-----------------------------фигня, но работает--------------------
            B1.Content = nums[0];
            B2.Content = nums[1];
            B3.Content = nums[2];
            B4.Content = nums[3];
            B5.Content = nums[4];
            B6.Content = nums[5];
            B7.Content = nums[6];
            B8.Content = nums[7];
            B9.Content = nums[8];
            B10.Content = nums[9];
            B11.Content = nums[10];
            B12.Content = nums[11];
            B13.Content = nums[12];
            B14.Content = nums[13];
            B15.Content = nums[14];
            B16.Content = nums[15];
            B17.Content = nums[16];
            B18.Content = nums[17];
            B19.Content = nums[18];
            B20.Content = nums[19];
            B21.Content = nums[20];
            B22.Content = nums[21];
            B23.Content = nums[22];
            B24.Content = nums[23];
            B25.Content = nums[24];

        }

        public void Butt_check() //---------проверяем, сколько ошибок совершили--------
        {
            for(int i = 1; i <= 25; i++)
            {
                int numer = 0;
                for(int j = 0; j < 25; j++)
                {
                    if(checker[j] == i)
                    {
                        numer++;
                    }
                }
                if(numer == 0)
                {
                    mistakes++;
                }
                else
                {
                    mistakes += numer - 1;
                }
            }

            //-------считываем потраченное время-------
            date2 = DateTime.Now;
            Console.WriteLine(mistakes);
            spent_time_fake = date2.Subtract(date1);
            spent_time = spent_time_fake.Seconds;
        }

        public void end_check()
        {
            if(checker[posi-1] == 25)
            {
                Butt_check();
                EWindow EndWindow = new EWindow(mistakes, spent_time, username);
                EndWindow.Show();
                Close();
            }
        }

        //-----------------------------------------------тупо считывание тыков-------------------------------
        private void B1_Click(object sender, RoutedEventArgs e)
        {
            checker[posi] = nums_1[0];
            posi++;
            end_check();
        }

        private void B2_Click(object sender, RoutedEventArgs e)
        {
            checker[posi] = nums_1[1];
            posi++;
            end_check();
        }

        private void B3_Click(object sender, RoutedEventArgs e)
        {
            checker[posi] = nums_1[2];
            posi++;
            end_check();
        }

        private void B4_Click(object sender, RoutedEventArgs e)
        {
            checker[posi] = nums_1[3];
            posi++;
            end_check();
        }

        private void B5_Click(object sender, RoutedEventArgs e)
        {
            checker[posi] = nums_1[4];
            posi++;
            end_check();
        }

        private void B6_Click(object sender, RoutedEventArgs e)
        {
            checker[posi] = nums_1[5];
            posi++;
            end_check();
        }

        private void B7_Click(object sender, RoutedEventArgs e)
        {
            checker[posi] = nums_1[6];
            posi++;
            end_check();
        }

        private void B8_Click(object sender, RoutedEventArgs e)
        {
            checker[posi] = nums_1[7];
            posi++;
            end_check();
        }

        private void B9_Click(object sender, RoutedEventArgs e)
        {
            checker[posi] = nums_1[8];
            posi++;
            end_check();
        }

        private void B10_Click(object sender, RoutedEventArgs e)
        {
            checker[posi] = nums_1[9];
            posi++;
            end_check();
        }

        private void B11_Click(object sender, RoutedEventArgs e)
        {
            checker[posi] = nums_1[10];
            posi++;
            end_check();
        }

        private void B12_Click(object sender, RoutedEventArgs e)
        {
            checker[posi] = nums_1[11];
            posi++;
            end_check();
        }

        private void B13_Click(object sender, RoutedEventArgs e)
        {
            checker[posi] = nums_1[12];
            posi++;
            end_check();
        }

        private void B14_Click(object sender, RoutedEventArgs e)
        {
            checker[posi] = nums_1[13];
            posi++;
            end_check();
        }

        private void B15_Click(object sender, RoutedEventArgs e)
        {
            checker[posi] = nums_1[14];
            posi++;
            end_check();
        }

        private void B16_Click(object sender, RoutedEventArgs e)
        {
            checker[posi] = nums_1[15];
            posi++;
            end_check();
        }

        private void B17_Click(object sender, RoutedEventArgs e)
        {
            checker[posi] = nums_1[16];
            posi++;
            end_check();
        }

        private void B18_Click(object sender, RoutedEventArgs e)
        {
            checker[posi] = nums_1[17];
            posi++;
            end_check();
        }

        private void B19_Click(object sender, RoutedEventArgs e)
        {
            checker[posi] = nums_1[18];
            posi++;
            end_check();
        }

        private void B20_Click(object sender, RoutedEventArgs e)
        {
            checker[posi] = nums_1[19];
            posi++;
            end_check();
        }

        private void B21_Click(object sender, RoutedEventArgs e)
        {
            checker[posi] = nums_1[20];
            posi++;
            end_check();
        }

        private void B22_Click(object sender, RoutedEventArgs e)
        {
            checker[posi] = nums_1[21];
            posi++;
            end_check();
        }

        private void B23_Click(object sender, RoutedEventArgs e)
        {
            checker[posi] = nums_1[22];
            posi++;
            end_check();
        }

        private void B24_Click(object sender, RoutedEventArgs e)
        {
            checker[posi] = nums_1[23];
            posi++;
            end_check();
        }

        private void B25_Click(object sender, RoutedEventArgs e)
        {
            checker[posi] = nums_1[24];
            posi++;
        }
    }
}
