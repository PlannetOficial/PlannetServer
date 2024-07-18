using Domain.Primitives;

namespace Domain.Companies
{
    public sealed class InfoCompany : Entity<Guid>
    {
        private InfoCompany(Guid id, string companyName, string address, string contactInfo) : base(id)
        {
            CompanyName = companyName;
            Address = address;
            ContactInfo = contactInfo;
        }

        public string CompanyName { get; private set; }

        public string Address { get; private set; }

        public string ContactInfo { get; private set; }

        public static InfoCompany Create(string companyName, string address, string contactInfo)
        {
            return new InfoCompany(Guid.NewGuid(), companyName, address, contactInfo);
        }
    }
}
