using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CetBookStore.Models
{
    public class Book
    {
        public int Id { get; set; }

        [StringLength(512, MinimumLength =3)]
        [Required]
        [Display(Name ="Kitap Adı")]
        public string Title { get; set; } // nvarchar(512), not nullable
        public int? PageCount { get; set; }

        [StringLength(100, MinimumLength = 3, ErrorMessage = "Yazar Adı 3 ile 10 karakter arasında olmalıdır")]
        [Required]
        [Display(Name = "Yazar Adı")]
        public string Authors { get; set; }

        [StringLength(500, MinimumLength = 3, ErrorMessage = "Açıklama Alanı 2 ile 500 karakter arasında olmalıdır")]
        [Required]
        [Display(Name = "Açıklama")]
        public string Description  { get; set; }

        [Range(0, 999.99)]
        [Required]
        [Display(Name = "Fiyatı")]
        public Decimal Price { get; set; }

        [Range(0, 9999)]
        [Required]
        [Display(Name = "Basım Yılı")]
        public int PressYear { get; set; }

        [Range(0, 9999)]
        [Required]
        [Display(Name = "Stok Miktarı")]
        public int StockCount { get; set; }

        
        public int CategoryId { get; set; }
        //[ForeignKey("CategoryId")]

        
        public  Category Category { get; set; }

        [Required]
        [Display(Name = "Yayın Tarihi")]
        public DateTime CreatedDate { get; set; }
        public virtual List<Comment> Comments { get; set; }
        public Book()
        {
            CreatedDate = DateTime.Now;
          //  double result = 4.0 / 2.0; //2.0000000000000000000000001 1.9999999999999999999999998
        }

    }
}
