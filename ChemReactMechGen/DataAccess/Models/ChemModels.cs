using System.ComponentModel.DataAnnotations;
using DataAccess.Interface;
using DataAccess.Middleware;

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
public static class ElementLocalization
{
    public static Dictionary<string, Dictionary<string, (string LocalName, string LatinName)>> Translations = new()
    {
    { "en", new Dictionary<string, (string, string)>
        {
                { "Hydrogen", ("Hydrogen", "Hydrogenium") },
                { "Helium", ("Helium", "Helium") },
                { "Lithium", ("Lithium", "Lithium") },
                { "Beryllium", ("Beryllium", "Beryllium") },
                { "Boron", ("Boron", "Boron") },
                { "Carbon", ("Carbon", "Carbon") },
                { "Nitrogen", ("Nitrogen", "Nitrogen") },
                { "Oxygen", ("Oxygen", "Oxygen") },
                { "Fluorine", ("Fluorine", "Fluorine") },
                { "Neon", ("Neon", "Neon") },
                { "Sodium", ("Sodium", "Natrium") },
                { "Magnesium", ("Magnesium", "Magnesium") },
                { "Aluminum", ("Aluminum", "Aluminium") },
                { "Silicon", ("Silicon", "Silicium") },
                { "Phosphorus", ("Phosphorus", "Phosphorus") },
                { "Sulfur", ("Sulfur", "Sulphur") },
                { "Chlorine", ("Chlorine", "Chlorum") },
                { "Argon", ("Argon", "Argon") },
                { "Potassium", ("Potassium", "Kalium") },
                { "Calcium", ("Calcium", "Calcium") },
                { "Scandium", ("Scandium", "Scandium") },
                { "Titanium", ("Titanium", "Titanium") },
                { "Vanadium", ("Vanadium", "Vanadium") },
                { "Chromium", ("Chromium", "Chromium") },
                { "Manganese", ("Manganese", "Manganum") },
                { "Iron", ("Iron", "Ferrum") },
                { "Cobalt", ("Cobalt", "Cobaltum") },
                { "Nickel", ("Nickel", "Niccolum") },
                { "Copper", ("Copper", "Cuprum") },
                { "Zinc", ("Zinc", "Zincum") },
                { "Gallium", ("Gallium", "Gallium") },
                { "Germanium", ("Germanium", "Germanium") },
                { "Arsenic", ("Arsenic", "Arsenicum") },
                { "Selenium", ("Selenium", "Selenium") },
                { "Bromine", ("Bromine", "Bromum") },
                { "Krypton", ("Krypton", "Krypton") },
                { "Rubidium", ("Rubidium", "Rubidium") },
                { "Strontium", ("Strontium", "Strontium") },
                { "Yttrium", ("Yttrium", "Yttrium") },
                { "Zirconium", ("Zirconium", "Zirconium") },
                { "Niobium", ("Niobium", "Niobium") },
                { "Molybdenum", ("Molybdenum", "Molybdaenum") },
                { "Technetium", ("Technetium", "Technetium") },
                { "Ruthenium", ("Ruthenium", "Ruthenium") },
                { "Rhodium", ("Rhodium", "Rhodium") },
                { "Palladium", ("Palladium", "Palladium") },
                { "Silver", ("Silver", "Argentum") },
                { "Cadmium", ("Cadmium", "Cadmium") },
                { "Indium", ("Indium", "Indium") },
                { "Tin", ("Tin", "Stannum") },
                { "Antimony", ("Antimony", "Stibium") },
                { "Tellurium", ("Tellurium", "Tellurium") },
                { "Iodine", ("Iodine", "Iodum") },
                { "Xenon", ("Xenon", "Xenon") },
                { "Cesium", ("Cesium", "Caesium") },
                { "Barium", ("Barium", "Barium") },
                { "Lanthanum", ("Lanthanum", "Lanthanum") },
                { "Cerium", ("Cerium", "Cerium") },
                { "Praseodymium", ("Praseodymium", "Praseodymium") },
                { "Neodymium", ("Neodymium", "Neodymium") },
                { "Promethium", ("Promethium", "Promethium") },
                { "Samarium", ("Samarium", "Samarium") },
                { "Europium", ("Europium", "Europium") },
                { "Gadolinium", ("Gadolinium", "Gadolinium") },
                { "Terbium", ("Terbium", "Terbium") },
                { "Dysprosium", ("Dysprosium", "Dysprosium") },
                { "Holmium", ("Holmium", "Holmium") },
                { "Erbium", ("Erbium", "Erbium") },
                { "Thulium", ("Thulium", "Thulium") },
                { "Ytterbium", ("Ytterbium", "Ytterbium") },
                { "Lutetium", ("Lutetium", "Lutetium") },
                { "Hafnium", ("Hafnium", "Hafnium") },
                { "Tantalum", ("Tantalum", "Tantalum") },
                { "Tungsten", ("Tungsten", "Wolfram") },
                { "Rhenium", ("Rhenium", "Rhenium") },
                { "Osmium", ("Osmium", "Osmium") },
                { "Iridium", ("Iridium", "Iridium") },
                { "Platinum", ("Platinum", "Platinum") },
                { "Gold", ("Gold", "Aurum") },
                { "Mercury", ("Mercury", "Hydrargyrum") },
                { "Thallium", ("Thallium", "Thallium") },
                { "Lead", ("Lead", "Plumbum") },
                { "Bismuth", ("Bismuth", "Bismuthum") },
                { "Polonium", ("Polonium", "Polonium") },
                { "Astatine", ("Astatine", "Astatum") },
                { "Radon", ("Radon", "Radon") },
                { "Francium", ("Francium", "Francium") },
                { "Radium", ("Radium", "Radium") },
                { "Actinium", ("Actinium", "Actinium") },
                { "Thorium", ("Thorium", "Thorium") },
                { "Protactinium", ("Protactinium", "Protactinium") },
                { "Uranium", ("Uranium", "Uranium") },
                { "Neptunium", ("Neptunium", "Neptunium") },
                { "Plutonium", ("Plutonium", "Plutonium") },
                { "Americium", ("Americium", "Americium") },
                { "Curium", ("Curium", "Curium") },
                { "Berkelium", ("Berkelium", "Berkelium") },
                { "Californium", ("Californium", "Californium") },
                { "Einsteinium", ("Einsteinium", "Einsteinium") },
                { "Fermium", ("Fermium", "Fermium") },
                { "Mendelevium", ("Mendelevium", "Mendelevium") },
                { "Nobelium", ("Nobelium", "Nobelium") },
                { "Lawrencium", ("Lawrencium", "Lawrencium") },
                { "Rutherfordium", ("Rutherfordium", "Rutherfordium") },
                { "Dubnium", ("Dubnium", "Dubnium") },
                { "Seaborgium", ("Seaborgium", "Seaborgium") },
                { "Bohrium", ("Bohrium", "Bohrium") },
                { "Hassium", ("Hassium", "Hassium") },
                { "Meitnerium", ("Meitnerium", "Meitnerium") },
                { "Darmstadtium", ("Darmstadtium", "Darmstadtium") },
                { "Roentgenium", ("Roentgenium", "Roentgenium") },
                { "Copernicium", ("Copernicium", "Copernicium") },
                { "Nihonium", ("Nihonium", "Nihonium") },
                { "Flerovium", ("Flerovium", "Flerovium") },
                { "Moscovium", ("Moscovium", "Moscovium") },
                { "Livermorium", ("Livermorium", "Livermorium") },
                { "Tennessine", ("Tennessine", "Tennessine") },
                { "Oganesson", ("Oganesson", "Oganesson") }

                        }
    },
    { "ru", new Dictionary<string, (string, string)>
        {
{ "Hydrogen", ("Водород", "Hydrogenium") },
{ "Helium", ("Гелий", "Helium") },
{ "Lithium", ("Литий", "Lithium") },
{ "Beryllium", ("Бериллий", "Beryllium") },
{ "Boron", ("Бор", "Borum") },
{ "Carbon", ("Углерод", "Carboneum") },
{ "Nitrogen", ("Азот", "Nitrogenium") },
{ "Oxygen", ("Кислород", "Oxygenium") },
{ "Fluorine", ("Фтор", "Fluorum") },
{ "Neon", ("Неон", "Neon") },
{ "Sodium", ("Натрий", "Natrium") },
{ "Magnesium", ("Магний", "Magnesium") },
{ "Aluminum", ("Алюминий", "Aluminium") },
{ "Silicon", ("Кремний", "Silicium") },
{ "Phosphorus", ("Фосфор", "Phosphorus") },
{ "Sulfur", ("Сера", "Sulphur") },
{ "Chlorine", ("Хлор", "Chlorum") },
{ "Argon", ("Аргон", "Argon") },
{ "Potassium", ("Калий", "Kalium") },
{ "Calcium", ("Кальций", "Calcium") },
{ "Scandium", ("Скандий", "Scandium") },
{ "Titanium", ("Титан", "Titanium") },
{ "Vanadium", ("Ванадий", "Vanadium") },
{ "Chromium", ("Хром", "Chromium") },
{ "Manganese", ("Марганец", "Manganum") },
{ "Iron", ("Железо", "Ferrum") },
{ "Cobalt", ("Кобальт", "Cobaltum") },
{ "Nickel", ("Никель", "Niccolum") },
{ "Copper", ("Медь", "Cuprum") },
{ "Zinc", ("Цинк", "Zincum") },
{ "Gallium", ("Галлий", "Gallium") },
{ "Germanium", ("Германий", "Germanium") },
{ "Arsenic", ("Мышьяк", "Arsenicum") },
{ "Selenium", ("Селен", "Selenium") },
{ "Bromine", ("Бром", "Bromum") },
{ "Krypton", ("Криптон", "Krypton") },
{ "Rubidium", ("Рубидий", "Rubidium") },
{ "Strontium", ("Стронций", "Strontium") },
{ "Yttrium", ("Иттрий", "Yttrium") },
{ "Zirconium", ("Цирконий", "Zirconium") },
{ "Niobium", ("Ниобий", "Niobium") },
{ "Molybdenum", ("Молибден", "Molybdaenum") },
{ "Technetium", ("Технеций", "Technetium") },
{ "Ruthenium", ("Рутений", "Ruthenium") },
{ "Rhodium", ("Родий", "Rhodium") },
{ "Palladium", ("Палладий", "Palladium") },
{ "Silver", ("Серебро", "Argentum") },
{ "Cadmium", ("Кадмий", "Cadmium") },
{ "Indium", ("Индий", "Indium") },
{ "Tin", ("Олово", "Stannum") },
{ "Antimony", ("Сурьма", "Stibium") },
{ "Tellurium", ("Теллур", "Tellurium") },
{ "Iodine", ("Йод", "Iodum") },
{ "Xenon", ("Ксенон", "Xenon") },
{ "Cesium", ("Цезий", "Caesium") },
{ "Barium", ("Барий", "Barium") },
{ "Lanthanum", ("Лантан", "Lanthanum") },
{ "Cerium", ("Церий", "Cerium") },
{ "Praseodymium", ("Празеодим", "Praseodymium") },
{ "Neodymium", ("Неодим", "Neodymium") },
{ "Promethium", ("Прометий", "Promethium") },
{ "Samarium", ("Самарий", "Samarium") },
{ "Europium", ("Европий", "Europium") },
{ "Gadolinium", ("Гадолиний", "Gadolinium") },
{ "Terbium", ("Тербий", "Terbium") },
{ "Dysprosium", ("Диспрозий", "Dysprosium") },
{ "Holmium", ("Гольмий", "Holmium") },
{ "Erbium", ("Эрбий", "Erbium") },
{ "Thulium", ("Тулий", "Thulium") },
{ "Ytterbium", ("Иттербий", "Ytterbium") },
{ "Lutetium", ("Лютеций", "Lutetium") },
{ "Hafnium", ("Гафний", "Hafnium") },
{ "Tantalum", ("Тантал", "Tantalum") },
{ "Tungsten", ("Вольфрам", "Wolframium") },
{ "Rhenium", ("Рений", "Rhenium") },
{ "Osmium", ("Осмий", "Osmium") },
{ "Iridium", ("Иридий", "Iridium") },
{ "Platinum", ("Платина", "Platinum") },
{ "Gold", ("Золото", "Aurum") },
{ "Mercury", ("Ртуть", "Hydrargyrum") },
{ "Thallium", ("Таллий", "Thallium") },
{ "Lead", ("Свинец", "Plumbum") },
{ "Bismuth", ("Висмут", "Bismuthum") },
{ "Polonium", ("Полоний", "Polonium") },
{ "Astatine", ("Астат", "Astatinum") },
{ "Radon", ("Радон", "Radon") },
{ "Francium", ("Франций", "Francium") },
{ "Radium", ("Радий", "Radium") },
{ "Actinium", ("Актиний", "Actinium") },
{ "Thorium", ("Торий", "Thorium") },
{ "Protactinium", ("Протактиний", "Protactinium") },
{ "Uranium", ("Уран", "Uranium") },
{ "Neptunium", ("Нептуний", "Neptunium") },
{ "Plutonium", ("Плутоний", "Plutonium") },
{ "Americium", ("Америций", "Americium") },
{ "Curium", ("Кюрий", "Curium") },
{ "Berkelium", ("Берклий", "Berkelium") },
{ "Californium", ("Калифорний", "Californium") },
{ "Einsteinium", ("Айнштейний", "Einsteinium") },
{ "Fermium", ("Фермий", "Fermium") },
{ "Mendelevium", ("Менделевий", "Mendelevium") },
{ "Nobelium", ("Нобелий", "Nobelium") },
{ "Lawrencium", ("Лоуренсий", "Lawrencium") },
{ "Rutherfordium", ("Резерфордий", "Rutherfordium") },
{ "Dubnium", ("Дубний", "Dubnium") },
{ "Seaborgium", ("Сиборгий", "Seaborgium") },
{ "Bohrium", ("Борий", "Bohrium") },
{ "Hassium", ("Хассий", "Hassium") },
{ "Meitnerium", ("Мейтнерий", "Meitnerium") },
{ "Darmstadtium", ("Дармштадтий", "Darmstadtium") },
{ "Roentgenium", ("Рентгений", "Roentgenium") },
{ "Copernicium", ("Коперниций", "Copernicium") },
{ "Nihonium", ("Нихоний", "Nihonium") },
{ "Flerovium", ("Флеровий", "Flerovium") },
{ "Moscovium", ("Московий", "Moscovium") },
{ "Livermorium", ("Ливерморий", "Livermorium") },
{ "Tennessine", ("Теннессин", "Tennessine") },
{ "Oganesson", ("Оганесон", "Oganesson") }

        }
    }
    // Добавьте другие языки...
};
}
public class Atom
{
    public int AtomId { get; set; }

    [Required]
    [StringLength(50, MinimumLength = 1)]
    public string Name { get; set; }

            [Required]
    [StringLength(3, MinimumLength = 1)]
    public string Symbol { get; set; }

        [Range(1, 118)]
 public byte AtomicNumber { get; set; }
    public decimal AtomicWeight{ get; set; }// получается из PeriodicTableGenerator, а не =>CalculateAtomicWeight();
    
       [Range(1, 7)]
    public byte Period { get; set; }

    [Range(1, 18)]
    public byte Group { get; set; }

    public Nucleus AtomNucleus { get; set; }
    public Electron Electrons { get; set; }
    public Dictionary<byte, Electron> ElectronLevels { get; set; }

    public decimal IonizationEnergy { get; set; }
    public decimal ElectronAffinity { get; set; }
    public decimal Electronegativity { get; set; }
    public decimal AtomicRadius { get; set; }
    public decimal MolecularMass =>CalculateMolecularMass();
    public byte ValenceElectrons { get; set; } 

    public Atom()
    {
        Name = "";
        Symbol = "";
        AtomNucleus = new Nucleus(0, 0);
        Electrons = new Electron(0);
        ElectronLevels = [];
    }

    public Atom(
        string name, string symbol, byte atomicNumber, byte period, byte group, byte protons, byte neutrons, byte electrons, decimal ionizationEnergy, decimal electronAffinity, decimal electronegativity, decimal atomicRadius, byte valenceElectrons)
    {
        
                   if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Name cannot be empty.", nameof(name));
        if (string.IsNullOrWhiteSpace(symbol)) throw new ArgumentException("Symbol cannot be empty.", nameof(symbol));
        if (atomicNumber < 1 || atomicNumber > 118) throw new ArgumentException("AtomicNumber must be between 1 and 118.", nameof(atomicNumber));

        Name = name;
        Symbol = symbol;
        AtomicNumber = atomicNumber;
        Period = period;
        Group = group;
        AtomNucleus = new Nucleus(protons, neutrons);
        Electrons = new Electron(electrons);
        ElectronLevels = CalculateElectronLevels(electrons);
        IonizationEnergy = ionizationEnergy;
        ElectronAffinity = electronAffinity;
        Electronegativity = electronegativity;
        AtomicRadius = atomicRadius;
        ValenceElectrons = valenceElectrons;
        
    }

    public (string LocalName, string LatinName) GetLocalizedNames(string languageCode)
    {
        if (ElementLocalization.Translations.TryGetValue(languageCode, out var translations))
        {
            if (translations.TryGetValue(Name, out var names))
            {
                return names;
            }
        }
        return (Name, Name); // Вернуть оригинальное название, если перевод не найден
    }

    private static Dictionary<byte, Electron> CalculateElectronLevels(byte numberOfElectrons)
    {
        Dictionary<byte, Electron> levels = [];
        byte[] maxElectronsPerLevel = [2, 8, 18, 32, 50, 72, 98];
        byte remainingElectrons = numberOfElectrons;
        byte level = 1;

        foreach (var maxElectrons in maxElectronsPerLevel)
        {
            byte electronsToAdd = Math.Min(remainingElectrons, maxElectrons);
            levels[level] = new Electron (electronsToAdd);

            remainingElectrons -= electronsToAdd;

            if (remainingElectrons == 0)
            {
                break;
            }

            level++;
        }

        return levels;
    }
    private decimal CalculateAtomicWeight()
    {
        decimal protonMass = 1.67262192369e-27m;
        decimal neutronMass = protonMass;
        decimal electronMass = 9.1093837015e-31m;

        byte neutrons = (byte)(AtomNucleus.TotalParticles - AtomNucleus.NumberOfChargeCarriers); // Количество нейтронов
        byte protons = (byte)(AtomNucleus.TotalParticles - neutrons); // Количество протонов
        byte electrons = Electrons.NumberOfChargeCarriers; // Количество электронов

        return (protons * protonMass) + (neutrons * neutronMass) + (electrons * electronMass);
    }

    private decimal CalculateMolecularMass()
    {
        return CalculateAtomicWeight(); // Используем расчет атомной массы для молекулярной массы
    }
}
public class Molecule
{
    public int MoleculeId { get; set; }
    public List<Atom> Atoms { get; private set; }
    public List<Bond> Bonds { get; private set; }
    public string? Name { get; internal set; }

    [Range(1, int.MaxValue)]
    public int Coefficient { get; set; } = 1; // Стехиометрический коэффициент

    public Molecule()
    {
        Atoms = [];
        Bonds = [];
    }

    public void AddAtom(Atom atom)
    {
        if (atom == null) throw new ArgumentNullException(nameof(atom));
        Atoms.Add(atom);
    }

    public void AddBond(Bond bond)
    {
        if (bond == null) throw new ArgumentNullException(nameof(bond));
        if (!Atoms.Contains(bond.Atom1) || !Atoms.Contains(bond.Atom2))
        {
            throw new ArgumentException("Bond atoms must be part of the molecule's atom list.");
        }
        Bonds.Add(bond);
    }

    public void SetName(string name)
    {
        if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Name cannot be empty.", nameof(name));
        Name = name;
    }
}
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
public class PeriodicTable
{
    public List<Atom> Elements { get; private set; }

    public PeriodicTable()
    {
        Elements = PeriodicTableGenerator.GeneratePeriodicTable();
    }

    public Atom GetElementByName(string name)
    {
        if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Name cannot be empty.", nameof(name));
        return Elements.Find(e => e.Name.Equals(name, StringComparison.OrdinalIgnoreCase)) ?? throw new KeyNotFoundException($"Element {name} not found.");
    }

    public Atom GetElementBySymbol(string symbol)
    {
        if (string.IsNullOrWhiteSpace(symbol)) throw new ArgumentException("Symbol cannot be empty.", nameof(symbol));
        return Elements.Find(e => e.Symbol.Equals(symbol, StringComparison.OrdinalIgnoreCase)) ?? throw new KeyNotFoundException($"Element with symbol {symbol} not found.");
    }

    public Atom GetElementByAtomicNumber(byte atomicNumber)
    {
        return Elements.Find(e => e.AtomicNumber == atomicNumber) ?? throw new KeyNotFoundException($"Element with atomic number {atomicNumber} not found.");
    }

    public Atom GetElementByPeriod(byte period)
    {
        return Elements.Find(e => e.Period == period) ?? throw new KeyNotFoundException($"Element with period {period} not found.");
    }

    public Atom GetElementByGroup(byte group)
    {
        return Elements.Find(e => e.Group == group) ?? throw new KeyNotFoundException($"Element with group {group} not found.");
    }
}
public class Reaction
{
    public int ReactionId { get; set; }
    public List<Molecule> Reactants { get; private set; }
    public List<Molecule> Products { get; private set; }
    public Dictionary<string, object> Conditions { get; private set; }

    public Reaction(List<Molecule> reactants, List<Molecule> products, Dictionary<string, object> conditions)
    {
        Reactants = reactants ?? throw new ArgumentNullException(nameof(reactants));
        Products = products ?? throw new ArgumentNullException(nameof(products));
        Conditions = conditions ?? throw new ArgumentNullException(nameof(conditions));

        if (!reactants.Any()) throw new ArgumentException("Reactants list cannot be empty.", nameof(reactants));
        if (!products.Any()) throw new ArgumentException("Products list cannot be empty.", nameof(products));
    }
}
