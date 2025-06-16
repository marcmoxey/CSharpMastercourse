<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            "Hello World!".PrintToConsole();
            4.Add(2);

            HotelRoomModel room = new HotelRoomModel();
            // returning the same object
            room.TurnOnAir().SetTemperature(72).OpenShades();

            room.TurnOnAir().CloseShades();

            Console.ReadLine(); 
        }
    }

    public class HotelRoomModel
    {
        public int Temperature { get; set; }
        public bool IsAirRunning { get; set; }
        public bool AreShadesOpen { get; set; } 
    }

    // Extension method class - has to be static 
    public static class ExtensionSamples
    {
        // this - the type you want to extend
        public static void PrintToConsole(this string message)
        {
            Console.WriteLine(message);
        }

        public static void Add(this int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public static HotelRoomModel TurnOnAir(this HotelRoomModel room)
        {
            room.IsAirRunning = true;
            return room;
        }

        public static HotelRoomModel TurnOffAir(this HotelRoomModel room)
        {
            room.IsAirRunning = false;
            return room;
        }

        public static HotelRoomModel SetTemperature(this HotelRoomModel room, int temperature)
        {
            room.Temperature = temperature;
            return room;
        }

        public static HotelRoomModel OpenShades(this HotelRoomModel room)
        {
            room.AreShadesOpen = true;
            return room;
        }


        public static HotelRoomModel CloseShades(this HotelRoomModel room)
        {
            room.AreShadesOpen = false;
            return room;
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            "Hello World!".PrintToConsole();
            4.Add(2);

            HotelRoomModel room = new HotelRoomModel();
            // returning the same object
            room.TurnOnAir().SetTemperature(72).OpenShades();

            room.TurnOnAir().CloseShades();

            Console.ReadLine(); 
        }
    }

    public class HotelRoomModel
    {
        public int Temperature { get; set; }
        public bool IsAirRunning { get; set; }
        public bool AreShadesOpen { get; set; } 
    }

    // Extension method class - has to be static 
    public static class ExtensionSamples
    {
        // this - the type you want to extend
        public static void PrintToConsole(this string message)
        {
            Console.WriteLine(message);
        }

        public static void Add(this int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public static HotelRoomModel TurnOnAir(this HotelRoomModel room)
        {
            room.IsAirRunning = true;
            return room;
        }

        public static HotelRoomModel TurnOffAir(this HotelRoomModel room)
        {
            room.IsAirRunning = false;
            return room;
        }

        public static HotelRoomModel SetTemperature(this HotelRoomModel room, int temperature)
        {
            room.Temperature = temperature;
            return room;
        }

        public static HotelRoomModel OpenShades(this HotelRoomModel room)
        {
            room.AreShadesOpen = true;
            return room;
        }


        public static HotelRoomModel CloseShades(this HotelRoomModel room)
        {
            room.AreShadesOpen = false;
            return room;
        }
    }
}
>>>>>>> 9e6ca562ba4b79c549dfe0a1520ee498281f8ad9
