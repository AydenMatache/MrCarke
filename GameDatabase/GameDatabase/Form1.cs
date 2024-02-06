using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameDatabase
{
    enum Rating
    {
        Everyone, Everyone_10_plus, Teen, Mature_17_plus, Adults_Only_18_plus, Rating_Pending, Rating_Pending_Likely_Mature_17_plus
    }
    struct Game
    {
        public string title;
        public string creator;
        public Rating rating;
        public string revenue;
        public string character;
        public string picture;
    }

    public partial class Form1 : Form
    {
        private Game[] games;
        private int count;
        private int current;
        public string fileName;

        public Form1()
        {
            InitializeComponent();
            count = 0;
            current = 0;
            games = new Game[50];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("Games.txt"))
            {
                StreamReader inFile = new StreamReader("Games.txt");
                while (!inFile.EndOfStream)
                {
                    string S = inFile.ReadLine();
                    Game g = ReadGame(S);
                    games[count] = g;
                    count++;
                }
                inFile.Close();
                DisplayGame(games[0]);

            }
        }

        private Game ReadGame(string s)
        {
            Game g = new Game();
            string[] fields = s.Split('|');
            g.title = fields[0];
            g.creator = fields[1];
            g.rating = (Rating)Enum.Parse(typeof(Rating), fields[2]);
            g.revenue = fields[3];
            g.character = fields[4];
            g.picture = fields[5];

            return g;
        }

        private void DisplayGame(Game g)
        {
            titleTbox.Text = g.title;
            creatorTbox.Text = g.creator;
            ratingCbox.Text = g.rating.ToString();
            revenueTbox.Text = g.revenue.ToString();
            characterTbox.Text = g.character;
            pictureBox1.Load(g.picture);
        }

        private void Save()
        {
            string tmp = "";
            tmp += titleTbox.Text;
            tmp += "|";
            tmp += creatorTbox.Text;
            tmp += "|";
            tmp += ratingCbox.Text;
            tmp += "|";
            tmp += revenueTbox.Text;
            tmp += "|";
            tmp += characterTbox.Text;
            tmp += "|";
            tmp += pictureBox1.ImageLocation;
            games[current] = ReadGame(tmp);

            StreamWriter outFile = new StreamWriter("Games.txt");
            for (int i = 0; i < count; i++)
            {
                outFile.WriteLine(GameToString(games[i]));
            }
            outFile.Close();

        }

        private string GameToString(Game g)
        {
            string retVal = "";
            retVal += g.title.ToString();
            retVal += "|";
            retVal += g.creator.ToString();
            retVal += "|";
            retVal += g.rating.ToString();
            retVal += "|";
            retVal += g.revenue.ToString();
            retVal += "|";
            retVal += g.character.ToString();
            retVal += "|";
            retVal += g.picture.ToString();
            return retVal;
        }

        private void Clear()
        {
            titleTbox.Text = "";
            creatorTbox.Text = "";
            ratingCbox.Text = "";
            revenueTbox.Text = "";
            characterTbox.Text = "";
            pictureBox1.Image = null;
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            current = count;
            count++;
            Clear();
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            if (current > 0)
            {
                Save();
                current--;
                DisplayGame(games[current]);
            }

        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (current < count - 1)
            {
                Save();
                current++;
                DisplayGame(games[current]);
            }
        }

        private void firstBtn_Click(object sender, EventArgs e)
        {
            Save();
            current = 0;
            DisplayGame(games[current]);
        }

        private void lastBtn_Click(object sender, EventArgs e)
        {
            Save();
            current = count - 1;
            DisplayGame(games[current]);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Save();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            pictureBox1.Load(openFileDialog1.FileName);
            fileName = openFileDialog1.FileName;
          
        }
    }
}

