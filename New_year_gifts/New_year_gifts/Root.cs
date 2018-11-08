using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_year_gifts
{
    class Root
    {       //all sweets    
            [JsonProperty(PropertyName = "Chocolate")]
            public ICollection<ChocolateSweets> Chocolate { get; set; }
            [JsonProperty(PropertyName = "Lollipop")]
            public ICollection<Lollipop> Lollipop { get; set; }
        
    }
}
