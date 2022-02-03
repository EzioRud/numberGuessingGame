using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Media;
using System.Windows.Resources;
using System.IO;
using ThinkLib;


namespace guess_game_by_Rudolph
{
    /// <summary>
    /// Interaction logic for GameItSelf.xaml
    /// </summary>
    public partial class GameItSelf : Window
    {
       
        Turtle goku;
       
        int i = 1;
        int levelone = 0;   
        
        int lowerlim = 0;
        int upperbound = 10;
      

        int counter = 5; //chances given each level
        int take = 0;  //number of tries and starts at 1 because its your fisrt try
        int guessed = 0;
        int rum = 10;
        int upperlim = 10;
        int levelim = 0;
        int lowerbound;
        int bl = 0;
        int bu = 10;
        int answer = 0;
        int move = 0;

        Random secret = new Random();
        
        public GameItSelf()
        {
            InitializeComponent();
            goku = new Turtle(home, 10, 20);
            levelone = secret.Next(rum);


        }
        private void Stamp(int k)
        {
            
            int i = 0;
            int row = 10;
            int col = 10;
            int dl = 0;
            while (dl < k) 
            {
                while (i < 10)
                {
                    goku.WarpTo(col, row);
                    goku.Stamp(Convert.ToString(dl) + Convert.ToString(i));
                    col = col + 40;

                    i = i + 1;
                }
                dl = dl + 1;
                i = 0;
                col = 10;
                row = row + 20;
            }
        }

        void stampp()
        {
           
            int c = guessed % 10;
            int r = guessed / 10;
            int col = 10 + (c * 40) + 9;
            int row = 10 + (r * 20) + 13;
            goku.WarpTo(col, row);
            goku.Stamp();
        }

        void checking(int g, int n)
        {
            if (levelim < 10)
            {


                if (g > n && counter > 0)
                {
                    chance.Clear();
                    taken.Clear();
                    guess1.Clear();
                    makeSound1();
                    outbox.Text = "try a lower number";
                    counter = counter - 1;
                    chance.AppendText(Convert.ToString(counter));
                    take = take + 1;
                    taken.AppendText(Convert.ToString(take));
                    upperlim = guessed + 1;

                    bu = guessed;
                    move = bu / 2;
                    move = bu - move;
                    guessed = move;
                    bu = bu - 1;


                }
                else if (g < n && counter > 0)
                {
                    guess1.Clear();
                    chance.Clear();
                    taken.Clear();
                    makeSound();
                    outbox.Text = "try a higher number";
                    counter = counter - 1;
                    chance.AppendText(Convert.ToString(counter));
                    take = take + 1;
                    taken.AppendText(Convert.ToString(take));
                    move = bu - guessed;
                    move = move / 2;
                    guessed = move + bl;
                    bl = guessed;
                    lowerlim = guessed + 1;
                    bl = bl + 1;


                }
                else if (g == n && counter > 0)
                {
                    guess1.Clear();
                    chance.Clear();
                    taken.Clear();
                    makeSound2();
                    outbox.Text = "Well Done";
                    
                    counter = counter + 4;
                    chance.AppendText(Convert.ToString(counter));
                    take = take + 1;
                    taken.AppendText(Convert.ToString(take));
                    i = i + 1;
                    levell.Text = Convert.ToString(i);
                    rum = rum + 10;
                    MessageBox.Show("well done");
                    take = 1; 
                    taken.Clear();
                    taken.AppendText("0");
                    goku.Clear();
                    Stamp(i);
                    levelone = secret.Next(rum);
                    levelim = levelim + 1;
                    lowerlim = 0;
                    upperlim = rum;
                    bl = 0;
                    bu = rum;
                    lowerbound = 0;
                    upperbound = rum;
                }
                else if (counter == 0)
                {
                    MessageBox.Show("You lose");
                    Environment.Exit(0);
                }


            }
            if (levelim == 10)
            {

                n = levelone;
                Stamp(i);
                stampp();
                checking(g, n);
                MessageBox.Show("You Win");
                Environment.Exit(0);
                levelim = levelim + 1;

            }
        }

        private void checkValid(int g, int n)
        {
            levell.Text = Convert.ToString(i); // shows which level you are on
            n = levelone;
            Stamp(i);
            stampp();
            checking(g, n);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            guessed = Convert.ToInt32(guess1.Text);
            guess1.Text = Convert.ToString(guessed);
            checkValid(guessed, levelone);
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
           
        }
        private void CheckBox_UnChecked(object sender, RoutedEventArgs e)
        {
          
        }

        int binary(int y)
        {

            int g = lowerbound + upperbound;
            int mid = g / 2;
            while (lowerbound < upperbound)
            {


                if (mid == y)
                {
                    return mid;
                }
                if (mid > y)
                {
                    upperbound = mid;
                    return mid;
                }
                if (mid < y)
                {
                    lowerbound = mid;
                    return mid;
                }
            }
            return 0;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            guessed = (binary(levelone));
            checkValid(guessed, levelone);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            guess1.Clear();
            int rah = secret.Next(rum);
            guess1.Text = Convert.ToString(rah);

            guessed = Convert.ToInt32(guess1.Text);
            checkValid(guessed, levelone);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            guess1.Clear();

            int limitrandom = secret.Next(lowerlim, upperlim);
            guessed = Convert.ToInt32(limitrandom); ;
            checkValid(guessed, levelone);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            
            levelim = 1;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("The game is about to exit, come back to have more fun");
            Environment.Exit(0);
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.Escape:
                    this.Close();
                    break;
             
            }

        }

        private void makeSound()
        {
            Uri pathToFile = new Uri("pack://application:,,,/HigherN.wav");
            StreamResourceInfo strm = Application.GetResourceStream(pathToFile);
            SoundPlayer sp = new SoundPlayer(strm.Stream);
            sp.Play();
        }

        private void makeSound1()
        {
            Uri pathToFile = new Uri("pack://application:,,,/LowerN.wav");
            StreamResourceInfo strm = Application.GetResourceStream(pathToFile);
            SoundPlayer sp = new SoundPlayer(strm.Stream);
            sp.Play();
        }

        private void makeSound2()
        {
            Uri pathToFile = new Uri("pack://application:,,,/GoodN.wav");
            StreamResourceInfo strm = Application.GetResourceStream(pathToFile);
            SoundPlayer sp = new SoundPlayer(strm.Stream);
            sp.Play();
        }

    }
}
