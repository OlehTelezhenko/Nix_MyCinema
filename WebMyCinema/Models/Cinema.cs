using System;
using System.ComponentModel.DataAnnotations;

public class Cinema
{
    [Required]
    [Key]
    public int CimenaId { get; set; };

    [Required]
    [StringLength(20)]
    public string CinemaName { get; set; }

    [Required]
    public string CinemaAddress { get; set; }

    public string AboutTheCinema { get; set; }

    [Phone]//Переделать 
    public string CinemaPhoneNumber { get; set; }

    [Url]
    public string CinemaPhotography { get; set; }//фото кинотеатра



    public void AddNewCinema() //добавить кинотеатр
    { }

    public void CinemaInfo() //информация о кинотеатре
    { }

    public void СinemaInfoEdit() //изменение данных
    { }
}
