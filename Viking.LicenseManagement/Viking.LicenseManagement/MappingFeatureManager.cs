using System.Collections.Generic;
using System.Linq;

namespace Viking.LicenseManagement
{
    public class MappingFeatureManager<TBase, Feature> : IFeatureManager<Feature>
    {
        private IFeatureMapper<TBase,Feature> Mapper { get; }
        private ILicenseManager<TBase> Licenses { get; }

        public MappingFeatureManager(ILicenseManager<TBase> licenseManager, IFeatureMapper<TBase, Feature> mapper)
        {
            Licenses = licenseManager;
            Mapper = mapper;
        }

        public IEnumerable<Feature> AllFeatures => Licenses.GetHeldLicenses().SelectMany(lic => Mapper.GetFeatures(lic.License));
        public IEnumerable<Feature> GetAllFeaturesNotAvailable(IEnumerable<Feature> features)
        {
            var feats = new HashSet<Feature>(AllFeatures);
            return features.Where(a => !feats.Contains(a));
        }

        public bool HasAllFeatures(IEnumerable<Feature> features)
        {
            return !GetAllFeaturesNotAvailable(features).Any();
        }

        public bool HasFeature(Feature feature)
        {
            return AllFeatures.Contains(feature);
        }
    }
}
