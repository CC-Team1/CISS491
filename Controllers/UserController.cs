using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace ADB_Fishing_Tournament.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Home()
        {
            ViewData["Tournament"] = "ADB Fishing Tournament";
            ViewData["Participants"] = 50;
            ViewData["Events"] = new List<string> { "Burbot Bash", "East Canyon Ice Fishing Derby with Fins & Fur",
            "Slotbuster Ice Fishing Tournament"};
            return View();
        }
    }
}
