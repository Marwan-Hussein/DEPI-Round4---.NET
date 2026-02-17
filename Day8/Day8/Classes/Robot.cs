using Day8.Interfaces;
using System;

namespace Day8.Classes
{
    internal class Robot : IWalkable
    {
        public void Walk()
        {
            Console.WriteLine("Robot is walking");
        }

        void IWalkable.Walk()
        {
            Console.WriteLine("WALKING FROM THE IFACE");
        }

        }
    }
