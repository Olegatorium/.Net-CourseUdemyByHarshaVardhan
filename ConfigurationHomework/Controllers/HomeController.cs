using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace ConfigurationHomework.Controllers
{
    public class HomeController : Controller
    {
        private readonly SocialMediaLinksOptions _options;

        public HomeController(IOptions<SocialMediaLinksOptions> socialMediaLinksOptions)
        {
            _options = socialMediaLinksOptions.Value;
        }

        [Route("/")]
        public IActionResult Index()
        {
            ViewBag.FaceBook = _options.Facebook;
            ViewBag.Instagram = _options.Instagram;
            ViewBag.Twitter = _options.Twitter;
            ViewBag.Youtube = _options.Youtube;

            return View();
        }
    }
}
