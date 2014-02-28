using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EXPEDIT.Geology.Models;
using Orchard.ContentManagement.Handlers;
using Orchard.Data;

namespace EXPEDIT.Geology.Handlers
{
    public class BlockModelHandler : ContentHandler
    {
        public BlockModelHandler(IRepository<BlockModelPartRecord> repository)
        {
            Filters.Add(StorageFilter.For(repository));
            Filters.Add(new ActivatingFilter<BlockModelPart>("BlockModel"));
        }
    }

}