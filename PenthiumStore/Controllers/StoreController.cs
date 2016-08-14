using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PenthiumStore.Models;

namespace PenthiumStore.Controllers
{
    public class StoreController : Controller
    {
        PenthiumContext storeDB = new PenthiumContext();


        //
        // GET: /Store/
        public ActionResult Index()
        {
            List<Category> genres = storeDB.Categories.ToList();

            return View(genres);
        }
        //
        // GET: /Store/Browse?genre=Disco

        public ActionResult Browse(string Category = "Mobile cases")
        {
            // Retrieve Genre and its Associated Albums from database
            Category category = storeDB.Categories.Include("Products").Single(g => g.Name == Category);

            return View(category);
        }
        //
        // GET: /Store/Details/5

        public ActionResult Details(int id = 1)
        {
            Product product = storeDB.Products.Find(id);

            return View(product);
        }
    }
}