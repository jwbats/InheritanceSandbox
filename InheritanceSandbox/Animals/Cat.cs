using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSandbox.Animals
{
	class Cat : Mammal
	{

		public override void Feed()
		{
			Debug.WriteLine("Giraffe feeding.");
		}

	}
}
