using System;
using System.ComponentModel.DataAnnotations;

public class UserAccaunt
{
    
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(100), MinLength(2)]
    public string FullUsername { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    public decimal Account { get; set; }//Счет

    [CreditCard]
    public string UserCreditCard { get; set; }// Банковсткая карта



}
