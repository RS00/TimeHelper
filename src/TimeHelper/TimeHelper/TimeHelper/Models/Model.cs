using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeHelper.Views;

namespace TimeHelper.Model
{

    public class Model
    {
        public Model()
        {
            TargetType = typeof(ItemDetail);
        }
        public String Name { get; set; }
        public string Date { get; set; }

        public Type TargetType { get; set; }
    }
}