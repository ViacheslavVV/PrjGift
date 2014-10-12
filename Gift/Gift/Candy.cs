using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gift
{
    class Candy : AbstractComponent
    {
        //Fields
        private string _filling;
        private string _form;
        //Props
        public string Filling
        {
            set
            {
                _filling = value;
            }
            get
            {
                return _filling;
            }
        }
        public string Form
        {
            set
            {
                _form = value;
            }
            get
            {
                return _form;
            }
        }

        public Candy() : base()
        {
            this._filling = "None";
            this._form = "None";
         }

        public Candy(string type, string name, double weight, double calories, double sugar, double tasteMark, string filling, string form)
            : base(type, name, weight, calories, sugar, tasteMark)
        {
            this._filling = filling;
            this._form = form;
        }

        public override string ToString()
        {
            string result = string.Empty;
            result += base.ToString();
            result += "Filling : " + Filling + Environment.NewLine;
            result += "Form : " + Form + Environment.NewLine;

            return result;
        }

    }
}
