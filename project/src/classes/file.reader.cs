using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Cars
{
    public static class FileReader
    {

        public static List<Car> readCars(string path)
        {
            var res = File.ReadAllLines(path)
            .Skip(1)
            .Where(line => line.Length > 1)
            .Select(transformToCar)
            .ToList();
            return res;
        }
        public static List<Manufacturer> readManufactures(string path)
        {
            var res = File.ReadAllLines(path)
            .Skip(1)
            .Where(line => line.Length > 1)
            .Select(transformToManufactures)
            .ToList();
            return res;
        }

        private static Manufacturer transformToManufactures(string line)
        {
            var columns = line.Split(',');
            return new Manufacturer
            {
                Name = columns[0],
                Headquarters = columns[1],
                Year = int.Parse(columns[2]),
            };
        }

        private static Car transformToCar(string line)
        {
            var columns = line.Split(',');
            return new Car
            {
                Year = int.Parse(columns[0]),
                Manufacturer = columns[1],
                Name = columns[2],
                Displacement = double.Parse(columns[3]),
                Cylinders = int.Parse(columns[4]),
                City = int.Parse(columns[5]),
                Highway = int.Parse(columns[6]),
                Combined = int.Parse(columns[7]),
            };
        }
    }
}