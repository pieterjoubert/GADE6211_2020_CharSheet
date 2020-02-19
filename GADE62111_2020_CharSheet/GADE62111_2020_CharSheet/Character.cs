using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE62111_2020_CharSheet
{
    public enum ClassTypes
    {
        Rogue,
        Fighter,
        Wizard
    }

    public abstract class Character
    {
        private Random r = new Random();

        private string playerName;

        public string PlayerName
        {
            get { return playerName; }
            set { playerName = value; }
        }

        private string characterName;

        public string CharacterName
        {
            get { return characterName; }
            set { characterName = value; }
        }

        private ClassTypes characterClass;

        public ClassTypes CharacterClass
        {
            get { return  characterClass; }
            set { characterClass = value; }
        }

        public int Wisdom { get; set; }
        public int Charisma { get; set; }
        public int Consitution { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
        public int Strength { get; set; }

        public int[] GenerateAbilityScores()
        {
            int[] tempValues = new int[6];
            for(int i = 0; i < 6; i++)
            {
                int[] diceRolls = new int[4];
                for(int j = 0; j < 4; j++)
                {
                    diceRolls[j] = r.Next(1, 7);
                }
                diceRolls = Sort(diceRolls);
                tempValues[i] = diceRolls[0] + diceRolls[1] + diceRolls[2];
            }

            return tempValues;
        }

        public int[] Sort(int[] unsorted)
        {
            for(int i = 0; i < unsorted.Length; i++)
            {
                for(int j = 0; j < unsorted.Length; j++)
                {
                    if(unsorted[i] > unsorted[j])
                    {
                        int temp = unsorted[j];
                        unsorted[j] = unsorted[i];
                        unsorted[i] = temp;
                    }
                }
            }

            return unsorted;
        }

        public override String ToString()
        {
            string temp = "";
            temp += PlayerName + " " + CharacterName + " " + CharacterClass + " " + Wisdom + " "
                 + Charisma + " " + Strength + " " + Consitution + " " + Dexterity + " " + Intelligence;
            return temp;
        }

        abstract public void SetAbilityScores(int Wis, int Cha, int Str, int Con, int Dex, int Int);
    }
}
