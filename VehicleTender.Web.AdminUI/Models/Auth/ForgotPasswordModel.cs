using System.ComponentModel.DataAnnotations;

namespace VehicleTender.Web.AdminUI.Models.Auth
{
    public class ForgotPasswordModel
    {
        [Required(ErrorMessage ="Boş geçilemez.")]
        [EmailAddress(ErrorMessage ="Geçerli bir mail adresi giriniz."),MaxLength(255,ErrorMessage ="255 karakterin altında giriş yapınız.")]
        public string Email { get; set; }
    }
}
