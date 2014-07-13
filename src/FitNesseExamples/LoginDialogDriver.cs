using System;

namespace FitNesseExamples.Fixtures
{
    public class LoginDialogDriver
    {
        private int _loginAttempts;
        private string _message;
        public string UserName { get; private set; }
        public string Password { get; private set; }

        public LoginDialogDriver(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }

        public bool LoginWithUsernameAndPassword(string userName, string password)
        {
            _loginAttempts++;
            var result = UserName.Equals(userName) && Password.Equals(password);
            _message = String.Format(result ? "{0} logged in." : "{0} not logged in.", UserName);
            return result;
        }

        public string LoginMessage()
        {
            return _message;
        }

        public int NumberOfLoginAttempts()
        {
            return _loginAttempts;
        }
    }
}
