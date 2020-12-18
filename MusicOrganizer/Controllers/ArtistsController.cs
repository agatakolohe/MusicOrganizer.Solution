using Microsoft.AspNetCore.Mvc;
using MusicOrganizer.Models;
using System.Collections.Generic;
using System;

namespace MusicOrganizer.Controllers
{
    public class ArtistsController : Controller
    {


        [HttpGet("/albums/{albumId}/artists/new")]//user creates the ChildObject example:Item in category. Category: Housework == Item:Mop the floors
        public ActionResult New(int albumId)
        {
            Album album = Album.Find(albumId);
            return View(album);
        }

        [HttpPost("/artists/delete")] //deleting 
        public ActionResult DeleteAll()
        {
            Artist.ClearAll();
            return View();
        }
        [HttpGet("/albums/{albumId}/artists/{artistId}")] //show both objects
        public ActionResult Show(int albumId, int artistId)
        {
            Artist artist = Artist.Find(artistId);
            Album album = Album.Find(albumId);
            Dictionary<string, object> model = new Dictionary<string, object>();
            model.Add("artist", artist);
            model.Add("album", album);
            return View(model);
        }

    }
}