

namespace GregsListDotNet.Services
{
    public class CarsService
    {

        private readonly CarsRepository _repository;
        public CarsService(CarsRepository repository)
        {
            _repository = repository;
        }

        internal Car GetCarById(int carId)
        {
            Car car = _repository.GetCarsById(carId);
            if (car == null)
            {
                throw new Exception("Invalid Id");
            }
            return car;
        }

        internal List<Car> GetCars()
        {
            List<Car> cars = _repository.GetCars();
            return cars;

        }

        internal Car UpdateCar(int carId, Car carData)
        {
            Car ogCar = GetCarById(carId);
            ogCar.Model = carData.Model ?? ogCar.Model;
            ogCar.Make = carData.Make ?? ogCar.Make;
            ogCar.Year = carData.Year ?? ogCar.Year;

            _repository.UpdateCar(ogCar);
            return ogCar;
        }
    }
}