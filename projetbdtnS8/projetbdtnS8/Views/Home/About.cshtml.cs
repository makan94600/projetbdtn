using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace projetbdtnS8.Views.Home
{
    public class AboutModel : PageModel
    {
        public string? hasData ;
        public string firstName="";
        public string lastName="";
        public string message="";
        public void OnGet()
        {
        }

        public void OnPost()
        {
            hasData = "qqc";
            firstName=Request.Form["firsName"];
           
            message = Request.Form["message"];
            

        }

    }

}


