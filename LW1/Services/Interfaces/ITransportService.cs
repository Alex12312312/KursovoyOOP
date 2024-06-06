using LW1.Models.Service;

namespace LW1.Services.Interfaces;

/// <summary>
/// Интерфейс класса-преобразователя типов
/// </summary>
public interface ITransportService
{
    /// <summary>
    /// Получение всех автобусов из базы данных
    /// </summary>
    /// <returns>Список всех автобусов</returns>
    Task<List<Transport>> GetAll();
    /// <summary>
    /// Получение автобуса по id
    /// </summary>
    /// <param name="id">Id искомого автобуса</param>
    /// <returns>Автобус с указанным id</returns>
    Task<Transport> GetById(int id);
    /// <summary>
    /// Добавление автобуса в базу данных
    /// </summary>
    /// <param name="Transport">Новый автобус</param>
    /// <returns></returns>
    Task<Transport> Add(Transport Transport);
    /// <summary>
    /// Получение автобусов с заданными параметрами
    /// </summary>
    /// <param name="model">Модель автобусов</param>
    /// <param name="route">Маршрут автобусов</param>
    /// <returns>Список автобусов с указанными параметрами</returns>
    Task<List<Transport>> GetByParametrs(string model = "", string route = "");
    /// <summary>
    /// Обновление информации об автобусе
    /// </summary>
    /// <param name="Transport">Обновленная информация об автобусе</param>
    /// <returns></returns>
    Task<Transport> Update(Transport Transport);
    /// <summary>
    /// Удаление автобуса с заданным id
    /// </summary>
    /// <param name="id">id удаляемого автобуса</param>
    /// <returns></returns>
    Task Delete(int id);
    /// <summary>
    /// Очистка базы данных
    /// </summary>
    /// <returns></returns>
    Task ClearDB();
}