using DesktopAssistant.global.config;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DesktopAssistant.bases.utils;
using DesktopAssistant.domain;
using Microsoft.Data.Sqlite;

namespace DesktopAssistant.repository
{
    class TaskDAO
    {
        //数据库操作对象
        SqliteCommand cmd = SqliteConnecter.getSqliteCommand();

        private string TaskColumn = "id, start_time, end_time, progress, describe, detail, tag_id";

        public Task getById(int id)
        {

            cmd.CommandText = "SELECT * FORM task WHERE id = @id";
            cmd.Parameters.Add("id", SqliteType.Integer).Value = id;

            SqliteDataReader reader = cmd.ExecuteReader();

            Task task = ModelUtils.ReaderToModel<Task>(reader);

            return task;
        }

        public List<Task> getAll()
        {
            cmd.CommandText = "SELECT task.* FROM task where finish=false";

            SqliteDataReader reader = cmd.ExecuteReader();

            List<Task> tasks = ModelUtils.ReaderToModelList<Task>(reader);

            return tasks;
        }


        public void insert(Task task)
        {
            cmd.CommandText = "INSERT INTO task" + "(" + TaskColumn + ")" 
                + " VALUES(@Id, @StartTime, @EndTime, @Progress, @Describe, @Detail, @TagId)";

            cmd.Parameters.AddWithValue("Id", task.Id);
            cmd.Parameters.AddWithValue("StartTime", task.StartTime);
            cmd.Parameters.AddWithValue("EndTime", task.EndTime);
            cmd.Parameters.AddWithValue("Progress", task.Progress);
            cmd.Parameters.AddWithValue("Describe", task.Describe);
            cmd.Parameters.AddWithValue("Detail", task.Detail);
            cmd.Parameters.AddWithValue("TagId", task.TagId);

            cmd.ExecuteNonQuery();
        }

        public void update(Task task)
        {
            cmd.CommandText = "UPDATE task SET ";

            if (task.StartTime != 0)
            {
                cmd.CommandText += "start_time=@StartTime,";
                cmd.Parameters.AddWithValue("StartTime", task.StartTime);
            }
            if (task.EndTime != 0)
            {
                cmd.CommandText += "end_time=@EndTime,";
                cmd.Parameters.AddWithValue("EndTime", task.EndTime);
            }
            if(task.Progress != 0)
            {
                cmd.CommandText += "progress=@Progress,";
                cmd.Parameters.AddWithValue("Progress", task.Progress);
            }
            if (task.Describe != "")
            {
                cmd.CommandText += "describe=@Describe,";
                cmd.Parameters.AddWithValue("Describe", task.Describe);
            }
            if (task.Detail != "")
            {
                cmd.CommandText += "detail=@Detail,";
                cmd.Parameters.AddWithValue("Detail", task.Detail);
            }
            if (task.TagId != 0)
            {
                cmd.CommandText += "tag_id=@TagId,";
                cmd.Parameters.AddWithValue("TagId", task.TagId);
            }

            cmd.CommandText = cmd.CommandText.Substring(0, cmd.CommandText.Length-1);

            cmd.CommandText += " WHERE id=@id";
            cmd.Parameters.AddWithValue("id", task.Id);

            cmd.ExecuteNonQuery();

        }

    }
}
