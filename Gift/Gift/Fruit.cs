using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gift
{
    class Fruit : AbstractComponent
    {
        private string _grownIn;
        private string _color;

        public string GrownIn
        {
            set
            {
                _grownIn = value;
            }
            get
            {
                return _grownIn;
            }
        }
        public string Color
        {
            set
            {
                _color = value;
            }
            get
            {
                return _color;
            }
        }

        
        public Fruit() : base()
        {
            this._grownIn = "None";
            this._color = "None";
         }

        public Fruit(string type, string name, double weight, double calories, double sugar, double tasteMark, string grownIn, string color)
            : base(type, name, weight, calories, sugar, tasteMark)
        {
            this._grownIn = grownIn;
            this._color = color;
        }

        public override string ToString()
        {
            string result = string.Empty;
            result += base.ToString();
            result += "Was grown in : " + GrownIn + Environment.NewLine;
            result += "Color : " + Color + Environment.NewLine;

            return result;
        }

    }
}
