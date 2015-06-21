using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSandbox.Shapes
{

	class Square : ShapesClass
	{
		private int side = 0;

		public Square(int n)
		{
			side = n;
		}

		// abstract area method must be implemented using the override keyword
		public override int Area1()
		{
			return side * side;
		}

		// virtual area method may be implemented using override keyword
		public override int Area2(int a, int b)
		{
			return base.Area2(a, b);
		}

		// virtual area method may be implemented using override keyword
		public new int Area3(int a, int b)
		{
			return base.Area3(a, b);
		}
		
	}

}
