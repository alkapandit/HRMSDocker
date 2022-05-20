using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRMSDCocker.Models
{
    public class House
    {
        public int HouseId { get; set; }

        public int HouseNo { get; set; }

        public string Locality { get; set; }

        public string City { get; set; }

        public int Rent { get; set; }

        public string Address { get; set; }

        public string Description { get; set; }

        public string Status { get; set; }

       

    }
}
