using System.ComponentModel.DataAnnotations;

namespace WalletApp.API.Models.Dto;

public class RegisterDto
{
    [Required]
    [MinLength(10, ErrorMessage ="Phone number is a minimum of ten characters")]
    [MaxLength(10, ErrorMessage ="Phone number is a maximum of ten characters")]
    public string PhoneNumber { get; set; }
    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    [Required]
    [MinLength(1, ErrorMessage ="FirstName is a minimum of one character")]
    [MaxLength(255, ErrorMessage ="FirstName is a maximum of 255 characters")]
    public string FirstName { get; set; }
    [Required]
    [MinLength(1, ErrorMessage ="LastName is a minimum of one character")]
    [MaxLength(255, ErrorMessage ="LastName is a maximum of 255 characters")]
    public string LastName { get; set; }
}