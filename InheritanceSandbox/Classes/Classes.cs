using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InheritanceSandbox.Classes
{

	class A
	{
		public virtual void show()
		{
			Debug.WriteLine("Base");
		}
	}

	class B : A
	{
		public override void show()
		{
			Debug.WriteLine("Override");
		}
	}

	class C : B
	{
		public new void show()
		{
			Debug.WriteLine("New");
		}
	}

}

