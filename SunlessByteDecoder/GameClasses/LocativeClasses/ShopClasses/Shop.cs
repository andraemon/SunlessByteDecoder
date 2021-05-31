using SunlessByteDecoder.GameClasses.BaseClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace SunlessByteDecoder.GameClasses.LocativeClasses.ShopClasses
{
    public class Shop : Entity
    {
        public Shop()
        {
            QualitiesRequired = new List<ShopQRequirement>();
        }
        public virtual string Name { get; set; }
        public virtual string Image { get; set; }
        public virtual string Description { get; set; }
        public virtual int Ordering { get; set; }
        public virtual Exchange Exchange { get; set; }
        public virtual IList<Availability> Availabilities { get; set; }
        public virtual IList<ShopQRequirement> QualitiesRequired { get; set; }
    }
}
