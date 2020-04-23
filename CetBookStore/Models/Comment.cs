using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CetBookStore.Models
{
    public class Comment
    {
        public int Id{ get; set; }

        [StringLength(100, MinimumLength = 3)]
        [Required]
        [Display(Name = "Başlık")]
        public string Title { get; set; }

        [StringLength(100, MinimumLength = 3)]
        [Required]
        [Display(Name = "Detay")]
        public string Detail { get; set; }

        [Required]
        [Display(Name = "Rating Oranı")]
        [Range(0, 99)]
        public int? Rating { get; set; }
        public DateTime CreatedDate { get; set; }

        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}
