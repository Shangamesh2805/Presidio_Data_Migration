using Microsoft.AspNetCore.Mvc;
using Shared.Services; 

namespace Frontend.Controllers
{
    public class HomeController : Controller
    {
        private readonly ItemService _itemService;

        public HomeController(ItemService itemService)
        {
            _itemService = itemService;
        }

        public IActionResult Index()
        {
            var items = _itemService.GetItems();
            return View(items);
        }
    }
}
