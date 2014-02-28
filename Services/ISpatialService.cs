using System;
using System.Collections.Generic;
using System.IO;
using System.Web;
using Orchard;
using NKD.Models;
using System.ServiceModel;

namespace EXPEDIT.Geology.Services
{
    [ServiceContract]
    public interface ISpatialService : IDependency
    {
        [OperationContract]
        void TestSpatial();

    }
}
