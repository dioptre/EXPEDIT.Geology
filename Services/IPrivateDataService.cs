using System;
using System.Collections.Generic;
using System.IO;
using System.Web;
using Orchard;
using NKD.Models;
using System.ServiceModel;
using NKD.Module.BusinessObjects;

namespace EXPEDIT.Geology.Services
{
    [ServiceContract]
    public interface IPrivateDataService : IDependency {

        [OperationContract]
        T GetObject<T>(string lookup);

        [OperationContract]
        Guid? GetKey(string lookup);

        [OperationContract]
        MetaData[] GetMetadata(Guid referenceID, Func<MetaData, bool> predicate = null);

        [OperationContract]
        T GetFirstMetadata<T>(Guid referenceID, Func<MetaData, bool> predicate = null);

        [OperationContract]
        void SetObject(string lookup, string value, string tabletype = null, string usertype = null, string systemdatatype = null);

        Guid NKD_GUID_LOG
        {
            [OperationContract]
            get;
            [OperationContract]
            set;
        }

        Guid NKD_BM_STAGE
        {
            [OperationContract]
            get;
            [OperationContract]
            set;
        }
    }
}