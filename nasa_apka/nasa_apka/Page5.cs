﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace nasa_apka
{
    public class Page5 : ContentPage
    {
        public Page5()
		{
			var rootPageButton = new Button { Text = "Hlavná strana", VerticalOptions = LayoutOptions.CenterAndExpand };
			rootPageButton.Clicked += OnRootPageButtonClicked;


			Title = "Lieky";
			Content = new StackLayout
			{
				Children = {
					rootPageButton,

				}
			};
		}

		async void OnRootPageButtonClicked(object sender, EventArgs e)
		{
			await Navigation.PopToRootAsync();
		}
	}
}