using System;
using WebApplicationC__Tut101.Services.Auths.Interfaces.IAuths;

// This class implements the IAuthService interface, which defines the contract for authentication-related operations such as user registration and login. The AuthService class will contain the logic to handle these operations, including validating user credentials, creating new user accounts, and generating authentication tokens if necessary.
// The ILogger<UserService> is injected into the constructor to allow for logging of important events and errors during the authentication process.
namespace WebApplicationC__Tut101.Services.Auths
{

    public class AuthService : IAuthService
    {
        private readonly ILogger<UserService> _logger;

        public AuthService(ILogger<UserService> logger)
        {
            _logger = logger;
        }




    }



}