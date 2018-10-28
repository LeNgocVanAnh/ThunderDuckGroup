using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ThunderDuckGroup.Models;

namespace ThunderDuckGroup.Models
{
    public class HomeMaster
    {
        public IQueryable<Td_BrandMaker_Story> sto { get; set; }
        public IQueryable<Td_BrandMaker_Slider> sli { get; set; }
        public List<Td_BrandMaker_Tours> tou { get; set; }
        public List<Td_BrandMaker_Events> eve { get; set; }
        public List<Td_BrandMaker_News> newss { get; set; }
        public IQueryable<Td_BrandMaker_Images> img { get; set; }
        public List<Td_BrandMaker_Members> mem { get; set; }
        public IQueryable<Td_BrandMaker_Contact> con { get; set; }

    }
    public class ConMaster { 
        public IQueryable<Td_Constrution_Story> stor { get; set; }
        public IQueryable<Td_Construction_Slider> slie { get; set; }
        public List<Td_Construction_Construction> constr { get; set; }
        public IQueryable<Td_Construction_Contact> conta { get; set; }
        public List<Td_Construction_Images> ima { get; set; }
        public List<Td_Construction_Member> meme { get; set; }
        public List<Td_Construction_New> news { get; set; }
    }
}
