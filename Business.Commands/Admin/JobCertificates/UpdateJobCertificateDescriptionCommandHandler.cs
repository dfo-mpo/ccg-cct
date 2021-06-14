using CCG.AspNetCore.Business.Interface;
using CCG.AspNetCore.Business.Validator;
using DataModel;
using FluentValidation;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Business.Commands.Admin.JobCertificates
{
    public class UpdateJobCertificateDescriptionCommand : ICommand
    {
        public int Id { get; set; }
        public string DescEng { get; set; }
        public string DescFre { get; set; }
    }

    public class JobCertificateDescriptionCommandValidator : AbstractCommandValidator<UpdateJobCertificateDescriptionCommand>
    {
        public JobCertificateDescriptionCommandValidator(CctDbContext db)
        {
        }
    }
    public class JobCertificateDescriptionCommandHandler : ICommandHandler<UpdateJobCertificateDescriptionCommand>
    {
        private readonly CctDbContext _db;

        public JobCertificateDescriptionCommandHandler(CctDbContext db)
        {
            _db = db;
        }

        public async Task ExecuteAsync(UpdateJobCertificateDescriptionCommand command, CancellationToken cancellationToken = new CancellationToken())
        {
            var jobcertificatedesc = _db.CertificateDescriptions.First(e => e.Id == command.Id);
            jobcertificatedesc.DescEng = string.IsNullOrEmpty(command.DescEng) ? string.Empty : command.DescEng;
            jobcertificatedesc.DescFre = string.IsNullOrEmpty(command.DescFre) ? string.Empty : command.DescFre;
            await _db.SaveChangesAsync(cancellationToken);
        }
    }
}
