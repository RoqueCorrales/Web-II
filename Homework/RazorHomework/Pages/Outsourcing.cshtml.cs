using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorHomework.Pages
{
    public class OutsourcingModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "El outsourcing, en otras palabras, consiste en movilizar recursos hacia una empresa externa a través de un contrato. De esta forma, la compañía subcontratada desarrolla actividades en nombre de la primera.";
        }
    }
}
