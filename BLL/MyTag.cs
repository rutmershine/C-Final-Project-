using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public enum Color { Red, Orange, Yello, Green, Pink}
    public class MyTag
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private Color color;

        public Color Color
        {
            get { return color; }
            set { color = value; }
        }


    }
}
