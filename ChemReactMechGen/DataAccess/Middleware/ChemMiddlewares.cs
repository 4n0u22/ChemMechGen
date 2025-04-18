using System;
using System.Collections.Generic;
using DataAccess.Models;

namespace DataAccess.Middleware;
 public class MoleculeCalculator
{
    public decimal CalculateMolecularWeight(Molecule molecule)
    {
        return molecule.Atoms.Sum(a => a.AtomicWeight);
    }
}

    public class ReactionBalancer
    {
        public bool IsBalanced(Reaction reaction)
        {
            if (reaction == null || reaction.Reactants == null || reaction.Products == null)
            {
                return false;
            }

            if (!reaction.Reactants.Any() || !reaction.Products.Any())
            {
                return false;
            }

            var reactantAtoms = CountAtoms(reaction.Reactants);
            var productAtoms = CountAtoms(reaction.Products);

            if (reactantAtoms.Count != productAtoms.Count)
            {
                return false;
            }

            foreach (var element in reactantAtoms)
            {
                if (!productAtoms.TryGetValue(element.Key, out int productCount) || productCount != element.Value)
                {
                    return false;
                }
            }

            return true;
        }

        private Dictionary<byte, int> CountAtoms(List<Molecule> molecules)
        {
            var atomCounts = new Dictionary<byte, int>();

            foreach (var molecule in molecules)
            {
                if (molecule?.Atoms == null || molecule.Coefficient < 1)
                {
                    continue;
                }

                foreach (var atom in molecule.Atoms)
                {
                    if (atom == null)
                    {
                        continue;
                    }

                    byte atomicNumber = atom.AtomicNumber;
                    int count = molecule.Coefficient;

                    if (atomCounts.ContainsKey(atomicNumber))
                    {
                        atomCounts[atomicNumber] += count;
                    }
                    else
                    {
                        atomCounts[atomicNumber] = count;
                    }
                }
            }

            return atomCounts;
        }
    }
public static class PeriodicTableGenerator
{
public static List<Atom> GeneratePeriodicTable()
{
    return
    [
 new() { Name = "Hydrogen", Symbol = "H", AtomicNumber = 1, Period = 1, Group = 1, AtomNucleus = new Nucleus(1, 0), Electrons = new Electron(1), IonizationEnergy = 13.5984m, ElectronAffinity = 0.7542m, Electronegativity = 2.20m, AtomicRadius = 0.53m, ValenceElectrons = 1 },
new() { Name = "Helium", Symbol = "He", AtomicNumber = 2, Period = 1, Group = 18, AtomNucleus = new Nucleus(2, 2), Electrons = new Electron(2), IonizationEnergy = 24.5874m, ElectronAffinity = 0m, Electronegativity = 0m, AtomicRadius = 0.31m, ValenceElectrons = 2 },
new() { Name = "Lithium", Symbol = "Li", AtomicNumber = 3, Period = 2, Group = 1, AtomNucleus = new Nucleus(3, 4), Electrons = new Electron(3), IonizationEnergy = 5.3917m, ElectronAffinity = 0.618m, Electronegativity = 0.98m, AtomicRadius = 1.67m, ValenceElectrons = 1 },
new() { Name = "Beryllium", Symbol = "Be", AtomicNumber = 4, Period = 2, Group = 2, AtomNucleus = new Nucleus(4, 5), Electrons = new Electron(4), IonizationEnergy = 9.3227m, ElectronAffinity = 0m, Electronegativity = 1.57m, AtomicRadius = 1.12m, ValenceElectrons = 2 },
new() { Name = "Boron", Symbol = "B", AtomicNumber = 5, Period = 2, Group = 13, AtomNucleus = new Nucleus(5, 6), Electrons = new Electron(5), IonizationEnergy = 8.2980m, ElectronAffinity = 0.2797m, Electronegativity = 2.04m, AtomicRadius = 0.87m, ValenceElectrons = 3 },
new() { Name = "Carbon", Symbol = "C", AtomicNumber = 6, Period = 2, Group = 14, AtomNucleus = new Nucleus(6, 6), Electrons = new Electron(6), IonizationEnergy = 11.2603m, ElectronAffinity = 1.2621m, Electronegativity = 2.55m, AtomicRadius = 0.67m, ValenceElectrons = 4 },
new() { Name = "Nitrogen", Symbol = "N", AtomicNumber = 7, Period = 2, Group = 15, AtomNucleus = new Nucleus(7, 7), Electrons = new Electron(7), IonizationEnergy = 14.5341m, ElectronAffinity = 0m, Electronegativity = 3.04m, AtomicRadius = 0.56m, ValenceElectrons = 5 },
new() { Name = "Oxygen", Symbol = "O", AtomicNumber = 8, Period = 2, Group = 16, AtomNucleus = new Nucleus(8, 8), Electrons = new Electron(8), IonizationEnergy = 13.6181m, ElectronAffinity = 1.4611m, Electronegativity = 3.44m, AtomicRadius = 0.48m, ValenceElectrons = 6 },
new() { Name = "Fluorine", Symbol = "F", AtomicNumber = 9, Period = 2, Group = 17, AtomNucleus = new Nucleus(9, 10), Electrons = new Electron(9), IonizationEnergy = 17.4228m, ElectronAffinity = 3.4012m, Electronegativity = 3.98m, AtomicRadius = 0.42m, ValenceElectrons = 7 },
new() { Name = "Neon", Symbol = "Ne", AtomicNumber = 10, Period = 2, Group = 18, AtomNucleus = new Nucleus(10, 10), Electrons = new Electron(10), IonizationEnergy = 21.5645m, ElectronAffinity = 0m, Electronegativity = 0m, AtomicRadius = 0.38m, ValenceElectrons = 8 },
new() { Name = "Sodium", Symbol = "Na", AtomicNumber = 11, Period = 3, Group = 1, AtomNucleus = new Nucleus(11, 12), Electrons = new Electron(11), IonizationEnergy = 5.1391m, ElectronAffinity = 0.548m, Electronegativity = 0.93m, AtomicRadius = 1.90m, ValenceElectrons = 1 },
new() { Name = "Magnesium", Symbol = "Mg", AtomicNumber = 12, Period = 3, Group = 2, AtomNucleus = new Nucleus(12, 12), Electrons = new Electron(12), IonizationEnergy = 7.6462m, ElectronAffinity = 0m, Electronegativity = 1.31m, AtomicRadius = 1.45m, ValenceElectrons = 2 },
new() { Name = "Aluminium", Symbol = "Al", AtomicNumber = 13, Period = 3, Group = 13, AtomNucleus = new Nucleus(13, 14), Electrons = new Electron(13), IonizationEnergy = 5.9858m, ElectronAffinity = 0.441m, Electronegativity = 1.61m, AtomicRadius = 1.18m, ValenceElectrons = 3 },
new() { Name = "Silicon", Symbol = "Si", AtomicNumber = 14, Period = 3, Group = 14, AtomNucleus = new Nucleus(14, 14), Electrons = new Electron(14), IonizationEnergy = 8.1517m, ElectronAffinity = 1.389m, Electronegativity = 1.90m, AtomicRadius = 1.11m, ValenceElectrons = 4 },
new() { Name = "Phosphorus", Symbol = "P", AtomicNumber = 15, Period = 3, Group = 15, AtomNucleus = new Nucleus(15, 16), Electrons = new Electron(15), IonizationEnergy = 10.4867m, ElectronAffinity = 0.7465m, Electronegativity = 2.19m, AtomicRadius = 0.98m, ValenceElectrons = 5 },
new() { Name = "Sulfur", Symbol = "S", AtomicNumber = 16, Period = 3, Group = 16, AtomNucleus = new Nucleus(16, 16), Electrons = new Electron(16), IonizationEnergy = 10.36m, ElectronAffinity = 2.077m, Electronegativity = 2.58m, AtomicRadius = 0.88m, ValenceElectrons = 6 },
new() { Name = "Chlorine", Symbol = "Cl", AtomicNumber = 17, Period = 3, Group = 17, AtomNucleus = new Nucleus(17, 18), Electrons = new Electron(17), IonizationEnergy = 12.9676m, ElectronAffinity = 3.6127m, Electronegativity = 3.16m, AtomicRadius = 0.79m, ValenceElectrons = 7 },
new() { Name = "Argon", Symbol = "Ar", AtomicNumber = 18, Period = 3, Group = 18, AtomNucleus = new Nucleus(18, 22), Electrons = new Electron(18), IonizationEnergy = 15.7596m, ElectronAffinity = 0m, Electronegativity = 0m, AtomicRadius = 0.71m, ValenceElectrons = 8 },
new() { Name = "Potassium", Symbol = "K", AtomicNumber = 19, Period = 4, Group = 1, AtomNucleus = new Nucleus(19, 20), Electrons = new Electron(19), IonizationEnergy = 4.3407m, ElectronAffinity = 0.501m, Electronegativity = 0.82m, AtomicRadius = 2.43m, ValenceElectrons = 1 },
new() { Name = "Calcium", Symbol = "Ca", AtomicNumber = 20, Period = 4, Group = 2, AtomNucleus = new Nucleus(20, 20), Electrons = new Electron(20), IonizationEnergy = 6.1132m, ElectronAffinity = 0m, Electronegativity = 1.00m, AtomicRadius = 1.94m, ValenceElectrons = 2 },
new() { Name = "Scandium", Symbol = "Sc", AtomicNumber = 21, Period = 4, Group = 3, AtomNucleus = new Nucleus(21, 24), Electrons = new Electron(21), IonizationEnergy = 6.5615m, ElectronAffinity = 0m, Electronegativity = 1.36m, AtomicRadius = 1.84m, ValenceElectrons = 3 },
new() { Name = "Titanium", Symbol = "Ti", AtomicNumber = 22, Period = 4, Group = 4, AtomNucleus = new Nucleus(22, 26), Electrons = new Electron(22), IonizationEnergy = 6.8281m, ElectronAffinity = 0m, Electronegativity = 1.54m, AtomicRadius = 1.76m, ValenceElectrons = 4 },
new() { Name = "Vanadium", Symbol = "V", AtomicNumber = 23, Period = 4, Group = 5, AtomNucleus = new Nucleus(23, 28), Electrons = new Electron(23), IonizationEnergy = 6.7462m, ElectronAffinity = 0.525m, Electronegativity = 1.63m, AtomicRadius = 1.71m, ValenceElectrons = 5 },
new() { Name = "Chromium", Symbol = "Cr", AtomicNumber = 24, Period = 4, Group = 6, AtomNucleus = new Nucleus(24, 28), Electrons = new Electron(24), IonizationEnergy = 6.7665m, ElectronAffinity = 0.675m, Electronegativity = 1.66m, AtomicRadius = 1.66m, ValenceElectrons = 6 },
new() { Name = "Manganese", Symbol = "Mn", AtomicNumber = 25, Period = 4, Group = 7, AtomNucleus = new Nucleus(25, 30), Electrons = new Electron(25), IonizationEnergy = 7.4340m, ElectronAffinity = 0m, Electronegativity = 1.55m, AtomicRadius = 1.61m, ValenceElectrons = 7 },
new() { Name = "Iron", Symbol = "Fe", AtomicNumber = 26, Period = 4, Group = 8, AtomNucleus = new Nucleus(26, 30), Electrons = new Electron(26), IonizationEnergy = 7.9024m, ElectronAffinity = 0.151m, Electronegativity = 1.83m, AtomicRadius = 1.56m, ValenceElectrons = 8 },
new() { Name = "Cobalt", Symbol = "Co", AtomicNumber = 27, Period = 4, Group = 9, AtomNucleus = new Nucleus(27, 32), Electrons = new Electron(27), IonizationEnergy = 7.8810m, ElectronAffinity = 0.662m, Electronegativity = 1.88m, AtomicRadius = 1.52m, ValenceElectrons = 9 },
new() { Name = "Nickel", Symbol = "Ni", AtomicNumber = 28, Period = 4, Group = 10, AtomNucleus = new Nucleus(28, 31), Electrons = new Electron(28), IonizationEnergy = 7.6398m, ElectronAffinity = 1.156m, Electronegativity = 1.91m, AtomicRadius = 1.49m, ValenceElectrons = 10 },
new() { Name = "Copper", Symbol = "Cu", AtomicNumber = 29, Period = 4, Group = 11, AtomNucleus = new Nucleus(29, 35), Electrons = new Electron(29), IonizationEnergy = 7.7264m, ElectronAffinity = 1.235m, Electronegativity = 1.90m, AtomicRadius = 1.45m, ValenceElectrons = 11 },
new() { Name = "Zinc", Symbol = "Zn", AtomicNumber = 30, Period = 4, Group = 12, AtomNucleus = new Nucleus(30, 35), Electrons = new Electron(30), IonizationEnergy = 9.3942m, ElectronAffinity = 0m, Electronegativity = 1.65m, AtomicRadius = 1.42m, ValenceElectrons = 12 },
new() { Name = "Gallium", Symbol = "Ga", AtomicNumber = 31, Period = 4, Group = 13, AtomNucleus = new Nucleus(31, 39), Electrons = new Electron(31), IonizationEnergy = 5.9993m, ElectronAffinity = 0.300m, Electronegativity = 1.81m, AtomicRadius = 1.36m, ValenceElectrons = 13 },
new() { Name = "Germanium", Symbol = "Ge", AtomicNumber = 32, Period = 4, Group = 14, AtomNucleus = new Nucleus(32, 41), Electrons = new Electron(32), IonizationEnergy = 7.8994m, ElectronAffinity = 1.232m, Electronegativity = 2.01m, AtomicRadius = 1.25m, ValenceElectrons = 14 },
new() { Name = "Arsenic", Symbol = "As", AtomicNumber = 33, Period = 4, Group = 15, AtomNucleus = new Nucleus(33, 42), Electrons = new Electron(33), IonizationEnergy = 9.7886m, ElectronAffinity = 0.814m, Electronegativity = 2.18m, AtomicRadius = 1.14m, ValenceElectrons = 15 },
new() { Name = "Selenium", Symbol = "Se", AtomicNumber = 34, Period = 4, Group = 16, AtomNucleus = new Nucleus(34, 45), Electrons = new Electron(34), IonizationEnergy = 9.7524m, ElectronAffinity = 2.020m, Electronegativity = 2.55m, AtomicRadius = 1.03m, ValenceElectrons = 16 },
new() { Name = "Bromine", Symbol = "Br", AtomicNumber = 35, Period = 4, Group = 17, AtomNucleus = new Nucleus(35, 45), Electrons = new Electron(35), IonizationEnergy = 11.8138m, ElectronAffinity = 3.365m, Electronegativity = 2.96m, AtomicRadius = 0.94m, ValenceElectrons = 17 },
new() { Name = "Krypton", Symbol = "Kr", AtomicNumber = 36, Period = 4, Group = 18, AtomNucleus = new Nucleus(36, 48), Electrons = new Electron(36), IonizationEnergy = 13.9996m, ElectronAffinity = 0m, Electronegativity = 3.00m, AtomicRadius = 0.88m, ValenceElectrons = 18 },
new() { Name = "Rubidium", Symbol = "Rb", AtomicNumber = 37, Period = 5, Group = 1, AtomNucleus = new Nucleus(37, 48), Electrons = new Electron(37), IonizationEnergy = 4.1771m, ElectronAffinity = 0.486m, Electronegativity = 0.82m, AtomicRadius = 2.65m, ValenceElectrons = 1 },
new() { Name = "Strontium", Symbol = "Sr", AtomicNumber = 38, Period = 5, Group = 2, AtomNucleus = new Nucleus(38, 50), Electrons = new Electron(38), IonizationEnergy = 5.6949m, ElectronAffinity = 0m, Electronegativity = 0.95m, AtomicRadius = 2.19m, ValenceElectrons = 2 },
new() { Name = "Yttrium", Symbol = "Y", AtomicNumber = 39, Period = 5, Group = 3, AtomNucleus = new Nucleus(39, 50), Electrons = new Electron(39), IonizationEnergy = 6.2173m, ElectronAffinity = 0m, Electronegativity = 1.22m, AtomicRadius = 2.12m, ValenceElectrons = 3 },
new() { Name = "Zirconium", Symbol = "Zr", AtomicNumber = 40, Period = 5, Group = 4, AtomNucleus = new Nucleus(40, 51), Electrons = new Electron(40), IonizationEnergy = 6.6339m, ElectronAffinity = 0m, Electronegativity = 1.33m, AtomicRadius = 2.06m, ValenceElectrons = 4 },
new() { Name = "Niobium", Symbol = "Nb", AtomicNumber = 41, Period = 5, Group = 5, AtomNucleus = new Nucleus(41, 52), Electrons = new Electron(41), IonizationEnergy = 6.7589m, ElectronAffinity = 0.893m, Electronegativity = 1.6m, AtomicRadius = 1.98m, ValenceElectrons = 5 },
new() { Name = "Molybdenum", Symbol = "Mo", AtomicNumber = 42, Period = 5, Group = 6, AtomNucleus = new Nucleus(42, 54), Electrons = new Electron(42), IonizationEnergy = 7.0924m, ElectronAffinity = 0.747m, Electronegativity = 2.16m, AtomicRadius = 1.90m, ValenceElectrons = 6 },
new() { Name = "Technetium", Symbol = "Tc", AtomicNumber = 43, Period = 5, Group = 7, AtomNucleus = new Nucleus(43, 55), Electrons = new Electron(43), IonizationEnergy = 7.28m, ElectronAffinity = 0.55m, Electronegativity = 1.9m, AtomicRadius = 1.83m, ValenceElectrons = 7 },
new() { Name = "Ruthenium", Symbol = "Ru", AtomicNumber = 44, Period = 5, Group = 8, AtomNucleus = new Nucleus(44, 57), Electrons = new Electron(44), IonizationEnergy = 7.3605m, ElectronAffinity = 1.046m, Electronegativity = 2.2m, AtomicRadius = 1.78m, ValenceElectrons = 8 },
new() { Name = "Rhodium", Symbol = "Rh", AtomicNumber = 45, Period = 5, Group = 9, AtomNucleus = new Nucleus(45, 58), Electrons = new Electron(45), IonizationEnergy = 7.4589m, ElectronAffinity = 1.142m, Electronegativity = 2.28m, AtomicRadius = 1.73m, ValenceElectrons = 9 },
new() { Name = "Palladium", Symbol = "Pd", AtomicNumber = 46, Period = 5, Group = 10, AtomNucleus = new Nucleus(46, 60), Electrons = new Electron(46), IonizationEnergy = 8.3369m, ElectronAffinity = 0.562m, Electronegativity = 2.20m, AtomicRadius = 1.69m, ValenceElectrons = 10 },
new() { Name = "Silver", Symbol = "Ag", AtomicNumber = 47, Period = 5, Group = 11, AtomNucleus = new Nucleus(47, 61), Electrons = new Electron(47), IonizationEnergy = 7.5762m, ElectronAffinity = 1.302m, Electronegativity = 1.93m, AtomicRadius = 1.65m, ValenceElectrons = 11 },
new() { Name = "Cadmium", Symbol = "Cd", AtomicNumber = 48, Period = 5, Group = 12, AtomNucleus = new Nucleus(48, 64), Electrons = new Electron(48), IonizationEnergy = 8.9938m, ElectronAffinity = 0m, Electronegativity = 1.69m, AtomicRadius = 1.61m, ValenceElectrons = 12 },
new() { Name = "Indium", Symbol = "In", AtomicNumber = 49, Period = 5, Group = 13, AtomNucleus = new Nucleus(49, 66), Electrons = new Electron(49), IonizationEnergy = 5.7864m, ElectronAffinity = 0.300m, Electronegativity = 1.78m, AtomicRadius = 1.56m, ValenceElectrons = 13 },
new() { Name = "Tin", Symbol = "Sn", AtomicNumber = 50, Period = 5, Group = 14, AtomNucleus = new Nucleus(50, 69), Electrons = new Electron(50), IonizationEnergy = 7.3439m, ElectronAffinity = 1.112m, Electronegativity = 1.96m, AtomicRadius = 1.45m, ValenceElectrons = 14 },
new() { Name = "Antimony", Symbol = "Sb", AtomicNumber = 51, Period = 5, Group = 15, AtomNucleus = new Nucleus(51, 71), Electrons = new Electron(51), IonizationEnergy = 8.6084m, ElectronAffinity = 1.047m, Electronegativity = 2.05m, AtomicRadius = 1.33m, ValenceElectrons = 15 },
new() { Name = "Tellurium", Symbol = "Te", AtomicNumber = 52, Period = 5, Group = 16, AtomNucleus = new Nucleus(52, 76), Electrons = new Electron(52), IonizationEnergy = 9.0096m, ElectronAffinity = 1.971m, Electronegativity = 2.1m, AtomicRadius = 1.23m, ValenceElectrons = 16 },
new() { Name = "Iodine", Symbol = "I", AtomicNumber = 53, Period = 5, Group = 17, AtomNucleus = new Nucleus(53, 74), Electrons = new Electron(53), IonizationEnergy = 10.4513m, ElectronAffinity = 3.059m, Electronegativity = 2.66m, AtomicRadius = 1.15m, ValenceElectrons = 17 },
new() { Name = "Xenon", Symbol = "Xe", AtomicNumber = 54, Period = 5, Group = 18, AtomNucleus = new Nucleus(54, 77), Electrons = new Electron(54), IonizationEnergy = 12.1298m, ElectronAffinity = 0m, Electronegativity = 2.6m, AtomicRadius = 1.08m, ValenceElectrons = 18 },
new() { Name = "Cesium", Symbol = "Cs", AtomicNumber = 55, Period = 6, Group = 1, AtomNucleus = new Nucleus(55, 78), Electrons = new Electron(55), IonizationEnergy = 3.8939m, ElectronAffinity = 0.471m, Electronegativity = 0.79m, AtomicRadius = 2.98m, ValenceElectrons = 1 },
new() { Name = "Barium", Symbol = "Ba", AtomicNumber = 56, Period = 6, Group = 2, AtomNucleus = new Nucleus(56, 81), Electrons = new Electron(56), IonizationEnergy = 5.2117m, ElectronAffinity = 0m, Electronegativity = 0.89m, AtomicRadius = 2.53m, ValenceElectrons = 2 },
new() { Name = "Lanthanum", Symbol = "La", AtomicNumber = 57, Period = 6, Group = 3, AtomNucleus = new Nucleus(57, 82), Electrons = new Electron(57), IonizationEnergy = 5.5769m, ElectronAffinity = 0.47m, Electronegativity = 1.10m, AtomicRadius = 2.41m, ValenceElectrons = 3 },
new() { Name = "Cerium", Symbol = "Ce", AtomicNumber = 58, Period = 6, Group = 3, AtomNucleus = new Nucleus(58, 82), Electrons = new Electron(58), IonizationEnergy = 5.5387m, ElectronAffinity = 0.50m, Electronegativity = 1.12m, AtomicRadius = 2.35m, ValenceElectrons = 3 },
new() { Name = "Praseodymium", Symbol = "Pr", AtomicNumber = 59, Period = 6, Group = 3, AtomNucleus = new Nucleus(59, 82), Electrons = new Electron(59), IonizationEnergy = 5.473m, ElectronAffinity = 0.54m, Electronegativity = 1.13m, AtomicRadius = 2.39m, ValenceElectrons = 3 },
new() { Name = "Neodymium", Symbol = "Nd", AtomicNumber = 60, Period = 6, Group = 3, AtomNucleus = new Nucleus(60, 84), Electrons = new Electron(60), IonizationEnergy = 5.525m, ElectronAffinity = 0.44m, Electronegativity = 1.14m, AtomicRadius = 2.29m, ValenceElectrons = 3 },
new() { Name = "Promethium", Symbol = "Pm", AtomicNumber = 61, Period = 6, Group = 3, AtomNucleus = new Nucleus(61, 84), Electrons = new Electron(61), IonizationEnergy = 5.582m, ElectronAffinity = 0.50m, Electronegativity = 1.13m, AtomicRadius = 2.36m, ValenceElectrons = 3 },
new() { Name = "Samarium", Symbol = "Sm", AtomicNumber = 62, Period = 6, Group = 3, AtomNucleus = new Nucleus(62, 88), Electrons = new Electron(62), IonizationEnergy = 5.6437m, ElectronAffinity = 0.52m, Electronegativity = 1.17m, AtomicRadius = 2.28m, ValenceElectrons = 3 },
new() { Name = "Europium", Symbol = "Eu", AtomicNumber = 63, Period = 6, Group = 3, AtomNucleus = new Nucleus(63, 89), Electrons = new Electron(63), IonizationEnergy = 5.6704m, ElectronAffinity = 0.85m, Electronegativity = 1.2m, AtomicRadius = 2.31m, ValenceElectrons = 3 },
new() { Name = "Gadolinium", Symbol = "Gd", AtomicNumber = 64, Period = 6, Group = 3, AtomNucleus = new Nucleus(64, 93), Electrons = new Electron(64), IonizationEnergy = 6.1501m, ElectronAffinity = 0.92m, Electronegativity = 1.20m, AtomicRadius = 2.30m, ValenceElectrons = 3 },
new() { Name = "Terbium", Symbol = "Tb", AtomicNumber = 65, Period = 6, Group = 3, AtomNucleus = new Nucleus(65, 94), Electrons = new Electron(65), IonizationEnergy = 5.8638m, ElectronAffinity = 0.71m, Electronegativity = 1.2m, AtomicRadius = 2.25m, ValenceElectrons = 3 },
new() { Name = "Dysprosium", Symbol = "Dy", AtomicNumber = 66, Period = 6, Group = 3, AtomNucleus = new Nucleus(66, 96), Electrons = new Electron(66), IonizationEnergy = 5.9389m, ElectronAffinity = 0.52m, Electronegativity = 1.22m, AtomicRadius = 2.28m, ValenceElectrons = 3 },
new() { Name = "Holmium", Symbol = "Ho", AtomicNumber = 67, Period = 6, Group = 3, AtomNucleus = new Nucleus(67, 98), Electrons = new Electron(67), IonizationEnergy = 6.0215m, ElectronAffinity = 0.52m, Electronegativity = 1.23m, AtomicRadius = 2.26m, ValenceElectrons = 3 },
new() { Name = "Erbium", Symbol = "Er", AtomicNumber = 68, Period = 6, Group = 3, AtomNucleus = new Nucleus(68, 99), Electrons = new Electron(68), IonizationEnergy = 6.1077m, ElectronAffinity = 0.52m, Electronegativity = 1.24m, AtomicRadius = 2.26m, ValenceElectrons = 3 },
new() { Name = "Thulium", Symbol = "Tm", AtomicNumber = 69, Period = 6, Group = 3, AtomNucleus = new Nucleus(69, 100), Electrons = new Electron(69), IonizationEnergy = 6.1843m, ElectronAffinity = 0.50m, Electronegativity = 1.25m, AtomicRadius = 2.22m, ValenceElectrons = 3 },
new() { Name = "Ytterbium", Symbol = "Yb", AtomicNumber = 70, Period = 6, Group = 3, AtomNucleus = new Nucleus(70, 103), Electrons = new Electron(70), IonizationEnergy = 6.2542m, ElectronAffinity = 0m, Electronegativity = 1.1m, AtomicRadius = 2.22m, ValenceElectrons = 3 },
new() { Name = "Lutetium", Symbol = "Lu", AtomicNumber = 71, Period = 6, Group = 3, AtomNucleus = new Nucleus(71, 104), Electrons = new Electron(71), IonizationEnergy = 5.4259m, ElectronAffinity = 0.50m, Electronegativity = 1.27m, AtomicRadius = 2.17m, ValenceElectrons = 3 },
new() { Name = "Hafnium", Symbol = "Hf", AtomicNumber = 72, Period = 6, Group = 4, AtomNucleus = new Nucleus(72, 106), Electrons = new Electron(72), IonizationEnergy = 6.8251m, ElectronAffinity = 0m, Electronegativity = 1.3m, AtomicRadius = 2.08m, ValenceElectrons = 4 },
new() { Name = "Tantalum", Symbol = "Ta", AtomicNumber = 73, Period = 6, Group = 5, AtomNucleus = new Nucleus(73, 108), Electrons = new Electron(73), IonizationEnergy = 7.5496m, ElectronAffinity = 0.322m, Electronegativity = 1.5m, AtomicRadius = 2.00m, ValenceElectrons = 5 },
new() { Name = "Tungsten", Symbol = "W", AtomicNumber = 74, Period = 6, Group = 6, AtomNucleus = new Nucleus(74, 110), Electrons = new Electron(74), IonizationEnergy = 7.864m, ElectronAffinity = 0.815m, Electronegativity = 2.36m, AtomicRadius = 1.93m, ValenceElectrons = 6 },
new() { Name = "Rhenium", Symbol = "Re", AtomicNumber = 75, Period = 6, Group = 7, AtomNucleus = new Nucleus(75, 111), Electrons = new Electron(75), IonizationEnergy = 7.8335m, ElectronAffinity = 0.15m, Electronegativity = 1.9m, AtomicRadius = 1.88m, ValenceElectrons = 7 },
new() { Name = "Osmium", Symbol = "Os", AtomicNumber = 76, Period = 6, Group = 8, AtomNucleus = new Nucleus(76, 114), Electrons = new Electron(76), IonizationEnergy = 8.4382m, ElectronAffinity = 1.1m, Electronegativity = 2.2m, AtomicRadius = 1.85m, ValenceElectrons = 8 },
new() { Name = "Iridium", Symbol = "Ir", AtomicNumber = 77, Period = 6, Group = 9, AtomNucleus = new Nucleus(77, 115), Electrons = new Electron(77), IonizationEnergy = 8.967m, ElectronAffinity = 1.563m, Electronegativity = 2.2m, AtomicRadius = 1.80m, ValenceElectrons = 9 },
new() { Name = "Platinum", Symbol = "Pt", AtomicNumber = 78, Period = 6, Group = 10, AtomNucleus = new Nucleus(78, 117), Electrons = new Electron(78), IonizationEnergy = 8.9587m, ElectronAffinity = 2.128m, Electronegativity = 2.28m, AtomicRadius = 1.77m, ValenceElectrons = 10 },
new() { Name = "Gold", Symbol = "Au", AtomicNumber = 79, Period = 6, Group = 11, AtomNucleus = new Nucleus(79, 118), Electrons = new Electron(79), IonizationEnergy = 9.2255m, ElectronAffinity = 2.308m, Electronegativity = 2.54m, AtomicRadius = 1.74m, ValenceElectrons = 11 },
new() { Name = "Mercury", Symbol = "Hg", AtomicNumber = 80, Period = 6, Group = 12, AtomNucleus = new Nucleus(80, 121), Electrons = new Electron(80), IonizationEnergy = 10.4375m, ElectronAffinity = 0m, Electronegativity = 2.00m, AtomicRadius = 1.71m, ValenceElectrons = 12 },
new() { Name = "Thallium", Symbol = "Tl", AtomicNumber = 81, Period = 6, Group = 13, AtomNucleus = new Nucleus(81, 123), Electrons = new Electron(81), IonizationEnergy = 6.1082m, ElectronAffinity = 0.200m, Electronegativity = 2.04m, AtomicRadius = 1.56m, ValenceElectrons = 13 },
new() { Name = "Lead", Symbol = "Pb", AtomicNumber = 82, Period = 6, Group = 14, AtomNucleus = new Nucleus(82, 125), Electrons = new Electron(82), IonizationEnergy = 7.4167m, ElectronAffinity = 0.356m, Electronegativity = 2.33m, AtomicRadius = 1.54m, ValenceElectrons = 14 },
new() { Name = "Bismuth", Symbol = "Bi", AtomicNumber = 83, Period = 6, Group = 15, AtomNucleus = new Nucleus(83, 126), Electrons = new Electron(83), IonizationEnergy = 7.2856m, ElectronAffinity = 0.942m, Electronegativity = 2.02m, AtomicRadius = 1.43m, ValenceElectrons = 15 },
new() { Name = "Polonium", Symbol = "Po", AtomicNumber = 84, Period = 6, Group = 16, AtomNucleus = new Nucleus(84, 125), Electrons = new Electron(84), IonizationEnergy = 8.417m, ElectronAffinity = 1.9m, Electronegativity = 2.0m, AtomicRadius = 1.35m, ValenceElectrons = 16 },
new() { Name = "Astatine", Symbol = "At", AtomicNumber = 85, Period = 6, Group = 17, AtomNucleus = new Nucleus(85, 125), Electrons = new Electron(85), IonizationEnergy = 9.3m, ElectronAffinity = 2.8m, Electronegativity = 2.2m, AtomicRadius = 1.27m, ValenceElectrons = 17 },
new() { Name = "Radon", Symbol = "Rn", AtomicNumber = 86, Period = 6, Group = 18, AtomNucleus = new Nucleus(86, 136), Electrons = new Electron(86), IonizationEnergy = 10.745m, ElectronAffinity = 0m, Electronegativity = 0m, AtomicRadius = 1.20m, ValenceElectrons = 18 },
new() { Name = "Francium", Symbol = "Fr", AtomicNumber = 87, Period = 7, Group = 1, AtomNucleus = new Nucleus(87, 136), Electrons = new Electron(87), IonizationEnergy = 4.0727m, ElectronAffinity = 0.47m, Electronegativity = 0.7m, AtomicRadius = 2.7m, ValenceElectrons = 1 },
new() { Name = "Radium", Symbol = "Ra", AtomicNumber = 88, Period = 7, Group = 2, AtomNucleus = new Nucleus(88, 138), Electrons = new Electron(88), IonizationEnergy = 5.2784m, ElectronAffinity = 0m, Electronegativity = 0.9m, AtomicRadius = 2.2m, ValenceElectrons = 2 },
new() { Name = "Actinium", Symbol = "Ac", AtomicNumber = 89, Period = 7, Group = 3, AtomNucleus = new Nucleus(89, 138), Electrons = new Electron(89), IonizationEnergy = 5.17m, ElectronAffinity = 0m, Electronegativity = 1.1m, AtomicRadius = 2.12m, ValenceElectrons = 3 },
new() { Name = "Thorium", Symbol = "Th", AtomicNumber = 90, Period = 7, Group = 3, AtomNucleus = new Nucleus(90, 142), Electrons = new Electron(90), IonizationEnergy = 6.3067m, ElectronAffinity = 0m, Electronegativity = 1.3m, AtomicRadius = 1.95m, ValenceElectrons = 3 },
new() { Name = "Protactinium", Symbol = "Pa", AtomicNumber = 91, Period = 7, Group = 3, AtomNucleus = new Nucleus(91, 140), Electrons = new Electron(91), IonizationEnergy = 5.89m, ElectronAffinity = 0m, Electronegativity = 1.5m, AtomicRadius = 2.00m, ValenceElectrons = 3 },
new() { Name = "Uranium", Symbol = "U", AtomicNumber = 92, Period = 7, Group = 3, AtomNucleus = new Nucleus(92, 146), Electrons = new Electron(92), IonizationEnergy = 6.1941m, ElectronAffinity = 0m, Electronegativity = 1.38m, AtomicRadius = 1.75m, ValenceElectrons = 3 },
new() { Name = "Neptunium", Symbol = "Np", AtomicNumber = 93, Period = 7, Group = 3, AtomNucleus = new Nucleus(93, 144), Electrons = new Electron(93), IonizationEnergy = 6.2657m, ElectronAffinity = 0m, Electronegativity = 1.36m, AtomicRadius = 1.75m, ValenceElectrons = 3 },
new() { Name = "Plutonium", Symbol = "Pu", AtomicNumber = 94, Period = 7, Group = 3, AtomNucleus = new Nucleus(94, 150), Electrons = new Electron(94), IonizationEnergy = 6.0260m, ElectronAffinity = 0m, Electronegativity = 1.28m, AtomicRadius = 1.75m, ValenceElectrons = 3 },
new() { Name = "Americium", Symbol = "Am", AtomicNumber = 95, Period = 7, Group = 3, AtomNucleus = new Nucleus(95, 148), Electrons = new Electron(95), IonizationEnergy = 5.9738m, ElectronAffinity = 0m, Electronegativity = 1.3m, AtomicRadius = 1.75m, ValenceElectrons = 3 },
new() { Name = "Curium", Symbol = "Cm", AtomicNumber = 96, Period = 7, Group = 3, AtomNucleus = new Nucleus(96, 151), Electrons = new Electron(96), IonizationEnergy = 5.9914m, ElectronAffinity = 0m, Electronegativity = 1.3m, AtomicRadius = 1.75m, ValenceElectrons = 3 },
new() { Name = "Berkelium", Symbol = "Bk", AtomicNumber = 97, Period = 7, Group = 3, AtomNucleus = new Nucleus(97, 150), Electrons = new Electron(97), IonizationEnergy = 6.1979m, ElectronAffinity = 0m, Electronegativity = 1.3m, AtomicRadius = 1.70m, ValenceElectrons = 3 },
new() { Name = "Californium", Symbol = "Cf", AtomicNumber = 98, Period = 7, Group = 3, AtomNucleus = new Nucleus(98, 153), Electrons = new Electron(98), IonizationEnergy = 6.2817m, ElectronAffinity = 0m, Electronegativity = 1.3m, AtomicRadius = 1.70m, ValenceElectrons = 3 },
new() { Name = "Einsteinium", Symbol = "Es", AtomicNumber = 99, Period = 7, Group = 3, AtomNucleus = new Nucleus(99, 153), Electrons = new Electron(99), IonizationEnergy = 6.42m, ElectronAffinity = 0m, Electronegativity = 1.3m, AtomicRadius = 1.65m, ValenceElectrons = 3 },
new() { Name = "Fermium", Symbol = "Fm", AtomicNumber = 100, Period = 7, Group = 3, AtomNucleus = new Nucleus(100, 157), Electrons = new Electron(100), IonizationEnergy = 6.50m, ElectronAffinity = 0m, Electronegativity = 1.3m, AtomicRadius = 1.60m, ValenceElectrons = 3 },
new() { Name = "Mendelevium", Symbol = "Md", AtomicNumber = 101, Period = 7, Group = 3, AtomNucleus = new Nucleus(101, 157), Electrons = new Electron(101), IonizationEnergy = 6.58m, ElectronAffinity = 0m, Electronegativity = 1.3m, AtomicRadius = 1.60m, ValenceElectrons = 3 },
new() { Name = "Nobelium", Symbol = "No", AtomicNumber = 102, Period = 7, Group = 3, AtomNucleus = new Nucleus(102, 157), Electrons = new Electron(102), IonizationEnergy = 6.65m, ElectronAffinity = 0m, Electronegativity = 1.3m, AtomicRadius = 1.55m, ValenceElectrons = 3 },
new() { Name = "Lawrencium", Symbol = "Lr", AtomicNumber = 103, Period = 7, Group = 3, AtomNucleus = new Nucleus(103, 159), Electrons = new Electron(103), IonizationEnergy = 4.9m, ElectronAffinity = 0m, Electronegativity = 1.3m, AtomicRadius = 1.60m, ValenceElectrons = 3 },
new() { Name = "Rutherfordium", Symbol = "Rf", AtomicNumber = 104, Period = 7, Group = 4, AtomNucleus = new Nucleus(104, 163), Electrons = new Electron(104), IonizationEnergy = 6.0m, ElectronAffinity = 0m, Electronegativity = 1.3m, AtomicRadius = 1.50m, ValenceElectrons = 4 },
new() { Name = "Dubnium", Symbol = "Db", AtomicNumber = 105, Period = 7, Group = 5, AtomNucleus = new Nucleus(105, 163), Electrons = new Electron(105), IonizationEnergy = 6.1m, ElectronAffinity = 0m, Electronegativity = 1.3m, AtomicRadius = 1.50m, ValenceElectrons = 5 },
new() { Name = "Seaborgium", Symbol = "Sg", AtomicNumber = 106, Period = 7, Group = 6, AtomNucleus = new Nucleus(106, 165), Electrons = new Electron(106), IonizationEnergy = 6.2m, ElectronAffinity = 0m, Electronegativity = 1.3m, AtomicRadius = 1.50m, ValenceElectrons = 6 },
new() { Name = "Bohrium", Symbol = "Bh", AtomicNumber = 107, Period = 7, Group = 7, AtomNucleus = new Nucleus(107, 163), Electrons = new Electron(107), IonizationEnergy = 6.3m, ElectronAffinity = 0m, Electronegativity = 1.3m, AtomicRadius = 1.50m, ValenceElectrons = 7 },
new() { Name = "Hassium", Symbol = "Hs", AtomicNumber = 108, Period = 7, Group = 8, AtomNucleus = new Nucleus(108, 169), Electrons = new Electron(108), IonizationEnergy = 7.0m, ElectronAffinity = 0m, Electronegativity = 1.3m, AtomicRadius = 1.50m, ValenceElectrons = 8 },
new() { Name = "Meitnerium", Symbol = "Mt", AtomicNumber = 109, Period = 7, Group = 9, AtomNucleus = new Nucleus(109, 169), Electrons = new Electron(109), IonizationEnergy = 7.2m, ElectronAffinity = 0m, Electronegativity = 1.3m, AtomicRadius = 1.50m, ValenceElectrons = 9 },
new() { Name = "Darmstadtium", Symbol = "Ds", AtomicNumber = 110, Period = 7, Group = 10, AtomNucleus = new Nucleus(110, 171), Electrons = new Electron(110), IonizationEnergy = 7.3m, ElectronAffinity = 0m, Electronegativity = 1.3m, AtomicRadius = 1.50m, ValenceElectrons = 10 },
new() { Name = "Roentgenium", Symbol = "Rg", AtomicNumber = 111, Period = 7, Group = 11, AtomNucleus = new Nucleus(111, 171), Electrons = new Electron(111), IonizationEnergy = 7.4m, ElectronAffinity = 0m, Electronegativity = 1.3m, AtomicRadius = 1.50m, ValenceElectrons = 11 },
new() { Name = "Copernicium", Symbol = "Cn", AtomicNumber = 112, Period = 7, Group = 12, AtomNucleus = new Nucleus(112, 173), Electrons = new Electron(112), IonizationEnergy = 7.5m, ElectronAffinity = 0m, Electronegativity = 1.3m, AtomicRadius = 1.50m, ValenceElectrons = 12 },
new() { Name = "Nihonium", Symbol = "Nh", AtomicNumber = 113, Period = 7, Group = 13, AtomNucleus = new Nucleus(113, 173), Electrons = new Electron(113), IonizationEnergy = 7.6m, ElectronAffinity = 0m, Electronegativity = 1.3m, AtomicRadius = 1.50m, ValenceElectrons = 13 },
new() { Name = "Flerovium", Symbol = "Fl", AtomicNumber = 114, Period = 7, Group = 14, AtomNucleus = new Nucleus(114, 175), Electrons = new Electron(114), IonizationEnergy = 7.7m, ElectronAffinity = 0m, Electronegativity = 1.3m, AtomicRadius = 1.50m, ValenceElectrons = 14 },
new() { Name = "Moscovium", Symbol = "Mc", AtomicNumber = 115, Period = 7, Group = 15, AtomNucleus = new Nucleus(115, 175), Electrons = new Electron(115), IonizationEnergy = 7.8m, ElectronAffinity = 0m, Electronegativity = 1.3m, AtomicRadius = 1.50m, ValenceElectrons = 15 },
new() { Name = "Livermorium", Symbol = "Lv", AtomicNumber = 116, Period = 7, Group = 16, AtomNucleus = new Nucleus(116, 177), Electrons = new Electron(116), IonizationEnergy = 8.0m, ElectronAffinity = 0m, Electronegativity = 1.3m, AtomicRadius = 1.50m, ValenceElectrons = 16 },
new() { Name = "Tennessine", Symbol = "Ts", AtomicNumber = 117, Period = 7, Group = 17, AtomNucleus = new Nucleus(117, 177), Electrons = new Electron(117), IonizationEnergy = 8.2m, ElectronAffinity = 0m, Electronegativity = 1.3m, AtomicRadius = 1.50m, ValenceElectrons = 17 },
new() { Name = "Oganesson", Symbol = "Og", AtomicNumber = 118, Period = 7, Group = 18, AtomNucleus = new Nucleus(118, 176), Electrons = new Electron(118), IonizationEnergy = 8.4m, ElectronAffinity = 0m, Electronegativity = 1.3m, AtomicRadius = 1.50m, ValenceElectrons = 18 },
		
	];
}
}