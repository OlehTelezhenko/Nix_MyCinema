using System;
using System.ComponentModel.DataAnnotations;

public class UserAuthorization
{
    public string UserId { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    public string Password { get; set; }



    public void SearchEmailInDataBase() //Поиск емейла/логина
    { }

    public void EqualityOfEnteredPasswords() //Проверочка совпадения паролей
    { }

    public void UserLogin() //Вход 
    { }

    public void CreateANewUser() //Регистрация/добавление нового пользователя
    { }

    public void RemoveUser() //Временный метод
    { }

    public void UserInfo() //Временный метод
    { }

}
