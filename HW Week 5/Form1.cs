using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_Week_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox_Country_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
            if (comboBox_Country.SelectedItem == "England");
            {
                
                comboBox_Team.Items.Add("Manchester City");
                comboBox_Team.Items.Add("Manchester United");
                comboBox_Team.Items.Remove("Paris Saint Germain");
            }
            
            if (comboBox_Country.SelectedItem == "France");
            {
                comboBox_Team.Items.Remove("Manchester City" + "Manchester United");
                comboBox_Team.Items.Add("Paris Saint Germain");
            }
        }

        private void comboBox_Team_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBox_Team.SelectedItem == "Manchester City");
            {
                listBox_DaftarPemain.Items.Add("(09) Erling Haaland, CF");
                listBox_DaftarPemain.Items.Add("(19) Julian Alvarez, CF");
                listBox_DaftarPemain.Items.Add("(26) Riyad Mahrez, RW");
                listBox_DaftarPemain.Items.Add("(10) Jack Grealish, LW");
                listBox_DaftarPemain.Items.Add("(47) Phil Foden, LW");
                listBox_DaftarPemain.Items.Add("(17) Kevin De Bruyne, AM");
                listBox_DaftarPemain.Items.Add("(20) Bernardo Silva, CM");
                listBox_DaftarPemain.Items.Add("(16) Rodri, DM");
                listBox_DaftarPemain.Items.Add("(25) Manuel Akanji, CB");
                listBox_DaftarPemain.Items.Add("(06) Nathan Ake, CB");
                listBox_DaftarPemain.Items.Add("(31) Ederson, GK");
            }
            if (comboBox_Team.SelectedItem == "Manchester United") ;
            {
                listBox_DaftarPemain.Items.Add("(01) David De Gea, GK");
                listBox_DaftarPemain.Items.Add("(04) Phil Jones, LB");
                listBox_DaftarPemain.Items.Add("(05) Harry Maguire, CB");
                listBox_DaftarPemain.Items.Add("(06) Raphael Varane, CB");
                listBox_DaftarPemain.Items.Add("(06) Lisandro Martinez, RB");
                listBox_DaftarPemain.Items.Add("(12) Tyrell Malacia, DM");
                listBox_DaftarPemain.Items.Add("(23) Luke Shaw, DM");
                listBox_DaftarPemain.Items.Add("(08) Bruno Fernandez, AM");
                listBox_DaftarPemain.Items.Add("(17) Fred, CM");
                listBox_DaftarPemain.Items.Add("(21) Anthony, AM");
                listBox_DaftarPemain.Items.Add("(10) Marcus Rashford, CF");
            }
            if (comboBox_Team.SelectedItem == "Paris Saint Germain") ;
            {
                listBox_DaftarPemain.Items.Add("(99) Donnaruma, GK");
                listBox_DaftarPemain.Items.Add("(03) Kimpembe, LB");
                listBox_DaftarPemain.Items.Add("(04) Sergio Ramos, CB");
                listBox_DaftarPemain.Items.Add("(05) Marquinhos, CB");
                listBox_DaftarPemain.Items.Add("(06) Marco Verrati, CM");
                listBox_DaftarPemain.Items.Add("(08) Fabian Ruiz, DM");
                listBox_DaftarPemain.Items.Add("(17) Vitinha, AM");
                listBox_DaftarPemain.Items.Add("(08) Carlos Soler, CM");
                listBox_DaftarPemain.Items.Add("(10) Neymar, LF");
                listBox_DaftarPemain.Items.Add("(07) Kylian Mbappe, CF");
                listBox_DaftarPemain.Items.Add("(30) Lionel Messi, RF");
            }
        }
    }
}
