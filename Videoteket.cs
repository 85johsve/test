using Dapper;
using MySqlConnector;
public class Videoteket
{
    int ReceiptId;
    List<Movie> movieList = new List<Movie>();
    List<Customer> customerList = new List<Customer>();
    // List<Receipt> receiptList = new List<Receipt>();

    public void ReturnMovie()
    {
       
    }
    public void RentMovie()
    {
                
        using (var connection = new MySqlConnection("Server=localhost;Database=videotek;Uid=Johan;Pwd=abc123;"))
        {
            var movies = connection.Query<Movie>("SELECT movie_name FROM movie;").ToList();
            
            foreach(Movie p in movies)
            {
  
                Console.WriteLine(p.movieID + " " + p.movie_name);
            }

        }
        
       
        /*Movie rentMovie = new Movie();
        Console.WriteLine (" Renting name: ");
        rentMovie.MovieName= Console.ReadLine ().ToLower();
        foreach (var item in movieList)
        {
            if (item.MovieName == rentMovie.MovieName.ToLower () && item.movieStatus == MovieStatus.Available)
            {
                rentMovie =item;
                item.movieStatus=MovieStatus.Unavailable;
               
            }
            
        }
         foreach (var movie in movieList)
              {
              Console.WriteLine (movie);
              }*/
        //choose customer
        //show list of rentable movies
        //choose one or moore movies
        //confirm choises
        //movies are marked as rented out
        //receipt printed
    }
    public void RentingReminder()
    {

    }
    public void LateFeeInvoice()
    {

    }
    public void PrintReceipt()
    {

    }

}