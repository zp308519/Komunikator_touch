using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Komunikator_touch
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //private TaskCompletionSource<bool> keyPressedSource = new TaskCompletionSource<bool>();
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        public MainWindow()
        {

            InitializeComponent();
            this.KeyDown += S_KeyDown;
            this.KeyDown += W_KeyDown;
            this.KeyDown += A_KeyDown;

        }


        private bool S_keyPressed = false;
        int currentS = 0;
        int i = 0;

        private async void S_KeyDown(object sender, KeyEventArgs e)
        {

            Button[] buttonsS = { bEat, bDrink, bToilet, bBath, bSleep };

            if (e.Key == Key.S)
            {
                S_keyPressed = true;
                while (i <= 5)
                {
                    if (i == currentS && i < 5)
                    {
                        switch (i)
                        {

                            case 0:
                                player.SoundLocation = @"C:\Users\zuza7\OneDrive\Pulpit\Comiunicator_sounds\Eat 7.wav";
                                player.Load();
                                player.Play();
                                break;
                            case 1:
                                player.SoundLocation = @"C:\Users\zuza7\OneDrive\Pulpit\Comiunicator_sounds\Drink 1.wav";
                                player.Load();
                                player.Play();
                                break;
                            case 2:
                                player.SoundLocation = @"C:\Users\zuza7\OneDrive\Pulpit\Comiunicator_sounds\Toilet 9.wav";
                                player.Load();
                                player.Play();
                                break;
                            case 3:
                                player.SoundLocation = @"C:\Users\zuza7\OneDrive\Pulpit\Comiunicator_sounds\Bath 14.wav";
                                player.Load();
                                player.Play();
                                break;
                            case 4:
                                player.SoundLocation = @"C:\Users\zuza7\OneDrive\Pulpit\Comiunicator_sounds\Sleep 8.wav";
                                player.Load();
                                player.Play();
                                break;
                        }
                        buttonsS[i].Background = Brushes.Red;
                        if (i >= 1)
                        {
                            buttonsS[i - 1].Background = Brushes.AntiqueWhite;
                        }
                        i++;
                        break;
                    }
                    else if (i == 5)
                    {
                        i = 0;
                        currentS = 0;
                        buttonsS[4].Background = Brushes.AntiqueWhite;
                    }

                }
                S_keyPressed = false;
                currentS++;
                await Task.Run(() => { while (!S_keyPressed) ; });
            }
        }


        private bool W_keyPressed = false;
        int currentW = 0;
        int j = 0;
        private async void W_KeyDown(object sender, KeyEventArgs e)
        {
            Button[] buttonsW = {bPain, bSad, bHappy, bNeutral, bBoredom };

            if (e.Key == Key.W)
            {
                W_keyPressed = true;
                while (j <= 5)
                {
                    if (j == currentW && j < 5)
                    {
                        switch (j)
                        {
                            case 0:
                                player.SoundLocation = @"C:\Users\zuza7\OneDrive\Pulpit\Comiunicator_sounds\Pain 3.wav";
                                player.Load();
                                player.Play();
                                break;
                            case 1:
                                player.SoundLocation = @"C:\Users\zuza7\OneDrive\Pulpit\Comiunicator_sounds\Sad 1.wav";
                                player.Load();
                                player.Play();
                                break;
                            case 2:
                                player.SoundLocation = @"C:\Users\zuza7\OneDrive\Pulpit\Comiunicator_sounds\Happy 4.wav";
                                player.Load();
                                player.Play();
                                break;
                            case 3:
                                player.SoundLocation = @"C:\Users\zuza7\OneDrive\Pulpit\Comiunicator_sounds\Neutral 1.wav";
                                player.Load();
                                player.Play();
                                break;
                            case 4:
                                player.SoundLocation = @"C:\Users\zuza7\OneDrive\Pulpit\Comiunicator_sounds\Boredom 1.wav";
                                player.Load();
                                player.Play();
                                break;
                        }
                        buttonsW[j].Background = Brushes.Red;
                        if (j >= 1)
                        {
                            buttonsW[j - 1].Background = Brushes.AntiqueWhite;
                        }
                        j++;
                        break;
                    }
                    else if (j == 5)
                    {
                        j = 0;
                        currentW = 0;
                        buttonsW[4].Background = Brushes.AntiqueWhite;
                    }
                }
                W_keyPressed = false;
                currentW++;
                await Task.Run(() => { while (!W_keyPressed) ; });
            }
        }


        private bool A_keyPressed = false;
        int currentA = 0;
        int k = 0;
        private async void A_KeyDown(object sender, KeyEventArgs e)
        {
            Button[] buttonsA = { bYes, bNo, bDontKnow, bMaybe };

            if (e.Key == Key.A)
            {
                A_keyPressed = true;
                while (k <= 4)
                {
                    if (k == currentA && k < 4)
                    {
                        switch (k)
                        {
                            case 0:
                                player.SoundLocation = @"C:\Users\zuza7\OneDrive\Pulpit\Comiunicator_sounds\Yes 13.wav";
                                player.Load();
                                player.Play();
                                break;
                            case 1:
                                player.SoundLocation = @"C:\Users\zuza7\OneDrive\Pulpit\Comiunicator_sounds\No 11.wav";
                                player.Load();
                                player.Play();
                                break;
                            case 2:
                                player.SoundLocation = @"C:\Users\zuza7\OneDrive\Pulpit\Comiunicator_sounds\I don-t know 1.wav";
                                player.Load();
                                player.Play();
                                break;
                            case 3:
                                player.SoundLocation = @"C:\Users\zuza7\OneDrive\Pulpit\Comiunicator_sounds\Maybe 1.wav";
                                player.Load();
                                player.Play();
                                break;
                        }
                        buttonsA[k].Background = Brushes.Red;
                        if (k >= 1)
                        {
                            buttonsA[k - 1].Background = Brushes.AntiqueWhite;
                        }
                        k++;
                        break;
                    }
                    else if (k == 4)
                    {
                        k = 0;
                        currentA = 0;
                        buttonsA[3].Background = Brushes.AntiqueWhite;
                    }

                }
                A_keyPressed = false;
                currentA++;
                await Task.Run(() => { while (!A_keyPressed) ; });
            }
        }
    }
}