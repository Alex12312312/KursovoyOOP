using System.Data;
using Dapper;
using Microsoft.Data.Sqlite;

namespace LW1.Data;

/// <summary>
/// Класс, отвечающий за доступ к базе данных
/// </summary>
public class DataContext
{
    /// <summary>
    /// Строка открытия базы данных
    /// </summary>
    private string connectionString;
    
    /// <summary>
    /// Конструктор класса DataContext
    /// </summary>
    public DataContext()
    {
        connectionString = "Data Source=database.db";
    }

    /// <summary>
    /// Создание подключения к базе данных
    /// </summary>
    /// <returns>Объект класса SqliteConnection</returns>
    public IDbConnection CreateConnection()
    {
        return new SqliteConnection(connectionString);
    }

    /// <summary>
    /// Создание и подключение таблицы Transport
    /// </summary>
    /// <returns></returns>
    public async Task Init()
    {
        using var connection = CreateConnection();
        
        await initAirports();
        
        async Task initAirports()
        {
            var sql = """
                          CREATE TABLE IF NOT EXISTS
                          Transports (
                              Id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                              Model TEXT,
                              Name TEXT,
                              Surname TEXT,
                              Patronymic TEXT,
                              Route TEXT,
                              Mileage INTEGER
                          );
                      """;
            await connection.ExecuteAsync(sql);
        }
    }
}