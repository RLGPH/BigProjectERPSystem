using ERPSys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigProject_ERP_System
{
    public partial class DataBase
    {
        
        private List<Company> CompanyInstance(Company company)
        {
            List<Company> CompanyList = new();

            if (CompanyList == null && company.Id == 0)
            {
                // Create addresses
                Addresse address1 = new(1, "Vej1", "1", "1000", "By1", "Land1");
                Addresse address2 = new(2, "Vej2", "2", "2000", "By2", "Land2");
                Addresse address3 = new(3, "Vej3", "3", "3000", "By3", "Land3");
                Addresse address4 = new(4, "Vej4", "4", "4000", "By4", "Land4");

                // Create companies
                Company company1 = new(1, "Company1", Currency.Valuta.DKK, address1);
                Company company2 = new(2, "Company2", Currency.Valuta.SEK, address2);
                Company company3 = new(3, "Company3", Currency.Valuta.DKK, address3);
                Company company4 = new(4, "Company4", Currency.Valuta.EURO, address4);

                // Add companies to list
                CompanyList.Add(company1);
                CompanyList.Add(company2);
                CompanyList.Add(company3);
                CompanyList.Add(company4);
            }
            else if(company.Id >= 1)
            {
                CompanyList.Add(company);
            }
            return CompanyList;
        }
        public List<Company> GetCompanyList()
        {
            Addresse addresse = new(0, "", "", "", "", "");
            Company company = new(0,"",Currency.Valuta.DKK,addresse);
            return CompanyInstance(company);
        }
        public void AddCompany(Company company)
        {
            
            if (company.Id == 0)
            {
                company.Id = NextUsableCompanyId();
                CompanyInstance(company);
            }
        }
        public int NextUsableCompanyId()
        {
            List<Company> CompanyList = GetCompanyList();

            int maxId = 0;
            if (CompanyList.Count > 0)
            {
                maxId = CompanyList.Max(c => c.Id);
            }
            return maxId + 1;
        }

        public bool UpdateCompany(int id, Company newCompany)
        {
            List<Company> CompanyList = GetCompanyList();

            var company = CompanyList.FirstOrDefault(c => c.Id == id);
            if (company != null)
            {
                // Update the company details
                company.CompanyName = newCompany.CompanyName;
                company.Money = newCompany.Money;
                company.addresse = newCompany.addresse;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteCompany(int id)
        {
            List<Company> CompanyList = GetCompanyList();

            var company = CompanyList.FirstOrDefault(c => c.Id == id);
            if (company != null)
            {
                CompanyList.Remove(company);
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
