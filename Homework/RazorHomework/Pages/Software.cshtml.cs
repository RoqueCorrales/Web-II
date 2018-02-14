using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorHomework.Pages
{
    public class SoftwareModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "Software development is the process of conceiving, specifying, designing, programming, documenting, testing, and bug fixing involved in creating and maintaining applications, frameworks, or other software components.";
        }
    }
}
