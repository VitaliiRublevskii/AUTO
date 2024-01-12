using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//2) описать класс -авто- (марка - модель - обьем - привод - коробка). 
//    создать список машин и вывести с него только те, у которых в 
//    имени есть буква -а- или -а-


namespace Lesson_11_01_2024
{
    public class Auto
    {
        public string CarBrend { get; set; }
        public string Model { get; set; }
        public int EngineCapacity { get; set; }
        public string WheelDrive { get; set; }
        public string Transmission { get; set;}

        public Auto() { }
        public Auto(string carBrend, string model, int engineCapacity, string wheelDrive, string transmission)
        {
            CarBrend = carBrend;
            Model = model;
            EngineCapacity = engineCapacity;
            WheelDrive = wheelDrive;
            Transmission = transmission;
        }

        public void CarShow ()
        {
            Console.WriteLine(  $"Автомобыль иарки {CarBrend} модели {Model}, имеет ебъем двигателя {EngineCapacity} л.," +
                $"{WheelDrive} привод и {Transmission} коробку передач");
        }
    }
}
