using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MySqlConnector;
using MySQLFun.Models;

namespace MySQLFun.Controllers;

public class HomeController : Controller
{
    private RecipesDbContext _context { get; set; }
    
    //constructor
    public HomeController(RecipesDbContext temp)
    {
        _context = temp;
    }

    public IActionResult Index()
    {
        var recipes = _context.Recipes
            .Select(r => new Recipe
            {
                RecipeID = r.RecipeID,
                RecipeTitle = r.RecipeTitle ?? "", // Replace NULL with an empty string
                // Add other properties as needed
            })
            .ToList();

        return View(recipes);
    }
}