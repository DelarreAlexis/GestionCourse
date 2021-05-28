using System;
using System.Collections.Generic;
using System.Text;

namespace GestionCourse.Models
{
	public class Course
	{
		private int _num;
		private string _nom;
		private float _distance;
		private string _lieu;
		private List<Coureur> _coureurs;

		public int Num { get => _num; set => _num = value; }
		public string Nom { get => _nom; set => _nom = value; }
		public float Distance { get => _distance; set => _distance = value;   }
		public string Lieu { get => _lieu; set => _lieu = value;  }
		public List<Coureur> Coureurs { get => _coureurs; set => _coureurs = value; }
	}
}
