using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using YouTubeFavorites.Models;

namespace YouTubeFavorites.Controllers
{
  public class CategoriesController : Controller
  {

    [HttpGet("/categories")]
    public ActionResult Index()
    {
      List<Category> allCategories = Category.GetAll();
      return View(allCategories);
    }

    [HttpGet("/categories/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/categories")]
    public ActionResult Create(string categoryName)
    {
      Category newCategory = new Category(categoryName);
      return RedirectToAction("Index");
    }

    [HttpGet("/categories/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Category selectedCategory = Category.Find(id);
      List<YouTubePage> categoryYouTubePages = selectedCategory.YouTubePages;
      model.Add("category", selectedCategory);
      model.Add("youtubepages", categoryYouTubePages);
      return View(model);
    }


    // This one creates new Items within a given Category, not new Categories:

    [HttpPost("/categories/{categoryId}/youtubepages")]
    public ActionResult Create(int categoryId, string youtubepageTitle, string youtubepageDescription, string youtubepageLink)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Category foundCategory = Category.Find(categoryId);
      YouTubePage newYouTubePage = new YouTubePage(youtubepageTitle, youtubepageDescription, youtubepageLink);
      newYouTubePage.Save();
      foundCategory.AddYouTubePage(newYouTubePage);
      List<YouTubePage> categoryYouTubePages = foundCategory.YouTubePages;
      model.Add("youtubepages", categoryYouTubePages);
      model.Add("category", foundCategory);
      return View("Show", model);
    }

  }
}