using Microsoft.AspNetCore.Mvc;
using Ocuco.Hydra.WebMVC.Services;
using Ocuco.Hydra.WebMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocuco.Hydra.WebMVC.Controllers
{
    public class AppController : Controller
    {
        private readonly IMailService _mailService;
        //private readonly IDutchRepository _repository;

        public AppController(IMailService mailService
            //, IDutchRepository repository
            )
        {
            this._mailService = mailService;
            //this._repository = repository;
        }

        public IActionResult Index()
        {
            //throw new InvalidOperationException("Bad things happened");

            return View();
        }

        [HttpGet("contact")]
        public IActionResult Contact()
        {
            //throw new InvalidOperationException("Bad things happened");

            return View();
        }

        [HttpPost("contact")]
        public IActionResult Contact(ContactViewModel model)
        {
            //ViewBag.Title = "Contact Us";

            if (ModelState.IsValid)
            {
                // Send the email
                _mailService.SendMessage("daniel.tassi@ocuco.com", model.Subject, $"From: {model.Name} - {model.Email}, Message: {model.Message}");

                ViewBag.UserMessage = "Mail Sent";
                ModelState.Clear();
            }

            return View();
        }

        public IActionResult About()
        {
            ViewBag.Title = "About Us";

            return View();
        }
    }
}
