namespace FurnitureManufacturer.Engine.Factories
{
    using Interfaces;
    using Interfaces.Engine;
    using Models;

    public class CompanyFactory : ICompanyFactory
    {
        public ICompany CreateCompany(string name, string registrationNumber)
        {
            Company currentCompany = new Company();
            currentCompany.Name = name;
            currentCompany.RegistrationNumber = registrationNumber;
            return currentCompany;
        }
    }
}
