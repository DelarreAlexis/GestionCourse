using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GestionCourse
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new ListeCourse();
		}

		protected override void OnStart()
		{
		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
		}
	}
}
