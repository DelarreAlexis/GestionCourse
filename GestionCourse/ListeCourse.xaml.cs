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
		public List<Course> Courses { get; set; }

		public ListeCourse()
		{
			InitializeComponent();
			InitialiseListeCourse();
			lstCourse.ItemsSource = Courses;
		}

		
		private void InitialiseListeCourse()
		{
			if (Courses == null)
				Courses = new List<Course>();
			Courses.Add(new Course { Nom = "Marathon de Paris", Lieu = "Paris", Distance = 42.195f });
			Courses.Add(new Course { Nom = "Marathon de Montpellier", Lieu = "Montpellier", Distance = 42.195f });
			Courses.Add(new Course { Nom = "Semi-Marathon de Phalempin", Lieu = "Phalempin", Distance = 21.1f });
		}
	}
}
