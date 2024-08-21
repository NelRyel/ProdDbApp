using EntLibrary.EntModels.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntLibrary.EntModels.Companies
{
    public class Publisher : Company
    {
        public List<Game> Games { get; set; }
    }
}
