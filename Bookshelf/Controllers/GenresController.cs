using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Bookshelf.Models;
using System.Collections.Generic;
using System.Linq;

namespace Bookshelf.Models
{
  public class GenresController : Controller
  {
    private readonly BookshelfContext _db;

    public GenresController(BookshelfContext db)
    {
      _db = db;
    }
  }
}