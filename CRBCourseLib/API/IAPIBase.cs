using CRBCourseLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRBCourseLib.API
{
    /// <summary>
    /// Базовые метода API
    /// </summary>
    internal interface IAPIBase
    {
        /// <summary>
        /// Выполнение Get запроса к API ЦБ РФ
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="endpoint">Конечная точка сервиса</param>
        /// <param name="queryParams">Строка параметров запроса. Если не указана, запрос выполняется без параметров</param>
        /// <returns></returns>
        T Get<T>(string endpoint, string queryParams = null);
    }
}
