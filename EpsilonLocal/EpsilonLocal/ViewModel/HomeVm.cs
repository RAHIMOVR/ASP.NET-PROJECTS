using EpsilonLocal.Models;
using System.Collections.Generic;

namespace EpsilonLocal.ViewModel
{
    public class HomeVm
    {

      public List<EpExpense> EpExpenses { get; set; }
        public List<EpPayable> EpPayables { get; set; }

        public List<EpReceivable> EpReceivables { get; set; }

        public List<EtExpense> EtExpenses { get; set; }
        public List<EtPayable> EtPayables { get; set; }

        public List<EtReceivable> EtReceivables { get; set; }

        public List<Opportunity> Oppurtunities { get;set; }









    }
}
