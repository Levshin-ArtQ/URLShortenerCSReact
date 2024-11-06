using System.Text.Json.Serialization;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace URLShortenerCSReact.Models
{
  public class UserModel : IdentityUser
  {
    public string Name { get; set; }
    public string Email { get; set; }
    [JsonIgnore]
    private string Password { get; set; }

    public string PasswordHash { get; set; } = string.Empty;

    public string hashPassword(string password)
    {
      return Password;
    }

    public bool checkPassword(string password)
    {
      return Password == password;
    }

    public ICollection<URLModel> URLs { get; set; }


  }



}