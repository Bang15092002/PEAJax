using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BussinessObject.DataContext;
using BussinessObject.Model;

namespace MVC.Controllers
{
    public class StudentsController : Controller
    {
        

        public StudentsController()
        {

        }

        // GET: Students
        public async Task<IActionResult> Index()
        {
            return View();
        }

        // GET: Students/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            return View();
        }

        // GET: Students/Create
        public IActionResult Create()
        {
            return View();
        }

        // GET: Students/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {  
            return View();
        }
    }
}
