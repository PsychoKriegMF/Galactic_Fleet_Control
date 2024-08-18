namespace Galactic_Fleet_Control
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Cоздаем флот и командующего
            var fleet = new CommandFleet("Михаил", "Адмирал", 20);
            // Добавляем корабли
            fleet.AddSpaceShip(new SpaceShip(1, "Вояджер", "Исследователь", 10000));
            fleet.AddSpaceShip(new SpaceShip(2, "Милано", "Штурмовик", 20000));

            //Создание миссии
            fleet.AssignMission(2, new Mission(1, "Исследование космоса", "Марс", DateTime.Now));

            //Поиск краблей
            var searchResult = fleet.SearchSpaceShips(model: "Милано");

            // Вывод Json
            string jsonSpaceShips = JsonOperations.SerializeSpaceShips(searchResult);
            string jsonMissions = JsonOperations.SerializeMissins(fleet.missions);

            // Десериализация из json
            var deserializedShips = JsonOperations.DeserializeSpaceShips(jsonSpaceShips);
            var deserializedMissions = JsonOperations.DeserializeMissions(jsonMissions);
        }
    }
}
