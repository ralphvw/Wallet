using System.ComponentModel.DataAnnotations;

namespace WalletApp.API.Models.Dto;

public class LoginDto
{
    [Required]
    public string PhoneNumber { get; set; }
    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }
}