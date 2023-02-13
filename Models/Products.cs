using System.ComponentModel.DataAnnotations.Schema;

namespace SportsStore.Models
{
    public class Products //provides a template for the Products table in the database
    {
        public long ProductID { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        [Column(TypeName = "decimal(8, 2)")] //provides the data type for the Price column in the SQL database
        public decimal Price { get; set; }

        public string? Category { get; set; }
    }
}
