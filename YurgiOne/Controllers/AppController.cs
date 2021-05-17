using Microsoft.AspNetCore.Mvc;
using YurgiOne.Services;
using YurgiOne.ViewModels;

namespace YurgiOne.Controllers
{
    public class AppController : Controller
    {
        private readonly INullMailService _mailService;

        public AppController(INullMailService mailService)
        {
            _mailService = mailService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("contact")]
        public IActionResult Contact()
        {
            ViewBag.Title = "Contact us";
            return View();
        }

        [HttpPost("contact")]
        public IActionResult Contact(ContactViewModel contactViewModel)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Title = "Contact";

                _mailService.SendMessage(contactViewModel.Name, contactViewModel.Email, contactViewModel.Subject, contactViewModel.Message);
                ViewBag.UserMessage = "Mail sent";
                ModelState.Clear();
            }

            return View();
        }

        [HttpGet("about")]
        public IActionResult About()
        {
            ViewBag.Title = "About us";
            return View();
        }
    }
}