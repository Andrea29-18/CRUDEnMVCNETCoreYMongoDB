using CRUDMongo.Models;
using CRUDMongo.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CRUDMongo.Controllers
{
    public class SongController : Controller
    {
        private IAlbumColletion db = new AlbumCollection();

        public IActionResult Index()
        {
            return View();
        }

        // GET: SongController/Create
        public ActionResult Create(string id)
        {
            SongViewModel songVM = new SongViewModel() { AlbumId = id, Song = new Song() };
            return View(songVM);
        }


        // POST: SongController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                var album = db.GetAlbumById(collection["AlbumId"]);

                if(album.Songs == null) 
                {
                    album.Songs = new List<Song>();
                }

                album.Songs.Add(new Song 
                {
                    Name = collection["Song.Name"],
                    Duration = int.Parse(collection["Song.Duration"])
                });

                db.UpdateAlbum(album);

                return RedirectToAction("Index", "Album");
            }
            catch
            {
                return View();
            }
        }
    }
}
