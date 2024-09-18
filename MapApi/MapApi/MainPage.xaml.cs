using Microsoft.Maui.Maps;

namespace MapApi
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            var location = new Location(-23.51979722880348, -46.596486004008256);
            var mapSpan = new MapSpan(location, 0.01, 0.01);
            map.MoveToRegion(mapSpan);
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            
        }
    }

}
