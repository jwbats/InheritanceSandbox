using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSandbox.Shapes
{
	abstract class ShapesClass
	{
		// abstract: no body, must be implemented by deriving class
		abstract public int Area1();

		// virtual: body required, may be overridden (override) or hidden (new) by deriving class
		virtual public int Area2(int a, int b)
		{
			return a * b;
		}

		// virtual: body required, may be overridden (override) or hidden (new) by deriving class
		virtual public int Area3(int a, int b)
		{
			return a * b;
		}

		// virtual: body required, may be overridden (override) or hidden (new) by deriving class
		virtual public int Area4(int a, int b)
		{
			return a * b;
		}

	}
}
