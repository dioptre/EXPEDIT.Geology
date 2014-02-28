using System;
using System.Collections.Generic;
using System.IO;
using System.Web;
using Orchard;
using NKD.Models;
using System.ServiceModel;
using NKD.ViewModels;
using NKD.Module.BusinessObjects;
using EXPEDIT.Geology.ViewModels;

namespace EXPEDIT.Geology.Services
{
    [ServiceContract]
    public interface IProjectsService : IDependency {

        [OperationContract]
        IEnumerable<Project> GetProjects();

        [OperationContract]
        IEnumerable<ProjectPlanTask> GetStages(Guid projectID);

        [OperationContract]
        void DeleteProject(Guid projectID, Guid contactID);

        [OperationContract]
        void EmailAllProjectOwners(string subject, string body);

        [OperationContract]
        void UpdateProject(ProjectViewModel m);

        [OperationContract]
        void CreateProject(Project o);

    }
}