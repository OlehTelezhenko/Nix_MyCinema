using System;
using System.ComponentModel.DataAnnotations;

public class Directors
{
    public int Id { get; set; }

    [Required]
    [MaxLength(20), MinLength(2)]
    public string FullName { get; set; }

    [MaxLength(2000)]
    public string Biography { get; set; } //краткая био

    public string Films { get; set; } //Фильмы в котором снялся актер    ??

    [Url]
    public string Photo { get; set; } //фотография 
}
