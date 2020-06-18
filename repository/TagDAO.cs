using DesktopAssistant.bases.utils;
using DesktopAssistant.domain;
using DesktopAssistant.global.config;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAssistant.repository
{
    class TagDAO
    {

        private string TaskColumn = "id, name";

        //数据库操作对象
        SQLiteCommand cmd = SqliteConnecter.getSqliteCommand();

        public Tag getById(int id)
        {
            cmd.CommandText = "SELECT * FORM tag WHERE id = @id";
            cmd.Parameters.Add("id", DbType.Int32).Value = id;

            SQLiteDataReader reader = cmd.ExecuteReader();

            Tag tag = ModelUtils.ReaderToModel<Tag>(reader);

            return tag;
        }

        public List<Tag> getAll()
        {
            cmd.CommandText = "SELECT * FROM tag";

            SQLiteDataReader reader = cmd.ExecuteReader();

            List<Tag> tags = ModelUtils.ReaderToModelList<Tag>(reader);

            return tags;
        }

    }
}
