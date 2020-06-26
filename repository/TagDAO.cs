using DesktopAssistant.bases.utils;
using DesktopAssistant.domain;
using DesktopAssistant.global.config;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAssistant.repository
{
    public class TagDAO
    {

        //数据库操作对象
        SqliteCommand cmd = SqliteConnecter.getSqliteCommand();

        private string TaskColumn = "id, name";

        public Tag getById(int id)
        {
            cmd.Parameters.Clear();
        
            cmd.CommandText = "SELECT * FROM tag WHERE id=@id";
            cmd.Parameters.Add("id", SqliteType.Integer).Value = id;

            SqliteDataReader reader = cmd.ExecuteReader();

            Tag tag = ModelUtils.ReaderToModel<Tag>(reader);

            return tag;
        }

        public List<Tag> getAll()
        {
            cmd.CommandText = "SELECT * FROM tag";

            SqliteDataReader reader = cmd.ExecuteReader();

            List<Tag> tags = ModelUtils.ReaderToModelList<Tag>(reader);

            return tags;
        }

    }
}
