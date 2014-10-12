using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gift
{
    public abstract class AbstractComponent : IComparable
    {
        //Fields
        private string _type;
        private string _name;
        private double _weight;
        private double _calories;
        private double _sugar;
        private double _tasteMark;

        //Props
        public string Type
        {
            set
            {
                _type = value;
            }
            get
            {
                return _type;
            }
        }
        public string Name
        {
            set
            {
               _name = value;
            }
            get
            {
                return _name;
            }
        }
        public double Weight
        {
            set
            {
                _weight = value;
            }
            get
            {
                return _weight;
            }
        }
        public double Calories
        {
            set
            {
                _calories = value;
            }
            get
            {
                return _calories;
            }
        }
        public double Sugar
        {
            set
            {
                _sugar = value;
            }
            get
            {
                return _sugar;
            }
        }
        public double TasteMark
        {
            set
            {
                _tasteMark = value;
            }
            get
            {
                return _tasteMark;
            }
        }

        public AbstractComponent()
        {
            _type = "None";
            _name = "None";
            _weight = 0;
            _calories = 0;
            _sugar = 0;
            _tasteMark = 0;
        }

        public AbstractComponent(string type, string name, double weight, double calories, double sugar, double tasteMark)
        {
            this._type = type;
            this._name = name;
            this._weight = weight;
            this._calories = calories;
            this._sugar = sugar;
            this._tasteMark = tasteMark;
        }

        public override string ToString()
        {
            string info;
            StringBuilder str = new StringBuilder();
            str.Append("Type : " + Type + " " + Name + Environment.NewLine);
            str.Append("Weight : " + Weight + Environment.NewLine);
            str.Append("Sugar : " + Sugar + Environment.NewLine);
            str.Append("Calories : " + Calories + Environment.NewLine);
            str.Append("Taste mark : " + TasteMark + Environment.NewLine);
            info = str.ToString();
            return info;
        }

        public int CompareTo(object tempObject)
        {
            if (tempObject is AbstractComponent)
            {
                if (this._weight > ((AbstractComponent)tempObject)._weight)
                {
                    return 1;
                }
                else
                {
                    if (this._weight < ((AbstractComponent)tempObject)._weight)
                    {
                        return -1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            else
            {
                return 0;
            }
        }

    }
}