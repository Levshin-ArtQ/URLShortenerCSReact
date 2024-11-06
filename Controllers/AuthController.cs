using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using URLShortenerCSReact.Models;

namespace URLShortenerCSReact.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class AuthController : Controller
  {
    [HttpPost]
    public object registerUser(object model)
    {
      throw new System.NotImplementedException();
    }

    [HttpPost("")]
    public object loginUser(UserModel model)
    {
      throw new System.NotImplementedException();
    }


  }
}