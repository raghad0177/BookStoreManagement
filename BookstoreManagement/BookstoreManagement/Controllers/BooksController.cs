using BookstoreManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookstoreManagement.Controllers
{
    public class BooksController : Controller
    {
        private readonly BookStoreDbContext _context;
        public BooksController(BookStoreDbContext context)
        {
            _context = context;
        }      
        [HttpPost]
        public IActionResult Create(Book book)
        {
            var result = new Book
            {
                BookId = book.BookId,
                Title = book.Title,
                Author = book.Author,
                Genre = book.Genre,
                Price = book.Price
            };
            _context.Book.Add(result);
            var sucsses = _context.SaveChanges();
            if (sucsses == 1)
            {
                return Content("Successfully Added!");
            }
            else
            {
                return Content("Not Added!");
            }
        }
        public IActionResult Create()
        {
            Book book = new Book();
            return View(book);
        }
        public IActionResult Index()
        {
            var allBooks = _context.Book.ToList();
            return View(allBooks);
        }
        [HttpPost]
        public IActionResult Remove(string Id)
        {
            var Book = _context.Book.FirstOrDefault(a => a.BookId == Id);
            _context.Book.Remove(Book);
            _context.SaveChanges();
            return Content("Successfully Deleted!");
        }
        public IActionResult Remove()
        {
            Book book = new Book();
            return View(book);
        }
        public IActionResult Details(string Id)
        {
            var Book = _context.Book.FirstOrDefault(a => a.BookId == Id);
            return View(Book);
        }
        [HttpPost]
        public IActionResult Edit(Book book)
        {
            var Book = _context.Book.FirstOrDefault(a => a.BookId == book.BookId);
            Book.Title = book.Title;
            Book.Price = book.Price;
            Book.Author = book.Author;
            Book.Genre = book.Genre;
            _context.Update(Book);
            _context.SaveChanges();
            return Content("Updated Successfully!");
        }
        public IActionResult Edit()
        {            
            return View();
        }
    }
}
