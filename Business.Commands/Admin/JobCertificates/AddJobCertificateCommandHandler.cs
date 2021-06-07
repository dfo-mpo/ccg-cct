using CCG.AspNetCore.Business.Interface;
using CCG.AspNetCore.Business.Validator;
using DataModel;
using FluentValidation;
using System.Threading;
using System.Threading.Tasks;

namespace Business.Commands.Admin.JobCertificates
{
    public class AddJobCertificateCommand : ICommand
    {
        public string NameEng { get; set; }
        public string NameFre { get; set; }
        public string DescEng { get; set; }
        public string DescFre { get; set; }
    }

    public class AddJobCertificateCommandValidator : AbstractCommandValidator<AddJobCertificateCommand>
    {
        public AddJobCertificateCommandValidator(CctDbContext db)
        {
            RuleFor(e => e.DescEng)
                .MaximumLength(250);

            RuleFor(e => e.DescFre)
                .MaximumLength(255);
        }
    }
    public class AddJobCompetencyCommandHandler : ICommandHandler<AddJobCertificateCommand>
    {
        private readonly CctDbContext _db;

        public AddJobCompetencyCommandHandler(CctDbContext db)
        {
            _db = db;
        }

        public async Task ExecuteAsync(AddJobCertificateCommand command, CancellationToken cancellationToken = new CancellationToken())
        {
            await _db.Certificates.AddAsync(new Certificate()
            {
                NameEng = command.NameEng,
                NameFre = command.NameFre,
                DescEng = command.DescEng,
                DescFre = command.DescFre,
                Active = 1
            }, cancellationToken);
            await _db.SaveChangesAsync(cancellationToken);
        }

    }
}

