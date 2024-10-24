using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PersonalPortfolio.Models; // Bytt ut "PersonalPortfolio" med navnet på ditt faktiske navnerom

namespace PersonalPortfolio.Pages // Bytt ut "PersonalPortfolio" med navnet på ditt faktiske navnerom
{
    public class Project1Model : PageModel
    {
        public required ProjectDetailModel Project { get; set; }

        public void OnGet()
        {
            // Fyller inn data i modellen ved å bruke konstruktøren
            Project = new ProjectDetailModel();
        }
    }
}