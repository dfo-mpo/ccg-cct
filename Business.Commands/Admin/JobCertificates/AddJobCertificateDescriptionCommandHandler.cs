using CCG.AspNetCore.Business.Interface;
using CCG.AspNetCore.Business.Validator;
using DataModel;
using FluentValidation;
using System.Threading;
using System.Threading.Tasks;

namespace Business.Commands.Admin.JobCertificates
{
    public class AddJobCertificateDescriptionCommand : ICommand
    {
        public string DescEng { get; set; }
        public string DescFre { get; set; }
    }

    public class AddJobCertificateDescriptionCommandValidator : AbstractCommandValidator<AddJobCertificateDescriptionCommand>
    {
        public AddJobCertificateDescriptionCommandValidator(CctDbContext db)
        {
            RuleFor(e => e.DescEng)
                .MaximumLength(250);

            RuleFor(e => e.DescFre)
                .MaximumLength(255);
        }
    }
    public class AddJobCertificateDescriptionCommandHandler : ICommandHandler<AddJobCertificateDescriptionCommand>
    {
        private readonly CctDbContext _db;

        public AddJobCertificateDescriptionCommandHandler(CctDbContext db)
        {
            _db = db;
        }

        public async Task ExecuteAsync(AddJobCertificateDescriptionCommand command, CancellationToken cancellationToken = new CancellationToken())
        {
            await _db.CertificateDescriptions.AddAsync(new CertificateDescription()
            {
                DescEng = command.DescEng,
                DescFre = command.DescFre
            }, cancellationToken);
            await _db.SaveChangesAsync(cancellationToken);
        }

    }
}
