using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DataModel.SeedData
{
    public partial class SeedDataHelper
    {
        public List<CertificateDescription> CertificateDescriptions = new List<CertificateDescription>()
            {
                new CertificateDescription { Id = 1, DescEng = "Lorem ipsum", DescFre ="Lorem Ipsum"},
                new CertificateDescription { Id = 2, DescEng = "Lorem ipsum", DescFre ="Lorem Ipsum"},
                new CertificateDescription { Id = 3, DescEng = "Lorem ipsum", DescFre ="Lorem Ipsum"},
                new CertificateDescription { Id = 4, DescEng = "Lorem ipsum", DescFre ="Lorem Ipsum"},
                new CertificateDescription { Id = 5, DescEng = "Lorem ipsum", DescFre ="Lorem Ipsum"},
                new CertificateDescription { Id = 6, DescEng = "Lorem ipsum", DescFre ="Lorem Ipsum"},
                new CertificateDescription { Id = 7, DescEng = "Lorem ipsum", DescFre ="Lorem Ipsum"},
                new CertificateDescription { Id = 8, DescEng = "Lorem ipsum", DescFre ="Lorem Ipsum"},
                new CertificateDescription { Id = 9, DescEng = "Lorem ipsum", DescFre ="Lorem Ipsum"},
                new CertificateDescription { Id = 10, DescEng = "Lorem ipsum", DescFre ="Lorem Ipsum"}
                
            };

        
    }
}