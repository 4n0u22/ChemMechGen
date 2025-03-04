using System.Collections.Generic;

namespace DataAccess.Models
{
    public class Reaction(List<Molecule> reactants, List<Molecule> products, Dictionary<string, object> conditions)
    {
        public int ReactionId { get; set; }
        public List<Molecule> Reactants { get; private set; } = reactants;
        public List<Molecule> Products { get; private set; } = products;
        public Dictionary<string, object> Conditions { get; private set; } = conditions;
    }
}