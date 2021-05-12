using Microsoft.AspNetCore.Mvc;
using YouTubeFavorites.Models;
using System.Collections.Generic;

namespace YouTubeFavorites.Controllers
{
  public class YouTubePagesController : Controller
  {

    [HttpGet("/categories/{categoryId}/youtubepages/new")]
    public ActionResult New(int categoryId)
    {
      Category category = Category.Find(categoryId);
      return View(category);
    }

    [HttpPost("/youtubepages/delete")]
    public ActionResult DeleteAll()
    {
      YouTubePage.ClearAll();
      return View();
    }

    [HttpGet("/categories/{categoryId}/youtubepages/{pageId}")]
    public ActionResult Show(int categoryId, int pageId)
    {
      YouTubePage youtubepage = YouTubePage.Find(pageId);
      Category category = Category.Find(categoryId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("youtubepage", youtubepage);
      model.Add("category", category);
      return View(model);
    }
  }
}