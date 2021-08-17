using BookLibraryApp.Models.Domain;

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibraryApp.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {


            //List<Book> books = new List<Book>
            //{
            //    new Book {ID = 01, Title = "Vanity Fair", Year = 1848, Authors = {thackeray}},
            //    new Book {ID = 02, Title = "The Mill on the Floss", Year = 1860, Authors = {elliot}},
            //    new Book {ID = 03, Title = "The Doll", Year = 1890, Authors = { prus }}
            //};



            return View();


        }
        //[Route("BookLibraryApp/[BooksDetails]")]
        public IActionResult BooksDetails()
        {
            
            // =========== Book 01 ===========

            Author thackeray = new Author()
            {
                ID = 01,
                FirstName = "William",
                LastName = "Thackeray"
            };

            Book book01 = new Book()
            {
                ID = 01,
                Title = "Vanity Fair",
                Year = 1848,
                Authors = { thackeray }

            };

            // =========== Book 02 ===========

            Author elliot = new Author()
            {
                ID = 02,
                FirstName = "George",
                LastName = "Elliot"
            };

            Book book02 = new Book()
            {
                ID = 02,
                Title = "The Mill on the Floss",
                Year = 1860,
                Authors = { elliot }

            };

            // =========== Book 03 ===========

            Author prus = new Author()
            {
                ID = 03,
                FirstName = "Boleslaw",
                LastName = "Prus"
            };

            Book book03 = new Book()
            {
                ID = 03,
                Title = "The Doll",
                Year = 1890,
                Authors = { prus }

            };

            ViewBag.ID = book01;
            ViewBag.Title = book01;
            ViewBag.Year = book01;
            ViewBag.Authors = thackeray;

            return View(book01);
            
        }

        public IActionResult EmptyResult()
        {
            return new EmptyResult();
        }

        public IActionResult BookPreview(int? ID)
        {
            if (ID.HasValue)
                return View(); 

            return RedirectToAction("BooksDetails", "Book"); 
        }

        public IActionResult JSONBook()
        {
            Author zweig = new Author { ID = 42, FirstName = "Stefan", LastName = "Zweig" };
            var nova_knjiga = new Book{ ID = 33, Title = "The World Of Yesterday", Year = 1942, Authors = { zweig } };
            return new JsonResult(nova_knjiga); 
        }
    }
}
