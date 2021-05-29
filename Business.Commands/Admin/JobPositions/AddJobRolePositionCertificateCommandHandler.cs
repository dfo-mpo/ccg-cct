using CCG.AspNetCore.Business.Interface;
using CCG.AspNetCore.Business.Validator;
using DataModel;
using FluentValidation;
using System.Threading;
using System.Threading.Tasks;

namespace Business.Commands.Admin.JobPositions
{
    public class AddJobRolePositionCertificateCommand : ICommand
    {
        public int JobPositionId { get; set; }
        public int CertificateId { get; set; }
        public int JobGroupId { get; set; }
        public int JobGroupLevelId { get; set; }
        public int CertificateDescriptionId { get; set; }
    }

    public class AddJobRolePositionCertificateCommandValidator : AbstractCommandValidator<AddJobRolePositionCertificateCommand>
    {
        public AddJobRolePositionCertificateCommandValidator(CctDbContext db)
        {

        }
    }
    public class AddJobRolePositionCertificateCommandHandler : ICommandHandler<AddJobRolePositionCertificateCommand>
    {
        private readonly CctDbContext _db;

        public AddJobRolePositionCertificateCommandHandler(CctDbContext db)
        {
            _db = db;
        }

        public async Task ExecuteAsync(AddJobRolePositionCertificateCommand command, CancellationToken cancellationToken = new CancellationToken())
        {
            await _db.JobRolePositionCertificates.AddAsync(new JobRolePositionCertificate()
            {
                JobPositionId = command.JobPositionId,
                CertificateId = command.CertificateId,
                JobGroupId = command.JobGroupId,
                JobGroupLevelId = command.JobGroupLevelId,
                CertificateDescriptionId = command.CertificateDescriptionId
            }, cancellationToken);
            await _db.SaveChangesAsync(cancellationToken);
        }
    }
}
