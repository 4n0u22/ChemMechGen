using DataAccess.Interface;
namespace DataAccess.Models;
public class Electron(byte quantity) : IParticle
{
    public Guid ID { get; private set; } = Guid.NewGuid();
    public decimal Mass { get; set; } = 9.1093837015e-31m; // масса электрона в кг
    public int Charge { get; set; } = -1;
    public double Spin { get; set; } = 0.5;
    public byte NumberOfChargeCarriers { get; set; } = quantity;
}

public class Nucleus(byte protons, byte neutrons) : IParticle
{
    public Guid ID { get; private set; } = Guid.NewGuid();
    public decimal Mass { get; set; } = 1.67262192369e-27m; // точная масса протона в кг
    public int Charge { get; set; } = 1;
    public double Spin { get; set; } = 0.5;
    public byte NumberOfChargeCarriers { get; set; } = protons;
    public byte TotalParticles { get; set; } = (byte)(protons + neutrons);
}