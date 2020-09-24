using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CCG.AspNetCore.Business.Interface;
using CCG.AspNetCore.Business.Validator;
using DataModel;
using DataModel.Lookup;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace Business.Commands.Classifications
{
    public class UpdateClassificationCommand : ICommand
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string DescEng { get; set; }
        public string DescFre { get; set; }
    }

    public class UpdateClassificationCommandValidator : AbstractCommandValidator<UpdateClassificationCommand>
    {
        public UpdateClassificationCommandValidator(ExampleDbContext db)
        {
            RuleFor(e => e.Id)
                .NotEmpty()
                .Must(e => db.Classifications.Any(c => c.Id == e)).WithLocalizedStringMessage(typeof(Core.Resources.Validation), "NotFound")
                ;

            RuleFor(e => e.Code)
                .NotEmpty()
                .Must((command, c) => !db.Classifications.Any(cl => cl.Code == command.Code && cl.Id != command.Id)).WithLocalizedStringMessage(typeof(Core.Resources.Validation), "CodeAlreadyExists")
                ;

            RuleFor(e => e.DescEng)
                .MaximumLength(250);

            RuleFor(e => e.DescFre)
                .MaximumLength(255);



        }
    }
    public class UpdateClassificationCommandHandler : ICommandHandler<UpdateClassificationCommand>
    {
        private readonly ExampleDbContext _db;

        public UpdateClassificationCommandHandler(ExampleDbContext db)
        {
            _db = db;
        }

        public async Task ExecuteAsync(UpdateClassificationCommand command, CancellationToken cancellationToken = new CancellationToken())
        {
            var entity = await _db.Classifications.SingleAsync(e => e.Id == command.Id, cancellationToken);
            entity.Code = command.Code;
            entity.DescEng = command.DescEng;
            entity.DescFre = command.DescFre;
            await _db.SaveChangesAsync(cancellationToken);
        }

    }
}