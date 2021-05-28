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
	public partial class InscriptionCoureur : ContentPage
	{
		public Course Course { get; set; }
		public ListView List { get; set; }
		public InscriptionCoureur()
		{
			InitializeComponent();
		}

		public InscriptionCoureur(Course course, ListView list)
		{
			InitializeComponent();
			lstCoureur.ItemsSource = App.Coureurs;
			Course = course;
			List = list;
		}

		private void lstCoureur_ItemTapped(object sender, ItemTappedEventArgs e)
		{
			if (Course.Coureurs == null)
				Course.Coureurs = new List<Coureur>();

			Coureur coureur = (Coureur)e.Item;

			Course.Coureurs.Add(coureur);

			List.ItemsSource = null;
			List.ItemsSource = Course.Coureurs;
			Navigation.PopModalAsync();
		}
	}
}