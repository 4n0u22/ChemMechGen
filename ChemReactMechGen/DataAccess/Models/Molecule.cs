using System.Collections.Generic;

namespace DataAccess.Models;

public class Molecule
{
    public int MoleculeId { get; set; }
    public List<Atom> Atoms { get; private set; }
    public List<Bond> Bonds { get; private set; }

    public Molecule()
    {
        Atoms = [];
        Bonds = [];
    }

    public void AddAtom(Atom atom)
    {
        Atoms.Add(atom);
    }

    public void AddBond(Bond bond)
    {
        Bonds.Add(bond);
    }
}