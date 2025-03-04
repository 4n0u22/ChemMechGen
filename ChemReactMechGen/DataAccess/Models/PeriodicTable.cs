using System.Collections.Generic;
using DataAccess.Middleware;

namespace DataAccess.Models;

public class PeriodicTable
{
    public List<Atom> Elements { get; private set; }

    public PeriodicTable()
    {
        Elements = PeriodicTableGenerator.GeneratePeriodicTable();
    }

    public Atom GetElementByName(string name)
    {
        return Elements.Find(e => e.Name.Equals(name, StringComparison.OrdinalIgnoreCase))!;
    }

    public Atom GetElementBySymbol(string symbol)
    {
        return Elements.Find(e => e.Symbol.Equals(symbol, StringComparison.OrdinalIgnoreCase))!;
    }

    public Atom GetElementByAtomicNumber(byte atomicNumber)
    {
        return Elements.Find(e => e.AtomicNumber == atomicNumber)!;
    }

    public Atom GetElementByPeriod(byte period)
    {
        return Elements.Find(e => e.Period == period)!;
    }

    public Atom GetElementByGroup(byte group)
    {
        return Elements.Find(e => e.Group == group)!;
    }
}