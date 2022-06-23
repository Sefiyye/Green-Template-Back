using Green_Template_Back.DAL;
using Green_Template_Back.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Green_Template_Back.ViewComponents
{
    public class HeaderViewComponent:ViewComponent
    {
        private readonly AppDbContext _context;

        public HeaderViewComponent(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            HomeVM model = new HomeVM
            {
                Settings = await _context.Settings.FirstOrDefaultAsync(),
                SocialMedias = await _context.SocialMedias.ToListAsync()
            };
            return View(model);
        }
    }
}
