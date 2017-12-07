using System;
using System.Collections.Generic;

namespace Viking.LicenseManagement
{
    public delegate void LicenseSourceConnectionStateChanged<LicenseKey>(LicenseSourceConnectivity oldState, LicenseSourceConnectivity newState, ILicenseSource<LicenseKey> source);

    public enum LicenseSourceConnectivity
    {
        Unknown,
        Connected,
        Disconnected
    }

    public interface ILicenseSource<LicenseKey> : IDisposable
    {
        void RequestLicense(LicenseRequest<LicenseKey> request);
        void ReturnLicenses(LicenseKey key, int num);

        LicenseUsageInfo GetUsageInfo(LicenseKey key);
        IEnumerable<UserUsageInfo<UserHost>> GetUserHostPairsUsingLicense(LicenseKey key);
        IEnumerable<UserUsageInfo<string>> GetUsersUsingLicense(LicenseKey key);
        IEnumerable<UserUsageInfo<string>> GetHostsUsingLicense(LicenseKey key);

        LicenseSourceConnectivity ConnectionStatus { get; }
        LicenseSourceConnectionStateChanged<LicenseKey> ConnectionStateChanged { get; }
    }
}
