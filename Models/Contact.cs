using System.ComponentModel.DataAnnotations;

namespace contact_form.Models
{
    public class Contact
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Lütfen adınızı giriniz.")]
        [StringLength(50, MinimumLength =5, ErrorMessage = "Ad soyad en az 5, en fazla 50 karakter olabilir.")]
        public string Fullname { get; set; }

        [Required(ErrorMessage = "Lütfen telefon numaranızı giriniz.")]
        [RegularExpression(@"^05\d{9}$", ErrorMessage = "Telefon numarası '05xxxxxxxxx' formatında olmalıdır.")]
        public string Telephone { get; set; }

        [Required(ErrorMessage = "Lütfen e-posta adresinizi giriniz.")]
        [EmailAddress(ErrorMessage ="Geçerli bir e-posta adresi giriniz.")]
        public required string Email { get; set; }

        [Required(ErrorMessage = "Lütfen departman seçiniz.")]
        public required string Department { get; set; }

        [Required(ErrorMessage = "Mesaj alanı boş bırakılamaz.")]
        [StringLength(500, MinimumLength = 25, ErrorMessage = "Mesaj en az 25, en fazla 500 karakter olmalıdır.")]
        public required string Message { get; set; }

    }
}
