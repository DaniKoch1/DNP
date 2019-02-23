using System.ComponentModel.DataAnnotations;
namespace Exe1_3.Models
{
    public class TodoItem
    {
        public long Id { get; set; }
        [MinLength(3)]
        public string Name { get; set; }
        public bool IsComplete { get; set; }
    }
}