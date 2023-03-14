using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSI124AssgnmentNo12_ICompareable
{
    internal class Team_SortBudgetDsc : IComparer<Team>
    {
        int IComparer<Team>.Compare(Team x, Team y)
        {
           /* if (x.Budget > y.Budget) return 1;
            else if (x.Budget < y.Budget) return -1;
            else return 0;  */

            //Lets Dsc order by another method
           return x.Budget.CompareTo(y.Budget) * -1;
        }
    }
}
