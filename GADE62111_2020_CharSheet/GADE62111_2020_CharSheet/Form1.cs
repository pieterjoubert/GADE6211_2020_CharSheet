using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GADE62111_2020_CharSheet
{
    public partial class Form1 : Form
    {
        public Character character;
        public Form1()
        {
            character = new Character();
            InitializeComponent();
        }

        private void BtnAbilityRoll_Click(object sender, EventArgs e)
        {
            int[] tempValues = character.GenerateAbilityScores();
            txtAbility1.Text = tempValues[0].ToString();
            txtAbility2.Text = tempValues[1].ToString();
            txtAbility3.Text = tempValues[2].ToString();
            txtAbility4.Text = tempValues[3].ToString();
            txtAbility5.Text = tempValues[4].ToString();
            txtAbility6.Text = tempValues[5].ToString();
        }
    }
}
