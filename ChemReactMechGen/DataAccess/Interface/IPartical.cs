using System;
namespace DataAccess.Interface;
public interface IParticle
{
    Guid ID { get; }
    decimal Mass { get; set; }
    int Charge { get; set; }
    double Spin { get; set; }
    byte NumberOfChargeCarriers { get; set; }
}
