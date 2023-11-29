

namespace GregsListDotNet.Repositories
{
    public class CarsRepository
    {
        private readonly IDbConnection _db;

        public CarsRepository(IDbConnection db)
        {
            _db = db;
        }

        internal List<Car> GetCars()
        {
            string sql = "SELECT * FROM cars;";
            List<Car> cars = _db.Query<Car>(sql).ToList();
            return cars;
        }

        internal Car GetCarsById(int carId)
        {
            string sql = "SELECT * FROM cars WHERE id = @carId;";

            Car car = _db.Query<Car>(sql, new { carId }).FirstOrDefault();
            return car;
        }

        internal void UpdateCar(Car ogCar)
        {
            string sql = @"
            UPDATE cars
            SET
            make = @Make,
            model = @Model,
            year = @Year
            ;";

            _db.Execute(sql, ogCar);
        }
    }
}