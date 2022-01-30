using DIO.Series.Interfaces;

namespace DIO.Series
{
    public class SerieRepository : IRepository<Serie>
    {
        private List<Serie> listSeries = new List<Serie>();
        public void Update(int id, Serie entity)
        {
            listSeries[id] = entity;
        }

        public void Remove(int id)
        {
            listSeries[id].Remove();
        }

        public void Insert(Serie entity)
        {
            listSeries.Add(entity);
        }

        public List<Serie> List()
        {
            return listSeries;
        }

        public int NextId()
        {
            return listSeries.Count;
        }

        public Serie GetById(int id)
        {
            return listSeries[id];
        }
    }
}