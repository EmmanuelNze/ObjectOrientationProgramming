using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InLectureDemo
{
    class Rectangle
    {
        
            // attributes of the class
            // will will need to make these private - in a later lesson
            public int length;
            public int width;

            // methods
            // constructor method - must call this before we can use the class
            public Rectangle()
            {
                // creates an object with no values assigned to attributes
            }

            public Rectangle(int l, int w)
            {
                // creates an object with values assigned to attributes
                length = l;
                width = w;


            }
            public int CalcArea()
            {
                return length * width;

            }


            public virtual string ToString() // special methods that tells us about the object
            {
                return "I am a rectangle with length " + length;
            }
        }
}
