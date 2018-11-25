using System.Threading.Tasks;

namespace UnitOfWorkProject.Interfaces
{
    public interface IUnitOfWork
    {
         Task Save();
    }
}