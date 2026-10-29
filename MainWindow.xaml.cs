using System;
using System.Windows;

namespace Student_Autho
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // При запуске приложения отображается страница авторизации
            FrmMain.Navigate(new Pages.Autho());
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            FrmMain.GoBack();
        }

        private void FrmMain_ContentRendered(object sender, EventArgs e)
        {
            // На странице авторизации кнопка «Назад» скрыта
            if (FrmMain.CanGoBack)
                btnBack.Visibility = Visibility.Visible;
            else
                btnBack.Visibility = Visibility.Hidden;
        }
    }
}
