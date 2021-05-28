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
	public partial class AddCoureur : ContentPage
	{
		public AddCoureur()
		{
			InitializeComponent();
		}

		private void btnValider_Clicked(object sender, EventArgs e)
		{
			// Ici nous allons créer un coureur qui reprend les champs de la vue.		
			Coureur coureur = new Coureur()
			{
				Age = Convert.ToInt32(entAge.Text),
				Nom = entNom.Text,
				Prenom = entPrenom.Text,
				Sexe = Convert.ToInt32(entSexe.Text)
			};

			//Nous ajoutons à notre liste le coureur pour le "sauvegarder"
			App.Coureurs.Add(coureur);

			//Cela va permettre de revenir en arrière dans notre navigation. Donc ici de revenir sur ListeCourse
			Navigation.PopModalAsync();
		}
	}
}