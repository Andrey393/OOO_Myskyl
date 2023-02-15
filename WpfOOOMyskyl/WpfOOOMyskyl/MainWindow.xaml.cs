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

namespace WpfOOOMyskyl
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
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Helper.DB = new Entini.Entini(); //Создать объект подключения
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void ButtonMin_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }

        private void ButtonOpen_Click(object sender, RoutedEventArgs e)
        {
            if(Application.Current.MainWindow.WindowState != WindowState.Maximized)
            {
                Application.Current.MainWindow.WindowState = WindowState.Maximized;
            }
            else
            {
                Application.Current.MainWindow.WindowState = WindowState.Normal;
            }
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string Userlogin = TextLogin.Text;
            string Userpassword = TextPassword.Text;
            
            //Helper.user = Helper.DB.UserTable.Where(x=>x.login == Userlogin &&
            //x.password == Userpassword).ToList().FirstOrDefault();
            //if (Helper.user == null)            //Пустой пользователь
            //{
            //    MessageBox.Show("Ваших данные нет в БД");
            //    return;
            //}
            //else
            //{
               
            //}


            captcha2.CreateCaptcha(EasyCaptcha.Wpf.Captcha.LetterOption.Alphanumeric, 5);
            MessageBox.Show("s");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           

        }

    

        private void TextLogin_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}
