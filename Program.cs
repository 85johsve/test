using Dapper;
using MySqlConnector;

public class Movie
{
    public int MovieBarcode { get; set; }
    public string movie_name { get; set; }
    public int DatePublished { get; set; }
    public double MoviePrice { get; set; }
    public bool isOutdated { get; set; }
    public bool isRented { get; set; }
    
    public override string ToString()
    {
        return $"{movie_name}";
    }
    
}

internal class Program
{
    private static void Main(string[] args)
    {
        List<Movie> myList = new();
        using (var connection = new MySqlConnection("Server=localhost;Database=videotek;Uid=Johan;Pwd=abc123;"))
        {
            var movies = connection.Query<Movie>("SELECT movie_name FROM movie;").ToList();
            
            foreach(Movie p in movies)
            {
  
                Console.WriteLine(p.movie_name);
            }
        }
    }
}