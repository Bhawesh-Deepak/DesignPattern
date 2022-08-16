using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    public interface IBuilder
    {
        void SetReportType();
        void SetReportHeader();
        void SetReportContent();
        void SetReportFooter();
        void CreateNewReport();
        Report GetReport();


    }
}
