using System.Threading;
using System.Threading.Tasks;
using CCG.AspNetCore.Business.Interface;
using CCG.AspNetCore.Business.Validator;
using DataModel;
using FluentValidation;

namespace Business.Commands.Admin.JobCertificates
{
    public class DeleteJobCertificateByIdCommand : ICommand
    {
        public int Id { get; set; }
    }
    public class DeleteJobCertificateByIdCommandValidator : AbstractCommandValidator<DeleteJobCertificateByIdCommand>
    {
        public DeleteJobCertificateByIdCommandValidator(CctDbContext db)
        {
            RuleFor(e => e.Id)
                  .NotEmpty();
        }
    }
    public class DeleteJobCertificateByIdCommandHandler : ICommandHandler<DeleteJobCertificateByIdCommand>
    {
        private readonly CctDbContext _db;

        public DeleteJobCertificateByIdCommandHandler(CctDbContext db)
        {
            _db = db;
        }

        public async Task ExecuteAsync(DeleteJobCertificateByIdCommand command, CancellationToken cancellationToken = new CancellationToken())
        {
            var certificate = await _db.Certificates.FindAsync(command.Id);
            certificate.Active = 0;
            await _db.SaveChangesAsync(cancellationToken);
        }
    }
}
