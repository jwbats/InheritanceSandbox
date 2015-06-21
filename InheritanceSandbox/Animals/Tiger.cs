using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSandbox.Animals
{
	class Tiger : Mammal
	{

		public override void Feed()
		{
			Debug.WriteLine("Tiger feeding.");
		}

	}
}
