﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using DataModel;
using Admin.Data;

namespace Admin.Pages.Certificates
{
    public class DeleteModel : PageModel
    {
        private readonly DataModel.CctDbContext _context;
        private readonly ILogger<DeleteModel> _logger;
        private readonly JobCertificateService _jobCertificateService;

        public DeleteModel(DataModel.CctDbContext context,
            ILogger<DeleteModel> logger, JobCertificateService jobCertificateService)
        {
            _context = context;
            _logger = logger;
            _jobCertificateService = jobCertificateService;
        }

        [BindProperty]
        public Certificate Certificate { get; set; }
        public string ErrorMessage { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id, bool? saveChangesError = false)
        {
            if (id == null)
            {
                return NotFound();
            }

            Certificate = await _context.Certificates
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.Id == id);

            if (Certificate == null)
            {
                return NotFound();
            }
            if (saveChangesError.GetValueOrDefault())
            {
                ErrorMessage = String.Format("Delete {ID} failed. Try again", id);
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Certificate = await _context.Certificates.FindAsync(id);

            if (Certificate == null)
            {
                return NotFound();
            }

            try
            {
                // _context.Certificates.Remove(Certificate);
                _jobCertificateService.DeleteJobCertificate(Certificate);
                //await _context.SaveChangesAsync(); 
                return RedirectToPage("./Index");
            }
            catch (DbUpdateException ex)
            {
                _logger.LogError(ex, ErrorMessage);

                return RedirectToAction("./Delete",
                                     new { id, saveChangesError = true });
            }
        }
    }
}
