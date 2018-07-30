using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
using TaskAndBugLogger.Interfaces;
using TaskAndBugLogger.Models;

namespace TaskAndBugLogger.Data
{
    public class WorkItemService : IWorkItemService
    {
        private readonly MongoDBRepository mongoDBRepo;

        public WorkItemService(IOptions<Settings> settings)
        {
            mongoDBRepo = new MongoDBRepository(settings);
        }

        public IEnumerable<WorkItem> GetAllWorkItems()
        {
            return mongoDBRepo.WorkItems.Find(x => true).ToList();
        }
    }
}
