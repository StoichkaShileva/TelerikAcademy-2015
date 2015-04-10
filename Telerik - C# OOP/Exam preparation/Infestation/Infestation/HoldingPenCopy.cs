using System.Runtime.InteropServices;
using Infestation.Supplements;

namespace Infestation
{
    public class HoldingPenCopy : HoldingPen
    {
        protected override void ExecuteAddSupplementCommand(string[] commandWords)
        {
            
            var type = commandWords[1];
            ISupplement currentSupplement;
            if (type == "AgressionCataclyst")
            {
                currentSupplement = new AgressionCataclyst();
            }
            else if (type == "HealthCatalyst")
            {
                currentSupplement = new HealthCatalyst();
            }
            else if (type == "PowerCatalyst")
            {
                currentSupplement = new PowerCatalyst();
            }
            else if (type == "Weapon")
            {
                currentSupplement = new Weapon();
            }
        }
    }
}
