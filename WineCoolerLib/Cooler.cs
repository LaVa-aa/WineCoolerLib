using System;
using System.Threading;

namespace Opg2WineCoolerLib
{
    public class Cooler
    {
        //• CoolerId, et tal.
        //• Temp, et tal(valgt temperatur for cooler)

        //instance feldt
        private int id;
        private int capacityOfBottles;
        private int temp;
        private int bottlesInStorage;
        public int Id { get; set; }
        public int CapacityOfBottles { get; set; }
        //• CapacityOfBottles, et tal(maks antal flasker for cooler)
        public int Temp { get; set; }

        //• BottlesInStorage, et tal, skal være mellem 0 og CapacityOfBottles
        public int BottlesInStorage
        {
            get => bottlesInStorage;
            set
            {
                if (value >= CapacityOfBottles)
                {
                    bottlesInStorage = CapacityOfBottles;
                }
                else
                {
                    bottlesInStorage = value;
                }
            }
        }

        public Cooler()
        {

        }

        public Cooler(int id, int capacityOfBottles, int temp, int bottlesInStorage)
        {
            Id = id; //instalisering property 
            CapacityOfBottles = capacityOfBottles;
            Temp = temp;
            BottlesInStorage = bottlesInStorage;
        }

        public bool CoolerIsFull()
        {
            if (BottlesInStorage==CapacityOfBottles)
            {
                return true;
            }


            //(A || B) is true. Called Logical NOT Operator. It is used to reverse the logical state of its operand. 
            //if (BottlesInStorage < 1 || BottlesInStorage > CapacityOfBottles)
            //{
            //    throw new ArgumentOutOfRangeException();
            //}
            return false;
        }

        public int AddWine()
        {
            if (BottlesInStorage >= CapacityOfBottles)
            {//fejl håndterjing rang hvor mange der er i
                throw new ArgumentOutOfRangeException();
            }

            if (CapacityOfBottles>BottlesInStorage)
            {
                BottlesInStorage++;
                
            }
            return BottlesInStorage;
        }

        public override string ToString() //tage vædier lave eget string metode 
        {
            return " ID " + id + " CapacityOfBottles " + CapacityOfBottles + " Temp " + Temp + " BottlesInStorage " + BottlesInStorage;
        }


    }
}
