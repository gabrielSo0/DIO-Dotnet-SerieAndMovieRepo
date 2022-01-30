namespace DIO.Series
{
    public class Serie : ScreenEntertainment
    {
        // private Genre Genre { get; set; }
        // private string Title { get; set; }
        // private string Description { get; set; }
        // private int Releaseyear { get; set; }
        // private bool Removed { get; set; }

        public Serie(int id, Genre genre, string title, string description, int releaseYear)
        {
            this.Id = id;
            this.Genre = genre;
            this.Title = title;
            this.Description = description;
            this.Releaseyear = releaseYear;
            this.Removed = false;
        }

        // public override string ToString()
        // {
        //     string retorno = "";
        //     retorno += "Genre: " + this.Genre + Environment.NewLine;
        //     retorno += "Title: " + this.Title + Environment.NewLine;
        //     retorno += "Description: " + this.Description + Environment.NewLine;
        //     retorno += "Release Year: " + this.Releaseyear + Environment.NewLine;
        //     retorno += "Removed: " + this.Removed;
        //     return retorno;
        // }
        // public string GetTitle()
        // {
        //     return this.Title;
        // }
        // public int GetId()
        // {
        //     return this.Id;
        // }
        // public bool GetRemoved()
        // {
        //     return this.Removed;
        // }
        // public void Remove()
        // {
        //     this.Removed = true;
        // }
    }
}