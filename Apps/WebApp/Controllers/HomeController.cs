using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;
using WebApp.Models.Common;
using WebApp.Models.Profiles;
using WebApp.Models.WebContent;

namespace WebApp.Controllers {
    public class HomeController : Controller {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger) {
            _logger = logger;
        }

        

        private (PageTemplate, Page) GetObject() {
            Profile profile = new() {
                Id = Guid.NewGuid(),
                CreatedDateUtc = DateTime.UtcNow,
                Name = "Jason Iverson Consulting",
                //PrimaryContact = new() {
                //    Id = Guid.NewGuid(),
                //    Email = "hello@jason-iverson.com",
                //    //Address = new() {
                //    //    Id = Guid.NewGuid(),
                //    //    Line1 = "PO Box 277298",
                //    //    Locality = "Sacramento",
                //    //    Region = States.CALIFORNIA.Abbreviation,
                //    //    PostalCode = "95827"
                //    //},
                //    GivenName = "Jason",
                //    FamilyName = "Iverson",
                //    PhoneNumber = "9166680068",
                //    Title = "Proprietor",
                //    CreatedDateUtc = DateTime.UtcNow
                //},
                SocialMediaAccounts = new() {
                    //new SocialMediaAccount() {
                    //    Platform = SocialMediaPlatforms.Twitter,
                    //    Order = 0,
                    //    UserName = "JasonAtSBWP"
                    //},
                    new SocialMediaAccount() {
                        Platform = SocialMediaPlatforms.LinkedIn,
                        Order = 1,
                        UserName = "jasoniverson"
                    }
                }
            };

            PageTemplate pageTemplate = new() {
                Id = Guid.NewGuid(),
                //Profile = profile
            };
            Page page = new() {
                Id = Guid.NewGuid(),
                //ProfileId = profile.Id,
                //Profile = profile,
                Name = "Home",
                Type = PageTypes.Homepage,
                Metadata = new() {
                    Title = "Jason Iverson Consulting",
                    Description = "Sacramento based Microsoft technologies consultant with over 15 years of experience delivering business solutions on time and under budget",
                    Keywords = "Sacramento, .NET Full Stack Developer, Back End Developer, Software Consultant, Web Develper, Software Engineer"
                }
            };

            return (pageTemplate, page);
        }

        [Route("/")]
        public IActionResult Index() {
            return this.View(this.GetObject());
        }

        [Route("/elements")]
        public IActionResult Elements() {
            return this.View(this.GetObject());
        }

        public IActionResult Privacy() {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
