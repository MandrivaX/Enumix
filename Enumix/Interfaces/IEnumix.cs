using System;
using System.Collections.Generic;
using System.Text;

namespace Enumix.Interfaces
{
    public interface IEnumix
    {
        /// <summary>
        /// Get display name of selected enum member
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        string GetDisplayName(Enum val);

        /// <summary>
        /// Get display names of enums member
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        string GetEnumElementsDisplayName<K>();

        /// <summary>
        /// Get display names of enums member with separator
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        string GetEnumElementsDisplayName<K>(string separator);

        /// <summary>
        /// Get Description of enums member
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        string GetDescription(Enum val);

        /// <summary>
        /// Get Descriptions of enums member
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        string GetEnumElementsDescription<K>();

        /// <summary>
        /// Get Descriptions of enums memnber with separator
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        string GetEnumElementsDescription<K>(string separator);

        /// <summary>
        /// Get Count of enums member
        /// </summary>
        /// <returns></returns>
        int GetEnumCount<K>();
    }
}
