namespace Yacht_Yard
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Accessory")]
    public partial class Accessory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Accessory()
        {
            AccToBoats = new HashSet<AccToBoats>();
            OrderDetails = new HashSet<OrderDetails>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Accessory_ID { get; set; }

        [StringLength(255)]
        public string AccName { get; set; }

        [StringLength(255)]
        public string DescriptionOfAccessory { get; set; }

        public double? Price { get; set; }

        public double? VAT { get; set; }

        public double? Inventory { get; set; }

        public double? OrderLevel { get; set; }

        public double? OrderBatch { get; set; }

        public int? Partner_ID { get; set; }

        public virtual Partner Partner { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AccToBoats> AccToBoats { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
