

using System;
using System.Collections.Generic;
namespace DataAccess.Models;

public class Atom
{
    public int AtomId { get; set; }
    public string Name { get; set; }
    public string Symbol { get; set; }
    public byte AtomicNumber { get; set; }
    public decimal AtomicWeight =>CalculateAtomicWeight();
    public byte Period { get; set; }
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

    public Atom() { }

    public Atom(
        string name, string symbol, byte atomicNumber, byte period, byte group, byte protons, byte neutrons, byte electrons, decimal ionizationEnergy, decimal electronAffinity, decimal electronegativity, decimal atomicRadius, byte valenceElectrons)
    {
 {
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
        decimal neutronMass = 1.67492749804e-27m;
        decimal electronMass = 9.1093837015e-31m;

        byte protons = (byte)(AtomNucleus.TotalParticles - AtomNucleus.NumberOfChargeCarriers); // Количество протонов
        byte neutrons = (byte)(AtomNucleus.TotalParticles - protons); // Количество нейтронов
        byte electrons = Electrons.NumberOfChargeCarriers; // Количество электронов

        return (protons * protonMass) + (neutrons * neutronMass) + (electrons * electronMass);
    }

    private decimal CalculateMolecularMass()
    {
        return CalculateAtomicWeight(); // Используем расчет атомной массы для молекулярной массы
    }
}
