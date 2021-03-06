//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FXA.DPSE.Service.PaymentInstruction.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class ClientSession
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ClientSession()
        {
            this.PaymentInstructions = new HashSet<PaymentInstruction>();
        }
    
        public long Id { get; set; }
        public string UserId1 { get; set; }
        public string UserId2 { get; set; }
        public string DeviceId { get; set; }
        public string IpAddressV4 { get; set; }
        public string IpAddressV6 { get; set; }
        public string ClientName { get; set; }
        public string ClientVersion { get; set; }
        public string OS { get; set; }
        public string OSVersion { get; set; }
        public string CaptureDevice { get; set; }
        public string SessionId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PaymentInstruction> PaymentInstructions { get; set; }
    }
}
