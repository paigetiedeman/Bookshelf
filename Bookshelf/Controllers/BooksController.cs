using Bookshelf.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Bookshelf.Controllers
{
  public class BooksController : Controller
  {
    private readonly BookshelfContext _db;

    public BooksController(BookshelfContext db)
    {
      _db = db;
    }
  }
}