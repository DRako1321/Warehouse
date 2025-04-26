using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse_SharedLibrary.Interfaces;

public interface IWarehouseItem
{    
    string name { get; set; }   
    string description { get; set; }
}