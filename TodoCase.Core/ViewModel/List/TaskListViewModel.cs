using System;
using System.Collections.Generic;
using System.Text;
using TodoCase.Core.Entities;
using TodoCase.Core.Enums;

namespace TodoCase.Core.ViewModel
{
    public class TaskListViewModel
    {
        public Task Task { get; set; }
        public IEnumerable<Person> PersonList { get; set; }
        public TaskStatus TaskStatus { get; set; }
    }
}
