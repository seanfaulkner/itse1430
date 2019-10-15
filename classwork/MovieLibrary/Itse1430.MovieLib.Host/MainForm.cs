using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Itse1430.MovieLib.Host
{
    public partial class MainForm : Form
    {
        public MainForm ()
        {
            InitializeComponent ();
        }

        protected override void OnLoad ( EventArgs e )
        {
            base.OnLoad (e);

            UpdateUI ();
        }

        //Called when Movie\Add selected
        private void OnMovieAdd ( object sender, EventArgs e )
        {
            var form = new MovieForm ();

            //Modeless - does not block main window
            //form.Show();

            //Show the new movie form modally
            if (form.ShowDialog (this) == DialogResult.OK)
            {
                _movies.Add (form.Movie);
                UpdateUI ();
            };
        }

        private Movie GetSelectedMovie ()
        {
            //return _lstMovies.SelectedItem as Movie;
            var item = _lstMovies.SelectedItem;
            //if (item == null)
            //    return null;

            //Movie or null
            return item as Movie;

            ////Other approaches
            ////C-style cast
            //(Movie)item;

            ////Old approach 1
            //var tempVar = item as Movie;
            //if (tempVar != null)
            //{
            //};

            ////Old approach 2
            //if (item is Movie)
            //{
            //    var i = (Movie)item;
            //    //Do something with movie
            //}

            ////Pattern matching
            //if (item is Movie movie)
            //{
            //};
        }

        private void OnMovieEdit ( object sender, EventArgs e )
        {
            //Get selected movie
            var movie = GetSelectedMovie ();
            if (movie == null)
                return;

            var form = new MovieForm ();
            form.Movie = movie;

            if (form.ShowDialog (this) == DialogResult.OK)
            {
                _movies.Update (movie.Id, form.Movie);
                UpdateUI ();
            };
        }

        private void OnMovieDelete ( object sender, EventArgs e )
        {
            #region Playing with null
            //var menuItem = sender as Button;
            ////This will crash if menuItem is null
            ////var text = menuItem.Text;

            ////Handle null - as statement
            //var text = "";
            //if (menuItem != null)
            //    text = menuItem.Text;
            //else
            //    text = "";

            ////As expression
            //var text2 = (menuItem != null) ? menuItem.Text : "";

            ////Null coalescing menuItem ?? "";
            ////Null conditional operator
            //var text3 = menuItem?.Text ?? "";
            #endregion

            var movie = GetSelectedMovie ();
            if (movie == null)
                return;

            //Confirmation
            var msg = $"Are you sure you want to delete {movie.Title}?";
            var result = MessageBox.Show (msg, "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;

            //Delete it
            _movies.Remove (movie.Id);
            UpdateUI ();
        }

        private void OnFileExit ( object sender, EventArgs e )
        {
            Close ();
        }

        private void OnHelpAbout ( object sender, EventArgs e )
        {
            var form = new AboutForm ();
            form.ShowDialog (this);
        }

        private void UpdateUI ()
        {
            var movies = _movies.GetAll ();

            //var movie = movies[0];
            //movie.Title = "Bob";

            //Programmatic approach
            //_lstMovies.Items.Clear();
            //_lstMovies.Items.AddRange(movies);

            //For more complex bindings
            _lstMovies.DataSource = movies;
        }

        private MovieDatabase _movies = new MovieDatabase ();
    }
}
