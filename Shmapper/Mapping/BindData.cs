using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shmapper
{
    /// <summary>
    /// Used in attribute to bind values of complex type to fields
    /// </summary>
    public enum BindData
    {
        Default,
        LookupId,
        LookupValue
    }
}
