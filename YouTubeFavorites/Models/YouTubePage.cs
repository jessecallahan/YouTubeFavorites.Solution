using System.Collections.Generic;

namespace YouTubeFavorites.Models
{
  public class YouTubePage
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public string Link { get; set; }
    public int Id { get; }
    private static List<YouTubePage> _instances = new List<YouTubePage> { };

    public YouTubePage(string title, string description, string link)
    {
      Title = title;
      Description = description;
      Link = link;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<YouTubePage> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static YouTubePage Find(int searchId)
    {
      return _instances[searchId - 1];
    }
  }
}