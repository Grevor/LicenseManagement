namespace Viking.LicenseManagement
{
    public struct UserUsageInfo<UserKey>
    {
        public UserKey User { get; }
        public int NumberOfLicenses { get; }
        public LicenseScope Span { get; }

        public UserUsageInfo(UserKey user, LicenseScope span, int num)
        {
            User = user;
            Span = span;
            NumberOfLicenses = num;
        }
    }
}
