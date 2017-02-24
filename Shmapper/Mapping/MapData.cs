using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shmapper
{
    /// <summary>
    /// Used in attribute to map values of complex type to fields
    /// </summary>
    public enum MapData
    {
        Default,
        LookupId,
        LookupValue
    }
}
