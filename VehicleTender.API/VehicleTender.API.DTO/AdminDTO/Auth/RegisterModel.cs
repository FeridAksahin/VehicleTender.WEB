using System.ComponentModel.DataAnnotations;

namespace VehicleTender.API.DTO.AdminDTO.Models.Auth
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Boş geçilemez.")]
        [MaxLength(255, ErrorMessage = "255 karakterin altında giriş yapınız."), MinLength(5, ErrorMessage = "6 karakterden uzun giriş yapınız.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Boş geçilemez.")]
        [MaxLength(255, ErrorMessage = "255 karakterin altında giriş yapınız."), MinLength(5, ErrorMessage = "6 karakterden uzun giriş yapınız.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Boş geçilemez.")]
        [Phone(ErrorMessage = "Geçerli bir telefon numarası giriniz.")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Boş geçilemez.")]
        [MaxLength(500, ErrorMessage = "500 karakterin altında giriş yapınız."), MinLength(6, ErrorMessage = "6 karakterden uzun giriş yapınız.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Boş geçilemez.")]
        [EmailAddress(ErrorMessage = "Geçerli bir mail adresi giriniz."), MaxLength(255, ErrorMessage = "255 karakterin altında giriş yapınız."), MinLength(6, ErrorMessage = "6 karakterden uzun giriş yapınız.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Boş geçilemez.")]
        [MaxLength(255, ErrorMessage = "255 karakterin altında giriş yapınız."), MinLength(5, ErrorMessage = "6 karakterden uzun giriş yapınız.")]
        public string Password { get; set; }
    }
}
