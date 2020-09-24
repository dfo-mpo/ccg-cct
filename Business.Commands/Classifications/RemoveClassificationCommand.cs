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
    public class RemoveClassificationCommand : ICommand
    {
        public Guid Id { get; set; }

    }

    public class RemoveClassificationCommandValidator : AbstractCommandValidator<RemoveClassificationCommand>
    {
        public RemoveClassificationCommandValidator(ExampleDbContext db)
        {
            RuleFor(e => e.Id)
                .NotEmpty()
                .Must(e => !db.Classifications.Any(c => c.Id == e))
                ;
        }
    }
    public class RemoveClassificationCommandHandler : ICommandHandler<RemoveClassificationCommand>
    {
        private readonly ExampleDbContext _db;

        public RemoveClassificationCommandHandler(ExampleDbContext db)
        {
            _db = db;
        }

        public async Task ExecuteAsync(RemoveClassificationCommand command, CancellationToken cancellationToken = new CancellationToken())
        {
            var entity = new Classification() {Id = command.Id};
            _db.Classifications.Attach(entity);
            _db.Classifications.Remove(entity);
            await _db.SaveChangesAsync(cancellationToken);
        }

    }
}