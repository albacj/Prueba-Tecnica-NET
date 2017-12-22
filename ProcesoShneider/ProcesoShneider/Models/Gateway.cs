namespace ProcesoShneider.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("Gateway")]
    public partial class Gateway
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string SerialNumber { get; set; }

        [StringLength(50)]
        public string Brand { get; set; }

        [StringLength(50)]
        public string Model { get; set; }

        [Required]
        [StringLength(50)]
        public string Ip { get; set; }

        public int? Port { get; set; }

        public static List<Gateway> GetAll()
        {
            DBContext context = new DBContext();
            return context.Gateway.ToList();
        }

        public static Gateway GetByID(int id)
        {
            DBContext context = new DBContext();
            return context.Gateway.Where(x => x.Id == id).SingleOrDefault();
        }

    }
}
