using System;
using System.ComponentModel.DataAnnotations;

public class Film
{
    public string Id { get; set; } //Ааааайди
    [Required]
    [StringLength(20)]
    public string Title { get; set; } //Название фильма
    [Required]
    [StringLength(20)]
    public string Cauntry { get; set; } //Страна        
    [Required]
    public string Genre { get; set; } //Жанр                                             ?
    [Required]
    public float Rating { get; set; } //Оценка, например 7.7
    [Required]
    public DataType ReleaseDate { get; set; } //Дата выхода фильма
    [Required]
    [MaxLength(2000)]
    public string Description { get; set; } //Описание
    [Required]
    public int Duration { get; set; } //Продолжительность фильма в минутах
    [Required]
    public string Director { get; set; } //Режиссер

    public Actor Actors = new Actor(); //Актеры                                               ?
    
    [Url]
    public string MoviePoster { get; set; } //Обложка кино

    public FilmScreenShots ScreenShots = new FilmScreenShots(); //Скриншоты
}
