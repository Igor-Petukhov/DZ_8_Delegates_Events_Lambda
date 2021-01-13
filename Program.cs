using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_8_Delegates_Events_Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------ROAD RASH 2020--------");
            Sport_Car sport_car_1 = new Sport_Car("Formula_1", "Shumacher", 15);
            Sport_Car sport_car_2 = new Sport_Car("Formula_2", "Shumacher_2", 15);
            Light_Car car_1 = new Light_Car("bobik", "prapor69", 15);

            Game game = new Game();
            game.event_drive += sport_car_1.Drive;
            game.event_drive += sport_car_2.Drive;
            game.event_drive += car_1.Drive;

            game.event_info += sport_car_1.Show_info;
            game.event_info += sport_car_2.Show_info;
            game.event_info += car_1.Show_info;

            game.Show_info_dispetcher();
            game.Drive_dispetcher();

            Console.Clear();
            game.Show_info_dispetcher();

            Console.ReadKey();
        }
    }
}
