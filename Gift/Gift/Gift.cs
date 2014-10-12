using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;


namespace Gift
{
    class Gift
    {

        private List<AbstractComponent> _components;

        public List<AbstractComponent> Components
        {
            set {
                _components = value;
            }
            get {
                return _components;
            }
        }

        public Gift()
        {
            Components = new List<AbstractComponent>();
        }



        public void AddComponent(AbstractComponent tempComponent)
        {
            Components.Add(tempComponent);
        }

        public double GetWeight()
        {
            double tempWeight = 0;
            for (int i = 0; i < Components.Count; i++)
            {
                tempWeight += Components[i].Weight;
            }
            return tempWeight;
        }

        public void SortingByWeight()
        {
            Components.Sort();
        }

        public Candy FindCandy(double lowerLimit, double upperLimit)
        {
            return Components.Where(item=>item.GetType()==typeof(Candy)).Cast<Candy>().
                FirstOrDefault(item => item.Sugar >= lowerLimit && item.Sugar <= upperLimit);
        }

        public override string ToString()
        {
            string tempString = string.Empty;

            foreach (AbstractComponent tempComponent in Components)
            {
                tempString += tempComponent.ToString() + Environment.NewLine + Environment.NewLine;
            }
            return tempString;
        }
        
    }
}
