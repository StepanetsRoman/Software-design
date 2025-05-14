
namespace Mediator
{
    public class Aircraft
    {
        private string id;
        private CommandCentre mediator;

        public Aircraft(string id, CommandCentre mediator)
        {
            this.id = id;
            this.mediator = mediator;
            mediator.RegisterAircraft(this);
        }

        public void RequestLanding()
        {
            Console.WriteLine($"Літак {id} запитує посадку...");
            mediator.RequestRunway(this);
        }

        public void Land(string runwayId)
        {
            Console.WriteLine($"Літак {id} сідає на злітну смугу {runwayId}");
        }

        public string Id => id;
    }

    public class Runway
    {
        public string Id { get; }
        public bool IsAvailable { get; set; } = true;

        public Runway(string id) => Id = id;
    }

    public class CommandCentre
    {
        private List<Aircraft> aircrafts = new();
        private List<Runway> runways = new();

        public void RegisterAircraft(Aircraft aircraft) => aircrafts.Add(aircraft);
        public void AddRunway(Runway runway) => runways.Add(runway);

        public void RequestRunway(Aircraft aircraft)
        {
            var available = runways.FirstOrDefault(r => r.IsAvailable);
            if (available != null)
            {
                available.IsAvailable = false;
                aircraft.Land(available.Id);
            }
            else
            {
                Console.WriteLine($"Немає вільної смуги для {aircraft.Id}");
            }
        }
    }
}
