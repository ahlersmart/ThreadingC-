using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TableTopWarGameSimulator
{
    //a class to roll a dice asynchronomous.
    public static class DiceRoller
    {
        private static int D4=0;
        private static int D6=0;
        private static int D8=0;
        private static int D10=0;
        private static int D12=0;
        private static int D20=0;

        //class that roles the dice
        private static int rollDice(int size)
        {
            Random rand = new Random();
            return rand.Next(1, size + 1); ;
        }

        //the class checks if the dice has ever been rolled before. If it has it will return the last roll and roll the dice again in a sepperate thread so losing no time.
        //if it hasn't been roled it will roll it first.
        public static int rollD4()
        {
            if (D4 == 0)
            {
                D4 = rollDice(4);
            }
            ThreadPool.QueueUserWorkItem(state =>
            {
                DiceRoller.D4 = DiceRoller.rollDice(4);
            });
            return D4;
        }

        public static int rollD4(int amout)
        {
            int roll = 0;
            for(int i = 0; i<amout; i++)
            {
                roll += rollD4();
            }
            return roll;
        }

        public static int rollD6()
        {
            if (D6 == 0)
            {
                D6 = rollDice(6);
            }
            ThreadPool.QueueUserWorkItem(state =>
            {
                DiceRoller.D6 = DiceRoller.rollDice(6);
            });
            return D8;
        }

        public static int rollD6(int amout)
        {
            int roll = 0;
            for (int i = 0; i < amout; i++)
            {
                roll += rollD6();
            }
            return roll;
        }

        public static int rollD8()
        {
            if (D8 == 0)
            {
                D8 = rollDice(8);
            }
            ThreadPool.QueueUserWorkItem(state =>
            {
                DiceRoller.D4 = DiceRoller.rollDice(8);
            });
            return D8;
        }

        public static int rollD8(int amout)
        {
            int roll = 0;
            for (int i = 0; i < amout; i++)
            {
                roll += rollD8();
            }
            return roll;
        }

        public static int rollD10()
        {
            if (D10 == 0)
            {
                D10 = rollDice(10);
            }
            ThreadPool.QueueUserWorkItem(state =>
            {
                DiceRoller.D10 = DiceRoller.rollDice(10);
            });
            return D10;
        }

        public static int rollD10(int amout)
        {
            int roll = 0;
            for (int i = 0; i < amout; i++)
            {
                roll += rollD10();
            }
            return roll;
        }

        public static int rollD12()
        {
            if (D12 == 0)
            {
                D12 = rollDice(12);
            }
            ThreadPool.QueueUserWorkItem(state =>
            {
                DiceRoller.D12 = DiceRoller.rollDice(12);
            });
            return D12;
        }

        public static int rollD12(int amout)
        {
            int roll = 0;
            for (int i = 0; i < amout; i++)
            {
                roll += rollD12();
            }
            return roll;
        }

        public static int rollD20()
        {
            if (D20 == 0)
            {
                D20 = rollDice(20);
            }
            ThreadPool.QueueUserWorkItem(state =>
            {
                DiceRoller.D20 = DiceRoller.rollDice(20);
            });
            return D20;
        }

        public static int rollD20(int amout)
        {
            int roll = 0;
            for (int i = 0; i < amout; i++)
            {
                roll += rollD20();
            }
            return roll;
        }
    }
}
