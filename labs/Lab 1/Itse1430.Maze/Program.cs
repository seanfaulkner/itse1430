// Sean Faulkner
//ITSE 1430
//Itse1430.Maze
//



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itse1430.Maze
{


    class Program
    {
        static int location = 0;
        static string choice = "";
        static int north = 1; // is north allowable? 0 = yes 1 = no
        static int south = 0; // is south allowable? 0 = yes 1 = no
        static int east = 1; // is east allowable? 0 = yes 1 = no
        static int west = 1; // is west allowable? 0 = yes 1 = no
        static string roomname = "Starting Room";
        static void Main ( string[] args )
        {
            welcome ();
            MazeLoop ();
            quit ();
        }

        private static void welcome ()
        {
            Console.WriteLine ("Welcome to Sean's Maze");
            Console.WriteLine ("You are currently in Location " + roomname + "\n");


        }

        private static void MazeLoop ()
        {
            do
            {
                Console.WriteLine ("You are at the " + roomname);
                Console.WriteLine ("Your Commands are:");
                Console.WriteLine ("Go North");
                Console.WriteLine ("Go South");
                Console.WriteLine ("Go East");
                Console.WriteLine ("Go West");
                Console.WriteLine ("Quit\n");
                Console.WriteLine ("What is your Command? ");
                choice = Console.ReadLine ();
                Console.WriteLine ();
                choice = choice.ToUpper ();
                if (choice == "QUIT")
                {
                    Console.WriteLine ("So sorry to see you go!!!");
                    Console.WriteLine ("Press any key to exit");
                    Console.ReadLine ();
                    break;
                } else if (choice == "")
                {

                } else if (choice == "GO NORTH")
                {
                    if (north == 1)
                        Console.WriteLine ("You cannot go north that way there is a wall");
                    else
                    {
                        switch (location)
                        {
                            case 0:                           
                            break;
                            case 1:                            
                            location = 0;
                            roomname = "Starting Room ";
                            break;
                            case 2:
                            break;
                            case 3:
                            break;
                            case 4:
                            break;
                            case 5:
                            break;
                            case 6:
                            location = 1;
                            roomname = "Foyer ";
                            Console.WriteLine ("There is a door to the north and the south.");
                            break;
                            case 7:
                            break;
                            case 8:
                            break;
                            case 9:
                            location = 4;
                            roomname = "master bedroom ";
                            Console.WriteLine ("There's a door to the south, east, and west");
                            break;
                            case 10:
                            break;
                            case 11:
                            location = 6;
                            roomname = "Coat room ";
                            Console.WriteLine ("There is a door to the north and the south.");
                            break;
                            case 12:
                            location = 7;
                            roomname = "wetbar ";
                            Console.WriteLine ("There is a door to the south and the west.");
                            break;
                            case 13:
                            location = 8;
                            roomname = "kitchen ";
                            Console.WriteLine ("There is a door to the south and the east.");
                            break;
                            case 14:
                            location = 9;
                            roomname = "wine cellar ";
                            Console.WriteLine ("There's a door in every direction choose wisely!");
                            break;
                            case 15:
                            break;
                            case 16:
                            break;
                            case 17:
                            break;
                            case 18:
                            break;
                            case 19:
                            location = 14;
                            roomname = "pantry ";
                            Console.WriteLine ("There is a door to the north, west, and south.");
                            break;
                            case 20:
                            location = 15;
                            roomname = "cigar room! ";
                            Console.WriteLine ("Good room but not the end, there is a door to the south.");
                            break;
                            case 21:
                            break;
                            case 22:
                            location = 17;
                            roomname = "bedroom 1 ";
                            Console.WriteLine ("There is a door to the east, west, and south.");
                            break;
                            case 23:
                            location = 18;
                            roomname = "bathroom ";
                            Console.WriteLine ("There is a door to the south and the west.");
                            break;
                            case 24:
                            location = 19;
                            roomname = "living room ";
                            Console.WriteLine ("There is a door to the north, south, and the east.");
                            break;
                            case 25:
                            break;
                        }
                    }
                } else if (choice == "GO SOUTH")
                {
                    if (south == 1)
                        Console.WriteLine ("You cannot go south there is a wall there");
                    else
                    {
                        switch (location)
                        {
                            case 0:
                            location = 1;
                            roomname = "Foyer ";
                            Console.WriteLine ("There is a door to the north and the south.");
                            break;
                            case 1:
                            location = 6;
                            roomname = "Coat room ";
                            Console.WriteLine ("There is a door to the north, south and the east.");
                            break;
                            case 2:
                            break;
                            case 3:
                            break;
                            case 4:
                            location = 9;
                            roomname = "wine cellar ";
                            Console.WriteLine ("There's a door in every direction choose wisely!");
                            break;
                            case 5:
                            break;
                            case 6:
                            location = 11;
                            roomname = "storage closet ";
                            Console.WriteLine ("There is a door to the north.");
                            break;
                            case 7:
                            location = 12;
                            roomname = "formal living room ";
                            Console.WriteLine ("There is a door to the north and the east.");
                            break;
                            case 8:
                            location = 13;
                            roomname = "formal dining room ";
                            Console.WriteLine ("There is a door to the north, east and west.");
                            break;
                            case 9:
                            location = 14;
                            roomname = "pantry ";
                            Console.WriteLine ("There is a door to the north, west, and south.");
                            break;
                            case 10:
                            break;
                            case 11:
                            break;
                            case 12:
                            break;
                            case 13:
                            break;
                            case 14:
                            location = 19;
                            roomname = "living room ";
                            Console.WriteLine ("There is a door to the north, south, and the east.");
                            break;
                            case 15:
                            location = 20;
                            roomname = "media room ";
                            Console.WriteLine ("There is a door to the north and the west.");
                            break;
                            case 16:
                            break;
                            case 17:
                            location = 22;
                            roomname = "bedroom 2 ";
                            Console.WriteLine ("There is a door to the north and the west.");
                            break;
                            case 18:
                            location = 23;
                            roomname = "game room ";
                            Console.WriteLine ("Another great room but not the goal, there is a door to the north and the east.");
                            break;
                            case 19:
                            location = 24;
                            roomname = "pool hall ";
                            Console.WriteLine ("THE BEST room in the house you'll have a ball, there is a door to the north, east and the west.");
                            break;
                            case 20:
                            break;
                            case 21:
                            break;
                            case 22:
                            break;
                            case 23:
                            break;
                            case 24:
                            break;
                            case 25:
                            break;
                        }
                    }
                } else if (choice == "GO EAST")
                {
                    if (east == 1)
                        Console.WriteLine ("You cannot go east there is a wall there");
                    else
                    {
                        switch (location)
                        {
                            case 0:
                            break;
                            case 1:
                            break;
                            case 2:
                            location = 3;
                            roomname = "master bath ";
                            Console.WriteLine ("There is a door to the east and the west.");
                            break;
                            case 3:
                            location = 4;
                            roomname = "master bedroom ";
                            Console.WriteLine ("There's a door to the south, east, and west");
                            break;
                            case 4:
                            location = 5;
                            Console.WriteLine ("CONGRATS YOU FOUND THE EXIT!!!!!!");
                            Console.WriteLine ("Press any key to end");
                            Console.ReadLine ();
                            break;
                            case 5:
                            break;
                            case 6:
                            location = 7;
                            roomname = "wetbar ";
                            Console.WriteLine ("There is a door to the south and the west.");
                            break;
                            case 7:
                            break;
                            case 8:
                            location = 9;
                            roomname = "wine cellar ";
                            Console.WriteLine ("There's a door in every direction choose wisely!");
                            break;
                            case 9:
                            location = 10;
                            roomname = "half bathroom ";
                            Console.WriteLine ("There is a door to the west.");
                            break;
                            case 10:
                            break;
                            case 11:
                            break;
                            case 12:
                            location = 13;
                            roomname = "formal dining room ";
                            Console.WriteLine ("There is a door to the north, east and west.");
                            break;
                            case 13:
                            location = 14;
                            roomname = "pantry ";
                            Console.WriteLine ("There is a door to the north, west, and south.");
                            break;
                            case 14:
                            break;
                            case 15:
                            break;
                            case 16:
                            location = 17;
                            roomname = "bedroom 1 ";
                            Console.WriteLine ("There is a door to the east, west, and south.");
                            break;
                            case 17:
                            location = 18;
                            roomname = "bathroom ";
                            Console.WriteLine ("There is a door to the south and the west.");
                            break;
                            case 18:
                            break;
                            case 19:
                            location = 20;
                            roomname = "media room ";
                            Console.WriteLine ("There is a door to the north and the west.");
                            break;
                            case 20:
                            break;
                            case 21:
                            location = 22;
                            roomname = "bedroom 2 ";
                            Console.WriteLine ("There is a door to the north and the west.");
                            break;
                            case 22:
                            break;
                            case 23:
                            location = 24;
                            roomname = "pool hall ";
                            Console.WriteLine ("THE BEST room in the house you'll have a ball, there is a door to the north, east and the west.");
                            break;
                            case 24:
                            location = 25;
                            roomname = "half bathroom ";
                            Console.WriteLine ("There is a door to the west.");
                            break;
                            case 25:
                            break;
                        }
                    }
                } else if (choice == "GO WEST")
                {
                    if (west == 1)
                        Console.WriteLine ("You cannot go west there is a wall there");
                    else
                    {
                        switch (location)
                        {
                            case 0:
                            break;
                            case 1:
                            break;
                            case 2:
                            break;
                            case 3:
                            location = 2;
                            roomname = "master closet ";
                            Console.WriteLine ("There is a door to the east.");
                            break;
                            case 4:
                            location = 3;
                            roomname = "master bath ";
                            Console.WriteLine ("There is a door to the east and the west.");
                            break;
                            case 5:
                            break;
                            case 6:
                            break;
                            case 7:
                            location = 6;
                            roomname = "Coat room ";
                            Console.WriteLine ("There is a door to the north, south and the east.");
                            break;
                            case 8:
                            break;
                            case 9:
                            location = 8;
                            roomname = "kitchen ";
                            Console.WriteLine ("There is a door to the south and the east.");
                            break;
                            case 10:
                            location = 9;
                            roomname = "wine cellar ";
                            Console.WriteLine ("There's a door in every direction choose wisely!");
                            break;
                            case 11:
                            break;
                            case 12:
                            break;
                            case 13:
                            location = 12;
                            roomname = "formal living room ";
                            Console.WriteLine ("There is a door to the north and the east.");
                            break;
                            case 14:
                            location = 13;
                            roomname = "formal dining room ";
                            Console.WriteLine ("There is a door to the north, east and west.");
                            break;
                            case 15:
                            break;
                            case 16:
                            break;
                            case 17:
                            location = 16;
                            roomname = "bed room 1 closet ";
                            Console.WriteLine ("There is a door to the east.");
                            break;
                            case 18:
                            location = 17;
                            roomname = "bedroom 1 ";
                            Console.WriteLine ("There is a door to the east, west, and south.");
                            break;
                            case 19:
                            break;
                            case 20:
                            location = 19;
                            roomname = "living room ";
                            Console.WriteLine ("There is a door to the north, south, and the east.");
                            break;
                            case 21:
                            break;
                            case 22:
                            location = 21;
                            roomname = "bed room 2 closet ";
                            Console.WriteLine ("There is a door to the east.");
                            break;
                            case 23:
                            break;
                            case 24:
                            location = 23;
                            roomname = "game room ";
                            Console.WriteLine ("Another great room but not the goal, there is a door to the north and the east.");
                            break;
                            case 25:
                            location = 24;
                            roomname = "pool hall ";
                            Console.WriteLine ("THE BEST room in the house you'll have a ball, there is a door to the north, east and the west.");
                            break;
                        }

                    }
                } else
                    Console.WriteLine ("That is not a valid command please choose from the list");

                MazeInstructions (location);
                //put in function to check to see if you can move based on the maze location

            }
            while (location != 5);

        }


        private static void quit ()
        { }

        public static void MazeInstructions ( int input )
        {
            switch (input)
            {
                case 0:

                north = 1;
                west = 1;
                east = 1;
                south = 0;

                break;

                case 1:
                north = 1;
                west = 1;
                east = 1;
                south = 0;

                break;
                case 2:
                north = 1;
                west = 1;
                east = 0;
                south = 1;

                break;
                case 3:
                north = 1;
                west = 0;
                east = 0;
                south = 1;
                break;
                case 4:
                north = 1;
                west = 0;
                east = 0;
                south = 0;
                break;
                case 5:
                break;
                case 6:
                north = 0;
                west = 1;
                east = 0;
                south = 0;
                break;
                case 7:
                north = 1;
                west = 0;
                east = 1;
                south = 0;
                break;
                case 8:
                north = 1;
                west = 1;
                east = 0;
                south = 0;
                break;
                case 9:
                north = 0;
                west = 0;
                east = 0;
                south = 0;
                break;
                case 10:
                north = 1;
                west = 0;
                east = 1;
                south = 1;
                break;
                case 11:
                north = 0;
                west = 1;
                east = 1;
                south = 1;
                break;
                case 12:
                north = 0;
                west = 1;
                east = 0;
                south = 0;
                break;
                case 13:
                north = 0;
                west = 0;
                east = 0;
                south = 1;
                break;
                case 14:
                north = 0;
                west = 0;
                east = 1;
                south = 0;
                break;
                case 15:
                north = 1;
                west = 1;
                east = 1;
                south = 0;
                break;
                case 16:
                north = 1;
                west = 1;
                east = 0;
                south = 1;
                break;
                case 17:
                north = 1;
                west = 0;
                east = 0;
                south = 0;
                break;
                case 18:
                north = 1;
                west = 0;
                east = 1;
                south = 0;
                break;
                case 19:
                north = 0;
                west = 1;
                east = 0;
                south = 0;
                break;
                case 20:
                north = 0;
                west = 0;
                east = 1;
                south = 1;
                break;
                case 21:
                north = 1;
                west = 1;
                east = 0;
                south = 1;
                break;
                case 22:
                north = 0;
                west = 0;
                east = 1;
                south = 1;
                break;
                case 23:
                north = 0;
                west = 1;
                east = 0;
                south = 1;
                break;
                case 24:
                north = 0;
                west = 0;
                east = 0;
                south = 1;
                break;
                case 25:
                north = 1;
                west = 0;
                east = 1;
                south = 1;
                break;

            }

        }
    }


}


