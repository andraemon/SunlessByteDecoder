using SunlessByteDecoder.GameClasses.BaseClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace SunlessByteDecoder.GameClasses.ProspectClasses.CompletionClasses
{
    public class Completion : Entity
    {
        public virtual Prospect Prospect { get; set; }
        public virtual string Description { get; set; }
        public virtual string SatisfactionMessage { get; set; }
        public virtual IList<CompletionQEffect> QualitiesAffected { get; set; }
        public virtual IList<CompletionQRequirement> QualitiesRequired { get; set; }
    }
}
