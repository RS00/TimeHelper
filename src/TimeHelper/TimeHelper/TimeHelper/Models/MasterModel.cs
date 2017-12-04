using System;

namespace TimeHelper.Model
{
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
