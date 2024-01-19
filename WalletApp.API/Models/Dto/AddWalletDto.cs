using System.ComponentModel.DataAnnotations;
using WalletApp.API.Validation;

namespace WalletApp.API.Models.Dto;

public class AddWalletDto
{
    [Required]
    [MinLength(1, ErrorMessage ="Name is a minimum of one character")]
    [MaxLength(255, ErrorMessage ="Name is a maximum of 255 characters")]
    public string Name { get; set; }
    [Required]
    [RegularExpression("^(momo|card)$", ErrorMessage = "Type must be 'momo' or 'card'")]
    public string Type { get; set; }
    [Required]
    public string AccountNumber { get; set; }
    [Required]
    [ValidAccountScheme(ErrorMessage = "Invalid AccountScheme")]
    [RegularExpression("^(visa|mastercard|mtn|vodafone|airteltigo)$", ErrorMessage = "Invalid AccountScheme")]
    public string AccountScheme { get; set; }
}