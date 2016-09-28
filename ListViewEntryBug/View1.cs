using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace ListViewEntryBug
{
    public class View1 : ViewCell
    {
        public View1()
        {
            var layout = new StackLayout()
            {
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.FillAndExpand,
            };
            var theName = new Label()
            {
                WidthRequest = 100
            };
            var theText = new Entry()
            {
                WidthRequest = 100
            };
            theText.Focused += TheText_Focused;
            theText.Unfocused += TheText_Unfocused;
            theName.SetBinding(Label.TextProperty, new Binding("name", BindingMode.Default));
            theText.SetBinding(Entry.TextProperty, new Binding("someText", BindingMode.Default));
            layout.Children.Add(theName);
            layout.Children.Add(theText);
            View = layout;
        }

        private void TheText_Unfocused(object sender, FocusEventArgs e)
        {
            var temp = sender as Entry;
            Debug.WriteLine("Unfocused ->{0}", temp.Text);
        }

        private void TheText_Focused(object sender, FocusEventArgs e)
        {
            var temp = sender as Entry;
            Debug.WriteLine("Focused ->{0}", temp.Text);
        }
    }
}
