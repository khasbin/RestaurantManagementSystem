using Microsoft.AspNetCore.Identity;
using Restaurant_Management_System.Models;

namespace Restaurant_Management_System.Utilities
{
    public class UserService
    {
        private readonly UserManager<User> _userManager;
        public UserService(UserManager<User> userManager)
        {
            _userManager = userManager;
        }
        public async Task<IdentityResult> CreateUserWithRoleAsync(string email, string password)
        {
            // Create the user
            var user = new User { UserName = email, Email = email };
            var result = await _userManager.CreateAsync(user, password);

            // If user creation is successful, assign the "Customer" role
            if (result.Succeeded)
            {
                result = await _userManager.AddToRoleAsync(user, "Customer");
            }

            return result;
        }

    }
}
