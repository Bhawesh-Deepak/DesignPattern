using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    public class ExcelBuilder : IBuilder
    {
        private Report reportInstance;
        public void CreateNewReport()
        {
            reportInstance= new Report();
        }

        public Report GetReport()
        {
           return reportInstance;
        }

        public void SetReportContent()
        {
            reportInstance.ReportContent = "Excel Content Section";
        }

        public void SetReportFooter()
        {
            reportInstance.ReportFooter = "Excel Report Footer";
        }

        public void SetReportHeader()
        {
            reportInstance.ReportHeader = "Excel Report Header";
        }

        public void SetReportType()
        {
            reportInstance.ReportType = "Excel Report Type";
        }
    }
}
