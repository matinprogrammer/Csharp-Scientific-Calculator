using ScientificCalculator.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScientificCalculator.DataLayer
{
    public class UnitOfWork : IDisposable
    {
        ScientificCalculatorEntities db = new ScientificCalculatorEntities();

        private IHistoryRepository historyRepository;

        public IHistoryRepository HistoryRepository { 
            get
            {
                if(historyRepository == null)
                {
                    historyRepository = new HistoryRepository(db);
                }
                return historyRepository;
            }
        }

        public void Dispose()
        {
            db.Dispose();
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
