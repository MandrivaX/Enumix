using System;
using System.Collections.Generic;
using System.Text;

namespace Enumix.Interfaces
{
    public interface IEnumix
    {
        string GetDisplayName(Enum val);
        string GetEnumElements<K>();
        string GetEnumElementsWithSeparator<K>(string separator);
    }
}
