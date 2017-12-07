using System.Collections.Generic;

namespace Viking.LicenseManagement
{
    public interface ILicenseManager<LicenseKey> : ILicenseSource<LicenseKey>
    {
        IEnumerable<HeldLicense<LicenseKey>> GetHeldLicenses();
    }
}
