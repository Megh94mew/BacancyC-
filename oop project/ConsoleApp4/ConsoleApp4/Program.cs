using System;

namespace UserManagement
{
    class UserProfile
    {
        // Private fields
        private string username;
        private string email;
        private string password;

        // Constructor
        public UserProfile(string username, string email, string password)
        {
            Username = username;
            Email = email;
            Password = password;
        }

        // Public properties with validation
        public string Username
        {
            get { return username; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Username cannot be empty.");
                username = value;
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || !value.Contains("@"))
                    throw new ArgumentException("Invalid email address.");
                email = value;
            }
        }

        public string Password
        {
            get { return password; }
            set
            {
                if (value.Length < 6)
                    throw new ArgumentException("Password must be at least 6 characters long.");
                password = value;
            }
        }

        // Display user info (excluding password)
        public void DisplayProfile()
        {
            Console.WriteLine("\n--- User Profile ---");
            Console.WriteLine($"Username : {Username}");
            Console.WriteLine($"Email    : {Email}");
        }
    }
}
