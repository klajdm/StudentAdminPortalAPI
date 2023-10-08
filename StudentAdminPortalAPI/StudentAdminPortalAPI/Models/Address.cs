using System;

namespace StudentAdminPortalAPI.Models
{
    public class Address
    {
        public Guid Id { get; set; }

        public string PhysicalAddress { get; set; }

        public string PostalAddres { get; set; }

        // Navigation Property

        public Guid StudentId { get; set; }
    }
}
