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
	public partial class ListeCoureur : ContentPage
	{
		public Course Course { get; set; }
		public ListeCoureur()
		{
			InitializeComponent();
		}

		public ListeCoureur(Course course)
		{
			InitializeComponent();
			Course = course;
			lblTitre.Text = Course.Nom;

			if (Course.Coureurs == null)
				Course.Coureurs = new List<Coureur>();
			lstCoureur.ItemsSource = Course.Coureurs;
		}

		private void btnCoureur_Clicked(object sender, EventArgs e)
		{
			Navigation.PushModalAsync(new InscriptionCoureur(Course, lstCoureur));
		}

		private void btnBack_Clicked(object sender, EventArgs e)
		{
			Navigation.PopModalAsync();
		}
	}
}