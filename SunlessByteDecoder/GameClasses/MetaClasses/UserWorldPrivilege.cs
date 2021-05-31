using SunlessByteDecoder.GameClasses.BaseClasses;
using SunlessByteDecoder.GameClasses.LocativeClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace SunlessByteDecoder.GameClasses.MetaClasses
{
    public class UserWorldPrivilege : Entity
    {
        public virtual World World { get; set; }
        public virtual PrivilegeLevel PrivilegeLevel { get; set; }
        public virtual User User { get; set; }
    }
}
