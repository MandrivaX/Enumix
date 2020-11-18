using Enumix.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;

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

        public  string GetEnumElements<K>()
        {
            if (typeof(K).BaseType != typeof(Enum))
            {
                throw new InvalidCastException();
            }
            var stringBuilder = new StringBuilder();
            foreach (string enumMember in Enum.GetNames(typeof(K)))
            {
                stringBuilder.Append($"{enumMember}|");
            }
            stringBuilder.Length--;
            return stringBuilder.ToString();
        }


        public string GetEnumElementsWithSeparator<K>(string separator)
        {
            if (typeof(K).BaseType != typeof(Enum))
            {
                throw new InvalidCastException();
            }
            var stringBuilder = new StringBuilder();
            foreach (string enumMember in Enum.GetNames(typeof(K)))
            {
                stringBuilder.Append($"{enumMember} {separator}");
            }
            stringBuilder.Length--;
            return stringBuilder.ToString();
        }
    }
}
