using ScientificCalculator.DataLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScientificCalculator.DataLayer
{
    public class HistoryRepository : IHistoryRepository
    {
        ScientificCalculatorEntities db;
        public HistoryRepository(ScientificCalculatorEntities db_) 
        {
            db = db_;
        }

        public void Add(History history)
        {
            db.Histories.Add(history);
        }

        public bool Delete(History history)
        {
            try
            {
                history.IsDeleted = 1;
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public void Delete(IEnumerable<History> hostories)
        {
            foreach (var history in hostories)
            {
                Delete(history);
            }
        }

        public IEnumerable<History> GetAll()
        {
            return db.Histories.Where(h => h.IsDeleted == 0).ToList();
        }
    }
}
