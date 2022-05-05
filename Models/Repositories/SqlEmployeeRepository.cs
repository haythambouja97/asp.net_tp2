using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Models
{
    public class SqlEmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext context;

        public SqlEmployeeRepository(AppDbContext context)
        {
            this.context = context;
        }

        public Employe Add(Employe employe)
        {
            context.Employees.Add(employe);
            context.SaveChanges();
            return employe;
        }

        public Employe Delete(int id)
        {
            Employe employe = context.Employees.Find(id);
            if(employe != null)
            {
                context.Employees.Remove(employe);
                context.SaveChanges();
            }
            return employe;
        }

        public IEnumerable<Employe> GetAllEmploye()
        {
            throw new NotImplementedException();
        }

        public Employe GetEmploye(int id)
        {
            return context.Employees.Find(id);
        }

        public Employe Update(Employe employeeChanges)
        {
            var employee = context.Employees.Attach(employeeChanges);
            employee.State = EntityState.Modified;
            context.SaveChanges();
            return employeeChanges;
        }
    }
}