﻿using MongoDB.Bson;

namespace TaskAndBugLogger.Models
{
    public class WorkItem
    {
        public ObjectId Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Severity { get; set; }
        public string WorkItemType { get; set; }
        public string AssignedTo { get; set; }
    }
}
