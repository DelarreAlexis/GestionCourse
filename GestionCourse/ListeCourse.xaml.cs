using GestionCourse.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GestionCourse
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListeCourse : ContentPage
	{

		public ListeCourse()
		{
			InitializeComponent();

			//On affecte notre liste de course que nous venons de créer à la propriété ITEMSOURCE de notre ListView (qui se trouve dans le xaml)
			lstCourse.ItemsSource = App.Courses;
		}

		private void btnCourse_Clicked(object sender, EventArgs e)
		{
			Navigation.PushModalAsync(new AddCourse(lstCourse));
		}

		private void btnCoureur_Clicked(object sender, EventArgs e)
		{
			//"Navigation" nous permet de naviguer dans notre application, de bouger de page à page. Ici nous avons pris la décision 
			// d'appeler la prochaine page en modal. Donc "AddCoureur" va venir s'ouvrir au dessus de ListeCourse.
			Navigation.PushModalAsync(new AddCoureur());
		}

		private void lstCourse_ItemTapped(object sender, ItemTappedEventArgs e)
		{
			//Ici je viens lui dire que mon objet qui se situe dans e.Item est de type "Course"
			//e.Item correspond à l'objet sur lequel nous avons "tapé"
			Navigation.PushModalAsync(new ListeCoureur((Course)e.Item));
		}
	}
}
