using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using InheritanceSandbox.Animals;
using InheritanceSandbox.Classes;
using InheritanceSandbox.Shapes;

namespace InheritanceSandbox
{

	class Program
	{

		private static void FeedTheAnimals(IEnumerable<Animal> animals) 
		{ 
			foreach(Animal animal in animals)
			{
				animal.Feed();
			}
		}




		private static void DoSomethingToACat(Action<Cat> action, Cat cat)
		{
			action(cat);
		}




		private static void DoSomethingToADog(Action<Dog> action, Dog dog)
		{
			action(dog);
		}




		private static void ReadAndWrite(IList<Mammal> mammals)
		{
			Animal animal = mammals[0];
			Mammal mammal = mammals[0];
			mammals[0] = new Tiger();
		}




		private static void Main()
		{
			Square square = new Square(12);
			Debug.WriteLine("Area of the square = {0}", square.Area1());
			Debug.WriteLine("Area of the square = {0}", square.Area2(2, 3));
			Debug.WriteLine("Area of the square = {0}", square.Area3(4, 5));
			Debug.WriteLine("Area of the square = {0}", square.Area4(6, 7));

			Debug.WriteLine("");

			A a1 = new A();
			a1.show(); // Base

			B b1 = new B();
			b1.show(); // Override
	
			C c1 = new C();
			c1.show(); // New
			
			A a2 = new B();
			a2.show(); // Override
			
			A a3 = new C();
			a3.show(); // Override
			
			B b3 = new C();
			b3.show(); // Override

			Debug.WriteLine("");

			// create some lists
			List<Animal> animals = new List<Animal>() { new Animal() };
			List<Mammal> mammals = new List<Mammal>() { new Mammal() };
			List<Cat>    cats    = new List<Cat>()    { new Cat() };
			List<Dog>    dogs    = new List<Dog>()    { new Dog() };

			// covariance: passing derived type to base type
			FeedTheAnimals(cats);
			FeedTheAnimals(dogs);

			// contravariance: passing base type to derived type
			Action<Animal> feed = animal => { animal.Feed(); };
			DoSomethingToACat(feed, new Cat());
			DoSomethingToADog(feed, new Dog());

			// invariance: passing a type to its own type
			IList<Mammal> list = new List<Mammal>() { new Dog(), new Cat() };
			ReadAndWrite(list);

			// covariance: assigning cats to ienumerable of base type
			IEnumerable<Animal> lstAnimals = cats;

			// contravariance: assigning base type action to derived type action
			Action<Animal> actAnimal = (animal) => { animal.Feed(); };
			Action<Cat> actCat = actAnimal;
		}

	}

}