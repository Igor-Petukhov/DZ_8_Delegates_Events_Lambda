using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_8_Delegates_Events_Lambda
{
    abstract class Car
    {
        public string type;
        protected int current_length = 0;
        protected int finish = 100;
        protected int speed;

        public string car_name { get; set; }
        public string driver { get; set; }

        public Car(string _car_name, string _driver, int _speed)
        {
            car_name = _car_name;
            driver = _driver;
            speed = _speed;
        }

        protected void Start() 
        {
            Console.WriteLine($"Start -> {this.type} \tcar: {this.car_name} \tdriver: {this.driver} \tready for race!");
        }

        public void Show_info()
        {
            Console.WriteLine($"{this.type} \tcar: {this.car_name} \tdriver: {this.driver} \tcurrent speed: {this.speed} \tcurrent_length: {this.current_length}");
        }

        virtual public void Drive() { }
        protected void Finish() 
        {
            Console.WriteLine($"Finish -> {this.type} \tcar: {this.car_name} \tdriver: {this.driver} \tcurrent speed: {this.speed}");
        }

    }

    class Sport_Car : Car
    {
        public Sport_Car(string _car_name, string _driver, int _speed) : base(_car_name, _driver, _speed) { base.type = "Sport_Car"; }

        public delegate void delegate_finish();
        public event delegate_finish eventFinish;
        public override void Drive()
        {
            if (current_length >= finish)
            {
                eventFinish();
                return;
            }
            else
            {
                current_length += speed;
                speed = GlobalVariables.rand.Next(0, 30);
            }
        }

    }

    class Light_Car : Car
    {
        public Light_Car(string _car_name, string _driver, int _speed) : base(_car_name, _driver, _speed) { base.type = "Light_car"; }

        public delegate void delegate_finish();
        public event delegate_finish eventFinish;
        public override void Drive()
        {
            if (current_length >= finish)
            {
                eventFinish();
                return;
            }
            else
            {
                current_length += speed;
                speed = GlobalVariables.rand.Next(0, 20);
            }
        }

    }
}
