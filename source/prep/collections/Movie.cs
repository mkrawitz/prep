using System;

namespace prep.collections
{
  public class Movie
  {
    public string title { get; set; }
    public ProductionStudio production_studio { get; set; }
    public Genre genre { get; set; }
    public int rating { get; set; }
    public DateTime date_published { get; set; }
    public override bool Equals(Object obj)
    {
        Movie movieObj = obj as Movie;
        if (movieObj == null)
        {
            return false;
        }
        else
        {
            return
                (title ?? "").Equals(movieObj.title ?? "") &&
                (production_studio ?? new ProductionStudio()).Equals(movieObj.production_studio ??
                                                                     new ProductionStudio()) &&
                (genre ?? new Genre()).Equals(movieObj.genre ?? new Genre()) &&
                (rating == movieObj.rating) &&
                (date_published.Equals(movieObj.date_published));
        }
    }

    public override int GetHashCode()
    {
        return
            (title ?? "").GetHashCode() ^
            (production_studio ?? new ProductionStudio()).GetHashCode() ^
            (genre ?? new Genre()).GetHashCode() ^
            rating.GetHashCode() ^
            date_published.GetHashCode();
    }
  }
}