
using System;
using System.ComponentModel.DataAnnotations;

namespace Session10.Data.Entities
{
    public class Cat
    {
        public int Id {set; get;}
        [StringLength(20, MinimumLength=2)]
        [Required]
        public string Name{set; get;}
        [RegularExpression(@"^[a-zA-Z''\s-]$", ErrorMessage="Only letters allowed")]
        public string  Color{set; get;}
        public string  FavoriteDish{set; get;}
        [Range(0,100)]
        [DataType(DataType.Currency)]
        [Required]
        public decimal Price{set; get;}
        public DateTime Birthdate{set; get;}
    }
}