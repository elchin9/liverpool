using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Liverpool.DAL;
using Liverpool.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Liverpool.Controllers
{
    public class AjaxController : Controller
    {

        private readonly DB_Liverpool _context;
        private readonly UserManager<AppUser> _userManager;

        public AjaxController(DB_Liverpool context,
                              UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IActionResult LoadGallery(int skip)
        {
            var model =
                _context.Gallery.OrderByDescending(g => g.Id).Skip(skip).Take(8);

            return PartialView("_GalleryPartialView", model);
        }
        public IActionResult LoadEvent(int skip)
        {
            var model =
                _context.Event.Where(e => e.Time > DateTime.Now)
                              .OrderByDescending(g => g.Id)
                              .Skip(skip)
                              .Take(2);

            return PartialView("_EventPartialView", model);
        }
        public IActionResult LoadNews(int skip)
        {
            var model =
                _context.News.OrderByDescending(g => g.Id)
                              .Skip(skip)
                              .Take(8);

            return PartialView("_NewsPartialView", model);
        }
        public IActionResult LoadVideos(int skip)
        {
            var model =
                _context.Video.OrderByDescending(g => g.Id)
                              .Skip(skip)
                              .Take(8);

            return PartialView("_VideoPartialView", model);
        }
        public IActionResult LoadStadiumPhotos(int skip)
        {
            var model =
                _context.StadiumPhotos.OrderByDescending(g => g.Id)
                              .Skip(skip)
                              .Take(8);

            return PartialView("_StadiumPhotosPartialView", model);
        }
    }
}