using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CodeBitsLibraryManagement.Models;

namespace CodeBitsLibraryManagement.Controllers
{
    public class PublisherController : Controller
    {
        public IActionResult PublisherLists()
        {
            List<Publisher> PublisherList = new List<Publisher>()
            {
                new Publisher() {Pub_ID = 1, Pub_Name = "Mathew", Phone = "0702-692-8219", Address = "21 Falana street", City = "Enugu", State = "Enugu", Country = "Nigeria"},
                new Publisher() {Pub_ID = 2, Pub_Name = "Mark", Phone = "0803-562-1219", Address = "56 joge street", City = "Kano", State = "Kano", Country = "Nigeria"},
                new Publisher() {Pub_ID = 3, Pub_Name = "Lukeman", Phone = "0502-298-8125", Address = "13 Bclose street", City = "Lokoja", State = "Kogi", Country = "Nigeria"},
                new Publisher() {Pub_ID = 4, Pub_Name = "John", Phone = "0705-712-1679", Address = "28 Owode Estate", City = "Ibadan", State = "Oyo", Country = "Nigeria"},
                new Publisher() {Pub_ID = 5, Pub_Name = "Paul", Phone = "0703-984-1258", Address = "92 Donald street", City = "Owere", State = "Imo", Country = "Nigeria"}
            };
            return View(PublisherList);
        }

        public ViewResult Create()
        {
            Publisher publisher = new Publisher
            {
                AllState = Enum.GetValues(typeof(State)).Cast<State>().ToList(),
            };

            
            return View(publisher);
        }

    }
}