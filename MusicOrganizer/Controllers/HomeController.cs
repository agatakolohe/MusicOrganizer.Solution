using Microsoft.AspNetCore.Mvc;
using MusicOrganizer.Models;
using System.Collections.Generic;

namespace MusicOrganizer.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public ActionResult Index()
        {
            return View();
        }

        // [Route("/favorite_photos")] //route to pictures
        // public ActionResult FavoritePhotos()
        // {
        //     return View();
        // }


    }
}