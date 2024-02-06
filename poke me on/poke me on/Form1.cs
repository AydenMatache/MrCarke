using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace poke_me_on
{
    enum Attacks
    {
        Attack, Sp_Attack, Defense, Sp_Defense
    }
    struct Pokemon
    {
        public string Name;
        public string Type;
        public int Level;
        public Attacks attackType;
        public int HP;
        public int Exp;
        public bool Legendary;
        public bool Shiny;
        public int Gen;
    }
    public partial class Form1 : Form
    {
        private int current;
        private int count;
        private Pokemon[] pokemons;

        public Form1()
        {
            InitializeComponent();
            current = 0;
            count = 0;
           currentLabel.Text = current.ToString();
            pokemons = new Pokemon[50];

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("pokemeon.txt"))
            {
                StreamReader inFile = new StreamReader("pokemeon.txt");
                while (!inFile.EndOfStream)
                {
                    string S = inFile.ReadLine();
                    Pokemon p = ReadPokemon(S);
                    pokemons[count] = p;
                    count++;
                }
                inFile.Close();
                ShowPokemon(pokemons[0]);
            }
        }

        private Pokemon ReadPokemon(string s)
        {
            Pokemon p = new Pokemon();
            string[] fields = s.Split('|');
            p.Name = fields[0];
            p.Type = fields[1];
            p.Level = int.Parse(fields[2]);
            p.attackType = (Attacks)Enum.Parse(typeof(Attacks), fields[3]);
            p.HP = int.Parse(fields[4]);
            p.Exp = int.Parse(fields[5]);
            if (fields[6] == "True")
                p.Legendary = true;
            else
                p.Legendary = false;
            if (fields[7] == "True")
                p.Shiny = true;
            else
                p.Shiny = false;
            p.Gen = int.Parse(fields[8]);

            return p;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            string tmp = "";
            tmp += nameTbox.Text;
            tmp += "|";
            tmp += TypeTbox.Text;
            tmp += "|";
            tmp += levelTbox.Text;
            tmp += "|";
            tmp += attackComboBox.Text;
            tmp += "|";
            tmp += hpTbox.Text;
            tmp += "|";
            tmp += expTbox.Text;
            tmp += "|";
            tmp += legendaryCbox.Checked;
            tmp += "|";
            tmp += shinyCbox.Checked;
            tmp += "|";
            tmp += genUpDown.Value;
            pokemons[current] = ReadPokemon(tmp);

            StreamWriter outFile = new StreamWriter("Pokemon.txt");
            for (int i = 0; i < count; i++)
            {
                outFile.WriteLine(PokemonToString(pokemons[i]));
            }
            //outFile.Write(tmp);
            outFile.Close();
        }
        private string PokemonToString(Pokemon p)
        {
            string retVal = "";
            retVal += p.Name.ToString();
            retVal += "|";
            retVal += p.Type.ToString();
            retVal += "|";
            retVal += p.Level.ToString();
            retVal += "|";
            retVal += p.attackType.ToString();
            retVal += "|";
            retVal += p.HP.ToString();
            retVal += "|";
            retVal += p.Exp.ToString(); 
            retVal += "|";
            retVal += p.Legendary.ToString();
            retVal += "|";
            retVal += p.Shiny.ToString();
            retVal += "|";
            retVal += p.Gen.ToString();
            return retVal;
        }
        private void ShowPokemon(Pokemon p)
        {
            nameTbox.Text = p.Name;
            TypeTbox.Text = p.Type;
            levelTbox.Text = p.Level.ToString();
            attackComboBox.Text = p.attackType.ToString();
            hpTbox.Text = p.HP.ToString();
            expTbox.Text = p.Exp.ToString();
            legendaryCbox.Checked = p.Legendary;
            shinyCbox.Checked = p.Shiny;
            genUpDown.Value = p.Gen;
        }

        private void firstButton_Click(object sender, EventArgs e)
        {
            //set this to 0
            current = 0;
            currentLabel.Text = current.ToString();
            ShowPokemon(pokemons[current]);
        }

        private void lastButton_Click(object sender, EventArgs e)
        {
            //set this to count -1
            current = count - 1;
            currentLabel.Text = current.ToString();
            ShowPokemon(pokemons[current]);
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            //set this to 0
            if (current > 0)
            {
                //this line makes you a cool programmer!
                current--;
                currentLabel.Text = current.ToString();
                ShowPokemon(pokemons[current]);
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (current < count - 1)
            {
                current++;
                currentLabel.Text = current.ToString();
                ShowPokemon(pokemons[current]);
            }
        }
        private void clear()
        {
            nameTbox.Text = "";
            TypeTbox.Text = "";
            levelTbox.Text ="";
            attackComboBox.Text = "";
            hpTbox.Text = "";
            expTbox.Text = "";
            legendaryCbox.Checked = false;
            shinyCbox.Checked = false;
            genUpDown.Value =0;
        }
        private void newButton_Click(object sender, EventArgs e)
        {

            current = count;
            current = count++;
        }
    }
}