using System;
using System.Text.Json;
using System.Threading.Tasks;

namespace ProtoTinkr
{
    public class PlayerManager
    {
        public PlayerProfile _playerProfile { get; private set; }

        public delegate void OnUserUpdate(object sender, EventArgs e);
        public event OnUserUpdate UserUpdated;
        public void SetActiveUserFromJsonElement(JsonElement jsonAnswer)
        {
            _playerProfile = JsonSerializer.Deserialize<PlayerProfile>(jsonAnswer.GetProperty("user").ToString() ?? throw new InvalidOperationException("The Get Active User answer is null"));
            Console.WriteLine("Setting Active User. Ready for Event.");
            UserUpdated?.Invoke(this, new EventArgs());
        }
    }
}