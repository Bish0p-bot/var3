using System.Windows.Controls;

namespace Student_Autho.Pages
{
    public partial class Client : Page
    {
        // Параметр user — данные авторизованного пользователя; для гостя передаётся null
        public Client(object user)
        {
            InitializeComponent();
        }
    }
}
