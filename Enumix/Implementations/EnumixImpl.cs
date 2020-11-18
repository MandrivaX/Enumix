using Enumix.EnumExtensions;
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
        public string GetDescription(Enum val)
        {
            return val.GetDescription();
        }

        public  string GetEnumElementsDisplayName<K>()
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


        public string GetEnumElementsDisplayName<K>(string separator)
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

        public string GetEnumElementsDescription<K>()
        {
            if (typeof(K).BaseType != typeof(Enum))
            {
                throw new InvalidCastException();
            }
            var stringBuilder = new StringBuilder();

            foreach (Enum enumMember in Enum.GetValues(typeof(K)))
            {
                stringBuilder.Append($"{enumMember.GetDescription()}|");
            }
            stringBuilder.Length--;
            return stringBuilder.ToString();
        }

        public string GetEnumElementsDescription<K>(string separator)
        {
            if (typeof(K).BaseType != typeof(Enum))
            {
                throw new InvalidCastException();
            }
            var stringBuilder = new StringBuilder();

            foreach (Enum enumMember in Enum.GetValues(typeof(K)))
            {
                stringBuilder.Append($"{enumMember.GetDescription()}  {separator}");
            }
            stringBuilder.Length--;
            return stringBuilder.ToString();
        }
    }
}
