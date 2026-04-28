using System;
using WebApplicationC__Tut101.Common;
using WebApplicationC__Tut101.DTOs.Requests;
using WebApplicationC__Tut101.DTOs.Responses;
using WebApplicationC__Tut101.Services.Interfaces.IAuths;

// This class implements the IAuthService interface, which defines the contract for authentication-related operations such as user registration and login. The AuthService class will contain the logic to handle these operations, including validating user credentials, creating new user accounts, and generating authentication tokens if necessary.
// The ILogger<UserService> is injected into the constructor to allow for logging of important events and errors during the authentication process.
namespace WebApplicationC__Tut101.Services.Auths
{

    public class AuthService : IAuthService
    {
        private readonly ILogger<AuthService> _logger;

        public AuthService(ILogger<AuthService> logger)
        {
            _logger = logger;
        }

        public Task<ApiResponse<UserSigninResponseDto>> Signin(UserSigninRequestDto request)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponse<UserSignupResponseDto>> Signup(UserSignupRequestDto request)
        {
            throw new NotImplementedException();
        }
    }

}