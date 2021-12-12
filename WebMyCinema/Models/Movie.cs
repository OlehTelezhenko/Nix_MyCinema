using System;

public class Movie
{
    public string MovieId { get; set; } //Ааааайди
    public string MovieTitle { get; set; } //Название фильма
    public string MovieGenre { get; set; } //Жанр                                             ?
    public string MovieReleaseDate { get; set; } //Дата выхода фильма
    public string MovieDescription { get; set; } //Описание
    public int MovieDuration { get; set; } //Продолжительность фильма в минутах
    public string MovieDerector { get; set; } //Режиссер
    public object Actors; //Актеры, обкашлять, обдумать   id, промежуточная бд               ?
    //Обложка кино


}
