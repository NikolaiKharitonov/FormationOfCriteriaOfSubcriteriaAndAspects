using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationOfCriteriaOfSubcriteriaAndAspects.Controller
{
    class Connect
    {
        private static Model.ProductionPracticeEntities _context;
        public static Model.ProductionPracticeEntities GetContext()
        {
            if (_context == null)
            {
                _context = new Model.ProductionPracticeEntities();
            }
            return _context;
        }
    }
}
