using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace inde.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;
        public bool hasData = false;
        public string firstName = "";
        public string lastName = "";
        public string message = "";

        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }




        public void OnPost()
        {
            hasData = true;
            firstName = Request.Form["firstName"];

            message = Request.Form["message"];
        }



            public void OnGet()
        {
        }
    }
}