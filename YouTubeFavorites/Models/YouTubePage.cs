using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace YouTubeFavorites.Models
{
  public class YouTubePage
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public string Link { get; set; }
    public int Id { get; set; }


    public YouTubePage(string title, string description, string link)
    {
      Title = title;
      Description = description;
      Link = link;
    }
    public YouTubePage(string title, string description, string link, int id)
    {
      Title = title;
      Description = description;
      Link = link;
      Id = id;
    }

    public void Save()
    {
      MySqlConnection conn = DB.Connection();
      conn.Open();
      var cmd = conn.CreateCommand() as MySqlCommand;

      // Begin new code

      cmd.CommandText = @"INSERT INTO youtubepages (title) VALUES (@YouTubeTitle);";
      cmd.CommandText = @"INSERT INTO youtubepages (description) VALUES (@YouTubeDescription);";
      cmd.CommandText = @"INSERT INTO youtubepages (link) VALUES (@YouTubeLink);";
      MySqlParameter title = new MySqlParameter();
      title.ParameterName = "@YouTubeTitle";
      title.Value = this.Title;
      cmd.Parameters.Add(title);

      MySqlParameter description = new MySqlParameter();
      description.ParameterName = "@YouTubeDescription";
      description.Value = this.Description;
      cmd.Parameters.Add(description);

      MySqlParameter link = new MySqlParameter();
      link.ParameterName = "@YouTubeLink";
      link.Value = this.Link;
      cmd.Parameters.Add(link);

      cmd.ExecuteNonQuery();
      Id = (int)cmd.LastInsertedId;

      // End new code

      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
    }

    public override bool Equals(System.Object otherYouTubePage)
    {
      if (!(otherYouTubePage is YouTubePage))
      {
        return false;
      }
      else
      {
        YouTubePage newYouTubePage = (YouTubePage)otherYouTubePage;
        bool idEquality = (this.Id == newYouTubePage.Id);
        bool descriptionEquality = (this.Description == newYouTubePage.Description);
        bool titleEquality = (this.Title == newYouTubePage.Title);
        bool linkEquality = (this.Link == newYouTubePage.Link);
        return (idEquality && descriptionEquality && titleEquality && linkEquality);
      }
    }

    public static List<YouTubePage> GetAll()
    {
      List<YouTubePage> allYouTubePages = new List<YouTubePage> { };
      MySqlConnection conn = DB.Connection();
      conn.Open();
      MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"SELECT * FROM youtubepages;";
      MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
      while (rdr.Read())
      {
        int itemId = rdr.GetInt32(0);
        string itemTitle = rdr.GetString(1);
        string itemDescription = rdr.GetString(2);
        string itemLink = rdr.GetString(3);
        YouTubePage newYouTubePage = new YouTubePage(itemTitle, itemDescription, itemLink, itemId);
        allYouTubePages.Add(newYouTubePage);
      }
      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
      return allYouTubePages;
    }

    public static void ClearAll()
    {
      MySqlConnection conn = DB.Connection();
      conn.Open();
      var cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"DELETE FROM youtubepages;";
      cmd.ExecuteNonQuery();
      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
    }

    public static YouTubePage Find(int searchId)
    {
      YouTubePage placeholderYouTubePage = new YouTubePage("placeholder item", "other thhing", "other thing");
      return placeholderYouTubePage;
    }
  }
}