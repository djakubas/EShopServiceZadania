using Microsoft.EntityFrameworkCore;

namespace EShop.Domain.Models
{
    public class Category
    {
        /// <summary>
        /// Category Name, default "Unknown"
        /// </summary>
        public string Name { get; set; } = "Unknown";

        public int Id {  get; set; }

    }
}