using System.Collections.Generic;
using TaskAndBugLogger.Models;

namespace TaskAndBugLogger.Interfaces
{
    public interface IWorkItemService
    {
        IEnumerable<WorkItem> GetAllWorkItems();
        void InsertWorkItem(WorkItem workItem);
    }
}
