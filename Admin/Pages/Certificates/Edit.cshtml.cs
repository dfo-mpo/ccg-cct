﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DataModel;
using Microsoft.Extensions.Logging;
using Admin.Data;
using System.Threading;

namespace Admin.Pages.Certificates
{
    public class EditModel : PageModel
    {
        private readonly DataModel.CctDbContext _context;
        private readonly ILogger<EditModel> _logger;
        private readonly JobCertificateService _jobCertificateService;


        public EditModel(DataModel.CctDbContext context,
            ILogger<EditModel> logger, JobCertificateService jobCertificateService)
        {
            _context = context;
            _logger = logger;
            _jobCertificateService = jobCertificateService;
        }

        [BindProperty]
        public Certificate Certificate { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Certificate = await _context.Certificates.FindAsync(id);

            if (Certificate == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync(int id)
        {
            var certificateToUpdate = await _context.Certificates.FindAsync(id);

            if (certificateToUpdate == null)
            {
                return NotFound();
            }

            if (await TryUpdateModelAsync<Certificate>(
                certificateToUpdate,
                "certificate",
                s => s.NameEng, s => s.NameFre, s => s.DescEng, s => s.DescFre))
            {
                _jobCertificateService.UpdateJobCertificate(Certificate);
                Thread.MemoryBarrier();
                return RedirectToPage("Details", new { id });
            }

            return Page();
        }
    }
}

