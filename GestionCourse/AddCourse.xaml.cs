using GestionCourse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GestionCourse
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AddCourse : ContentPage
	{
		public ListView List { get; set; }
		public AddCourse()
		{
			InitializeComponent();
		}

		public AddCourse(ListView list)
		{
			InitializeComponent();
			List = list;
		}

		private void btnValider_Clicked(object sender, EventArgs e)
		{
			Course course = new Course()
			{
				Distance = float.Parse(entDistance.Text),
				Lieu = entLieu.Text,
				Nom = entNom.Text,
			};

			App.Courses.Add(course);

			List.ItemsSource = null;
			List.ItemsSource = App.Courses;

			Navigation.PopModalAsync();
		}
	}
}