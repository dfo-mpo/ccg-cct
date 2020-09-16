using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Commands.Classifications;
using DataModel;
using DataModel.Lookup;
using DataModel.Tests;
using FluentValidation.Results;
using Microsoft.EntityFrameworkCore;
using Xunit;
using Xunit.Extensions.AssertExtensions;

namespace Business.Queries.Tests.Classifications
{
    public class UpdateClassificationCommandTests : IDisposable
    {
        private readonly DbHelper<ExampleDbContext> _dbHelper;

        public void Dispose()
        {
        }

        public UpdateClassificationCommandTests()
        {
            _dbHelper = new DbHelper<ExampleDbContext>().RunMigrations();
        }

        [Fact]
        public async Task ValidatorShouldCheckCodeAgainstOtherEntries()
        {
            var entity = new Classification()
            {
                Id = Guid.NewGuid(),
                Code = Guid.NewGuid().ToString(),
            };
            var entity2 = new Classification()
            {
                Id = Guid.NewGuid(),
                Code = Guid.NewGuid().ToString(),
            };

            // setup data
            using (var db = _dbHelper.GetDbContext())
            {
                db.Classifications.RemoveRange(db.Classifications);
                await db.Classifications.AddAsync(entity);
                await db.Classifications.AddAsync(entity2);
                await db.SaveChangesAsync();
            }

            // run operation
            using (var db = _dbHelper.GetDbContext())
            {
                var validator = new UpdateClassificationCommandValidator(db);;

                var command = new UpdateClassificationCommand()
                {
                    Id = entity.Id,
                    Code = entity2.Code,
                };
                var result = await validator.ValidateAsync(command);

                // check result
                result.IsValid.ShouldBeFalse();
                result.Errors.Count.ShouldEqual(1);
                result.Errors.First().PropertyName.ShouldEqual(nameof(command.Code));

            }

        }

        [Fact]
        public async Task Validator_ShouldFail_CodeEmpty()
        {
            var entity = new Classification()
            {
                Id = Guid.NewGuid(),
                Code = Guid.NewGuid().ToString(),
            };

            // setup data
            using (var db = _dbHelper.GetDbContext())
            {
                db.Classifications.RemoveRange(db.Classifications);
                await db.Classifications.AddAsync(entity);
                await db.SaveChangesAsync();
            }

            // run operation
            using (var db = _dbHelper.GetDbContext())
            {
                var validator = new UpdateClassificationCommandValidator(db);;

                var command = new UpdateClassificationCommand()
                {
                    Id = entity.Id,
                    Code = ""
                };
                var result = await validator.ValidateAsync(command);

                // check result
                result.IsValid.ShouldBeFalse();
                result.Errors.Count.ShouldEqual(1);
                result.Errors.First().PropertyName.ShouldEqual(nameof(command.Code));

            }

        }

        [Fact]
        public async Task Validator_ShouldFail_NoIdFound()
        {


            // run operation
            using (var db = _dbHelper.GetDbContext())
            {
                var validator = new UpdateClassificationCommandValidator(db);;

                var command = new UpdateClassificationCommand()
                {
                    Id = Guid.NewGuid(),
                    Code = Guid.NewGuid()+""
                };
                var result = await validator.ValidateAsync(command);

                // check result
                result.IsValid.ShouldBeFalse();
                result.Errors.Count.ShouldEqual(1);
                result.Errors.First().PropertyName.ShouldEqual(nameof(command.Id));

            }

        }

        [Fact]
        public async Task Validator_ShouldFail_DescLengthTooLong()
        {
            var entity = new Classification()
            {
                Id = Guid.NewGuid(),
                Code = Guid.NewGuid().ToString(),
            };

            var descTooLong = "";
            for (var i = 0; i < 300; i++) descTooLong += "-";
            // setup data
            using (var db = _dbHelper.GetDbContext())
            {
                db.Classifications.RemoveRange(db.Classifications);
                await db.Classifications.AddAsync(entity);
                await db.SaveChangesAsync();
            }

            // run operation
            using (var db = _dbHelper.GetDbContext())
            {
                var validator = new UpdateClassificationCommandValidator(db);;

                var command = new UpdateClassificationCommand()
                {
                    Id = entity.Id,
                    Code = entity.Code,
                    DescEng = descTooLong
                };
                var result = await validator.ValidateAsync(command);

                // check result
                result.IsValid.ShouldBeFalse();
                result.Errors.Count.ShouldEqual(1);
                result.Errors.First().PropertyName.ShouldEqual(nameof(command.DescEng));

            }

        }
        [Fact]
        public async Task Validator_ShouldPass_GoodData()
        {
            var entity = new Classification()
            {
                Id = Guid.NewGuid(),
                Code = Guid.NewGuid().ToString(),
            };

            // setup data
            using (var db = _dbHelper.GetDbContext())
            {
                db.Classifications.RemoveRange(db.Classifications);
                await db.Classifications.AddAsync(entity);
                await db.SaveChangesAsync();
            }

            // run operation
            using (var db = _dbHelper.GetDbContext())
            {
                var validator = new UpdateClassificationCommandValidator(db);

                var command = new UpdateClassificationCommand()
                {
                    Id = entity.Id,
                    Code = entity.Code+"Updated"
                };
                
                // check result
                var result = await validator.ValidateAsync(command);
                result.IsValid.ShouldBeTrue();
            }
        }

        [Fact]
        public async Task Command_ShouldPass_GoodData()
        {
            var entity = new Classification()
            {
                Id = Guid.NewGuid(),
                Code = Guid.NewGuid().ToString(),
            };

            // setup data
            using (var db = _dbHelper.GetDbContext())
            {
                db.Classifications.RemoveRange(db.Classifications);
                await db.Classifications.AddAsync(entity);
                await db.SaveChangesAsync();
            }

            // run operation
            using (var db = _dbHelper.GetDbContext())
            {
                var handler = new UpdateClassificationCommandHandler(db);

                var command = new UpdateClassificationCommand()
                {
                    Id = entity.Id,
                    Code = entity.Code+"Updated"
                };
                await handler.ExecuteAsync(command);
            }

            // check result
            using (var db = _dbHelper.GetDbContext())
            {
                db.Classifications.ShouldNotBeEmpty(); 
                (await db.Classifications.CountAsync()).ShouldEqual(1);
                (await db.Classifications.SingleAsync()).Code.ShouldEndWith("Updated");
            }
        }
    }
}
