using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace PainterMobile.Droid
{
	[Activity (Label = "PainterMobile.Android", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		int count = 1;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
            ActionBar.NavigationMode = ActionBarNavigationMode.Tabs;
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button btnpopupmenu = FindViewById<Button>(Resource.Id.btnpopupmenu);
            btnpopupmenu.Click += (s, arg) =>
            {
                PopupMenu menu = new PopupMenu(this, btnpopupmenu);
                menu.Inflate(Resource.Menu.popup_menu);
                menu.Show();
            };

            ActionBar.Tab tab = ActionBar.NewTab();
            //tab.SetText(Resources.GetString(Resource.String.tab1_text));
            //tab.SetIcon(Resource.Drawable.tab1_icon);
            tab.TabSelected += (sender, args) => {
                // Do something when tab is selected
            };
            ActionBar.AddTab(tab);

            tab = ActionBar.NewTab();
            //tab.SetText(Resources.GetString(Resource.String.tab2_text));
            //tab.SetIcon(Resource.Drawable.tab2_icon);
            tab.TabSelected += (sender, args) =>
            {
                // Do something when tab is selected
            };
            ActionBar.AddTab(tab);
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.option_menu, menu);
            return true;
        }
    }
}


