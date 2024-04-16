namespace SQLAssignment.Pages.Model
{
    public class Titles
    {
        public int TitlesID { get; set; }
        public string Title { get; set; }
        public string StartYear { get; set; }


        public Titles() { }

        public Titles(int titlesID, string title, string startYear)
        {
            TitlesID = titlesID;
            Title = title;
            StartYear = startYear;

        }

        public string GetInfo()
        {
            return ToString();
        }


        private readonly List<Titles> title = new List<Titles>()
        {

        };

        public List<Titles> GetAllTitles()
        {
            return new List<Titles>(title);

        }

    }
}
