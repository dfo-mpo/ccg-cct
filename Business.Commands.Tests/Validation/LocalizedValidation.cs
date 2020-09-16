using System;
using System.Linq;
using CCG.AspNetCore.Business.Commands.Auth;
using CCG.AspNetCore.Business.Models;
using CCG.AspNetCore.Business.Validator;
using DataModel;
using DataModel.Tests;
using FluentValidation;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Xunit;
using Xunit.Extensions.AssertExtensions;

namespace Business.Commands.Tests.Validation
{
    public class LocalizedValidation : IDisposable
    {
        private readonly DbHelper<ExampleDbContext> _dbHelper;
        private readonly ExampleDbContext _handlerDbContext;

        public LocalizedValidation()
        {
            _dbHelper = new DbHelper<ExampleDbContext>().RunMigrations();
            _handlerDbContext = _dbHelper.GetDbContext();
            ValidatorOptions.LanguageManager = new LocalizedLanguageManager();
        }

        public void Dispose()
        {
            _handlerDbContext.Dispose();
        }

        [Fact]
        public void HasLocalizedErrorMessageWithDefaultMessages()
        {
            var validator = new InlineValidator<AddNewUserAccountCommand>();
            validator.RuleFor(e => e.Email).NotEmpty().EmailAddress();
            var result = validator.Validate(new AddNewUserAccountCommand());

            result.IsValid.ShouldBeFalse();
            IsValidJson(result.Errors.First().ErrorMessage).ShouldBeTrue();

            var message = JsonConvert.DeserializeObject<LocalizedString>(result.Errors.First().ErrorMessage);
            message.En.ShouldNotBeEmpty();
            message.Fr.ShouldNotBeEmpty();
        }

        [Fact]
        public void HasLocalizedErrorMessageWitLocalizedStringMessages()
        {
            var validator = new InlineValidator<AddNewUserAccountCommand>();
            validator.RuleFor(e => e.Email)
                .NotEmpty().WithLocalizedStringMessage(typeof(Core.Resources.Validation), nameof(Core.Resources.Validation.NotFound));
            var result = validator.Validate(new AddNewUserAccountCommand());

            result.IsValid.ShouldBeFalse();
            IsValidJson(result.Errors.First().ErrorMessage).ShouldBeTrue();

            var message = JsonConvert.DeserializeObject<LocalizedString>(result.Errors.First().ErrorMessage);
            message.En.ShouldNotBeEmpty();
            message.Fr.ShouldNotBeEmpty();
        }

        private static bool IsValidJson(string strInput)
        {
            strInput = strInput.Trim();
            if ((!strInput.StartsWith("{") || !strInput.EndsWith("}")) &&
                (!strInput.StartsWith("[") || !strInput.EndsWith("]"))) return false;
            try
            {
                var obj = JToken.Parse(strInput);
                return true;
            }
            catch (JsonReaderException jex)
            {
                //Exception in parsing json
                Console.WriteLine(jex.Message);
                return false;
            }
            catch (Exception ex) //some other exception
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
    }
}
