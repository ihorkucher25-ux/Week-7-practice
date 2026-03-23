public class Movie
{
    public string Title { get; set; }
    public string Director { get; set; }
    public int Year { get; set; }
    private double _rating;

    private static int _totalMovies = 0;
    public  static int  TotalMoovies => _totalMovies;

    public double Rating 
    {  
        
        get 
        { 
            return _rating; 
        }
        set
        {
            if (value < 0 || value > 10) 
        {
            throw new ArgumentException("Rating must be a number between 0 and 10."); 
        }
        _rating = value; 
        } 
    }
    public string? Description { get; set; }


    public Movie(string title, string director, int year, double rating, string? description = null)
    {
        Title = title;
        Director = director;
        Year = year;
        Rating = rating;
        Description = description;
        _totalMovies++;
    }

    public override string ToString()
    {
        return $"{Title} ({Year}) - Director: {Director }, Rating: {Rating}/10";
    }
        public override bool Equals(object? obj)
    {
        if (obj is not Movie other) return false;
        return Title == other.Title
               && Director == other.Director
               && Year == other.Year;
    }
    public override int GetHashCode()
    {
        return HashCode.Combine(Title, Director, Year);
    }
    public string GetDescription()
    {
        return Description?? "There is no description";
    }
}

