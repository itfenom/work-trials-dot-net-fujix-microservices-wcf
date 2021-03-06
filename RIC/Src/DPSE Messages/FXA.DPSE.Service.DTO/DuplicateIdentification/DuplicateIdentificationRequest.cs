﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using FXA.DPSE.Service.DTO.Core.Validation;

namespace FXA.DPSE.Service.DTO.DuplicateIdentification
{
    [DataContract]
    public class DuplicateIdentificationRequest
    {
        public DuplicateIdentificationRequest()
        {
        }

        public DuplicateIdentificationRequest(string trackingId)
        {
            TrackingId = trackingId;
        }

        public DuplicateIdentificationRequest(string trackingId, string channelType, string sessionId, Cheque[] cheques)
        {
            TrackingId = trackingId;
            ChannelType = channelType;
            SessionId = sessionId;
            Cheques = cheques;
        }

        [DataMember(Name = "tracking_id")]
        public string TrackingId { get; set; }

        [Required]
        [DataMember(Name = "channel_type")]
        public string ChannelType { get; set; }

        [RequiredWithGuidFormat()]
        [DataMember(Name = "session_id")]
        public string SessionId { get; set; }

        [Required]
        [DataMember(Name = "cheques")]
        public Cheque[] Cheques { get; set; }
    }

    [DataContract]
    public class Cheque
    {
        [Required]
        [DataMember(Name = "sequence_id")]
        public int SequenceId { get; set; }

        [Required]
        [DataMember(Name = "codeline")]
        public string Codeline { get; set; }

        [Required]
        [DataMember(Name = "cheque_amount")]
        public int ChequeAmount { get; set; }

        [DataMember(Name = "tracking_id")]
        public string TrackingId { get; set; }
    }
}

