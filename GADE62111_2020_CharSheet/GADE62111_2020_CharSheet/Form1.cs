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
            InitializeComponent();
        }

        private void BtnAbilityRoll_Click(object sender, EventArgs e)
        {
            try
            {
                int[] tempValues = character.GenerateAbilityScores();
                txtAbility1.Text = tempValues[0].ToString();
                txtAbility2.Text = tempValues[1].ToString();
                txtAbility3.Text = tempValues[2].ToString();
                txtAbility4.Text = tempValues[3].ToString();
                txtAbility5.Text = tempValues[4].ToString();
                txtAbility6.Text = tempValues[5].ToString();
            }
            catch(NullReferenceException ex)
            {
                MessageBox.Show("Please select a class first.");
            }
        }

        private void CmbAbility1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetAbilityScore(cmbAbility1.SelectedIndex, Convert.ToInt32(txtAbility1.Text));
        }

        private void SetAbilityScore(int index, int value)
        {
            switch (index)
            {
                case 0: txtWisdom.Text = value.ToString(); break;
                case 1: txtCharisma.Text = value.ToString(); break;
                case 2: txtStrength.Text = value.ToString(); break;
                case 3: txtConstitution.Text = value.ToString(); break;
                case 4: txtDexterity.Text = value.ToString(); break;
                case 5: txtIntelligence.Text = value.ToString(); break;
            }
        }

        private void CmbAbility2_SelectedIndexChanged(object sender, EventArgs e)
        {

            SetAbilityScore(cmbAbility2.SelectedIndex, Convert.ToInt32(txtAbility2.Text));
        }

        private void CmbAbility3_SelectedIndexChanged(object sender, EventArgs e)
        {

            SetAbilityScore(cmbAbility3.SelectedIndex, Convert.ToInt32(txtAbility3.Text));
        }

        private void CmbAbility4_SelectedIndexChanged(object sender, EventArgs e)
        {

            SetAbilityScore(cmbAbility4.SelectedIndex, Convert.ToInt32(txtAbility4.Text));
        }

        private void CmbAbility5_SelectedIndexChanged(object sender, EventArgs e)
        {

            SetAbilityScore(cmbAbility5.SelectedIndex, Convert.ToInt32(txtAbility5.Text));
        }

        private void CmbAbility6_SelectedIndexChanged(object sender, EventArgs e)
        {

            SetAbilityScore(cmbAbility6.SelectedIndex, Convert.ToInt32(txtAbility6.Text));
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            character.SetAbilityScores(Convert.ToInt32(txtWisdom.Text),
               Convert.ToInt32(txtCharisma.Text),
               Convert.ToInt32(txtStrength.Text),
               Convert.ToInt32(txtConstitution.Text),
               Convert.ToInt32(txtDexterity.Text),
               Convert.ToInt32(txtIntelligence.Text));
            txtCharacter.Text = character.ToString();
        }

        private void CmbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbClass.SelectedIndex == 0)
            {
                character = new Rogue();
            }
            else if(cmbClass.SelectedIndex == 1)
            {
                character = new Fighter();
            }
            else if(cmbClass.SelectedIndex == 0)
            {
                character = new Wizard();
            }
        }
    }
}
