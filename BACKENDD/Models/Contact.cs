using System.ComponentModel.DataAnnotations;

namespace BACKENDD.Models
{
    public class Contact
    {

        [Key] 
        public int Id { get; set; }  

        [Display(Name = "Введите Имя")]
        [Required(ErrorMessage = "НУЖНО ИМЯ!")]

        public required string Name { get; set; }

        [Display(Name = "Введите Фамилию")]
        [Required(ErrorMessage = "НУЖНА ФАМИЛИЯ!")]


        public required string SecName { get; set; }

        [Display(Name = "Введите Возраст")]
        [Required(ErrorMessage = "НУЖЕН ВОЗРАСТ!")]

        public required int Age { get; set; }

        [Display(Name = "Введите Почту")]
        [Required(ErrorMessage = "НУЖНА ПОЧТА!")]

        public required string Email { get; set; }

        [Display(Name = "Введите Сообщение")]
        [Required(ErrorMessage = "НУЖНО СООБЩЕНИЕ!")]

        public required string Message { get; set; }





    }
}
