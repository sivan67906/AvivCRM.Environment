﻿using AvivCRM.Environment.Application.DTOs.LeadAgent;

namespace AvivCRM.Environment.Application.DTOs
{
    public class UpdateLeadAgentRequest : LeadAgentBaseModel
    {
        public Guid Id { get; set; }
    }
}