namespace WebApplication2.Models
{
    public interface IEmployeeRepository
    {
        Employe GetEmploye(int id);
        IEnumerable<Employe> GetAllEmploye();
        Employe Add(Employe employe);
        Employe Update(Employe employe);
        Employe Delete(int id);

    }
}
