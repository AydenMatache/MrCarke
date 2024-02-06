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
Movie;
namespace MovieRater
{
    

    public partial class Form1 : Form
    {
        private List<Movie> movies;
        private int currentMovieIndex;

        public Form1()
        {
            InitializeComponent();
            movies = new List<Movie>();
            currentMovieIndex = -1;
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            if (currentMovieIndex > 0)
            {
                currentMovieIndex--;
                ShowMovie();
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (currentMovieIndex < movies.Count - 1)
            {
                currentMovieIndex++;
                ShowMovie();
            }
        }

        private void firstButton_Click(object sender, EventArgs e)
        {
            if (movies.Count > 0)
            {
                currentMovieIndex = 0;
                ShowMovie();
            }
        }

        private void lastButton_Click(object sender, EventArgs e)
        {
            if (movies.Count > 0)
            {
                currentMovieIndex = movies.Count - 1;
                ShowMovie();
            }
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            Movie newMovie = new Movie();
            movies.Add(newMovie);
            currentMovieIndex = movies.Count - 1;
            ShowMovie();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadMovies();
            if (movies.Count > 0)
            {
                currentMovieIndex = 0;
                ShowMovie();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (currentMovieIndex >= 0 && currentMovieIndex < movies.Count)
            {
                movies[currentMovieIndex].Title = titleTextBox.Text;
                movies[currentMovieIndex].Creator = creatorTextBox.Text;
                Enum.TryParse(ratingComboBox.SelectedItem.ToString(), out Rating rating);
                movies[currentMovieIndex].MovieRating = rating;
                movies[currentMovieIndex].Revenue = decimal.Parse(revenueTextBox.Text);
                movies[currentMovieIndex].Character = characterTextBox.Text;
                movies[currentMovieIndex].PicturePath = picturePathTextBox.Text;

                SaveMovies();
            }
        }

        private void loadPictureButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picturePathTextBox.Text = openFileDialog.FileName;
                imagePictureBox.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void ShowMovie()
        {
            if (currentMovieIndex >= 0 && currentMovieIndex < movies.Count)
            {
                Movie currentMovie = movies[currentMovieIndex];
                titleTextBox.Text = currentMovie.Title;
                creatorTextBox.Text = currentMovie.Creator;
                ratingComboBox.SelectedItem = currentMovie.MovieRating.ToString();
                revenueTextBox.Text = currentMovie.Revenue.ToString();
                characterTextBox.Text = currentMovie.Character;
                picturePathTextBox.Text = currentMovie.PicturePath;
                if (File.Exists(currentMovie.PicturePath))
                    imagePictureBox.Image = Image.FromFile(currentMovie.PicturePath);
                else
                    imagePictureBox.Image = null;
            }
            else
            {
                ClearFields();
            }
        }

        private void ClearFields()
        {
            titleTextBox.Clear();
            creatorTextBox.Clear();
            ratingComboBox.SelectedIndex = -1;
            revenueTextBox.Clear();
            characterTextBox.Clear();
            picturePathTextBox.Clear();
            imagePictureBox.Image = null;
        }

        private void LoadMovies()
        {
            if (File.Exists("movies.txt"))
            {
                try
                {
                    string[] lines = File.ReadAllLines("movies.txt");
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split('|');
                        Movie movie = new Movie();
                        movie.Title = parts[0];
                        movie.Creator = parts[1];
                        Enum.TryParse(parts[2], out Rating rating);
                        movie.MovieRating = rating;
                        movie.Revenue = decimal.Parse(parts[3]);
                        movie.Character = parts[4];
                        movie.PicturePath = parts[5];
                        movies.Add(movie);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading movies: " + ex.Message);
                }
            }
        }

        private void SaveMovies()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("movies.txt"))
                {
                    foreach (Movie movie in movies)
                    {
                        writer.WriteLine($"{movie.Title}|{movie.Creator}|{movie.MovieRating}|{movie.Revenue}|{movie.Character}|{movie.PicturePath}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving movies: " + ex.Message);
            }
        }
    }
}

