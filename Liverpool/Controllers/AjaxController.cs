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

        public IActionResult LoadVideoIndex(int skip)
        {
            var model =
                _context.Video.OrderByDescending(g => g.Id).Skip(skip).Take(10);

            return PartialView("_VideoIndexPartialView", model);
        }

        public IActionResult LoadCupIndex(int skip)
        {
            var model =
                _context.Cup.OrderByDescending(g => g.Id).Skip(skip).Take(10);

            return PartialView("_CupIndexPartialView", model);
        }
        public IActionResult LoadNewsIndex(int skip)
        {
            var model =
                _context.News.OrderByDescending(g => g.Id).Skip(skip).Take(10);

            return PartialView("_NewsIndexPartialView", model);
        }
        public IActionResult LoadGalleryIndex(int skip)
        {
            var model =
                _context.Gallery.OrderByDescending(g => g.Id).Skip(skip).Take(10);

            return PartialView("_GalleryIndexPartialView", model);
        }
        public IActionResult LoadPlayerIndex(int skip)
        {
            var model =
                _context.Player.OrderByDescending(g => g.Id).Skip(skip).Take(10);

            return PartialView("_PlayerIndexPartialView", model);
        }
        public IActionResult LoadEventIndex(int skip)
        {
            var model =
                _context.Event.OrderByDescending(g => g.Id).Skip(skip).Take(10);

            return PartialView("_EventIndexPartialView", model);
        }
        public IActionResult LoadMessageIndex(int skip)
        {
            var model =
                _context.MailBox.OrderByDescending(g => g.Id).Skip(skip).Take(10);

            return PartialView("_MailBoxIndexPartialView", model);
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