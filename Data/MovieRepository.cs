using MovieApp.Models;

namespace MovieApp.Data
{
    public static class MovieRepository
    {
        private static List<Movie> _movies = null;

        static MovieRepository()
        {
            _movies = new List<Movie>()
            {
                new Movie() { 
                    Id=1, 
                    Name="Shazam",
                    Description="<p>A beautiful and contemporary retelling of Colin Thiele's classic Australian tale.</p>",
                    ShortDescription="Shazam", 
                    ImageUrl="1.jpg",
                    CategoryId = 1
                },
                new Movie() {
                    Id=2,
                    Name="Amazing Grace",
                    Description="<p>A beautiful and contemporary retelling of Colin Thiele's classic Australian tale.</p>",
                    ShortDescription="Amazing Grace",
                    ImageUrl="2.jpg",
                    CategoryId = 2
                },
                new Movie() {
                     Id=3,
                     Name="High Life",
                     Description = "<p>A beautiful and contemporary retelling of Colin Thiele's classic Australian tale.</p>",                       
                     ShortDescription="High Life", 
                     ImageUrl="3.jpg",
                     CategoryId = 2
                },
                new Movie() { 
                     Id=4,
                     Name="Billboard",
                     Description = "<p>A beautiful and contemporary retelling of Colin Thiele's classic Australian tale.</p>", 
                     ShortDescription="Billboard", 
                     ImageUrl="4.jpg",
                     CategoryId = 3
                },
                new Movie() {
                     Id=5, 
                     Name="Storm Boy", 
                     Description = "<p>A beautiful and contemporary retelling of Colin Thiele's classic Australian tale.</p>",
                     ShortDescription="Storm Boy", 
                     ImageUrl="5.jpg",
                     CategoryId = 3
                }
            };
        }

        public static List<Movie> Movies
        {
            get 
            {
                return _movies;
            }
        }

        public static void AddMovie(Movie entity)
        {
            _movies.Add(entity);
        }

        public static Movie GetById(int id) {
            return _movies.FirstOrDefault(i => i.Id == id);
        }
    }
}