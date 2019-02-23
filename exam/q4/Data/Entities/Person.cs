using System;
using System.ComponentModel.DataAnnotations;

namespace Data.Entities
{
    public class Person
    {
        [StringLength(10, MinimumLength = 3)]
        [Required]
        public string Name {get; set;}
        public int Age {get; set;}
        [DataType(DataType.Date)]
        public DateTime Bday {get; set;}


    }
}