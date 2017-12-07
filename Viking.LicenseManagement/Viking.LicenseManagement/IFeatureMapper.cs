using System.Collections.Generic;

namespace Viking.LicenseManagement
{
    public interface IFeatureMapper<TBase, Feature>
    {
        IEnumerable<Feature> GetFeatures(TBase other);
        IEnumerable<TBase> GetOther(Feature feature);
    }
}
