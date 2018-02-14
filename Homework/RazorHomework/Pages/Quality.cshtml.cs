using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorHomework.Pages
{
    public class QualityModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "El aseguramiento de la calidad (se usa con frecuencia el anglicismo quality assurance) es el conjunto de actividades planificadas y sistemáticas aplicadas en un sistema de gestión de la calidad para que los requisitos de calidad de un producto o servicio sean satisfechos. Entre estas actividades se encuentran la medición sistemática, la comparación con estándares, el seguimiento de los procesos, todas actividades asociadas con bucles de realimentación de información.";
        }
    }
}
