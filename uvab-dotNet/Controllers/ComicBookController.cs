using Microsoft.AspNetCore.Mvc;
using System;
using uvab_dotNet.Models;
using uvab_dotNet.Data;

/// <summary>
/// Summary description for Class1
/// </summary>
namespace uvab_dotNet.Controllers
{
    public class ComicBooksController : Controller
    {
        private ComicBookRepository _comicBookRepository = null;

        public ComicBooksController()
        {
            _comicBookRepository = new ComicBookRepository();
        }

        public ActionResult Index()
        {
            var comicBooks = _comicBookRepository.GetComicBooks();

            return View(comicBooks);
        }

        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return StatusCode(404);
            }

            var comicBook = _comicBookRepository.GetComicBook((int)id);

            return View(comicBook);
        }
    }
}