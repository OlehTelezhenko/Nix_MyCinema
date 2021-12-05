using System;

public class Actor
{
    public int ActorId { get; set; }
    public string FullName { get; set; } //кличка
    public string BiographyOfTheActor { get; set; } //краткая био
    public string FilmsWithTheActor { get; set; } //Фильмы в котором снялся актер
    //фотография 

    public void SearchForAnActor() //Поиск актера в бд
    { }

    public void AddNewAnActor() //добавить в базу
    { }

    public void EditingAnActor() //Редактирование 
    { }

    public void GetActorData() //Вывод инфы
    { }

}
