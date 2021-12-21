using System;
using System.ComponentModel.DataAnnotations;
using WebMyCinema.ValidationAttributes;

public class Cinema
{
    [Required]
    [Key]
    public int CimenaId { get; set; }

    [Required]
    [StringLength(20)]
    public string CinemaName { get; set; }

    [Required]
    public string CinemaAddress { get; set; }

    [Required]
    [MaxLength(2000)]
    public string AboutTheCinema { get; set; }

    [Required]
    [PhoneNumber]//Переделать 
    public string CinemaPhoneNumber { get; set; }

    [Required]
    [Url]
    public string CinemaPhotography { get; set; }//фото кинотеатра

}
