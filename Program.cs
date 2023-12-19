// See https://aka.ms/new-console-template for more information
using System;
using System.Text;

namespace Test {

    class Car {

        String model;
        public static int number;
        public Car(String model) {
            this.model = model;
            number++;
        }
    }

    class First {
        static void Main(string[] arg) {

            //under this a,b,c is the object inside the First (meaning they are explaining the class First)
            int a = 20;
            int b = 10;
            int c = a * b;
            System.Console.WriteLine(c);
            System.Console.WriteLine(Calculation(c,a));
            Car car1 = new Car("one");
            Car car2 = new Car("two");
            System.Console.WriteLine(Car.number);
        }

        // when static, it means it belongs to the class itself, not on the specific object
        static int Calculation(int num1, int num2) {

            return num1 * num2; 
            
        }

    }

}

