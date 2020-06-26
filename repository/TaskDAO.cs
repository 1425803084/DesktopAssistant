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
            cmd.Parameters.Clear();

            cmd.CommandText = "SELECT * FORM task WHERE id = @id";
            cmd.Parameters.Add("id", SqliteType.Integer).Value = id;

            SqliteDataReader reader = cmd.ExecuteReader();

            Task task = ModelUtils.ReaderToModel<Task>(reader);

            return task;
        }

        public List<Task> getAll()
        {
            cmd.CommandText = "SELECT * FROM task where finish=false";

            SqliteDataReader reader = cmd.ExecuteReader();

            List<Task> tasks = ModelUtils.ReaderToModelList<Task>(reader);

            return tasks;
        }


        public void insert(Task task)
        {
            cmd.Parameters.Clear();

            cmd.CommandText = "INSERT INTO task" + "(" + TaskColumn + ")" 
                + " VALUES(@Id, @StartTime, @EndTime, @Progress, @Describe, @Detail, @TagId)";

            cmd.Parameters.Add("@Id", SqliteType.Integer).Value = task.Id;
            cmd.Parameters.Add("@StartTime", SqliteType.Integer).Value = task.StartTime;
            cmd.Parameters.Add("@EndTime", SqliteType.Integer).Value =task.EndTime;
            cmd.Parameters.Add("@Progress", SqliteType.Integer).Value =task.Progress;
            cmd.Parameters.Add("@Describe", SqliteType.Text).Value = task.Describe;
            cmd.Parameters.Add("@Detail", SqliteType.Text).Value = task.Detail;
            cmd.Parameters.Add("@TagId", SqliteType.Integer).Value = task.TagId;

            cmd.ExecuteNonQuery();
        }

        public void update(Task task)
        {
            cmd.Parameters.Clear();

            cmd.CommandText = "UPDATE task SET ";

            if (task.StartTime != 0)
            {
                cmd.CommandText += "start_time=@StartTime,";
                cmd.Parameters.Add("@StartTime", SqliteType.Integer).Value = task.StartTime;
            }
            if (task.EndTime != 0)
            {
                cmd.CommandText += "end_time=@EndTime,";
                cmd.Parameters.Add("@EndTime", SqliteType.Integer).Value = task.EndTime;
            }
            if(task.Progress != 0)
            {
                cmd.CommandText += "progress=@Progress,";
                cmd.Parameters.Add("@Progress", SqliteType.Integer).Value = task.Progress;
            }
            if (task.Describe != "")
            {
                cmd.CommandText += "describe=@Describe,";
                cmd.Parameters.Add("@Describe", SqliteType.Text).Value = task.Describe;
            }
            if (task.Detail != "")
            {
                cmd.CommandText += "detail=@Detail,";
                cmd.Parameters.Add("@Detail", SqliteType.Text).Value = task.Detail;
            }
            if (task.TagId != 0)
            {
                cmd.CommandText += "tag_id=@TagId,";
                cmd.Parameters.Add("@TagId", SqliteType.Integer).Value = task.TagId;
            }
            
            cmd.CommandText += "finish=@Finish,";
            cmd.Parameters.Add("@Finish", SqliteType.Integer).Value = task.Finish;
            
            cmd.CommandText = cmd.CommandText.Substring(0, cmd.CommandText.Length-1);

            cmd.CommandText += " WHERE id=@id";
            cmd.Parameters.Add("@id", SqliteType.Integer).Value = task.Id;

            cmd.ExecuteNonQuery();

        }

    }
}
