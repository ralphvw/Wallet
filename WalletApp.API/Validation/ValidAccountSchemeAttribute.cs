namespace WalletApp.API.Validation;

using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

[AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
public class ValidAccountSchemeAttribute : ValidationAttribute
{
    private readonly string[] _validCardSchemes = { "visa", "mastercard" };
    private readonly string[] _validMomoSchemes = { "mtn", "vodafone", "airteltigo" };

    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        var typeProperty = validationContext.ObjectType.GetProperty("Type");
        var typeValue = typeProperty.GetValue(validationContext.ObjectInstance, null)?.ToString().ToLower();
        var accountNumber = validationContext.ObjectType.GetProperty("AccountNumber");
        var accountNumberValue = accountNumber.GetValue(validationContext.ObjectInstance, null)?.ToString().ToLower();
        
        if (typeValue == "card")
        {
            if (accountNumberValue.ToString().Length < 14 || accountNumberValue.ToString().Length > 16)
            {
                return new ValidationResult("Invalid length for card type. AccountNumber must be between 14 and 16 characters.");
            }
        }

        if (typeValue == "momo")
        {
            if (accountNumberValue.ToString().Length != 10)
            {
                return new ValidationResult("Invalid length for momo type. AccountNumber must be 10 characters.");
            }
        }
        
        if (typeValue == "card" && !_validCardSchemes.Contains(value.ToString().ToLower()))
        {
            return new ValidationResult("Invalid AccountScheme for card type. Allowed schemes are: Visa, MasterCard");
        }

        if (typeValue == "momo" && !_validMomoSchemes.Contains(value.ToString().ToLower()))
        {
            return new ValidationResult("Invalid AccountScheme for momo type. Allowed schemes are: Mtn, Vodafone, Airteltigo");
        }

        return ValidationResult.Success;
    }
}

