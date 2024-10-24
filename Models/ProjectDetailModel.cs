using System;
using System.ComponentModel.DataAnnotations;

namespace PersonalPortfolio.Models // Bytt ut "PersonalPortfolio" med navnet på ditt faktiske navnerom
{
    public class ProjectDetailModel
    {
        [Required(ErrorMessage = "Project name is required.")]
        public string Name { get; set; } // Navnet på prosjektet

        [Required(ErrorMessage = "Description is required.")]
        [StringLength(500, ErrorMessage = "Description cannot be longer than 500 characters.")]
        public string Description { get; set; } // Beskrivelse av prosjektet

        [Url(ErrorMessage = "Invalid URL format.")]
        public string ImageUrl { get; set; } // URL til bilde av prosjektet

        [Url(ErrorMessage = "Invalid URL format.")]
        public string LiveUrl { get; set; } // URL til live-versjonen av prosjektet

        [Url(ErrorMessage = "Invalid URL format.")]
        public string GitHubUrl { get; set; } // URL til GitHub-repoet

        // Tilleggsfelt
        public string TechnologiesUsed { get; set; } // Teknologier som er brukt i prosjektet

        [DataType(DataType.Date)]
        public DateTime CompletionDate { get; set; } // Fullføringsdato for prosjektet

        // Konstruktør for å fylle ut standardverdier
        public ProjectDetailModel()
        {
            Name = "Example Project";
            Description = "This is a sample project demonstrating the use of ASP.NET Core and Tailwind CSS.";
            ImageUrl = "https://example.com/image.png"; // Fiktiv URL
            LiveUrl = "https://example.com/live"; // Fiktiv URL til live prosjekt
            GitHubUrl = "https://github.com/example/example-project"; // Fiktiv GitHub URL
            TechnologiesUsed = "ASP.NET Core, Tailwind CSS, JavaScript"; // Teknologier brukt
            CompletionDate = new DateTime(2023, 9, 30); // Fullføringsdato
        }
    }
}