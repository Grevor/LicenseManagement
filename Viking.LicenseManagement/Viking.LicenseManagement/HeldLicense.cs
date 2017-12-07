namespace Viking.LicenseManagement
{
    public struct HeldLicense<LicenseKey>
    {
        public LicenseKey License { get; }
        public LicenseScope Scope { get; }
        public int NumLicenses { get; }

        public HeldLicense(LicenseKey license, LicenseScope scope, int num)
        {
            License = license;
            Scope = scope;
            NumLicenses = num;
        }
    }
}
