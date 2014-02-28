using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Orchard;
using Orchard.Settings;
using Orchard.Tasks.Scheduling;
using Orchard.ContentManagement;
using System.Transactions;
using System.Threading.Tasks;
using Autofac.Integration.Mvc;
using System.Dynamic;
using NKD.Models;
using NKD.Services;

namespace EXPEDIT.Geology.Helpers
{
    public static class TaskHelper
    {      
        public static void ProcessModelAsync(this IScheduledTaskManager _taskManager, ContentItem contentItem)
        {
            var tasks = _taskManager.GetTasks(Services.ProcessModelScheduledTaskHandler.TASK_TYPE_PROCESS_MODEL);
            if (tasks == null || tasks.Count() < 100)
                _taskManager.CreateTask(Services.ProcessModelScheduledTaskHandler.TASK_TYPE_PROCESS_MODEL, DateTime.UtcNow, contentItem);
        }
    
        public static void AppendModelAsync(this IScheduledTaskManager _taskManager, ContentItem contentItem)
        {
            var tasks = _taskManager.GetTasks(Services.AppendModelScheduledTaskHandler.TASK_TYPE_APPEND_MODEL);
            if (tasks == null || tasks.Count() < 100)
                _taskManager.CreateTask(Services.AppendModelScheduledTaskHandler.TASK_TYPE_APPEND_MODEL, DateTime.UtcNow, contentItem);
        }    

     
    }

}