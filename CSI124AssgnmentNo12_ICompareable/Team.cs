using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSI124AssgnmentNo12_ICompareable
{
    public class Team : IComparable<Team>
    {
        string _name;
        string _city;
        double _budget;

        public Team(string name, string city)
        {
            Random random = new Random();
            Name = name;
            City = city;
            Budget = random.Next(100000,10000000);
        }

        public string Name { get => _name; set => _name = value; }
        public string City { get => _city; set => _city = value; }
        public double Budget { get => _budget; set => _budget = value; }

        public int CompareTo(Team other)
        {
            //Write the code that tells sort how to organizing the list
            //Assending Order
            /*if (this._budget > other._budget) return 1;
            else if (this._budget < other._budget) return -1;
            else return 0;*/

            //dessending Order
           /* if (this._budget < other._budget) return 1;
            else if (this._budget > other._budget) return -1;
            else return 0;*/

           // return _budget.CompareTo(other.Budget) *-1;
            return _city.CompareTo(other.City) *-1;

            //x and y
            // x > y : 1;
            // x < y : -1;
            // x = y : 0;
        }

        public override string? ToString()
        {
            return $"{_city} {_name} budget: {_budget.ToString("c")}";
        }
    }
}
