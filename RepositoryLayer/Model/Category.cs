using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Model
{
    [Table("Categories")]
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public required string Name { get; set; }
        public List<Product>? Products { get; set; }
    }
}
