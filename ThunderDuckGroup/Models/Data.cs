using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ThunderDuckGroup.Models;

namespace ThunderDuckGroup.Models
{
    public class HomeMaster
    {
        public IQueryable<Td_Story> sto { get; set; }
        public IQueryable<Td_Tours> tou { get; set; }
        public IQueryable<Td_Events> eve { get; set; }
        public IQueryable<Td_Images> img { get; set; }
        public IQueryable<Td_Members> mem { get; set; }
        public IQueryable<Td_News> news { get; set; }
        public IQueryable<Td_Contact> con { get; set; }
    }
}