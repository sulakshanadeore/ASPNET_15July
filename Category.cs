using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NWBLL
{
    public class Category
    {
        int? _catid;
        public int? CatId 
        {
            get { return _catid; } 
            set 
            {
                if (string.IsNullOrEmpty(value.ToString()))
                {
                    throw new ArgumentNullException("Category id cannot be null");
                }
                else
                {
                    _catid = value;
                        
                }
            } 
        
        }
        public string CatName { get; set; }
        public string Desc { get; set; }
    }
}
