using DesktopAssistant.domain;
using DesktopAssistant.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesktopAssistant.service.task.impl
{
    class TaskServiceImpl : TaskService
    {

        private static TaskServiceImpl taskService = new TaskServiceImpl();

        TaskDAO taskDAO;

        public List<Task> getAll()
        {
            List<Task> tasks = taskDAO.getAll();

            tasks.Sort((t1, t2) => {
                return t1.EndTime - t2.EndTime;
            });

            return tasks;
        }

        private TaskServiceImpl()
        {
            taskDAO = new TaskDAO();
        }


        public static TaskServiceImpl getTaskService()
        {
            return taskService;
        }


    }
}
