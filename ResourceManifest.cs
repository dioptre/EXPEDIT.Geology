using Orchard.UI.Resources;

namespace EXPEDIT.Geology {
    public class ResourceManifest : IResourceManifestProvider {
        public void BuildManifests(ResourceManifestBuilder builder) {
            builder.Add().DefineStyle("ExpeditGeology").SetUrl("expedit-geology.css");
        }
    }
}
