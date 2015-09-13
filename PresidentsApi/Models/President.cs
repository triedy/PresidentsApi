using System;

namespace PresidentsApi.Models
{
  public class President
  {
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime Born { get; set; }
    public DateTime Died { get; set; }
    public string HomeState { get; set; }
  }
}