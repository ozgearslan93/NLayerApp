using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.DTOs
{
    public class ProductWithCategoryDto :ProductDto
    {
        public CategoryDto category { get; set; }

        //product ile birlikte category leride almak istediğimiz için bu özelliğiğ ekledik. ayrıca ProductDto dan da miras aldık
    }
}
