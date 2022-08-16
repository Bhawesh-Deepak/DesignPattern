using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    public class PDFBuilder : IBuilder
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
            reportInstance.ReportContent = "PDF Content Section";
        }

        public void SetReportFooter()
        {
            reportInstance.ReportFooter = "PDF Report Footer";
        }

        public void SetReportHeader()
        {
            reportInstance.ReportHeader = "PDF Report Header";
        }

        public void SetReportType()
        {
            reportInstance.ReportType = "PDF Report Type";
        }
    }
}
