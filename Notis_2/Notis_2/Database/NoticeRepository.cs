using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Notis_2.Database
{
    public class NoticeRepository
    {
        SQLiteConnection database;
        public NoticeRepository(string databasePath)
        {
            database = new SQLiteConnection(databasePath);
            database.CreateTable<Notices>();
        }
        public IEnumerable<Notices> GetItems()
        {
            return database.Table<Notices>().ToList();
        }
        public Notices GetItem(int id)
        {
            return database.Get<Notices>(id);
        }
        public int DeleteItem(int id)
        {
            return database.Delete<Notices>(id);
        }
        public int SaveItem(Notices item)
        {
            if (item.Id != 0)
            {
                database.Update(item);
                return item.Id;
            }
            else
            {
                return database.Insert(item);
            }
        }
    }
}
