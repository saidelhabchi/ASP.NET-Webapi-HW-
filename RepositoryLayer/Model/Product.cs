using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RepositoryLayer.Model
{
    [Table("Products")]
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        public int Qte { get; set; }
        public  int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
