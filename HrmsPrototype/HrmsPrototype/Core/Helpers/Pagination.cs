using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrmsPrototype.Core.Helpers
{
    internal class Pagination
    {
        private int _pageSize = 20;
        public int PageSize 
        { 
            get => _pageSize; 
            set => _pageSize = value; 
        }

        private int _pageNumber = 1;
        public int PageNumber 
        { 
            get => _pageNumber; 
            set => _pageNumber = value; 
        }
    }
}
