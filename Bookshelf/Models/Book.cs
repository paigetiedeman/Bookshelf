using System.Collections.Generic;

namespace Bookshelf.Models
{
  public class Book 
  {
    public Book()
    {
      this.JoinEntities = new HashSet<BookGenre>();
    }

    public int BookId { get; set; }
    public string BookName { get; set; }
    public string Description { get; set; }
    public string Rating { get; set; }
    public virtual ICollection<BookGenre> JoinEntities { get; set; }
  }
}