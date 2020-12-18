using Microsoft.AspNetCore.Mvc;
using MusicOrganizer.Models;
using System.Collections.Generic;

namespace MusicOrganizer.Controllers
{
    public class AlbumsController : Controller
    {
        [HttpGet("/albums")] //Display list of all ParentObjects
        public ActionResult Index()
        {
            List<Album> allAlbums = Album.GetAll(); //displaying all categories
            return View(allAlbums);
        }

        [HttpGet("/albums/new")] //user creates new ParentObject with form
        public ActionResult New()
        {
            return View();
        }

        [HttpPost("/albums")] //Creates new ParentObject on server process form submission
        public ActionResult Create(string albumName) //accepts argument because it is referring to the contents in form 
        {
            Album newAlbum = new Album(albumName); //create a new category
            return RedirectToAction("Index"); //sends the user back to the Index route
        }

        [HttpGet("/albums/{id}")] //Display one specific ParentObject's details
        public ActionResult Show(int id)
        {
            Dictionary<string, object> model = new Dictionary<string, object>();
            Album selectedAlbum = Album.Find(id);
            List<Artist> albumArtists = selectedAlbum.Artists;
            model.Add("album", selectedAlbum); //keys == "albums" and "artsts"
            model.Add("artist", albumArtists);
            return View(model); //view can only accept one model argument
        }

        // This one creates new Items within a given Category, not new Categories:
        [HttpPost("/albums/{albumId}/artists")]
        public ActionResult Create(int albumId, string artistName)
        {
            Dictionary<string, object> model = new Dictionary<string, object>();
            Album foundAlbum = Album.Find(albumId);
            Artist newArtist = new Artist(artistName);
            foundAlbum.AddArtist(newArtist);
            List<Artist> albumArtist = foundAlbum.Artists;
            model.Add("artist", albumArtist);
            model.Add("album", foundAlbum);
            return View("Show", model);
        }
    }
}