using CCG.AspNetCore.Business.Interface;
using CCG.AspNetCore.Business.Validator;
using DataModel;
using FluentValidation;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Business.Commands.Admin.JobCertificates
{
    public class UpdateJobCertificateCommand : ICommand
    {
        public int Id { get; set; }
        public string NameEng { get; set; }
        public string NameFre { get; set; }
        public string DescEng { get; set; }
        public string DescFre { get; set; }
    }

    public class JobCertificateCommandValidator : AbstractCommandValidator<UpdateJobCertificateCommand>
    {
        public JobCertificateCommandValidator(CctDbContext db)
        {
            RuleFor(e => e.Id)
                .NotEmpty();
            RuleFor(e => e.NameEng)
                .MaximumLength(1000);
            RuleFor(e => e.NameFre)
                .MaximumLength(1000);
            RuleFor(e => e.DescEng)
                .MaximumLength(1000);
            RuleFor(e => e.DescFre)
                .MaximumLength(1000);
        }
    }
    public class JobCertificateCommandHandler : ICommandHandler<UpdateJobCertificateCommand>
    {
        private readonly CctDbContext _db;

        public JobCertificateCommandHandler(CctDbContext db)
        {
            _db = db;
        }

        public async Task ExecuteAsync(UpdateJobCertificateCommand command, CancellationToken cancellationToken = new CancellationToken())
        {
            var jobcertificate = _db.Certificates.First(e => e.Id == command.Id);
            jobcertificate.NameEng = command.NameEng;
            jobcertificate.NameFre = command.NameFre;
            jobcertificate.DescEng = string.IsNullOrEmpty(command.DescEng) ? string.Empty : command.DescEng;
            jobcertificate.DescFre = string.IsNullOrEmpty(command.DescFre) ? string.Empty : command.DescFre;
            await _db.SaveChangesAsync(cancellationToken);
        }
    }
}