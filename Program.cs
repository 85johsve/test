using Dapper;
using MySqlConnector;



internal class Program
{
    private static void Main(string[] args)
    {
      
        using (var connection = new MySqlConnection("Server=localhost;Database=videotek;Uid=Johan;Pwd=abc123;"))
        {
            var movies = connection.Query<Movie>("SELECT movie_name, movieID, date_published FROM movie;").ToList();
            
            foreach(Movie p in movies)
            {
  
                Console.WriteLine(p.movieID + " " + p.movie_name + " " + p.date_published);
            }
        }
        
                using (var connection = new MySqlConnection("Server=localhost;Database=videotek;Uid=Johan;Pwd=abc123;"))
        {
            var bark = connection.Query<Barcode>("SELECT barcode.barcode, barcode.is_rented, movie_id FROM `barcode`;").ToList();
            
            foreach(Barcode p in bark)
            {
  
                Console.WriteLine(p.barcode + " " + p.is_rented + " " + p.movie_id);
            }
        }

        //         using (var connection = new MySqlConnection("Server=localhost;Database=videotek;Uid=Johan;Pwd=abc123;"))
        // {
        //     var myCoolList = connection.Query<Movie>("UPDATE barcode SET is_rented = 1 WHERE barcode = 1004").ToList();
            
        //     foreach(Movie p in myCoolList)
        //     {
  
        //         Console.WriteLine(p.movieID + " " + p.movie_name + " " + p.date_published);
        //     }
        // }

    }
}