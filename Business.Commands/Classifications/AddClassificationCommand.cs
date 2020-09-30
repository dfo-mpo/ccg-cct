using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CCG.AspNetCore.Business.Interface;
using CCG.AspNetCore.Business.Validator;
using DataModel;
using DataModel.Lookup;
using FluentValidation;
using Microsoft.EntityFrameworkCore.Internal;

namespace Business.Commands.Classifications
{
    public class AddClassificationCommand : ICommand
    {
        public string Id { get; set; }
        public string Code { get; set; }
        public string DescEng { get; set; }
        public string DescFre { get; set; }
    }

    public class AddClassificationCommandValidator : AbstractCommandValidator<AddClassificationCommand>
    {
        public AddClassificationCommandValidator(ExampleDbContext db)
        {
            RuleFor(e => e.Code)
                .NotEmpty()
                .Must(e => !db.Classifications.Any(c => c.Code == e)).WithLocalizedStringMessage(typeof(Core.Resources.Validation), "CodeAlreadyExists")
                ;

            RuleFor(e => e.DescEng)
                .MaximumLength(250);

            RuleFor(e => e.DescFre)
                .MaximumLength(255);



        }
    }
    public class AddClassificationCommandHandler : ICommandHandler<AddClassificationCommand>
    {
        private readonly ExampleDbContext _db;

        public AddClassificationCommandHandler(ExampleDbContext db)
        {
            _db = db;
        }

        public async Task ExecuteAsync(AddClassificationCommand command, CancellationToken cancellationToken = new CancellationToken())
        {
            await _db.Classifications.AddAsync(new Classification()
            {
                Code = command.Code,
                DescEng = command.DescEng,
                DescFre = command.DescFre
            }, cancellationToken);
            await _db.SaveChangesAsync(cancellationToken);
        }

    }
}