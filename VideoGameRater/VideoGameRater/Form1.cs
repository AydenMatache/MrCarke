using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoGameRater
{
    enum Rating
    {
        E = 0,
        E10Plus,
        T,
        M,
        AO
    }

    struct VideoGame
    {
        public string Title;
        public string Creator;
        public Rating Rating;
        public decimal Revenue;
        public string CharacterActor;
        public string PicturePath;
    }

    public partial class Form1 : Form
    {
        private int current;
        private int count;
        private VideoGame[] videoGames;

        public Form1()
        {
            InitializeComponent();
            current = 0;
            count = 0;
            videoGames = new VideoGame[50]; // Adjust capacity as needed
            void ShowVideoGame(VideoGame vg)
            {
                // Set text box values, combo box selection, and picture box image
                titleTbox.Text = vg.Title;
                creatorTbox.Text = vg.Creator;
                ratingComboBox.Text = vg.Rating.ToString();
                revenueTbox.Text = vg.Revenue.ToString();
                characterActorTbox.Text = vg.CharacterActor;
                pictureBox1.Image = Image.FromFile(vg.PicturePath);
            }
            // Load data from file if it exists
            if (File.Exists("VideoGames.txt"))
            {
                try
                {
                    StreamReader reader = new StreamReader("VideoGames.txt");
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        VideoGame game = ReadVideoGame(line);
                        videoGames[count] = game;
                        count++;
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error reading data: " + ex.Message);
                }
            }

            // Set initial values for controls
            ShowVideoGame(videoGames[current]);
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            // Get data from text boxes and controls
            string title = titleTbox.Text;
            string creator = creatorTbox.Text;
            Rating rating = (Rating)Enum.Parse(typeof(Rating), ratingComboBox.Text);
            decimal revenue = decimal.Parse(revenueTbox.Text);
            string characterActor = characterActorTbox.Text;
            string picturePath = pictureBox1.ImageLocation; // Get path from PictureBox

            // Validate data
            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(creator) ||
                string.IsNullOrEmpty(picturePath))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            // Create a new VideoGame object
            VideoGame game = new VideoGame
            {
                Title = title,
                Creator = creator,
                Rating = rating,
                Revenue = revenue,
                CharacterActor = characterActor,
                PicturePath = picturePath
            };

            // Update current game or add new one
            if (current < count)
            {
                videoGames[current] = game;
            }
            else
            {
                videoGames[count] = game;
                count++;
            }

            // Save data to file
            try
            {
                StreamWriter writer = new StreamWriter("VideoGames.txt");
                for (int i = 0; i < count; i++)
                {
                    writer.WriteLine(VideoGameToString(videoGames[i]));
                }
                writer.Close();
                MessageBox.Show("Data saved successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving data: " + ex.Message);
            }
        }

        private VideoGame ReadVideoGame(string line)
        {
            string[] fields = line.Split('|');
            VideoGame game = new VideoGame
            {
                Title = fields[0],
                Creator = fields[1],
                Rating = (Rating)Enum.Parse(typeof(Rating), fields[2]),
                Revenue = decimal.Parse(fields[3]),
                CharacterActor = fields[4],
                PicturePath = fields[5]
            };
            return game;
        }

        private string VideoGameToString(VideoGame game)
        {
            string line = "";
            line += game.Title + "|";
            line += game.Creator + "|";
            line += game.Rating.ToString() + "|";
            line += game.Revenue.ToString() + "|";
            line += game.CharacterActor + "|";
            line += game.PicturePath;
            return line;
        }
    }
}