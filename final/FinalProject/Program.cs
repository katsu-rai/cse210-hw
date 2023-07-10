using System;

class Program
{
    static void Main(string[] args)
    {
        string choice = null;
        Hotel JapanPrinceHotel = new Hotel("Japan Prince Hotel");

        List<Room> rooms = new List<Room>();
        Single single101 = new Single(101);
        rooms.Add(single101);
        Single single102 = new Single(102);
        rooms.Add(single102);
        Double double103 = new Double(103);
        rooms.Add(double103);
        Double double201 = new Double(201);
        rooms.Add(double201);
        Triple triple202 = new Triple(202);
        rooms.Add(triple202);
        Suite suite203 = new Suite(203);
        rooms.Add(suite203);
        foreach (Room room in rooms)
        {
            JapanPrinceHotel.AddRoomToHotel(room);
        }

        string customerName = null;
        string customerPhoneNumber = null;

        // make a reservation
        string reservationDate = null;
        int reservedRoomNumber = 0;

        // cancel a reservation
        string cancelationDate = null;

        Console.Clear();

        Console.WriteLine("Welcome to Japan Prince Hotel!");
        Console.WriteLine("What is your name?");
        Console.Write("=> ");
        customerName = Console.ReadLine();

        string[] allBookings = System.IO.File.ReadAllLines("hotelBooking.txt");
        foreach (string booking in allBookings)
        {
            string[] data = booking.Split(',');
            string date = data[0];
            int roomNumber = int.Parse(data[1]);
            string name = data[2];

            Booking loadedBooking = new Booking(date, roomNumber, name);
            JapanPrinceHotel.AddBookingToHotel(loadedBooking);
        }


        Customer previousCustomer = new Customer(customerName);
        foreach (Booking bookingInList in JapanPrinceHotel.GetBookings())
        {
            if (customerName == bookingInList.GetNameInBooking())
            {
                previousCustomer.AddBookingToCustomer(bookingInList);
            }
        }

        while (choice != "4")
        {
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Make a reservation");
            Console.WriteLine("  2. Check your reservation");
            Console.WriteLine("  3. Cancel your reservation");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from a menu: ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    // make a reservation
                    Console.Clear();
                    Console.WriteLine("What day would you like to make a reservation?(ex. 12/25) ");
                    reservationDate = Console.ReadLine();
                    foreach (Room room in JapanPrinceHotel.GetRooms())
                    {
                        if (room.IsAvailable(reservationDate))
                        {
                            room.DisplayDescription();
                        }
                    }
                    Console.WriteLine();
                    Console.Write("Which room would you like to stay?(ex. 101): ");
                    reservedRoomNumber = int.Parse(Console.ReadLine());

                    Console.WriteLine();
                    Console.WriteLine($"Your reservation is {reservationDate}, {reservedRoomNumber}");
                    Console.WriteLine("To confirm your reservation, press enter");
                    customerPhoneNumber = Console.ReadLine();

                    //make a booking class and add it to cutoemer and hotel classes
                    Customer customer = new Customer(customerName);

                    Booking booking = new Booking(reservationDate, reservedRoomNumber, customerName);
                    JapanPrinceHotel.AddBookingToHotel(booking);

                    Console.WriteLine("Your reservation is confirmed.");

                    break;
                case "2":
                    // load the reservation and display it
                    foreach (Booking bookingInList in JapanPrinceHotel.GetBookings())
                    {
                        if (customerName == bookingInList.GetNameInBooking())
                        {
                            Console.WriteLine(bookingInList.WriteInFile());
                        }
                    }
                    break;
                case "3":
                    // cancel the reservation
                    Console.WriteLine();

                    foreach (Booking bookingInList in JapanPrinceHotel.GetBookings())
                    {
                        if (customerName == bookingInList.GetNameInBooking())
                        {
                            Console.WriteLine(bookingInList.WriteInFile());
                        }
                    }

                    Console.WriteLine("Which reservatoin would you like to cancel? Type in the date please.(ex. 12/25)");
                    Console.Write("=>");
                    cancelationDate = Console.ReadLine();

                    for (int i = 0; i < JapanPrinceHotel.GetBookings().Count(); i++)
                    {
                        if (cancelationDate == JapanPrinceHotel.GetBookings()[i].GetDate())
                        {
                            JapanPrinceHotel.DeleteBookingFromList(JapanPrinceHotel.GetBookings()[i]);
                            Console.WriteLine("Your reservation was successfully canceled.");
                        }
                    }

                    break;
                case "4":
                    // Quit
                    using (StreamWriter outputFile = new StreamWriter("hotelBooking.txt"))
                    {
                        foreach (Booking bookingInList in JapanPrinceHotel.GetBookings())
                        {
                            outputFile.WriteLine(bookingInList.WriteInFile());
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Invalid response");
                    break;
            }
        }
    }
}