//using System;
//using System.Collections.Generic;


//namespace DesignPatterns
//{ 

//public class Task
//    {
//        public int Id { get; set; }
//        public string Title { get; set; }
//        public bool IsCompleted { get; set; }
//    }
    

//    public class TaskRepository
//    {
//        private List<Task> _tasks = new List<Task>();

//        public void Add(Task task)
//        {
//            _tasks.Add(task);
//        }

//        public void Update(Task task)
//        {
//            int index = _tasks.FindIndex(t => t.Id == task.Id);
//            if (index != -1)
//            {
//                _tasks[index] = task;
//            }
//        }

       

//        public Task GetByid(int taskid)
//        {
//            return _tasks.Find(copy => copy.Id == taskid);
//        }

//        internal Task GetById(int taskid)
//        {
//            throw new NotImplementedException();
//        }
//    }

//    public class UnitOfWork
//    {
//        private TaskRepository _taskRepository;

//        public UnitOfWork()
//        {
//        }

//        public UnitOfWork(TaskRepository taskRepository)
//        {
//            _taskRepository = taskRepository;
//        }

//        public void CompleteTask(int taskid)
//        {
//            Task task = _taskRepository.GetById(taskid);
//            if (task != null)
//            {
//                task.IsCompleted = true;
//                _taskRepository.Update(task);
//            }
//        }
//    }
//    }

    

