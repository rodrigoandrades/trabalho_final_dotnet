namespace WCFReader
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Notification")]
    public partial class Notification
    {
        [Key]
        [Column(Order = 0)]
        public DateTime data { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string mensagem { get; set; }
    }
}
