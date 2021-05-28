using GestionCourse.Models;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GestionCourse
{
	public partial class App : Application
	{
		public static List<Coureur> Coureurs { get; set; }

		public static List<Course> Courses { get; set; }

		public App()
		{
			InitializeComponent();

			// Nous avons créé une liste de coureur dans le fichier App, cela va permet d'avoir accès à cette liste de n'importe où. 
			// De plus cette liste est en static, elle va vivre le temps de l'application.
			if (Coureurs == null)
				Coureurs = new List<Coureur>();

			if (Courses == null)
				Courses = new List<Course>();
			InitialiseListeCourse();

			//Ici nous pouvons modifier la page de démarrage de l'application. En attribuant une nouvelle page à MainPage, l'application va s'ouvrir sur la page en question 
			//A savoir la page par défaut s'appelle MainPage.
			MainPage = new ListeCourse();
		}

		private void InitialiseListeCourse()
		{
			//Ici on va remplir notre liste de course
			if (Courses == null)
				Courses = new List<Course>();

			//Une liste stocke des objets, pour lui mettre des objets, on utilise la méthode Add()
			//Si on veut ajouter plusieurs objets en même temps on va utiliser AddRange() 
			Courses.Add(new Course { Nom = "Marathon de Paris", Lieu = "Paris", Distance = 42.195f });
			Courses.Add(new Course { Nom = "Marathon de Montpellier", Lieu = "Montpellier", Distance = 42.195f });
			Courses.Add(new Course { Nom = "Semi-Marathon de Phalempin", Lieu = "Phalempin", Distance = 21.1f });
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
