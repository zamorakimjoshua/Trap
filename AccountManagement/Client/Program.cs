using ClassroomManagementData;
using ClassroomManagementModels;
using System;

namespace Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool active = true;
            while (active)
            {
                {

                    Console.WriteLine("Joshua's Classroom System");
                    Console.WriteLine("What's Up Neggy?");
                    Console.WriteLine("1.Student wants to use a room");
                    Console.WriteLine("2.Student's done to use the room");
                    Console.WriteLine("3.Occupied Rooms");



                    Console.WriteLine("Enter the number:");
                    string number = Console.ReadLine();

                    if (number == "1")
                    {
                        Console.WriteLine("Who is the Professor?");

                        string prof = Console.ReadLine();


                        Console.WriteLine("What is the Classroom?");
                        string roomNum = Console.ReadLine();
                        SqlDbData.AddUser(prof, roomNum);


                        Console.WriteLine("Okay, heres the key to the room");


                    }

                    else if (number == "2")
                    {

                        Console.WriteLine("Whos the Professor?");

                        string prof = Console.ReadLine();
                        SqlDbData.DeleteUser(prof);


                        Console.WriteLine("Okay, Give me the key");

                    }
                    else if (number == "3")
                    {

                        Console.WriteLine("Okay, heres the occupied room and its professor");
                        Console.WriteLine("");
                        GetUsers();

                    }

                else
                {
                    Console.WriteLine("ERROR");
                }


            }
        }


        }

        public static void GetUsers()
        {
            List<User> usersFromDB = SqlDbData.GetUsers();

            foreach (var item in usersFromDB)
            {
                Console.WriteLine(item.prof);
                Console.WriteLine(item.roomNum);
            }
        }
    }
}
