using LW1.Mapping;
using LW1.Models.Service;
using LW1.Repositories.Interfaces;
using LW1.Services.Interfaces;

namespace LW1.Services;
/// <summary>
/// Сервис для работы с базой данных
/// </summary>
public class TransportService : ITransportService
{
    private ITransportRepository TransportRepository;

    /// <summary>
    /// Конструктор сервиса
    /// </summary>
    /// <param name="TransportRepository">объект класса TransportRepository</param>
    public TransportService(ITransportRepository TransportRepository)
    {
        this.TransportRepository = TransportRepository;
    }
    
    /// <summary>
    /// Получение всех имеющихся в базе данных автобусов
    /// </summary>
    /// <returns>Список автобусов</returns>
    public async Task<List<Transport>> GetAll()
    {
        return await TransportRepository.GetAll();
    }

    /// <summary>
    /// Получение одного автобуса по его id
    /// </summary>
    /// <param name="id"></param>
    /// <returns>Автобус с указанным Id</returns>
    public async Task<Transport> GetById(int id)
    {
        return await TransportRepository.GetById(id);
    }

    /// <summary>
    /// Поиск автобусов по параметрам
    /// </summary>
    /// <param name="model"></param>
    /// <param name="route"></param>
    /// <returns>Список автобусов с заданными параметрами</returns>
    public async Task<List<Transport>> GetByParametrs(string model = "", string route = "")
    {
        return await TransportRepository.GetByParams(model, route);
    }

    /// <summary>
    /// Добавление автобуса в базу данных
    /// </summary>
    /// <param name="Transport">Добавляемый автобус</param>
    /// <returns></returns>
    public async Task<Transport> Add(Transport Transport)
    {
        var dbTransport = Transport.MapToDb();
        return await TransportRepository.Add(dbTransport);
    }

    /// <summary>
    /// Обновление информации об автобусе
    /// </summary>
    /// <param name="Transport">Обновленная информация об автобусе</param>
    /// <returns></returns>
    public async Task<Transport> Update(Transport Transport)
    {
        var dbTransport = Transport.MapToDb();
        return await TransportRepository.Update(dbTransport);
    }

    /// <summary>
    /// Удаление автобуса из базы данных
    /// </summary>
    /// <param name="id">Id удаляемого автобуса</param>
    /// <returns></returns>
    public async Task Delete(int id)
    {
        await TransportRepository.Delete(id);
    }

    /// <summary>
    /// Очистка базы данных
    /// </summary>
    /// <returns></returns>
    public async Task ClearDB()
    {
        await TransportRepository.ClearDB();
    }
}