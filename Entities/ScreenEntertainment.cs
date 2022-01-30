namespace DIO.Series
{
    public abstract class ScreenEntertainment : EntityBase
    {
        protected Genre Genre { get; set; }
        protected string? Title { get; set; }
        protected string? Description { get; set; }
        protected int Releaseyear { get; set; }
        protected bool Removed { get; set; }

        // public ScreenEntertainment(int id, Genre genre, string title, string description, int releaseYear)
        // {
        //     this.Id = id;
        //     this.Genre = genre;
        //     this.Title = title;
        //     this.Description = description;
        //     this.Releaseyear = releaseYear;
        //     this.Removed = false;
        // }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Genre: " + this.Genre + Environment.NewLine;
            retorno += "Title: " + this.Title + Environment.NewLine;
            retorno += "Description: " + this.Description + Environment.NewLine;
            retorno += "Release Year: " + this.Releaseyear + Environment.NewLine;
            retorno += "Removed: " + this.Removed;
            return retorno;
        }
        public virtual string GetTitle()
        {
            return this.Title;
        }
        public virtual int GetId()
        {
            return this.Id;
        }
        public virtual bool GetRemoved()
        {
            return this.Removed;
        }
        public virtual void Remove()
        {
            this.Removed = true;
        }
    }
}