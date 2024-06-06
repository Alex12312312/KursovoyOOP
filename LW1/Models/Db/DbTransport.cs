namespace LW1.Models.Db;

/// <summary>
/// Класс, используемый для передачи объектов класса Транспорт в базу данных
/// </summary>
public class DbTransport
{
    /// <summary>
    /// id автобуса
    /// </summary>
    public int Id { get; set; }
    /// <summary>
    /// Модель автобуса
    /// </summary>
    public string Model { get; set; } = string.Empty;
    /// <summary>
    /// Имя водителя
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// Фамилия водителя
    /// </summary>
    public string Surname { get; set; }
    /// <summary>
    /// Отчество водителя
    /// </summary>
    public string Patronymic { get; set; }
    /// <summary>
    /// Маршрут автобуса
    /// </summary>
    public string Route { get; set; }
    /// <summary>
    /// Пробег автобуса
    /// </summary>
    public int Mileage { get; set; }
}