namespace Viking.LicenseManagement
{
    public struct LicenseUsageInfo
    {
        public int Total { get; }
        public int IsUse { get; }
        public int AvailableOverdraft { get; }
        public int Overdraft { get; }

        public LicenseUsageInfo(int total, int inUse, int availOverdraft, int overdraft)
        {
            Total = total;
            IsUse = inUse;
            AvailableOverdraft = availOverdraft;
            Overdraft = overdraft;
        }
    }
}
