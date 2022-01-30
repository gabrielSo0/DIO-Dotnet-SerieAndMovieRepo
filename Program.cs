using System;

namespace DIO.Series
{
    class Program
    {
        static SerieRepository serieRepository = new SerieRepository();
        static MovieRepository movieRepository = new MovieRepository();
        static void Main(string[] args)
        {
            string userOption = "";

            System.Console.WriteLine("1 - Series");
            System.Console.WriteLine("2 - Movies");

            System.Console.Write("Please, select one of the two options below: ");

            int isMovieOrSerie = int.Parse(Console.ReadLine());

            switch(isMovieOrSerie)
            {
                case 1:
                    userOption = getUserOption("Serie");
                    ExecuteSeriesMethods(userOption);
                    break;
                case 2:
                    userOption = getUserOption("Movie");
                    ExecuteMoviesMethods(userOption);
                    break;
            } 
            
            System.Console.WriteLine("Thanks for using our services.");
            Console.ReadLine();
        }
        private static void RemoveSerie()
        {
            System.Console.WriteLine("Please, type the serie's id: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            serieRepository.Remove(indiceSerie);
        }
        private static void ShowSerie()
        {
            System.Console.WriteLine("Please, type the serie's id: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            var serie = serieRepository.GetById(indiceSerie);

            System.Console.WriteLine(serie);
        }
        private static void UpdateSerie()
        {
            System.Console.WriteLine("Please, type the serie's id: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Genre)))
            {
                System.Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genre), i));
            }

            System.Console.Write("Type the genre between the options above: ");
            int genre = int.Parse(Console.ReadLine());

            System.Console.Write("Type the serie's title: ");
            string title = Console.ReadLine();

            System.Console.Write("Type the serie's release year: ");
            int releaseYear = int.Parse(Console.ReadLine());

            System.Console.Write("Type the serie's description: ");
            string description = Console.ReadLine();

            Serie updateSerie = new Serie(
                                        id: indiceSerie,
                                        genre: (Genre)genre,
                                        title: title,
                                        releaseYear: releaseYear,
                                        description: description);
            
            serieRepository.Update(indiceSerie, updateSerie);
        }
        private static void ListSeries()
        {
            System.Console.WriteLine("List all the series");

            var list = serieRepository.List();

            if(list.Count == 0)
            {
                System.Console.WriteLine("No registered series");
                return;
            }

            foreach (var serie in list)
            {
                var removed = serie.GetRemoved();
                System.Console.WriteLine("#ID {0}: - {1} {2}", serie.GetId(), serie.GetTitle(), removed ? "*Removed*": "");
            }
        }
        private static void insertSerie()
        {
            System.Console.WriteLine("Insert a new serie");

            foreach (int i in Enum.GetValues(typeof(Genre)))
            {
                System.Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genre), i));
            }

            System.Console.Write("Type the genre between the options above: ");
            int genre = int.Parse(Console.ReadLine());

            System.Console.Write("Type the serie's title: ");
            string title = Console.ReadLine();

            System.Console.Write("Type the serie's release year: ");
            int releaseYear = int.Parse(Console.ReadLine());

            System.Console.Write("Type the serie's description: ");
            string description = Console.ReadLine();

            Serie newSerie = new Serie(
                                        id: serieRepository.NextId(),
                                        genre: (Genre)genre,
                                        title: title,
                                        releaseYear: releaseYear,
                                        description: description);
            
            serieRepository.Insert(newSerie);
        }
        private static void RemoveMovie()
        {
            System.Console.WriteLine("Please, type the movie's id: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            movieRepository.Remove(indiceSerie);
        }
        private static void ShowMovie()
        {
            System.Console.WriteLine("Please, type the movie's id: ");
            int indiceMovie = int.Parse(Console.ReadLine());

            var serie = movieRepository.GetById(indiceMovie);

            System.Console.WriteLine(serie);
        }
        private static void UpdateMovie()
        {
            System.Console.WriteLine("Please, type the movie's id: ");
            int indiceMovie = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Genre)))
            {
                System.Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genre), i));
            }

            System.Console.Write("Type the genre between the options above: ");
            int genre = int.Parse(Console.ReadLine());

            System.Console.Write("Type the movie's title: ");
            string title = Console.ReadLine();

            System.Console.Write("Type the movie's release year: ");
            int releaseYear = int.Parse(Console.ReadLine());

            System.Console.Write("Type the movie's description: ");
            string description = Console.ReadLine();

            Movie updateMovie = new Movie(
                                        id: indiceMovie,
                                        genre: (Genre)genre,
                                        title: title,
                                        releaseYear: releaseYear,
                                        description: description);
            
            movieRepository.Update(indiceMovie, updateMovie);
        }
        private static void ListMovies()
        {
            System.Console.WriteLine("List all the movies");

            var list = movieRepository.List();

            if(list.Count == 0)
            {
                System.Console.WriteLine("No registered movies");
                return;
            }

            foreach (var movie in list)
            {
                var removed = movie.GetRemoved();
                System.Console.WriteLine("#ID {0}: - {1} {2}", movie.GetId(), movie.GetTitle(), removed ? "*Removed*": "");
            }
        }
        private static void insertMovies()
        {
            System.Console.WriteLine("Insert a new movie");

            foreach (int i in Enum.GetValues(typeof(Genre)))
            {
                System.Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genre), i));
            }

            System.Console.Write("Type the genre between the options above: ");
            int genre = int.Parse(Console.ReadLine());

            System.Console.Write("Type the movie's title: ");
            string title = Console.ReadLine();

            System.Console.Write("Type the movie's release year: ");
            int releaseYear = int.Parse(Console.ReadLine());

            System.Console.Write("Type the movie's description: ");
            string description = Console.ReadLine();

            Movie newMovie = new Movie(
                                        id: movieRepository.NextId(),
                                        genre: (Genre)genre,
                                        title: title,
                                        releaseYear: releaseYear,
                                        description: description);
            
            movieRepository.Insert(newMovie);
        }
        private static string getUserOption(string movieOrSerie)
        {
            string isMovieOrSerie = movieOrSerie;
            System.Console.WriteLine();
            System.Console.WriteLine($"DIO {isMovieOrSerie} for you to watch!!");
            System.Console.WriteLine("Enter the desired option:");

            System.Console.WriteLine($"1 - List {isMovieOrSerie}s");
            System.Console.WriteLine($"2 - Insert new {isMovieOrSerie}");
            System.Console.WriteLine($"3 - Update {isMovieOrSerie}");
            System.Console.WriteLine($"4 - Remove {isMovieOrSerie}");
            System.Console.WriteLine($"5 - Show {isMovieOrSerie}");
            System.Console.WriteLine("C - Clean Screen");
            System.Console.WriteLine("X - Exit");
            System.Console.WriteLine();

            string userOption = Console.ReadLine().ToUpper();
            System.Console.WriteLine();
            return userOption;
        } 
        private static void ExecuteSeriesMethods(string userOption)
        {
            while(userOption.ToUpper() != "X")
            {
                switch (userOption)
                {
                    case "1":
                        ListSeries();
                        break;
                    case "2":
                        insertSerie();
                        break;
                    case "3":
                        UpdateSerie();
                        break;
                    case "4":
                        RemoveSerie();
                        break;
                    case "5":
                        ShowSerie();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                userOption = getUserOption("Serie");
            }
        }
        private static void ExecuteMoviesMethods(string userOption)
        {
            while(userOption.ToUpper() != "X")
            {
                switch (userOption)
                {
                    case "1":
                        ListMovies();
                        break;
                    case "2":
                        insertMovies();
                        break;
                    case "3":
                        UpdateMovie();
                        break;
                    case "4":
                        RemoveMovie();
                        break;
                    case "5":
                        ShowMovie();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                userOption = getUserOption("Movie");
            }
        }

    }
}