using CRBCourseLib.Enums;
using CRBCourseLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRBCourseLib
{
    /// <summary>
    /// Получение курса валют из ЦБ РФ
    /// </summary>
    public interface ICRBCourse
    {
        /// <summary>
        /// Получение курса всех валют на указанную дату
        /// </summary>
        /// <param name="onDate">Дата на которую необходимо полкчить курс</param>
        /// <returns></returns>
        List<Valute> GetDeilyCourseList(DateTime onDate);

        /// <summary>
        /// Получение курса всех валют на текущую дату
        /// </summary>
        /// <returns></returns>
        List<Valute> GetDeilyCourseList();

        /// <summary>
        /// Получение курса указанных валют на текущую дату
        /// </summary>
        /// <param name="codes">Список валют для которых нужно пулкчить курс</param>
        /// <returns></returns>
        List<Valute> GetDeilyCourseList(IEnumerable<ValuteCode> codes);

        /// <summary>
        /// Получение курса указанных валют на указанную дату
        /// </summary>
        /// <param name="codes">Список валют для которых нужно пулкчить курс</param>
        /// <param name="onDate">Дата на которую необходимо получить курс</param>
        /// <returns></returns>
        List<Valute> GetDeilyCourseList(IEnumerable<ValuteCode> codes, DateTime onDate);

        /// <summary>
        /// Получение курса по указаной валюте на указанную дату
        /// </summary>
        /// <param name="code">Валюта для которй нужно плучить курс</param>
        /// <param name="onDate">Дата на которую необходимо получить курс</param>
        /// <returns></returns>
        Valute GetDeilyCourse(ValuteCode code, DateTime onDate);

        /// <summary>
        /// Получение курса по указаной валюте на текущую дату
        /// </summary>
        /// <param name="code">Валюта для которй нужно плучить курс</param>
        /// <returns></returns>
        Valute GetDeilyCourse(ValuteCode code);

        /// <summary>
        /// Получение справочника валют
        /// </summary>
        /// <returns></returns>
        ValutaDir GetValutaDir();
    }
}
