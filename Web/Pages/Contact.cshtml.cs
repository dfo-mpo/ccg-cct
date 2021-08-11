using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net;
using System.Net.Mail;
using System.ComponentModel.DataAnnotations;

namespace Web.Pages
{
    public class ContactFormModel
    {
        public string Cert { get; set; }
        public string CertNo { get; set; }
        public string CompListing { get; set; }
        public string CompListNo { get; set; }
        public string CompRemove { get; set; }
        public string CompAdd { get; set; }
        public string CompDefinition { get; set; }
        public string CompDefinitionNo { get; set; }
        public string CompDefinitionChange { get; set; }
        public string CompRating { get; set; }
        public string CompRatingNo { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }


    }
    public class ContactModel : PageModel
    { 
    [BindProperty]
        public ContactFormModel Contact { get; set; }

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        // create and send the mail here

        var mailbody = $@"New feedback from the CCT website:

            Name: {Contact.Name}
            Email: {Contact.Email}
            
            1. In your review of a given position’s competency profile in the CCT, were the certifications correct? (i.e. the right certifications listed overall for a position).: 
                {Contact.Cert}
               
                If no, what needs correction?  
                {Contact.CertNo}
            
            2. In your review of a given position’s competency profile in the CCT, were the competencies listed appropriate? (i.e. the right Knowledge, Technical, Behavioural competencies overall for a position). 
                {Contact.CompListing}

               If no:  
               {Contact.CompListNo}
                
               Which one/s should be removed?: 
               {Contact.CompRemove}

               Which one/s should be added?: 
               {Contact.CompAdd}

            3. In your review of a given position’s competency profile in the CCT, were the listed competency definitions written correctly? (i.e. the written Knowledge, Technical, Behavioural overall definitions, and the written level descriptions).
               {Contact.CompDefinition}

               If no, which ones?
               {Contact.CompDefinitionNo}

            4. If you listed competencies with definitions you think should be changed, please elaborate with your wording change recommendations, and why.
               {Contact.CompDefinitionChange}

            5. In your review of a given position competency profile in the CCT, were the listed competency definitions rated correctly? (i.e. the scores of 1-5).
               {Contact.CompRating}

               If no, which ones, and why?
               {Contact.CompRatingNo}
                
            ";

        SendMail(mailbody);
        return RedirectToPage("Sent");

    }
    private void SendMail(string mailbody)
    {
        using (var message = new MailMessage(Contact.Email, "DFO.CCG.ForceGen-GCC.GenPersonnel.MPO@dfo-mpo.gc.ca"))
        {
            message.From = new MailAddress(Contact.Email);
            message.Subject = "New feedback from the CCT website";
            message.Body = mailbody;

            using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
            {
                smtp.Credentials = new NetworkCredential("DFO.CCG.ForceGen-GCC.GenPersonnel.MPO@dfo-mpo.gc.ca", "password");
                smtp.EnableSsl = true;
                smtp.Send(message);
            }
        }
    }
    public void OnGet()
    {
    }
}
}
