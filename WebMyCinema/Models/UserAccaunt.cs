using System;
using System.ComponentModel.DataAnnotations;
using WebMyCinema.ValidationAttributes;

public class UserAccaunt
{
    public int Id { get; set; }

    [Required]
    [MaxLength(100), MinLength(2)]
    public string FullUsername { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    public string FullPhoneNumber { get; set; }

    [PhoneNumber]
    [MaxLength(10)]
    
    public string PhoneNumber 
    {
        get{ return FullPhoneNumber; }
        set
        {
            string CountryCode = "+38";
            value += CountryCode;
        }
    } 
    //Принимает 10 цифр, например 0931112233
    public decimal Account { get; set; } //Денежный счет


    
}
