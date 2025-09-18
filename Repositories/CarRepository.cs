using FleetManager.Models;

namespace FleetManager.Data

{
    public class CarRepository
    {
        private readonly List<Car> _cars;

        public CarRepository()
        {
            _cars = GenerateMockCars();
        }

        public List<Car> GetAllCars()
        {
            return _cars;
        }

        private List<Car> GenerateMockCars()
        {
            var cars = new List<Car>();
            var makes = new[] { "Toyota", "Honda", "Ford", "Chevrolet", "BMW" };
            var models = new[] { "Corolla", "Civic", "Focus", "Cruze", "3 Series" };
            var colors = new[] { "Red", "Blue", "Black", "White", "Silver" };
            var rnd = new Random();

            for (int i = 1; i <= 25; i++)
            {
                cars.Add(new Car
                {
                    Id = i,
                    Make = makes[rnd.Next(makes.Length)],
                    Model = models[rnd.Next(models.Length)],
                    Year = rnd.Next(2015, 2024),
                    Color = colors[rnd.Next(colors.Length)],
                    Mileage = rnd.Next(10_000, 150_000)
                });
            }

            return cars;
        }
    }
}
