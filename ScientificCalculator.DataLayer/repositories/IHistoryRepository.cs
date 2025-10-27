using ScientificCalculator.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScientificCalculator.DataLayer
{
    public interface IHistoryRepository
    {
        IEnumerable<History> GetAll();
        void Add(History history);
        bool Delete(History history);
        void Delete(IEnumerable<History> hostories);
    }
}
