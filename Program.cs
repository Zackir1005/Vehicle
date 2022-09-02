using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle {
    class Vehicle {
        public Vehicle() {
            Name = "Самокат";
            NumOfWheel = 2;
            Color = "Синий";
            Motor = "Электрический двигатель";
            Action = "Едет";
        }
        public void Print() {
            Console.WriteLine("{0} {1}, {2} на {3} колёсах, источник движения - {4}",Color, Name, Action, NumOfWheel, Motor);
        }
        public string Name { get; set; }
        public int NumOfWheel { get; set; }
        public string Color { get; set; }
        public string Motor { get; set; }
        public string Action { get; set; }
    }
    class Program {
        static void Main(string[] args) {
            Vehicle _myVehicle = new Vehicle();
            Console.WriteLine("Имя Транспорта: ");
            _myVehicle.Name = Console.ReadLine();
            Console.WriteLine("Кол-во колёс Транспорта: ");
            _myVehicle.NumOfWheel = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Цвет Транспорта: ");
            _myVehicle.Color = Console.ReadLine();
            Console.WriteLine("Источник движения Транспорта: ");
            _myVehicle.Motor = Console.ReadLine();
            Console.WriteLine("Движения Транспорта: ");
            _myVehicle.Action = Console.ReadLine();
            _myVehicle.Print();
        }
    }
}
