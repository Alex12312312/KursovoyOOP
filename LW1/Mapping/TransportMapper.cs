using LW1.Models.Db;
using LW1.Models.Service;

namespace LW1.Mapping;

/// <summary>
/// Класс выполняющий преобразование объектов классов
/// </summary>
public static class TransportMapper
{
    /// <summary>
    /// Преобразование объекта полученного из базы данных в объект класса Транспорт
    /// </summary>
    /// <param name="service">Объект полученный из базы данных</param>
    /// <returns>Объект класса Transport для взаимодействия в приложении</returns>
    public static Transport MapToService(this DbTransport service)
    {
        return service == null
            ? null
            : new Transport(service.Id, service.Model, service.Name, service.Surname, service.Patronymic,
                service.Route, service.Mileage);
    }

    /// <summary>
    /// Преобразование объектов полученных из базы данных в список объектов класса Транспорт
    /// </summary>
    /// <param name="db">Список полученных из базы данных объектов</param>
    /// <returns>Список автобусов для взаимодействия в приложении</returns>
    public static List<Transport> MapToService(this IEnumerable<DbTransport> db)
    {
        return db == null ? new List<Transport>() : db.Where(da => da != null).Select(da => da.MapToService()).ToList();
    }
    
    /// <summary>
    /// Преобразование объекта Транспорт для работы с базой данных
    /// </summary>
    /// <param name="service">Объект класса Транспорт, требующий взаимодействия с базой данных</param>
    /// <returns>Объект класса Transport для отправки в базу данных</returns>
    public static DbTransport MapToDb(this Transport service)
    {
        return service == null
            ? null
            : new DbTransport
            {
                Id = service.Id,
                Model = service.Model.ToUpper(),
                Name = service.Name.ToUpper(),
                Surname = service.Surname.ToUpper(),
                Patronymic = service.Patronymic.ToUpper(),
                Route = service.Route.ToUpper(),
                Mileage = service.Mileage
            };
    }

    /// <summary>
    /// Подготовка списка объектов класса Транспорт к работе с базой данных
    /// </summary>
    /// <param name="service">Контейнер объектов класса Транспорт</param>
    /// <returns>Список автобусов для отправки в базу данных</returns>
    public static List<DbTransport> MapToDb(this IEnumerable<Transport> service)
    {
        return service == null ? new List<DbTransport>() : service.Where(a => a != null).Select(a => a.MapToDb()).ToList();
    }
}