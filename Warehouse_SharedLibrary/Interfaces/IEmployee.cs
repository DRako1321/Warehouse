using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse_SharedLibrary.Interfaces;

internal interface IEmployee
{
    int id { get; set; }
    string name { get; set; }


    void clockIn ();
}