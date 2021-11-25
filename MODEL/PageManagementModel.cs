using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class PageManagementModel
    {
        public int PageID { get; set; }
        public string PageName { get; set; }
        public string PageContent { get; set; }
        public string Title { get; set; }
        public string Desription { get; set; }
        public string Keywords { get; set; }
        public bool IsActive { get; set; }
    }
}
