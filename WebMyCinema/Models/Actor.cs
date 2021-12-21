using System;
using System.ComponentModel.DataAnnotations;

public class Actor
{
    public int ActorId { get; set; }

    [Required]
    [MaxLength(20), MinLength(2)]
    public string FirstName { get; set; } 

    [Required]
    [MaxLength(20), MinLength(2)]
    public string Surname { get; set; } 

    [MaxLength(2000)]
    public string BiographyOfTheActor { get; set; } //краткая био

    public string FilmsWithTheActor { get; set; } //Фильмы в котором снялся актер    ??
    
    [Url]
    public string PhotoActor { get; set; } //фотография 

}
