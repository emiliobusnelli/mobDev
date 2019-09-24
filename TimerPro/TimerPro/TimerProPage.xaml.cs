using Xamarin.Forms;
using TimerPro.Custom;
using System;

namespace TimerPro
{
    public partial class TimerProPage : ContentPage
    {
        // o = object in otimerLogic
        TimerLogic otimerLogic;
        bool isRunning;

        public TimerProPage()
        {
            InitializeComponent();
            // takes class and instantiates it into an object
            otimerLogic = new TimerLogic();
        }
        
        void Start_Clicked(object sender, System.EventArgs e)
        {
            btnStop.IsEnabled = true;
            btnStart.IsEnabled = false;
            isRunning = true;

            // lamda expression is a function that needs to have true or false returned
            Device.StartTimer(TimeSpan.FromSeconds(1),() => {
                if (isRunning)
                {
                    otimerLogic.SetTickCount();
                    lblDisplay.Text = otimerLogic.GetFormattedTimeString();
                }
                return isRunning;
            });
        }

        void Stop_Clicked(object sender, System.EventArgs e)
        {
            btnStart.IsEnabled = true;
            btnStop.IsEnabled = false;
            isRunning = false;

        }

        void Reset_Clicked(object sender, System.EventArgs e)
        {
            otimerLogic.Reset();
            lblDisplay.Text = otimerLogic.GetFormattedTimeString();
            btnStart.IsEnabled = true;
            btnStop.IsEnabled = false;
            isRunning = false;
        }

        // the moment the view is visible to the end user
        protected override void OnAppearing()
        {
            base.OnAppearing();
            btnStart.IsEnabled = true;
            btnStop.IsEnabled = false;
            lblDisplay.Text = "00:00:00";
        }
    }
}
