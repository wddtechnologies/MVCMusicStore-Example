using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcMusicStore2.Models;

namespace MvcMusicStore2.Controllers
{
    public class StoreController : Controller
    {
        MusicStoreEntities storeDB = new MusicStoreEntities();

        // GET: Store
     
       public ActionResult Index()
        {
            // return " Hello from Store.Index()";
           var genres = storeDB.Genres.ToList();
           return View(genres);
        }
        //GET: /Store/Browse?genre=Disco

        public ActionResult Browse(string genre)
        {
            //string message = HttpUtility.HtmlEncode("Store.Browse, Genre = " + genre);
            //return message;
            // var genreModel = new Genre { Name = genre };
            // return View(genreModel);
            // Retrieve Genre and its Associated Albums from database
            var genreModel = storeDB.Genres.Include("Albums")
                .Single(g => g.Name == genre);

            return View(genreModel);
        }

        //GET: /Store/Details/5
        public ActionResult Details(int id)
        {
            // string message = "Store.Details, ID = " + id;
            // var album = new Album { Title = "Album" + id };
            // return View(album);
            var album = storeDB.Albums.Find(id);

            return View(album);
        }
    }
}