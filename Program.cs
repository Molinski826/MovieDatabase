





using System.ComponentModel.Design;
using MovieDatabase;

Console.WriteLine("Welcome to the movie database");

List<Movie> movies = new List<Movie>
        {
            new Movie("Toy Story", "animated", 81, 1995),
            new Movie("The Godfather", "drama", 175, 1972),
            new Movie("The Conjuring", "horror", 112, 2013),
            new Movie("Interstellar", "scifi", 169, 2014),
            new Movie("Finding Nemo", "animated", 100, 2003),
            new Movie("Titanic", "drama", 195, 1997),
            new Movie("A Quiet Place", "horror", 90, 2018),
            new Movie("Blade Runner 2049", "scifi", 164, 2017),
            new Movie("Shrek", "animated", 90, 2001),
            new Movie("Inception", "scifi", 148, 2010)

        };


//bool continueRunning = true;

//while (continueRunning)
//{
//    Console.WriteLine("Enter a category (animated, drama, horror, scifi):");
//    string category = Console.ReadLine().ToLower();

//    // Check if the category is valid
//    List<string> validCategories = new List<string> { "animated", "drama", "horror", "scifi" };

//    if (validCategories.Contains(category))
//    {
//        // Filter movies by category
//        List<Movie> filteredMovies = movies
//            .Where(movie => movie.Category == category)
//            .OrderBy(movie => movie.Title)
//            .ToList();

//            Console.WriteLine($"Movies in category '{category}':");
//            foreach (Movie movie in filteredMovies)
//            {
//                Console.WriteLine($"{movie.Title} ({movie.Year}) - {movie.Length} mins");
//            }

//    }
//    else
//    {
//        Console.WriteLine("Invalid category entered. Please enter one of the following: animated, drama, horror, scifi.");
//    }


//    while (true)
//    {
//        Console.WriteLine("Would you like to select another category? y/n");
//        string loopChoice = Console.ReadLine().ToLower().Trim();
//        if (loopChoice == "y")
//        {
//            break;
//        }
//        else if (loopChoice == "n")
//        {
//            continueRunning = false;
//            break;
//        }
//        else
//        {
//            Console.WriteLine("Invalid, try again");
//        }
//    }
//}














bool continueRunning = true;
while (continueRunning)
{
    Console.WriteLine("Enter a movie category: ");
    Console.WriteLine("1. Animated");
    Console.WriteLine("2. Drama");
    Console.WriteLine("3. Horror");
    Console.WriteLine("4. Sci-Fi");
    string category = Console.ReadLine().ToLower();

    string selectedCategory = category switch
    {
        "1" => "animated",
        "2" => "drama",
        "3" => "horror",
        "4" => "scifi",
        _ => null

    };
    if (selectedCategory == null)
    {
        Console.WriteLine("Invalid category. Please try again.");






        List<Movie> filteredMovies = movies.Where(movie => movie.Category == selectedCategory).OrderBy(movie => movie.Title).ToList();

        if (filteredMovies.Count > 0)
        {
            Console.WriteLine($"Movies in the {selectedCategory} category");
            foreach (Movie movie in filteredMovies)
            {
                Console.WriteLine($"{movie.Title}, {movie.Year}, {movie.Length}");
            }
        }
        else
        {
            Console.WriteLine("No movies found in that category");
        }
    }

    while (true)
    {
        Console.WriteLine("Would you like to select another category? y/n");
        string loopChoice = Console.ReadLine().ToLower().Trim();
        if (loopChoice == "y")
        {
            break;
        }
        else if (loopChoice == "n")
        {
            continueRunning = false;
            break;
        }
        else
        {
            Console.WriteLine("Invalid, try again");
        }
    }

}





