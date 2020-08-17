using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MusicDiary.Domain.Entities
{
    public abstract class Person
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Введите имя")]
        [MaxLength(30)]
        [Display(Name = "Имя")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Введите фамилию")]
        [MaxLength(30)]
        [Display(Name = "Фамилия")]
        public string Surname { get; set; }

        [MaxLength(30)]
        [Display(Name = "Отчество")]
        public string SecondName { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Дата рождения")]
        public DateTime BirthDay { get; set; }

        [DataType(DataType.Url)]
        [Display(Name = "Учетная запись ВКонтакте")]
        public string VKAccount { get; set; }

        [DataType(DataType.Url)]
        [Display(Name = "Учетная запись Facebook")]
        public string FacebookAccount { get; set; }

        [DataType(DataType.Url)]
        [Display(Name = "Учетная запись Instagram")]
        public string InstagramAccount { get; set; }

        [DataType(DataType.Url)]
        [Display(Name = "Учетная запись YouTube")]
        public string YouTubeAccount { get; set; }

        [Required(ErrorMessage ="Введите адрес электронной почты")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Адрес электронной почты")]
        public string  Email { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Номер телефона")]
        public string Phone { get; set; }
    }
}
