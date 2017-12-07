using System;

namespace Viking.LicenseManagement
{
    [Flags]
    public enum LicenseScope
    {
        None = 0,
        Unknown = 1,
        User = 2,
        Host = 4,
        Display = 8,

        All = User|Host|Display
    }

    public struct LicenseRequest<LicenseKey>
    {
        public LicenseKey Key { get; }
        public LicenseScope RequestedSpanType { get; }
        public int NumberOfLicenses { get; }
        public bool SpanMustMatch { get; }

        public LicenseRequest(LicenseKey key, LicenseScope span, int num, bool mustMatch)
        {
            Key = key;
            RequestedSpanType = span;
            NumberOfLicenses = num;
            SpanMustMatch = mustMatch;
        }
    }
}
