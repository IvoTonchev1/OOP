using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capitalism.Models.Interfaces;
using Capitalism.Models.OrganizationalUnits;

namespace Capitalism.Core
{
    public class Database
    {
        private IList<IOrganizationalUnit> companies;
        public Database()
        {
            this.companies = new List<IOrganizationalUnit>();
        }
        public IEnumerable<IOrganizationalUnit> Companies 
        {
            get { return this.companies; }  
        }

        public void AddCompany(IOrganizationalUnit company)
        {
            this.companies.Add(company);
        }


    }
}
