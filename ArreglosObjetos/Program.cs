using System;

namespace ArreglosObjetos
{
    class Program
    {
        static void Main()
        {
            Chocolate[] chocolatesArr = new Chocolate[3];
            Chocolate carlosV = new Chocolate();
            carlosV.Nombre = "Carlos V";
            carlosV.Sabor = "Amargo";
            carlosV.Color = "Café";

            chocolatesArr[0] = carlosV;

            Chocolate Crunch = new Chocolate();
            Crunch.Nombre = "Crunch";
            Crunch.Sabor = "Leche";
            Crunch.Color = "Amarillo";
            chocolatesArr[1] = Crunch;

            Chocolate Kinder = new Chocolate();
            Kinder.Nombre = "Kinder";
            Kinder.Sabor = "Almendras";
            Kinder.Color = "Café";

            chocolatesArr[2] = Kinder;

            for (int i=0;i< chocolatesArr.Length; i++)
            {
                Console.WriteLine("Marca:{0}\n sabor: {1}\n color{2}\n ",chocolatesArr[i].Nombre,chocolatesArr[i].Sabor,chocolatesArr[i].Color);
                
            }
            Console.ReadLine();

            Console.WriteLine("¿A que sabor quieres cambiar el chocolate kinder?");
            chocolatesArr[2].Sabor = Console.ReadLine();

            Console.WriteLine("El nuevo sabor es "+ chocolatesArr[2].Sabor);
            Console.ReadLine();

            try
            {
                Console.WriteLine("Ingresa el precio del chocolate {0} ", chocolatesArr[0].Nombre);
                chocolatesArr[2].Precio = float.Parse(Console.ReadLine());
                if(chocolatesArr[2].Precio <= 0  )
                {
                    throw new ApplicationException("El precio no puede ser negativo");
                }

                Console.WriteLine("El precio es {0} ", chocolatesArr[0].Precio);
                
                Console.ReadLine();
            }
            catch(ApplicationException error)
            {
                Console.WriteLine(error);
            }

            catch(FormatException)
            {
                Console.WriteLine("No se ingresó un número");
            }
            catch(IndexOutOfRangeException error)
            {
                Console.WriteLine(error.Message);
            }
            catch(Exception error)
            {
                Console.WriteLine(error);
            }





        }
    }
}
