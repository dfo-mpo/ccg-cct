using CCG.AspNetCore.Business.Interface;
using CCG.AspNetCore.Business.Validator;
using DataModel;
using FluentValidation;
using System.Threading;
using System.Threading.Tasks;

namespace Business.Commands.Admin.JobCertificates
{
    public class AddJobCertificateDescriptionCommand : IQuery<int>
    {
        public string DescEng { get; set; }
        public string DescFre { get; set; }
    }

    public class AddJobCertificateDescriptionCommandHandler : IQueryHandler<AddJobCertificateDescriptionCommand, int>
    {
        private readonly CctDbContext _db;

        public AddJobCertificateDescriptionCommandHandler(CctDbContext db)
        {
            _db = db;
        }

        public async Task<int> HandleAsync(AddJobCertificateDescriptionCommand command, CancellationToken cancellationToken = new CancellationToken())
        {
            var newCertificateDescription = new CertificateDescription()
            {
                DescEng = command.DescEng,
                DescFre = command.DescFre
            };
            await _db.CertificateDescriptions.AddAsync(newCertificateDescription, cancellationToken);
            await _db.SaveChangesAsync(cancellationToken);
            return newCertificateDescription.Id;
        }

    }
}
