using System.Collections.Generic;
using System.Linq;

namespace Viking.LicenseManagement
{
    public class FeatureManager<Feature> : IFeatureManager<Feature>
    {
        private HashSet<Feature> Features { get; } = new HashSet<Feature>();
        public IEnumerable<Feature> AllFeatures => Features;

        public IEnumerable<Feature> GetAllFeaturesNotAvailable(IEnumerable<Feature> features)
        {
            return features.Where(a => !Features.Contains(a));
        }

        public bool HasAllFeatures(IEnumerable<Feature> features)
        {
            return features.All(Features.Contains);
        }

        public bool HasFeature(Feature feature)
        {
            return Features.Contains(feature);
        }

        public void AddFeature(Feature feature) => Features.Add(feature);
        public bool RemoveFeature(Feature feature) => Features.Remove(feature);
        public void Clear() => Features.Clear();
    }
}
