using System;
using System.Collections.Generic;
using System.Text;
using ZCore.Enums;

namespace ZCore.Model
{
    public class User : AbstractModel
    {
        public Int64 IDUser { get; set; }

        public string Name { get; set; }

        public UserType UserType { get; set; }

        public override object Clone()
        {
            return this.Clone<User>();
        }
    }
}
