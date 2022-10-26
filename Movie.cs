

public enum MovieStatus
{
    Available,
    Unavailable
}

public class Movie
{
    public int movieID { get; set; }
    public string movie_name { get; set; }
    public string date_published { get; set; }
    public double MoviePrice { get; set; }
    public bool isOutdated { get; set; }
    public bool is_rented { get; set; }

    public MovieStatus movieStatus = MovieStatus.Available;

    private List<Movie> movies; //added a list

    public Movie()
    {
        movies = new List<Movie>(); //so we can reach the list
    }
    public Movie(int movieBarcode, string movieName, string datePublished)
    {
        movieID = movieBarcode;
        this.movie_name = movieName;
        this.date_published = datePublished;
    }

    public override string ToString()
    {
        return $"{movieID} {movie_name} {date_published} {MoviePrice} {movieStatus}";
    }
    // public void AddMovie(List<Movie> someMovies)
    // {
    //     foreach (var movie in someMovies) //loop to add movies
    //     {
    //         movies.Add(movie);
    //     }
    // }
    public void AddMovie(Movie movie)
    {

        movies.Add(movie);

    }
    public void PrintListOfMovies()
    {
        foreach (var item in movies)
        {
            Console.WriteLine(item);
        }
    }
            // Movie newMovie = new();
    public void SetMoviePrice()
    {
        
        foreach (var movie in movies)
        {
            // if (movie.date_published <= 1996)        //we pretend the year is 1998 :)
            // {
            //      movie.MoviePrice = 29;
            // }
            // else
            // {
            //      movie.MoviePrice = 49;
            // }
        
            // return MoviePrice=49;
        }
    }
    public void RemoveMovie(int answer)
    {
        // List <Movie> removeMovies = new();
        // var itemToRemove = movies.Single(r => r.MovieBarcode == answer);
        // movies.Remove(itemToRemove);
        // Console.WriteLine("hej");
        //var item = movies.SingleOrDefault(x => x.MovieBarcode == answer);
        //if (item != null)
        //Console.WriteLine(item);
        //movies.Remove(item);

        for (int i = 0; i < movies.Count; i++) // i am using this method but i think the other ones could work too since it was not the method problem. 
        {

            if (movies[i].movieID == (answer))
            {
                movies.RemoveAt(i);
            }
        }

    }


}