using Liverpool.DAL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Liverpool.ViewComponents
{
    public class ContactViewComponent : ViewComponent
    {
        private readonly DB_Liverpool _context;

        public ContactViewComponent(DB_Liverpool context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var social = _context.StaticData.FirstOrDefault();
            return View(await Task.FromResult(social));
        }
    }
}
