namespace LW1.Models.Service;

/// <summary>
/// Основной класс, хранящий всю информацию об автобусе
/// </summary>
public class Transport
{
    /// <summary>
    /// Счётчик объектов класса Transport
    /// </summary>
    public static int ObjectsCounter = 0;
    
    /// <summary>
    /// Идентификационный номер автобуса
    /// </summary>
    public int Id { get; set; }
    /// <summary>
    /// Модель автобуса
    /// </summary>
    public string Model { get; set; }
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

    /// <summary>
    /// Конструктор по умолчанию
    /// </summary>
    public Transport()
    {
        Id = 0;
        Model = string.Empty;
        Name = string.Empty;
        Surname = string.Empty;
        Patronymic = string.Empty;
        Route = string.Empty;
        Mileage = 0;
    }

    /// <summary>
    /// Конструктор с параметрами модель и пробег
    /// </summary>
    /// <param name="model">Модель автобуса</param>
    /// <param name="mileage">Пробег автобуса</param>
    public Transport(string model, int mileage)
    {
        Id = 0;
        Model = model.ToUpper();
        Name = string.Empty;
        Surname = string.Empty;
        Patronymic = string.Empty;
        Route = string.Empty;
        Mileage = mileage;
    }

    /// <summary>
    /// Конструктор со всеми параметрами
    /// </summary>
    /// <param name="id">id автобуса</param>
    /// <param name="model">Модель автобуса</param>
    /// <param name="name">Имя водителя</param>
    /// <param name="surname">Фамилия водителя</param>
    /// <param name="patronymic">Отчество водителя</param>
    /// <param name="route">Маршрут автобуса</param>
    /// <param name="mileage">Пробег автобуса</param>
    public Transport(int id, string model, string name, string surname, string patronymic,
        string route, int mileage)
    {
        Id = id;
        Model = model.ToUpper();
        Name = name.ToUpper();
        Surname = surname.ToUpper();
        Patronymic = patronymic.ToUpper();
        Route = route.ToUpper();
        Mileage = mileage;
    }

    /// <summary>
    /// Приведение данных об автобусе в строчный вид
    /// </summary>
    /// <returns>Строка с данными об автобусе</returns>
    public override string ToString()
    {
        return $"{Id} | {Name} | {Model}| {Name} | {Surname} | {Patronymic} | {Route} | {Mileage} ";
    }
}