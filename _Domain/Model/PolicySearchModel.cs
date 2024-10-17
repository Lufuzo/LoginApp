using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace _Domain.Model
{
   public class PolicySearchModel
    {

        public Int32? SchemeCode { get; set; }
        public IEnumerable<SelectListItem> GroupSchemes { get; set; }
        public Int32? SubSchemeCode { get; set; }
        public IEnumerable<SelectListItem> SubSchemes { get; set; }
        public String PolicySearch { get; set; }
        public Int32 PolicySearchType { get; set; }
    }
}
