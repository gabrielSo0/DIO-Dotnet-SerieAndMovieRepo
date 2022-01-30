using DIO.Series.Interfaces;

namespace DIO.Series
{
    public class MovieRepository : IRepository<Movie>
    {
        private List<Movie> listMovies = new List<Movie>();
        public void Update(int id, Movie entity)
        {
            listMovies[id] = entity;
        }

        public void Remove(int id)
        {
            listMovies[id].Remove();
        }

        public void Insert(Movie entity)
        {
            listMovies.Add(entity);
        }

        public List<Movie> List()
        {
            return listMovies;
        }

        public int NextId()
        {
            return listMovies.Count;
        }

        public Movie GetById(int id)
        {
            return listMovies[id];
        }
    }
}