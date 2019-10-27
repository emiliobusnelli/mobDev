using System;
using SQLite.Net;

namespace MovieApp.Custom
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
