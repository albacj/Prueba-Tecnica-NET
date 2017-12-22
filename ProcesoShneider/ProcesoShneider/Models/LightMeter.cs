namespace ProcesoShneider.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("LightMeter")]
    public partial class LightMeter
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Serial_Number { get; set; }

        [StringLength(50)]
        public string Brand { get; set; }

        [StringLength(50)]
        public string Model { get; set; }

        public static List<LightMeter> GetAll()
        {
            DBContext context = new DBContext();
            return context.LightMeter.ToList();
        }

        public static LightMeter GetByID(int id)
        {
            DBContext context = new DBContext();
            return context.LightMeter.Where(x => x.Id == id).SingleOrDefault();
        }
    }
}
