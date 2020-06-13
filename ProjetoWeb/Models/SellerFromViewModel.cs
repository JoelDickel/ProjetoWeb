
using System.Collections.Generic;


namespace ProjetoWeb.Models
{
    public class SellerFromViewModel
    {
        public Seller Seller { get; set; }
        public ICollection<Department> Departments { get; set; }


    }
}
