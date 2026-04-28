using WebApplicationC__Tut101.DTOs.Requests;
using WebApplicationC__Tut101.DTOs.Responses;
using WebApplicationC__Tut101.Common;

namespace WebApplicationC__Tut101.Services.Interfaces.IAuths
{
    public interface IAuthService
    {
        // This method will handle user registration. It takes a UserSignupRequestDto as input and returns an ApiResponse indicating the success or failure of the registration process.
        Task<ApiResponse> Signup(UserSignupRequestDto request);
        // This method will handle user login. It takes a UserSigninRequestDto as input and returns an ApiResponse containing a UserSigninResponseDto if the login is successful, or an error message if it fails.
        Task<ApiResponse<UserSigninResponseDto>> Signin(UserSigninRequestDto request);
    }
}