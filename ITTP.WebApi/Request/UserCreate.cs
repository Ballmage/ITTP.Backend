using System;
using System.ComponentModel.DataAnnotations;

namespace ITTP.WebApi.Request
{
    public class UserCreate
    {
        [Required]
        [StringLength(50)]
        [Display(Name = "Логин")]
        public string? Login { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Пароль")]
        public string? Password { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Имя")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Поле Пол пустое")]
        [Display(Name = "Пол")]
        public int Gender { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "День рождение")]
        public DateTime? Birthday { get; set; }

        [Required]
        [Display(Name = "Администратор?")]
        public bool Admin { get; set; }
    }
}
