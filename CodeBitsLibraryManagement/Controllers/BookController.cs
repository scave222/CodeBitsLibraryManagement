using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CodeBitsLibraryManagement.Models;

namespace CodeBitsLibraryManagement.Controllers
{
    public class BookController : Controller
    {
        public IActionResult BookLists()
        {
            List<Book> BookList = new List<Book>()
            {
                new Book() {Book_ID = 1, Book_Name = "The black boy", Price = 400.00M, Au_ID = 1, Pub_ID = 1, Dt_Of_Publish = "1/3/2018"},
                new Book() {Book_ID = 2, Book_Name = "Eze goes to school", Price = 250.00M, Au_ID = 2, Pub_ID = 2, Dt_Of_Publish = "11/8/2009"},
                new Book() {Book_ID = 3, Book_Name = "One door away from heaven", Price = 650.00M, Au_ID = 3, Pub_ID = 3, Dt_Of_Publish = "15/6/2012"},
                new Book() {Book_ID = 4, Book_Name = "Pepeye and the mango", Price = 200.00M, Au_ID = 4, Pub_ID = 4, Dt_Of_Publish = "8/8/2010"},
                new Book() {Book_ID = 5, Book_Name = "The lost boy", Price = 1000.00M, Au_ID = 5, Pub_ID = 5, Dt_Of_Publish = "5/2/2019"},
            };
            return View(BookList);
        }

        public ViewResult Create()
        {
            
            return View();
        }
    }
}