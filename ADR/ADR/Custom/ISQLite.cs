using System;
using SQLite;

namespace ADR.Custom
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
