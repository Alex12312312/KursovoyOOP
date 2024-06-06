using Dapper;
using LW1.Data;
using LW1.Mapping;
using LW1.Models.Db;
using LW1.Models.Service;
using LW1.Repositories.Interfaces;

namespace LW1.Repositories;

/// <summary>
/// Класс, выполняющий запросы в базу данных
/// </summary>
public class TransportRepository : ITransportRepository
{
    private DataContext context;

    /// <summary>
    /// Конструктор класса TransportRepository
    /// </summary>
    /// <param name="context"></param>
    public TransportRepository(DataContext context)
    {
        this.context = context;
    }
    
    /// <summary>
    /// Запрос на получение всех объектов из базы данных
    /// </summary>
    /// <returns>Список всех автобусов в базе данных</returns>
    public async Task<List<Transport>> GetAll()
    {
        using var connection = context.CreateConnection();
        var sql = """
                  SELECT * FROM Transports
                  """;
        return (await connection.QueryAsync<DbTransport>(sql)).MapToService();
    }

    /// <summary>
    /// Запрос на получение автобуса по его Id
    /// </summary>
    /// <param name="id"></param>
    /// <returns>Автобус с данным Id</returns>
    public async Task<Transport> GetById(int id)
    {
        using var connection = context.CreateConnection();
        var sql = """
                  SELECT * FROM Transports WHERE Id = @Id
                  """;
        var parameters = new { Id = id };
        return (await connection.QueryFirstOrDefaultAsync<DbTransport>(sql, parameters)).MapToService();
    }

    /// <summary>
    /// Запрос на получение автобуса по параметрам
    /// </summary>
    /// <param name="model">Модель искомого автобуса</param>
    /// <param name="route">Маршрут искомого автобуса</param>
    /// <returns>Список автобусов, соответствующих параметрам</returns>
    public async Task<List<Transport>> GetByParams(string model = "", string route = "")
    {
        using var connection = context.CreateConnection();
        string requestParams = "";
        int paramCounter = 0;
        if (model == "" && route == "") return null;
        if(model != "")
        {
            paramCounter++;
            requestParams += $"Model = @Model";
        }
        if(route != "")
        {
            if (paramCounter == 1) requestParams += " AND ";
            requestParams += $"Route = @Route";
        }
        var sql = $"""
                  SELECT * FROM Transports WHERE {requestParams}
                  """;
        var parameters = new { Model = model.ToUpper(), Route = route.ToUpper() };
        return (await connection.QueryAsync<DbTransport>(sql, parameters)).MapToService();
    }

    /// <summary>
    /// Запрос на добавление автобуса в базу данных
    /// </summary>
    /// <param name="dbTransport">Объект добавляемого автобуса</param>
    /// <returns></returns>
    public async Task<Transport> Add(DbTransport dbTransport)
    {
        using var connection = context.CreateConnection();
        var sql = """
                  INSERT INTO Transports (Model, Name, Surname, Patronymic, Route, Mileage)
                  VALUES (@Model, @Name, @Surname, @Patronymic, @Route, @Mileage)
                  RETURNING *
                  """;
        return (await connection.QuerySingleOrDefaultAsync<DbTransport>(sql, dbTransport)).MapToService();
    }

    /// <summary>
    /// Запрос за обновление данных об автобусе
    /// </summary>
    /// <param name="dbTransport">Обновленные данные об автобусе</param>
    /// <returns></returns>
    public async Task<Transport> Update(DbTransport dbTransport)
    {
        using var connection = context.CreateConnection();
        var sql = """
                  UPDATE Transports
                  SET Model = @Model,
                      Name = @Name,
                      Surname = @Surname,
                      Patronymic = @Patronymic,
                      Route = @Route,
                      Mileage = @Mileage
                  WHERE Id = @Id
                  RETURNING *
                  """;
        return (await connection.QuerySingleOrDefaultAsync<DbTransport>(sql, dbTransport)).MapToService();
    }

    /// <summary>
    /// Запрос на удаление автобуса из базы данных
    /// </summary>
    /// <param name="id">Id удаляемого автобуса</param>
    /// <returns></returns>
    public async Task Delete(int id)
    {
        using var connection = context.CreateConnection();
        var sql = """
                  DELETE FROM Transports WHERE Id = @Id
                  """;
        var parameters = new { Id = id };
        await connection.ExecuteAsync(sql, parameters);
    }

    /// <summary>
    /// Запрос на очистку базы данных
    /// </summary>
    /// <returns></returns>
    public async Task ClearDB()
    {
        using var connection = context.CreateConnection();
        var sql = """
                  DELETE FROM Transports
                  """;
        await connection.ExecuteAsync(sql);
    }
}