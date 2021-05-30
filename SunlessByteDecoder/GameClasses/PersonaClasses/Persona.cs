using SunlessByteDecoder.GameClasses.BaseClasses;
using SunlessByteDecoder.GameClasses.LocativeClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace SunlessByteDecoder.GameClasses.PersonaClasses
{
    internal class Persona : EntityWithName
    {
        public Persona()
        {
            DateTimeCreated = DateTime.Now;
            QualitiesAffected = new List<PersonaQEffect>();
            QualitiesRequired = new List<PersonaQRequirement>();
        }
        public virtual IList<PersonaQEffect> QualitiesAffected { get; set; }
        public virtual IList<PersonaQRequirement> QualitiesRequired { get; set; }
        public virtual string Description { get; set; }
        public virtual string OwnerName { get; set; }
        public virtual Setting Setting { get; set; }
        public virtual DateTime DateTimeCreated { get; set; }
    }
}
