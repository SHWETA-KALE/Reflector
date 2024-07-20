using System;
using System.Reflection;

namespace Reflector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Assembly executing = Assembly.GetExecutingAssembly();

            Type[] types = executing.GetTypes();

            foreach (var item in types)
            {
                Console.WriteLine("Class : {0}", item.Name);

                // Count methods
                MethodInfo[] methods = item.GetMethods();
                int methodCount = methods.Length;
                Console.WriteLine("Method Count: {0}", methodCount);

                // Print methods and their parameters (if any)
                if (methodCount > 0)
                {
                    foreach (var method in methods)
                    {
                        // Count parameters
                        ParameterInfo[] parameters = method.GetParameters();
                        int parameterCount = parameters.Length;
                        Console.WriteLine("--> Method: {0}", method.Name);
                        Console.WriteLine("    Parameter Count: {0}", parameterCount);

                        // Print each parameter
                        foreach (var param in parameters)
                        {
                            Console.WriteLine("    Parameter: {0} - Type: {1}", param.Name, param.ParameterType);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("No methods.");
                }

                // Count constructors
                ConstructorInfo[] ctors = item.GetConstructors();
                int constructorCount = ctors.Length;
                Console.WriteLine("Constructor Count: {0}", constructorCount);

                // Print constructors and their parameters (if any)
                if (constructorCount > 0)
                {
                    foreach (var ctor in ctors)
                    {
                        // Count parameters
                        ParameterInfo[] parameters = ctor.GetParameters();
                        int parameterCount = parameters.Length;
                        Console.WriteLine("--> Constructor: {0}", ctor);
                        Console.WriteLine("    Parameter Count: {0}", parameterCount);

                        // Print each parameter
                        foreach (var param in parameters)
                        {
                            Console.WriteLine("    Parameter: {0} - Type: {1}", param.Name, param.ParameterType);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("No constructors.");
                }

                Console.WriteLine(); // Separate classes with an empty line
            }

            Account accountInstance = new Account();
            Program programInstance = new Program();
            ShowDetails(accountInstance, programInstance);
        }

        static void ShowDetails(object obj1, object obj2)
        {
            Type type1 = obj1.GetType();
            Type type2 = obj2.GetType();

            Console.WriteLine("Details for {0}:", type1.Name);
            Console.WriteLine("Full Name: {0}", type1.FullName);

            Console.WriteLine();

            Console.WriteLine("Details for {0}:", type2.Name);
            Console.WriteLine("Full Name: {0}", type2.FullName);
        }

    }
}


















