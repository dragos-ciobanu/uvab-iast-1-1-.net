using Microsoft.AspNetCore.Mvc;
using System;

/// <summary>
/// Summary description for Class1
/// </summary>
namespace ComicBookGallery.Controllers
{
	public class ComicBookController : Controller
	{
		public ActionResult Detail()
        {
            ViewBag.SeriesTitle = "The Amazing Spider-Man";
            ViewBag.IssueNumber = 700;
            ViewBag.Dscription = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>";
            ViewBag.Artists = new string[]
            {
                "Script: Dan Slott",
                "Pencils: Humberto Ramos",
                "Inks: Victor Olazaba",
                "Colors: Edgar Delgado",
                "Letters: Chris Eliopoulos"
            };

            return View();
        }

	}
}