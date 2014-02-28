using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ionic.Zip;
using JetBrains.Annotations;
using Orchard.ContentManagement;
using Orchard.FileSystems.Media;
using Orchard.Localization;
using NKD.Models;
using Orchard.Security;
using Orchard.Settings;
using Orchard.Validation;
using Orchard;
using System.Transactions;
using NKD.Helpers;
using System.Data;
using NKD.Module.BusinessObjects;
using NKD.Services;

namespace EXPEDIT.Geology.Services
{
    [UsedImplicitly]
    public class PrivateDataService : NKD.Services.PrivateDataService, IPrivateDataService
    {
        private readonly IOrchardServices _orchardServices;
        private readonly IUsersService _users;
        public PrivateDataService(IOrchardServices orchardServices, IUsersService users) : base(orchardServices, users)
        {
            _users = users;
            _orchardServices = orchardServices;
            _localizer = NullLocalizer.Instance;
        }

               
        private const string guid_lookup_string = "NKD_GUID_LOG";
        private const string guid_log_string = "e8ac1711-df77-4738-82d3-63253177f0f8";
        private static Guid? guid_log = null;

        public Guid NKD_GUID_LOG
        {
            get
            {
                if (!guid_log.HasValue)
                {
                    guid_log = GetKey(guid_lookup_string);
                    if (!guid_log.HasValue)
                    {
                        SetObject(guid_lookup_string, guid_log_string, "X_Parameter", "Metadata Log", "System.Guid");
                        guid_log = new Guid(guid_log_string);
                    }
                }
                return guid_log.Value;
            }
            set
            {
                guid_log = value;
            }
        }

        private const string guid_bm_stage_lookup_string = "NKD_BM_STAGE";
        private const string guid_bm_stage_string = "B8D13700-29F0-4668-952F-98B0716DF22A";
        private static Guid? guid_bm_stage_id = null;
        

        public Guid NKD_BM_STAGE
        {
            get
            {
                if (!guid_bm_stage_id.HasValue)
                {
                    guid_bm_stage_id = GetKey(guid_bm_stage_lookup_string);
                    if (!guid_bm_stage_id.HasValue)
                    {
                        SetObject(guid_bm_stage_lookup_string, guid_bm_stage_string, "X_Parameter", "Metadata Stage", "System.Guid");
                        guid_bm_stage_id = new Guid(guid_bm_stage_string);
                    }
                }
                return guid_bm_stage_id.Value;
            }
            set
            {
                guid_bm_stage_id = value;
            }
        }
        
    }
}