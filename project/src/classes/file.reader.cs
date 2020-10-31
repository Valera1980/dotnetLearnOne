using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Cars
{
    public class FileReader
    {
        private string _path;

        public FileReader(string path)
        {
            _path = path;
        }
        public List<Car> read()
        {
            var res = File.ReadAllLines(_path)
            .Skip(1)
            .Where(line => line.Length > 1)
            .Select(transformToCar)
            .ToList();
            return res;
        }

        private Car transformToCar(string line)
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