using System;
using System.Reflection;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace LR3
{
    class Reflector
    {

        public static void MethodF(string className, String methodName)
        {

            try
            {
                object[] paramArray;
                Type type = Type.GetType(className);
                MethodInfo method = type.GetMethod(methodName);
                object classinstance = Activator.CreateInstance(type);
                paramArray = method.GetParameters();
          
           
                method.Invoke(classinstance,paramArray);
            }
            catch
            {
                Console.WriteLine("Исключение");
            }

        }


        
        public static void AllInfoInFile<T>(T obj) where T : class
        {
            Type thisType = typeof(T);
            MethodInfo[] MArr = thisType.GetMethods();
            PropertyInfo[] Parr = thisType.GetProperties();

            Console.WriteLine("Инфомация о классе {0} ", obj.ToString());
             
            Console.WriteLine("Свойства: ");

            foreach(var i in Parr)
            {
                Console.WriteLine(i.PropertyType + " " + i.Name);
            }

            Console.WriteLine("Методы с заданным параметром: ");

            
            foreach(var i in MArr)
            {
                
                if (i.ReturnType.ToString() == typeof(String).ToString() )
                {
                    Console.Write(i.ReturnType.Name + "  " + i.Name + "(");

                    ParameterInfo[] parametersArray = i.GetParameters();
                    for (int j = 0; j < parametersArray.Length; j++)
                    {
                        Console.Write(parametersArray[j].ParameterType.Name + " " + parametersArray[j].Name);
                        if (j + 1 < parametersArray.Length)
                            Console.Write(", ");
                    }

                    Console.Write(");");

                    Console.WriteLine();
                }
            }
            Console.WriteLine("-------------------------------");


            Console.WriteLine("Реализуемые интерфейсы");
            var im = thisType.GetInterfaces();
            foreach (Type tp in im)
                Console.WriteLine("--> " + tp.Name);
            
            Console.WriteLine("----------------------");

            FieldInfo[] FieldsName = thisType.GetFields();

            Console.WriteLine("Поля класса : ");
            foreach ( FieldInfo Names in FieldsName)
            {
                Console.WriteLine(Names.FieldType + " " + Names.Name + ";");
            }
            Console.WriteLine("--------------");


            Console.WriteLine("Методы: ");
            foreach (MethodInfo outer in MArr)
            {
                Console.Write(outer.ReturnType.Name + "  " + outer.Name + "(");

                ParameterInfo[] parametersArray = outer.GetParameters();
                for (int i = 0; i < parametersArray.Length; i++)
                {
                    Console.Write(parametersArray[i].ParameterType.Name + " " + parametersArray[i].Name);
                    if (i + 1 < parametersArray.Length)
                        Console.Write(", ");
                }

                Console.Write(");");

                Console.WriteLine();
            }
            Console.WriteLine("--------");

        }


    }
}

