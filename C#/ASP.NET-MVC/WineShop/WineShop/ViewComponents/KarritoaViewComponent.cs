using Microsoft.AspNetCore.Mvc;
using WineShop.Models;
using WineShop.Services;

namespace WineShop.ViewComponents
{
    public class KarritoaViewComponent : ViewComponent
    {
        private readonly ISaskiaService _saskiaService;
        public KarritoaViewComponent(ISaskiaService saskiaService)
        {
            _saskiaService = saskiaService;
        }

        public async Task<IViewComponentResult> InvokeAsync(string id)
        {

            List<SaskiaAlea> count = await _saskiaService.SaskiaLortuAleak(id);

            ViewBag.saskiacount = count.Count();
            return View();
        }
    }
}
