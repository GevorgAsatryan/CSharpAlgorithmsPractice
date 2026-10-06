using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp17
{
    internal class ValueObject 
    {
        public int? Value;
        public int? Value2;

        public ValueObject(int? value, int value2)
        {
            Value = value;
            Value2 = value2;

        }
        public override bool Equals(object? obj)
        {
            ValueObject vObj = obj as ValueObject;

            if (vObj == null)
            {
                return false;
            }
            return this.Value == vObj.Value && this.Value2 == vObj.Value2;
        }

        public static bool operator ==(ValueObject left, ValueObject right)
        {
            
            if(left is null || right is null)
            {
                return false;
            }
            return left.Equals(right);
        }

        public static bool operator !=(ValueObject left, ValueObject right)
        {
            return !(left == right);
        }
       
    }
}
