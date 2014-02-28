using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Autofac;
using System.Web.Mvc;

namespace EXPEDIT.Geology
{
    public class Module : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            ModelValidatorProviders.Providers.Clear();
            ModelValidatorProviders.Providers.Add(new DataAnnotationsModelValidatorProvider());
            ModelValidatorProviders.Providers.Add(new DataErrorInfoModelValidatorProvider());
            ModelValidatorProviders.Providers.Add(new ClientDataTypeModelValidatorProvider());
        }
    }
}