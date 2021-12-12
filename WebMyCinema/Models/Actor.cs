using System;
using System.ComponentModel.DataAnnotations;

public class Actor
{
    [Key]
    public int ActorId { get; set; }

    [Required]
    [MaxLength(100), MinLength(2)]
    public string FullName { get; set; } //кличка

    [MaxLength(500)]
    public string BiographyOfTheActor { get; set; } //краткая био

    public string FilmsWithTheActor { get; set; } //Фильмы в котором снялся актер    ??
    
    [Url]
    public string PhotoActor { get; set; } //фотография 



    public void SearchForAnActor() //Поиск актера в бд
    { }

    public void AddNewAnActor() //добавить в базу
    { }

    public void EditingAnActor() //Редактирование 
    { }

    public void GetActorData() //Вывод инфы
    { }

}
