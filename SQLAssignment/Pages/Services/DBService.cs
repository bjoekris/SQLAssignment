using SQLAssignment.Pages.Model;

namespace SQLAssignment.Pages.Services

{
    public class DBService : IDBService
    {


        private const String ConnectionString = "Very Nice Connectionstring i was unable to obtain";

        private Title Titles = new Title();

        public List<Title> GetAllTitles()
        {
            String sql = "select * from Titles";

            //Forbindelse 
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            //Kommando
            SqlCommand cmd = new SqlCommand(sql, conn);

            //Sendes til server og få svar ("reader" er svar fra databasen).
            SqlDataReader reader = cmd.ExecuteReader();

            //Laver en liste som svarene kan sættes ind i)
            List<Titles> lager = new List<Titles>();
            while (reader.Read())
            {
                lager.Add(ReadLager(reader));
            }
            return lager;

        }


    }

    }
}
