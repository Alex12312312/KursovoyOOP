using LW1.Models.Db;
using LW1.Models.Service;

namespace LW1.Repositories.Interfaces;
/// <summary>
/// Интерфейс класса, выполняющего запросы в базу данных
/// </summary>
public interface ITransportRepository
{   /// <summary>
    /// Запрос на получение всех объектов из базы данных
    /// </summary>
    /// <returns>Список всех автобусов в базе данных</returns>
    Task<List<Transport>> GetAll();
    /// <summary>
    /// Запрос на получение автобуса по его Id
    /// </summary>
    /// <param name="id"></param>
    /// <returns>Автобус с данным Id</returns>
    Task<Transport> GetById(int id);
    /// <summary>
    /// Запрос на получение автобуса по параметрам
    /// </summary>
    /// <param name="model">Модель искомого автобуса</param>
    /// <param name="route">Маршрут искомого автобуса</param>
    /// <returns>Список автобусов, соответствующих параметрам</returns>
    Task<List<Transport>> GetByParams(string model, string route);
    /// <summary>
    /// Запрос на добавление автобуса в базу данных
    /// </summary>
    /// <param name="dbTransport">Объект добавляемого автобуса</param>
    /// <returns></returns>
    Task<Transport> Add(DbTransport dbTransport);
    /// <summary>
    /// Запрос за обновление данных об автобусе
    /// </summary>
    /// <param name="dbTransport">Обновленные данные об автобусе</param>
    /// <returns></returns>
    Task<Transport> Update(DbTransport dbTransport);
    /// <summary>
    /// Запрос на удаление автобуса из базы данных
    /// </summary>
    /// <param name="id">Id удаляемого автобуса</param>
    /// <returns></returns>
    Task Delete(int id);
    /// <summary>
    /// Запрос на очистку базы данных
    /// </summary>
    /// <returns></returns>
    Task ClearDB();
}