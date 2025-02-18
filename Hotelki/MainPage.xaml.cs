using Microsoft.Maui.Controls;
namespace Hotelki
{
    public partial class MainPage : ContentPage
    {
        class Product
        {
            public string Name { get; set; } = "";
            public string Description { get; set; } = "";
            public string ImagePath { get; set; } = "";
        }
        public MainPage()
        {
            InitializeComponent();
        }

    }
}
