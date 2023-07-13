using FirewallManager.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirewallManager.Auth
{
    // UserAuthentication class handles user authentication and role-based access control
    public class UserAuthentication
    {
        private List<User> users;

        public UserAuthentication()
        {
            // Initialize the list of users
            users = new List<User>();
        }

        public void RegisterUser(User user)
        {
            // Add a new user to the list
            users.Add(user);
        }

        public bool Login(string username, string password)
        {
            // Find the user with the given username
            User user = users.FirstOrDefault(u => u.Username == username);

            if (user != null)
            {
                // Validate the user's password
                if (user.Password == password)
                {
                    // User is authenticated
                    Console.WriteLine("Login successful.");
                    return true;
                }
            }

            // User authentication failed
            Console.WriteLine("Invalid username or password.");
            return false;
        }

        public void Logout()
        {
            // Perform logout operations
            Console.WriteLine("Logout successful.");
        }

        public bool HasAccess(User user, string role)
        {
            // Check if the user has the specified role
            return user.Roles.Any(r => r.Name == role);
        }
    }

}
