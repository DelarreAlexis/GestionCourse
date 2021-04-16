using System;
using System.Collections.Generic;
using System.Text;

namespace GestionCourse.Models
{
	public class Coureur
	{
		private int _num;
		private string _nom;
		private string _prenom;
		private int _age;
		private int _sexe;

		public int Num { get => _num; set { _num = value; } }
		public string Nom { get => _nom; set { _nom = value; } }
		public string Prenom { get => _prenom; set { _prenom = value; } }
		public int Age { get => _age; set { _age = value;  } }
		public int Sexe { get => _sexe; set { _sexe = value; } }
	}
}
