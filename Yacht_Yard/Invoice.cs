namespace Yacht_Yard
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Invoice")]
    public partial class Invoice
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Invoice_ID { get; set; }

        public int? Contract_ID { get; set; }

        public bool? Settled { get; set; }

        [Column(TypeName = "money")]
        public decimal? Sum { get; set; }

        public double? Sum_inclVAT { get; set; }

        public DateTime? Date { get; set; }

        public virtual Contract Contract { get; set; }
    }
}
