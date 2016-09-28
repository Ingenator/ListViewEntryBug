using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace ListViewEntryBug
{
    public class Page1 : ContentPage
    {
        public Page1()
        {
            Title = "List";
            var theListView = new ListView();
            var data = new DataFilled();
            data.FillData(5);
            theListView.ItemsSource = data.ListData;
            theListView.ItemTemplate = new DataTemplate(() => new View1());
            Content = theListView;
        }
    }
}
