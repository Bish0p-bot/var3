using System.Windows;
using System.Windows.Controls;

namespace Student_Autho.Pages
{
    public partial class Autho : Page
    {
        public Autho()
        {
            InitializeComponent();
        }

        private void btnEnterGuests_Click(object sender, RoutedEventArgs e)
        {
            // Переход на страницу неавторизованного пользователя
            NavigationService.Navigate(new Client(null));
        }

        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            // Проверка логина и пароля будет реализована в следующих практических работах
            MessageBox.Show("Авторизация будет реализована позднее. Используйте вход как гость.",
                "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
