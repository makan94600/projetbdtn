using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace inde.Pages
{
    public class ContactModel : PageModel
    {
        private readonly ILogger<ContactModel> _logger;
        public bool hasData = false;
        public string firstName = "";
        public string lastName = "";
        public string message = "";

        public ContactModel(ILogger<ContactModel> logger)
        {
            _logger = logger;
        }


        public void OnPost()
        {
            hasData = true;
            firstName = Request.Form["firsName"];

            message = Request.Form["message"];


        }
        public void OnGet()
        {
        }
    }
}
