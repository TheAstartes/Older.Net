using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace TheShop.Models
{
    public class Opinia
    {
        [BindNever]
        public int ID { get; set; }
        [Required(ErrorMessage ="Username required")]
        [StringLength(25,ErrorMessage ="Username is too long (more than 25 characters")]
        public string Username { get; set; }
        [Required(ErrorMessage ="Email required")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|""(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*"")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])",
            ErrorMessage = "Email is incorrect")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Message required")]
        [StringLength(400,ErrorMessage ="Messsage is too long (more than 400 characters)")]
        public string Message { get; set; }
        public bool Oczekiwanie { get; set; }
    }
}
