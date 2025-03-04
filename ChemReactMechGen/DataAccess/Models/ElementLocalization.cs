using System.Collections.Generic;

namespace DataAccess.Models;

public static class ElementLocalization
{
    public static Dictionary<string, Dictionary<string, (string LocalName, string LatinName)>> Translations = new()
    {
    { "en", new Dictionary<string, (string, string)>
        {
            { "Hydrogen", ("Hydrogen", "Hydrogenium") },
            { "Helium", ("Helium", "Helium") },
            { "Lithium", ("Lithium", "Lithium") },
            // Добавьте остальные элементы...
        }
    },
    { "ru", new Dictionary<string, (string, string)>
        {
            { "Hydrogen", ("Водород", "Hydrogenium") },
            { "Helium", ("Гелий", "Helium") },
            { "Lithium", ("Литий", "Lithium") },
            // Добавьте остальные элементы...
        }
    }
    // Добавьте другие языки...
};
}