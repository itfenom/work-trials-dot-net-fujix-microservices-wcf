//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FXA.DPSE.Service.DipsPayload.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class VoucherImage
    {
        public long VoucherId { get; set; }
        public string FrontImage { get; set; }
        public string RearImage { get; set; }
        public string FrontImageSHA { get; set; }
        public string RearImageSHA { get; set; }
    
        public virtual Voucher Voucher { get; set; }
    }
}
