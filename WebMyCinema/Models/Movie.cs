using System;
using System.ComponentModel.DataAnnotations;

public class Movie
{
    public string MovieId { get; set; } //Ааааайди
    [Required]
    [StringLength(20)]
    public string MovieTitle { get; set; } //Название фильма
    [Required]
    [StringLength(20)]
    public string Cauntry { get; set; } //Страна        
    [Required]
    public string MovieGenre { get; set; } //Жанр                                             ?
    [Required]
    public float MovieRating { get; set; } //Оценка, например 7.7
    [Required]
    public string MovieReleaseDate { get; set; } //Дата выхода фильма
    [Required]
    [MaxLength(2000)]
    public string MovieDescription { get; set; } //Описание
    [Required]
    public int MovieDuration { get; set; } //Продолжительность фильма в минутах
    [Required]
    public string MovieDerector { get; set; } //Режиссер

    public Actor Actors = new Actor(); //Актеры                                               ?
    
    [Url]
    public string MoviePoster { get; set; } //Обложка кино

    public MovieSkreenShots SkreenShots = new MovieSkreenShots(); //Скриншоты


}
