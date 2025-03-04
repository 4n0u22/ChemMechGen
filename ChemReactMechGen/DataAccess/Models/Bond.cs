namespace DataAccess.Models;

public enum BondType : byte
{
    Single,
    Double,
    Triple
}

public class Bond(Atom atom1, Atom atom2, BondType type)
{
    public Atom Atom1 { get; set; } = atom1;
    public Atom Atom2 { get; set; } = atom2;
    public BondType BondType { get; set; } = type;
}