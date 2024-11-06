using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using URLShortenerCSReact.Models;

namespace URLShortenerCSReact.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class URLsController : ControllerBase
  {

    [HttpPost("shorten/{userId?}/{originalURL?}")]
    public object ShortenURL(string userId, string originalURL)
    {
      throw new System.NotImplementedException();
      URLModel url = new URLModel();

      url.UserId = userId;
      url.OriginalURL = originalURL;
      // todo generate code
      return url;
    }
    [HttpGet]
    public object GetURLs(object model)
    {
      throw new System.NotImplementedException();
    }

    [HttpPost("redirect")]
    public object RedirectURL(object model)
    {
      throw new System.NotImplementedException();
      // return redirect to original URL
      // then increment redirect counter for URL
      // or return 404

    }
  }
}