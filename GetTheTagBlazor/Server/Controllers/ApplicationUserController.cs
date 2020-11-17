using GetTheTagBlazor.Server.Data;
using GetTheTagBlazor.Server.Models;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace GetTheTagBlazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationUserController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ApplicationDbContext _context;

        public ApplicationUserController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, ApplicationDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
        }

        [HttpGet("{name}")]
        public async Task<ApplicationUser> GetApplicationUser(string name)
        {
            var appUser = new ApplicationUser();
            if (name != null)
            {
                appUser = await _context.ApplicationUsers.Where(x => x.Email == name).FirstOrDefaultAsync();
            }
            return appUser;
        }

        [HttpGet]
        public async Task<List<ApplicationUser>> GetApplicationUsers()
        {
            var appUsersFromDb = await _context.ApplicationUsers.ToListAsync();
            return appUsersFromDb;
        }

        //// GET: ApplicationUserController
        //public ActionResult Index()
        //{
        //    return View();
        //}

        //// GET: ApplicationUserController/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: ApplicationUserController/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: ApplicationUserController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: ApplicationUserController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: ApplicationUserController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: ApplicationUserController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: ApplicationUserController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
