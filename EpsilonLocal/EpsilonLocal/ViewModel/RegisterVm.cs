using System.ComponentModel.DataAnnotations;

namespace EpsilonLocal.ViewModel
{
    public class RegisterVm
    {
        [Required, MaxLength(250)]
        public string FullName { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required, DataType(DataType.Password)]
        public string Password { get; set; }

        [Required, DataType(DataType.Password), Compare("Password")]
        public string CheckPassword { get; set; }
        [Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
