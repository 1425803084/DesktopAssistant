using DesktopAssistant.global.config;
using System.Data.SQLite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DesktopAssistant.bases.utils;
using DesktopAssistant.domain;

namespace DesktopAssistant.repository
{
    class TaskDAO
    {
        //数据库操作对象
        SQLiteCommand cmd = SqliteConnecter.getSqliteCommand();

        private string TaskColumn = "id, start_time, end_time, progress, describe, detail, tag_id";

        public Task getById(int id)
        {

            cmd.CommandText = "SELECT * FORM task WHERE id = @id";
            cmd.Parameters.Add("id", DbType.Int32).Value = id;

            SQLiteDataReader reader = cmd.ExecuteReader();

            Task task = ModelUtils.ReaderToModel<Task>(reader);

            return task;
        }

        public List<Task> getAll()
        {
            cmd.CommandText = "SELECT task.* FROM task";

            SQLiteDataReader reader = cmd.ExecuteReader();

            List<Task> tasks = ModelUtils.ReaderToModelList<Task>(reader);

            return tasks;
        }


        public int insert(Task task)
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

            SQLiteDataReader reader = cmd.ExecuteReader();

            using (reader)
            {
                return reader.GetInt32(0);
            }
        }

        public void update(Task task)
        {
            cmd.CommandText = "UPDATE take SET ";

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

        }

    }
}
