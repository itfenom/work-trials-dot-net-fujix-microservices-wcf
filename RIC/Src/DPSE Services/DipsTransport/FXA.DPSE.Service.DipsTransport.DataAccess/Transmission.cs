//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FXA.DPSE.Service.DipsTransport.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Transmission
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Transmission()
        {
            this.TransmissionBatches = new HashSet<TransmissionBatch>();
        }
    
        public long Id { get; set; }
        public System.DateTime CreationDateTime { get; set; }
        public Nullable<System.DateTime> TransportedDateTime { get; set; }
        public string FilePath { get; set; }
        public string FileName { get; set; }
        public string FileSHAHash { get; set; }
        public Nullable<long> TransactionCount { get; set; }
        public Nullable<int> RetryCount { get; set; }
        public string Status { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransmissionBatch> TransmissionBatches { get; set; }
    }
}
