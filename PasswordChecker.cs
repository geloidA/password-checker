using System.Text.RegularExpressions;
using System.Windows;

namespace passwordchecker
{
    class PasswordChecker
    {
        private string[] patterns;

        public PasswordChecker(params string[] patterns)
        {
            this.patterns = patterns;
        }

        public bool Check(string password)
        {
            if (password.Length < 6)
                return ReturnFalseWithMessage("Минимум 6 символов");

            foreach(var pattern in patterns)
            {
                if (!Regex.IsMatch(password, pattern))
                    return ReturnFalseWithMessage($"Пароль не содержит {pattern}");
            }
            return true;
        }

        private bool ReturnFalseWithMessage(string message)
        {
            MessageBox.Show(message);
            return false;
        }
    }
}
