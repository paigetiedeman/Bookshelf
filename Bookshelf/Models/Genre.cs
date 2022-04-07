using System.Collections.Generic;

namespace Bookshelf.Models
{
  public class Genre
  {
    public Genre()
    {
      this.JoinEntities = new HashSet<BookGenre>();
    }

    public int GenreId { get; set; }
    public string Title { get; set; }
    public virtual ICollection<BookGenre> JoinEntities { get; set; }
  }
}