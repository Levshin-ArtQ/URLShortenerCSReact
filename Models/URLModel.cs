using System.Text.Json.Serialization;
using System;

namespace URLShortenerCSReact.Models
{
  public class URLModel
  {
    public Guid Id { get; set; }
    public string OriginalURL { get; set; } = string.Empty;
    public string ShortURL { get; set; } = string.Empty;
    public int RedirectCount { get; set; }
    public string Code { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }

    public String UserId { get; set; }
    public UserModel User { get; set; }
    
  }
}