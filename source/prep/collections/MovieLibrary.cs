using System;
using System.Collections.Generic;
using prep.utility;

namespace prep.collections
{
  public class MovieLibrary
  {
    IList<Movie> movies;

    public MovieLibrary(IList<Movie> list_of_movies)
    {
      this.movies = list_of_movies;
    }

    public IEnumerable<Movie> all_movies()
    {
      return movies.one_at_a_time();
    }

    public void add(Movie movie)
    {
      if (already_contains(movie)) return;
      movies.Add(movie);
    }

    bool already_contains(Movie movie)
    {
      return movies.Contains(movie);
    }

    public IEnumerable<Movie> sort_all_movies_by_title_descending()
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Movie> all_movies_published_by_pixar()
    {
      var genreToSearch = Genre.kids;
      var productionStudio = ProductionStudio.Pixar;
      IList<Movie> results = new List<Movie>();
      foreach (var currentMovie in this.movies)
      {
        if ((currentMovie.genre == genreToSearch) && (currentMovie.production_studio == productionStudio))
        {
          results.Add(currentMovie);
        }
      }

      return results;
    }

    public IEnumerable<Movie>  all_.....()
  {
    throw new NotImplementedException();
  }

    public IEnumerable<Movie> all_movies_published_by_pixar_or_disney()
    {
      var studios = new List<ProductionStudio> {ProductionStudio.Disney, ProductionStudio.Pixar};
      IList<Movie> results = new List<Movie>();

      foreach (var currentMovie in this.movies)
      {
        if (studios.Contains(currentMovie.production_studio))
        {
          results.Add(currentMovie);
        }
      }

      return results;
    }

    public IEnumerable<Movie> sort_all_movies_by_title_ascending()
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Movie> sort_all_movies_by_movie_studio_and_year_published()
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Movie> all_movies_not_published_by_pixar()
    {
      var productionHouse = ProductionStudio.Pixar;
      var results = new List<Movie>();
      foreach (var movie in movies)
      {
        if (movie.production_studio != productionHouse)
        {
          results.Add(movie);
        }
      }

      return results;
    }

    public IEnumerable<Movie> all_movies_published_after(int year)
    {
      var results = new List<Movie>();
      foreach (var movie in movies)
      {
        if (movie.date_published.Year > year)
        {
          results.Add(movie);
        }
      }

      return results;
    }

    public IEnumerable<Movie> all_movies_published_between_years(int startingYear, int endingYear)
    {
      var results = new List<Movie>();
      foreach (var movie in movies)
      {
        if (movie.date_published.Year >= startingYear && movie.date_published.Year <= endingYear)
        {
          results.Add(movie);
        }
      }
      return results;
    }

    public IEnumerable<Movie> all_kid_movies()
    {
      var genre = Genre.kids;
      IList<Movie> results = new List<Movie>();

      foreach (var currentMovie in this.movies)
      {
        if (currentMovie.genre == genre)
        {
          results.Add(currentMovie);
        }
      }

      return results;
    }

    public IEnumerable<Movie> all_action_movies()
    {
      var genre = Genre.action;

      var results = new List<Movie>();

      foreach (var movie in movies)
      {
        if (movie.genre == genre)
        {
          results.Add(movie);
        }
      }

      return results;
    }

    public IEnumerable<Movie> sort_all_movies_by_date_published_descending()
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Movie> sort_all_movies_by_date_published_ascending()
    {
      throw new NotImplementedException();
    }
  }
}
