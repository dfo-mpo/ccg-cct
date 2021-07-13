using System.Threading;
using System.Threading.Tasks;
using CCG.AspNetCore.Business.Interface;
using CCG.AspNetCore.Business.Validator;
using DataModel;
using FluentValidation;

namespace Business.Commands.Admin.JobCertificates
{
    public class DeleteJobCertificateDescriptionByIdCommand : ICommand
    {
        public int Id { get; set; }
    }
    public class DeleteJobCertificateDescriptionByIdCommandValidator : AbstractCommandValidator<DeleteJobCertificateDescriptionByIdCommand>
    {
        public DeleteJobCertificateDescriptionByIdCommandValidator(CctDbContext db)
        {
            RuleFor(e => e.Id)
                  .NotEmpty();
        }
    }
    public class DeleteJobCertificateDescriptionByIdCommandHandler : ICommandHandler<DeleteJobCertificateDescriptionByIdCommand>
    {
        private readonly CctDbContext _db;

        public DeleteJobCertificateDescriptionByIdCommandHandler(CctDbContext db)
        {
            _db = db;
        }

        public async Task ExecuteAsync(DeleteJobCertificateDescriptionByIdCommand command, CancellationToken cancellationToken = new CancellationToken())
        {
            var certificate = await _db.CertificateDescriptions.FindAsync(command.Id);
            certificate.Active = 0;
            await _db.SaveChangesAsync(cancellationToken);
        }
    }
}
