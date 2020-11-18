using Enumix.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace Enumix.Implementations
{
    public class EnumixImpl : IEnumix
    {
        public string GetDisplayName(Enum val)
        {
            return val.GetType()
                  .GetMember(val.ToString())
                  .FirstOrDefault()
                  ?.GetCustomAttribute<DisplayAttribute>(false)
                  ?.Name
                  ?? val.ToString();
        }
    }
}
