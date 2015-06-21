using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSandbox
{
	class Animal
	{

		public virtual void Feed()
		{
			Debug.WriteLine("Animal feeding.");
		}

	}
}
