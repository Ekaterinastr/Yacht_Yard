namespace Yacht_Yard
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Boat")]
    public partial class Boat
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Boat()
        {
            AccToBoats = new HashSet<AccToBoats>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int boat_ID { get; set; }

        [StringLength(255)]
        public string Model { get; set; }

        [StringLength(255)]
        public string BoatType { get; set; }

        public double? NumberOfRowers { get; set; }

        public bool Mast { get; set; }

        [StringLength(255)]
        public string Colour { get; set; }

        [StringLength(255)]
        public string Wood { get; set; }

        public double? BasePrice { get; set; }

        public double? VAT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AccToBoats> AccToBoats { get; set; }
    }
}
