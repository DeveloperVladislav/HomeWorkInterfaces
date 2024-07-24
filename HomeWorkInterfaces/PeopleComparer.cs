using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkInterfaces
{
	public class PeopleComparer : IComparer<Person>
	{
		// Реализация метода Compare для сравнения по имени
		public int Compare(Person? p1, Person? p2)
		{
			if (p1 is null || p2 is null)
				throw new ArgumentException("Некорректное значение параметра");
			return p1.Name.Length - p2.Name.Length;
		}
	}
}
