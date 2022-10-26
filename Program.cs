using Dapper;
using MySqlConnector;

public class Movie
{
    public int MovieBarcode { get; set; }
    public string MovieName { get; set; }
    public int DatePublished { get; set; }
    public double MoviePrice { get; set; }
    public bool isOutdated { get; set; }
    public bool isRented { get; set; }
    
    public override string ToString()
    {
        return $"{MovieName}";
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        using (var connection = new MySqlConnection("Server=localhost;Database=videotek;Uid=Johan;Pwd=abc123;"))
        {
            var movie = connection.Query<Movie>("SELECT movie_name FROM movie;").ToList();
            foreach(var item in movie)
            {
                Console.WriteLine(item);
            }
        }
    }
}