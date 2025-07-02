using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Encapsulation_RealLifeExmpls.models
{
    public class CoffeeMachine
    {
        private int wateramount;
        private int beansamount;
        private bool isHeated;
        public CoffeeMachine(int wateramount, int beansamount)
        {
            this.wateramount = wateramount;
            this.beansamount = beansamount;
            isHeated = false;
        }
        private void HeatWater()
        {
            if (!isHeated)
            {
                Console.WriteLine($"Heating water....");
                isHeated = true;
            }
        }
        private void GrindBeans(int amount)
        {
            if (beansamount < amount)

            {
                throw new InvalidOperationException("Not Enough beans!");
            }
            Console.WriteLine($"Grinding Beans...");
            beansamount -= amount;
        }
        public void MakeExpresso()
        {
            HeatWater();
            GrindBeans(20);
            Console.WriteLine($"Making Expresso....");
        }
        public void MakeLatte()
        {
            HeatWater();
            GrindBeans(44);
            Console.WriteLine($"Making Lattee....");
        }
        public int BeansLeft()
        {
            return beansamount;
        }
        public int WaterLeft()
        {
            return wateramount;
        }
    }

}