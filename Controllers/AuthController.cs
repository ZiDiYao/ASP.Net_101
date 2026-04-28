using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebApplicationC__Tut101.DTOs.Requests;
using WebApplicationC__Tut101.Services.Interfaces.IAuths;

namespace WebApplicationC__Tut101.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class  AuthController : ControllerBase
    {

        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }



    }


}

