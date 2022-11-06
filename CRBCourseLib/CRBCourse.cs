using CRBCourseLib.API;
using CRBCourseLib.Enums;
using CRBCourseLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRBCourseLib
{
    public class CRBCourse : ICRBCourse
    {
        private readonly IAPIBase _api;

        public CRBCourse()
        {
            var crbUrl = Properties.Settings.Default.CRBUrl;
            
            _api = new APIBase(crbUrl);
        }

        public List<Valute> GetDeilyCourseList(DateTime onDate)
        {
            var endpoint = Properties.Settings.Default.DailyCourseEndpoint;
            
            var query = $"date_req={onDate.ToString("dd/MM/yyyy")}";
            
            return _api.Get<ValCurs>(endpoint, query).Valute;
        }

        public List<Valute> GetDeilyCourseList()
        {
            var endpoint = Properties.Settings.Default.DailyCourseEndpoint;

            return _api.Get<ValCurs>(endpoint).Valute;
        }

        public List<Valute> GetDeilyCourseList(IEnumerable<ValuteCode> codes)
        {
            var endpoint = Properties.Settings.Default.DailyCourseEndpoint;

            var valutes = _api.Get<ValCurs>(endpoint).Valute;

            var result = new List<Valute>();

            foreach (var code in codes)
            {
                result.Add(valutes.FirstOrDefault(val => val.CharCode == code.ToString()));
            }

            return result;
        }

        public List<Valute> GetDeilyCourseList(IEnumerable<ValuteCode> codes, DateTime onDate)
        {
            var endpoint = Properties.Settings.Default.DailyCourseEndpoint;

            var query = $"date_req={onDate.ToString("dd/MM/yyyy")}";

            var valutes = _api.Get<ValCurs>(endpoint, query).Valute;

            var result = new List<Valute>();

            foreach (var code in codes)
            {
                result.Add(valutes.FirstOrDefault(val => val.CharCode == code.ToString()));
            }

            return result;
        }

        public Valute GetDeilyCourse(ValuteCode code, DateTime onDate)
        {
            var endpoint = Properties.Settings.Default.DailyCourseEndpoint;

            var query = $"date_req={onDate.ToString("dd/MM/yyyy")}";
            
            return _api.Get<ValCurs>(endpoint, query).Valute.FirstOrDefault(val => val.CharCode == code.ToString());
        }

        public Valute GetDeilyCourse(ValuteCode code)
        {
            var endpoint = Properties.Settings.Default.DailyCourseEndpoint;

            return _api.Get<ValCurs>(endpoint).Valute.FirstOrDefault(val => val.CharCode == code.ToString());
        }

        public ValutaDir GetValutaDir()
        {
            var endpoint = Properties.Settings.Default.ValutaDirEndpoint;

            return _api.Get<ValutaDir>(endpoint);
        }
    }
}
