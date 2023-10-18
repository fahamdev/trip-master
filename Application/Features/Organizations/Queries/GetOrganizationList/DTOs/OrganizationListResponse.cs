﻿namespace Application.Features.Organizations.Queries.GetOrganizationList.DTOs
{
    public class OrganizationListResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNo { get; set; } = string.Empty;
    }
}
