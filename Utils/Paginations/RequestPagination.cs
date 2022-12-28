using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils.Paginations
{
    public class RequestPagination<T>
    {
        private int _page = 1;
        private int _perPage = 10;

        public int Page 
        {
            get { return (_page <= 0) ? 1: _page; }
            set { _page = value;}
        }

        public int PerPage
        {
            get { return (_perPage <= 0) ? 10 : _perPage; }
            set { _perPage = value; }
        }
        public T Filter { get; set; }
    }
}
