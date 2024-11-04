using System.Text.Json.Serialization;

namespace URLShortenerCSReact.Models
{
  public class UserModel
  {
    public string Name { get; set; }
    public string Email { get; set; }
    [JsonIgnore]
    public string Password { get; set; }
  }

  public class LoginModel
  {
    public string Email { get; set; }
    public string Password { get; set; }
  }

  public class RegisterModel
  {
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
  }
}