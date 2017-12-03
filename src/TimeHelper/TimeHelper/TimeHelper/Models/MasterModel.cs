using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeHelper.Views;

namespace TimeHelper.Model
{
    //Model for Maste page
    class MasterModel
    {
        public MasterModel(Type t)
        {
            TargetType = t;
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}
