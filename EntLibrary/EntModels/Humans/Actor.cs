using EntLibrary.EntModels.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntLibrary.EntModels.Humans
{
    //актеры
    public class Actor : Human
    {
        public List<Movie> Movies { get; set; }
    }
}
