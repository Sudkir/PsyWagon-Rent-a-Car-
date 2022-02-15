using System;
using System.ComponentModel.DataAnnotations;

//fix namespace Че за

namespace RazorPagesMovie.Models
{
    public class User
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Не указан логин")] //ответ с ошибкой о неуказании
        public string Login { get; set; }

        [Required(ErrorMessage = "Не указан пароль")] //ответ с ошибкой о неуказании
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)] //приведение поля к password
        [Compare("Password", ErrorMessage = "Пароль введен неверно")] //ответ с ошибкой о несовпадении и сравнение
        public string ConfirmPassword { get; set; }

        [DataType(DataType.Date)]
        public DateTime LastLogin { get; set; }
    }
}