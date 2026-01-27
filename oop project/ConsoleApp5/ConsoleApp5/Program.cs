using System;
using System.Text.ReagularExpressions;
using System.Text.RegularExpressions;

namespace UserManagement
{
    class UserProfile
    {
        //private fields//
        private string username;
        private string email;
        private string password;

        //Constructors enforcment //
        public UserProfile(string username, string email, string password)
        {
            Username = username;
            Email = email;
            SetPassword = password;
        }

        //Username property //
        public string Username
        {
            get => username;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Username cannot be empty.");
                username = value;
            }
        }

        //Email property //

        public string Email
        {
            get => email;
            private set
            {
                if (!IsValidEmail(value))
                    throw new ArgumentException("Invalid email format.");
                email = value;
            }
        }
        // NO password Getter property //
        private void SetPassword(string value)
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length < 6)
                throw new ArgumentException("Password must be at least 6 characters long.");
            password = value;
        }

        //Password verification method //
        public bool VerifyPassword(string inputPassword)
        {
            return password == inputPassword;
        }

        //Email validation helper//
        private bool IsValiEmail(string email)
        {
            return Regex.IsMatch(
                email,
                @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                RegexOptions.IgnoreCase
            );
        }
        // Display Safe info//
        public void DispalyProfile()
        {
            Console.WriteLine("\n--- User Profile ---");
            Console.WriteLine($"Username : {Username}");
            Console.WriteLine($"Email    : {Email}");
        }

    }
}