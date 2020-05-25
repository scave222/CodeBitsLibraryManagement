using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using CodeBitsLibraryManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodeBitsLibraryManagement.Controllers
{
    public class AuthorController : Controller
    {
        public IActionResult AuthorsList()
        {
            List<Author> AuthorList = new List<Author>()
            {
                new Author() {Au_ID = 1, Au_Name = "Michael", Sex = "Male", Phone = "0904-678-6786", Address = "3 Bolu street", City = "Ota", State = "Ogun"},
                new Author() {Au_ID = 2, Au_Name = "Shakau", Sex = "Female", Phone = "0903-874-8721", Address = "8 Schoba Close", City = "Ikeja", State = "Lagos"},
                new Author() {Au_ID = 3, Au_Name = "Segun", Sex = "Male", Phone = "0804-652-8319", Address = "39 Casso street", City = "Alagbado", State = "Lagos"},
                new Author() {Au_ID = 4, Au_Name = "Naresh", Sex = "Female", Phone = "0703-931-0941", Address = "73 Iyana street", City = "Ibadan", State = "Oyo"},
                new Author() {Au_ID = 5, Au_Name = "Smith", Sex = "Male", Phone = "0904-078-9642", Address = "47 lolu street", City = "Benin", State = "Edo"}
            };
            return View(AuthorList);
        }

        public ViewResult Create()
        {
            Author author = new Author
            {
                AllState = Enum.GetValues(typeof(State)).Cast<State>().ToList()
            };
            return View(author);
        }
    }
}