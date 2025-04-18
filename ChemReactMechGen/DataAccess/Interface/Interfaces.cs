using System;
using DataAccess.Models;

namespace DataAccess.Interface;

public interface IElementRepository
{
    Atom GetByAtomicNumber(byte number);
    IEnumerable<Atom> GetByGroup(byte group);
    IEnumerable<Atom> GetByPeriod(byte period);
 
}
public interface IParticle
{
    Guid ID { get; }
    decimal Mass { get; set; }
    int Charge { get; set; }
    double Spin { get; set; }
    byte NumberOfChargeCarriers { get; set; }
}
