using Green_Template_Back.DAL;
using Green_Template_Back.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Green_Template_Back.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            HomeVM model = new HomeVM
            {
                Sliders= await _context.Sliders.ToListAsync(),
                Cards= await _context.Cards.ToListAsync(),
                Abouts = await _context.Abouts.FirstOrDefaultAsync(),
                AboutLists= await _context.AboutLists.ToListAsync(),
                Services=await _context.Services.ToListAsync(),
                Contacts = await _context.Contacts.FirstOrDefaultAsync(),
                SocialMedias= await _context.SocialMedias.ToListAsync(),
                Settings = await _context.Settings.FirstOrDefaultAsync(),
            };
            return View(model);
        }
    }
}
