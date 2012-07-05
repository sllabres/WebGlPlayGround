using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Web.Mvc;
using Spark.Web.Mvc.Descriptors;

namespace Lampkin.Web
{
    public class AreaDescriptorFilter : DescriptorFilterBase
    {
        private const string areaPathFormatString = "~\\Areas\\{0}\\Views";
        public override void ExtraParameters(ControllerContext context, IDictionary<string, object> extra)
        {
            object value;
            if (context.RouteData.Values.TryGetValue("area", out value))
                extra["area"] = value;
        }

        public override IEnumerable<string> PotentialLocations(IEnumerable<string> locations, IDictionary<string, object> extra)
        {
            string areaName;

            return TryGetString(extra, "area", out areaName)
                       ? locations.Select(x => Path.Combine(string.Format(areaPathFormatString, areaName), x)).Concat(locations)
                       : locations;
        }
    }
}
