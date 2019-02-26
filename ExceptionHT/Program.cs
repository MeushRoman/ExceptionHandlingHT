using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHT
{
    class Program
    {
        static void Main(string[] args)
        {
            ExpMethod();
        }

        //1.	Перехватить исключение запроса к несуществующему веб ресурсу и вывести сообщение о том, что произошла ошибка. Программа должна завершиться без ошибок.
        static void WebExp(string link)
        {
            WebClient web = new WebClient();

            try
            {
                WebRequest request = WebRequest.Create(link);
                WebResponse response = request.GetResponse();
                Console.WriteLine("Ссылка доступна");
                response.Close();
            }
            catch (WebException ex)
            {
                Console.WriteLine(ex.Status);
            }
        }
        //2.	Написать программу, которая обращается к элементам массива по индексу и выходит за его пределы.После обработки исключения вывести в финальном блоке сообщение о завершении обработки массива.
        static void ArrayExp(int index)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            try
            {
                Console.WriteLine(arr[index]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //3.	Реализовать несколько методов или классов с методами и вызвать один метод из другого. В вызываемом методе сгенерировать исключение и «поднять» его в вызывающий метод.
        static void ExpMethod()
        {
            try
            {
                Method(7);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void Method(int index)
        {
            int[] a = { 1, 2, 3, 4 };
            if (index >= a.Length || index < 0)
            {
                throw new Exception("Индекс не может выходить за пределы массива");
            }
            else
            {
                Console.WriteLine(a[index]);
            }
        }
    }


}
