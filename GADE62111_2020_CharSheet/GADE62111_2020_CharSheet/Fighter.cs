using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE62111_2020_CharSheet
{
    public class Fighter : Character
    {
        public override void SetAbilityScores(int Wis, int Cha, int Str, int Con, int Dex, int Int)
        {
            base.Wisdom = Wis;
            base.Charisma = Cha;
            base.Strength = Str + 1;
            base.Consitution = Con;
            base.Dexterity = Dex;
            base.Intelligence = Int - 1;
        }
    }
}
