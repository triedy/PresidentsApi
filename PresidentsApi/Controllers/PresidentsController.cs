using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using PresidentsApi.Models;

namespace PresidentsApi.Controllers
{
  public class PresidentsController : ApiController
  {
    President[] presidents = new President[]
      {
        new President { Id = 1, FirstName = "George", LastName = "Washington", HomeState = "Virginia", Born = new DateTime(1732, 2, 22), Died = new DateTime(1799, 12, 14) },
        new President { Id = 2, FirstName = "John", LastName = "Adams", HomeState = "Massachusetts", Born = new DateTime(1735, 10, 30), Died = new DateTime(1826, 7, 4) },
        new President { Id = 3, FirstName = "Thomas", LastName = "Jefferson", HomeState = "Virginia", Born = new DateTime(1743, 4, 13), Died = new DateTime(1826, 7, 4) },
        new President { Id = 4, FirstName = "James", LastName = "Madison", HomeState = "Virginia", Born = new DateTime(1751, 3, 16), Died = new DateTime(1836, 6, 28) }
      };

    public IEnumerable<President> GetAllPresidents()
    {
      return presidents;
    }

    public IHttpActionResult GetPresident(int id)
    {
      var president = presidents.FirstOrDefault((p) => p.Id == id);
      if (president == null)
      {
        return NotFound();
      }

      return Ok(president);
    }
  }
}
