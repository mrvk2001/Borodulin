namespace LSchool
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("14.clientservice")]
    public partial class clientservice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public clientservice()
        {
            documentbyservice = new HashSet<documentbyservice>();
            productsale = new HashSet<productsale>();
        }

        public int ID { get; set; }

        public int ClientID { get; set; }

        public int ServiceID { get; set; }

        public DateTime StartTime { get; set; }

        [StringLength(1073741823)]
        public string Comment { get; set; }

        public virtual client client { get; set; }

        public virtual service service { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<documentbyservice> documentbyservice { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<productsale> productsale { get; set; }
    }
}
