using System.Linq;

namespace PasswordValidation
{
    public class PasswordValidation
    {
        public bool Validation(string password)
        {


            return !string.IsNullOrEmpty(password) &&
                   password.Length > 8 && password.Length <= 15 &&
                   password.Any(char.IsUpper) &&
                   password.Any(char.IsLower) &&
                   password.Contains("_") &&
                   password.Any(char.IsDigit);

        }
    
    }
}