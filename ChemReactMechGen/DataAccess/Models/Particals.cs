namespace DataAccess.Models;

public abstract partial class Частица
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public abstract double Масса { get; set; }
    public abstract sbyte Спин { get; set; }
    public abstract sbyte Заряд { get; }
    public abstract byte КолвоНесущихЗаряд { get; set; }

}
public sealed partial class Электрон : Частица
{
    public override double Масса { get; set; } = 9.10938356e-31; // Масса электрона в кг
    public override sbyte Спин { get; set; }
    public override sbyte Заряд => -1;
    public override byte КолвоНесущихЗаряд { get; set; } = 0;
}
public sealed partial class Ядро : Частица
{
    public override double Масса { get; set; } = 1.6726219e-27; // Масса протона в кг
    public override sbyte Спин { get; set; }
    public override sbyte Заряд => 1;
    public override byte КолвоНесущихЗаряд { get; set; } = 1;
    public int КолвоЧастиц { get; set; } = 1;
}
