using System.IO;
using System.Windows;

namespace passwordchecker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void checkBtn_Click(object sender, RoutedEventArgs e)
        {
            var passwordChecker = new PasswordChecker("[0-9]", "[a-z]", "[!@#$%^]", "[A-Z]");

            if(passwordChecker.Check(passwordBox.Password))
            {
                File.WriteAllText(@"C:\Users\Public\password.txt", passwordBox.Password);
                MessageBox.Show(@"Файл с паролем сохранён в C:\Users\Public");
            }
        }
    }
}
