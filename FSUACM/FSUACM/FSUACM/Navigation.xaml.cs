using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FSUACM
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Navigation : ContentPage
    {
        public Navigation()
        {
            InitializeComponent();
        }

        async void OnClickCalendar(Object sender, EventArgs eventArgs)
        {
            Navigation.PushAsync(new FSUACM.Features.CalendarPage());
        }

    }
}