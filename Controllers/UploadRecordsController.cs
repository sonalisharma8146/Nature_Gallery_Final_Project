using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Nature_Gallery_Final_Project.Models;

namespace Nature_Gallery_Final_Project.Controllers
{


    //Displays the detais of uploaded records and all uploaded image records 
    //Publishers can inly see their uploaded images.
    public class UploadRecordsController : Controller
    {
        private readonly Nature_Gallery_DataContext _context;

        SignInManager<IdentityUser> SignInManager;

        public UploadRecordsController(Nature_Gallery_DataContext context,


             SignInManager<IdentityUser> SignInManager
            
            
            )
        {

            this.SignInManager = SignInManager;
            _context = context;
        }

        // GET: UploadRecords
        public async Task<IActionResult> Index()
        {

            if (SignInManager.IsSignedIn(User) && User.IsInRole("publisher_user")) {

                var galleryImages= _context.UploadRecord.Include(u => u.Image).
                    Include(u => u.Publisher).Where(u=> u.Publisher.EmailAddresss.Equals(User.Identity.Name));
                return View(await galleryImages.ToListAsync());
            }

            var nature_Gallery_DataContext = _context.UploadRecord.Include(u => u.Image).Include(u => u.Publisher);
            return View(await nature_Gallery_DataContext.ToListAsync());
        }

        // GET: UploadRecords/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var uploadRecord = await _context.UploadRecord
                .Include(u => u.Image)
                .Include(u => u.Publisher)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (uploadRecord == null)
            {
                return NotFound();
            }

            return View(uploadRecord);
        }

    }
}