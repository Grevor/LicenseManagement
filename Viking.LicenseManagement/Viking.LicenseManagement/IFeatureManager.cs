using System.Collections.Generic;

namespace Viking.LicenseManagement
{
    public interface IFeatureManager<Feature>
    {
        IEnumerable<Feature> AllFeatures { get; }

        bool HasFeature(Feature feature);
        bool HasAllFeatures(IEnumerable<Feature> features);

        IEnumerable<Feature> GetAllFeaturesNotAvailable(IEnumerable<Feature> features);

    }
}
