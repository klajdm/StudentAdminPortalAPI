using System;

namespace StudentAdminPortalAPI.DomainModels
{
    public class Address
    {
        public Guid Id { get; set; }

        public string PhysicalAddress { get; set; }

        public string PostalAddres { get; set; }

        public Guid StudentId { get; set; }
    }
}
