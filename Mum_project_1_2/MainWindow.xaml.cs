using System;
using System.Windows;

namespace Mum_project_1_2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string username;
        Random rnd = new Random();
        int[] nums_fake = new int[25];
        public int[] nums = new int[25];
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Start_button_Click(object sender, RoutedEventArgs e) //стартуем, переходим на окно с конпками
        {

            username = Name_user.Text;
            Console.WriteLine(username);
            button_sets(); //настраиваем номера на кнопках
            NewWindow NWindow = new NewWindow(nums, username);
            NWindow.Show();
            Close();
        }

        public void button_sets()
        {
            for (int i = 0; i < 25; i++) //забиваем буфферный массив номерами кнопок
            {
                nums_fake[i] = i + 1;
            }

            for (int i = 0; i < 25; i++) //распеределяем номера
            {
                nums[i] = nums_fake[(rnd.Next(0, 24 - i))]; //выбираем случайный номер из буффера
                //Console.WriteLine(nums[i]);

                int dot = 0;
                for (int j = 0; j < 25 - i; j++) //находим, на какой он в буффере позиции
                {
                    if (nums[i] == nums_fake[j])
                    {
                        dot = j;
                    }
                }

                for (int j = dot; j < 24; j++) //затираем убранное число
                {
                    nums_fake[j] = nums_fake[j + 1];
                }
            }

            int kost = rnd.Next(0, 23); //25 каким-то фигом было всегда в конце
            nums[24] = nums[kost];
            nums[kost] = 25;
            
        }

        private void Name_user_PreviewMouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Name_user.Text = "";
        }
    }

}
