using CCG.AspNetCore.Business.Interface;
using DataModel;
using FluentValidation;
using System.Threading;
using System.Threading.Tasks;

namespace Business.Commands.Admin.JobCertificates
{
    public class AddJobCertificateCommand : IQuery<int>
    {
        public string NameEng { get; set; }
        public string NameFre { get; set; }
        public string DescEng { get; set; }
        public string DescFre { get; set; }
    }

    public class AddJobCompetencyCommandHandler : IQueryHandler<AddJobCertificateCommand, int>
    {
        private readonly CctDbContext _db;

        public AddJobCompetencyCommandHandler(CctDbContext db)
        {
            _db = db;
        }

        public async Task<int> HandleAsync(AddJobCertificateCommand command, CancellationToken cancellationToken = new CancellationToken())
        {
            var newCertificate = new Certificate()
            {
                NameEng = command.NameEng,
                NameFre = command.NameFre,
                DescEng = command.DescEng,
                DescFre = command.DescFre,
                Active = 1
            };
            await _db.Certificates.AddAsync(newCertificate, cancellationToken);
            await _db.SaveChangesAsync(cancellationToken);
            return newCertificate.Id;

        }

    }
}

