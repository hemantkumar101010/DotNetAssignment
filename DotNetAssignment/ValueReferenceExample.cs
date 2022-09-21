using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAssignment
{
    //value type : a type is a value type if it holds data value within its own memory space
    //value type data types are int, long, float , struct

    struct Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    //reference type doesn't store value directly. it store the address where the value is being stored
    //value stored in heap are ramdomply unlike stack
    //string,class, array

    class Customer1
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
   

}
