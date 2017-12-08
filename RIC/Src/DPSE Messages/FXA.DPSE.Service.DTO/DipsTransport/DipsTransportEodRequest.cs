﻿using FXA.DPSE.Service.DTO.Core.Validation;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace FXA.DPSE.Service.DTO.DipsTransport
{
    [DataContract]
    public class DipsTransportEodRequest
    {
        [Required]
        [DataMember(Name = "message_version")]
        public string MessageVersion { get; set; }

        [Required]
        [DataMember(Name = "request_utc")]
        public string RequestUtc { get; set; }

        [Required]
        [RequiredWithGuidFormat]
        [DataMember(Name = "request_guid")]
        public string RequestGuid { get; set; }

        [Required]
        [DataMember(Name = "ip_address_v4")]
        public string IpAddressV4 { get; set; }

        [Required]
        [DataMember(Name = "report_date")]
        public string ReportDate { get; set; }
    }
}