using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Nature_Gallery_Final_Project.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace Nature_Gallery_Final_Project.Controllers
{

    //Responsibele for managing images permitted only to publiher and admin
    [Authorize(Roles="publisher_user,admin_user")]
    public class ImagesController : Controller
    {
        private readonly Nature_Gallery_DataContext _context;

        SignInManager<IdentityUser> SignInManager;
      

        public ImagesController(Nature_Gallery_DataContext context,
             SignInManager<IdentityUser> SignInManager,
        UserManager<IdentityUser> UserManager
            
            
            )
        {
            this.SignInManager = SignInManager;
         
            _context = context;
        }

        // GET: Images
        public async Task<IActionResult> Index()
        {

            

            return View(await _context.Image.ToListAsync());
        }

        // GET: Images/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var image = await _context.Image
                .FirstOrDefaultAsync(m => m.Id == id);
            if (image == null)
            {
                return NotFound();
            }

            return View(image);
        }

        // GET: Images/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Images/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Heading,Description,File")] Image image)
        {
            if (ModelState.IsValid)
            {
                if (SignInManager.IsSignedIn(User))
                {

                    UplaodToGallery(image);
                    _context.Add(image);
                    await _context.SaveChangesAsync();

                    var publisher = (from publishers in _context.Publisher

                                     where publishers.EmailAddresss.Equals(User.Identity.Name)
                                     select publishers).FirstOrDefault();

                    UploadRecord record = new UploadRecord();

                    record.ImageId = image.Id;
                    record.PublisherId = publisher.Id;
                    record.UploadTime = DateTime.Now;

                    _context.Add(record);
                    await _context.SaveChangesAsync();

                    return RedirectToAction(nameof(Index),"UploadRecords" );
                }
            }
            return View(image);
        }

        // GET: Images/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }



            var image = await _context.Image.FindAsync(id);
            if (image == null)
            {
                return NotFound();
            }
            return View(image);
        }

        // POST: Images/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Heading,Description,File")] Image image)
        {
            if (id != image.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    UplaodToGallery(image);
                    _context.Update(image);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ImageExists(image.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index), "UploadRecords");
            }
            return View(image);
        }

        // GET: Images/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var image = await _context.Image
                .FirstOrDefaultAsync(m => m.Id == id);
            if (image == null)
            {
                return NotFound();
            }

            return View(image);
        }

        // POST: Images/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var image = await _context.Image.FindAsync(id);
            _context.Image.Remove(image);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index), "UploadRecords");
        }

        private bool ImageExists(int id)
        {
            return _context.Image.Any(e => e.Id == id);
        }



        private void UplaodToGallery(Image Image)
        {

            if (Image.File != null)
            {
                Image.ImageUrl = Image.File.FileName;

                var uploadPath = "./wwwroot/pics/" + Image.File.FileName;


                if (Image.File.Length > 0)
                {
                    using (var stream = new FileStream(uploadPath, FileMode.Create))
                    {
                        Image.File.CopyTo(stream);
                    }
                }
            }


        }

    }
}
