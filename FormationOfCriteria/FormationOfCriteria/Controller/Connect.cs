using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationOfCriteria.Controller
{
    class Connect
    {
        private static Model.ProductionPracticeEntities3 _context;
        public static Model.ProductionPracticeEntities3 GetContext()
        {
            if (_context == null)
            {
                _context = new Model.ProductionPracticeEntities3();
            }
            return _context;
        }
    }
}
