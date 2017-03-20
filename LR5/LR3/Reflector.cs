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

        public static void AllInfoInFile<T>(T obj) where T : class
        {
            Type thisType = typeof(T);
            MethodInfo[] MArr = thisType.GetMethods();
           

            Console.WriteLine("------- Информация о класск {0} записана в файл ---------", obj.ToString());
            

            FileStream file1 = new FileStream("e:\\ClassInfo.txt", FileMode.Create);
            StreamWriter _out = new StreamWriter(file1);


            Console.WriteLine("\n*** Реализуемые интерфейсы ***\n");
            var im = thisType.GetInterfaces();
            foreach (Type tp in im)
                Console.WriteLine("--> " + tp.Name);


            _out.Write("Test");
            _out.WriteLine("Инфомация о классе {0} ", obj.ToString());

            FieldInfo[] FieldsName = thisType.GetFields();
           
            foreach ( FieldInfo Names in FieldsName)
            {
                Console.WriteLine(Names.Name + Names.MemberType + Names.ReflectedType);
            }


            foreach (MethodInfo outer in MArr)
            {
                _out.WriteLine(outer.ReturnType.Name + "  " + outer.Name + "(");

                ParameterInfo[] parametersArray = outer.GetParameters();
                for (int i = 0; i < parametersArray.Length; i++)
                {
                    _out.WriteLine(parametersArray[i].ParameterType.Name + " " + parametersArray[i].Name);
                    if (i + 1 < parametersArray.Length)
                        _out.WriteLine(", ");
                }
                _out.WriteLine();
            }

            file1.Close();

        }


    }
}

