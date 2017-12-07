namespace Viking.LicenseManagement
{
    public struct UserHost
    {
        public string User { get; }
        public string Host { get; }

        public UserHost(string user, string host)
        {
            User = user;
            Host = host;
        }

        public override string ToString()
        {
            return $"{User}@{Host}";
        }
    }
}
