using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE62111_2020_CharSheet
{
    public class Rogue: Character
    {
        public override void SetAbilityScores(int Wis, int Cha, int Str, int Con, int Dex, int Int)
        {
            base.Wisdom = Wis - 1;
            base.Charisma = Cha;
            base.Strength = Str;
            base.Consitution = Con;
            base.Dexterity = Dex + 1;
            base.Intelligence = Int;
        }
    }
}
