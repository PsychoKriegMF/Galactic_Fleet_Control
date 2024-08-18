using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Galactic_Fleet_Control
{
    public class JsonOperations
    {
        public static string SerializeSpaceShips(List<SpaceShip> spaceShips)
        {
            return JsonSerializer.Serialize(spaceShips);
        }
        public static List<SpaceShip> DeserializeSpaceShips(string json)
        {
            return JsonSerializer.Deserialize<List<SpaceShip>>(json);
        }
        public static string SerializeMissins(Dictionary<int, List<Mission>> missions) 
        
        {
            return JsonSerializer.Serialize(missions);
        }
        public static Dictionary<int, List<Mission>> DeserializeMissions(string json)
        {
            return JsonSerializer.Deserialize<Dictionary<int, List<Mission>>>(json);
        }
    }
}
