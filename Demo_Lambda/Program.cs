using System;
using System.Collections.Generic;
using System.Linq;



namespace Demo_Lambda
{


    class Program
    {
        static void Main()
        {
            // khai báo Delegate
            Func<int, int, int> add = Add;
            int result = add(3, 5);
            Console.WriteLine("ket qua cong: " + result);

            static int Add(int x, int y)
            {
                return x + y;
            }



            // Sử dụng Lambda Expression trong Delegate
            Func<int, int, int> add1 = (x, y) => x + y;
            int result1 = add(3, 5);
            Console.WriteLine("ket qua cong: " + result1);


            //============================================//

            // Sắp xếp danh sách bằng Lambda Expression
            List<string> names = new List<string> { "Alicia", "Poppy", "Character", "Davince" };
            names.Sort((a, b) => a.CompareTo(b));
            Console.WriteLine("Danh sach sau sap xep");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            // Tạo danh sách mới từ danh sách cũ bình phương các số
            List<int> numbers1 = new List<int> { 1, 2, 3, 4, 5 };
            var squaredNumbers = numbers1.Select(x => x * x).ToList();
            Console.WriteLine("Danh sach binh phuong cac so trong list");
            foreach (var number in squaredNumbers)
            {
                Console.WriteLine(number);
            }

            //============================================


            List<int> numbers2 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //============================================


            // Sử dụng Standard Query Operators để lọc các số chẵn
            var evenNumbers = numbers2.Where(x => x % 2 == 0);
            Console.WriteLine("So chan trong danh sach: ");
            foreach (var number in evenNumbers)
            {
                Console.WriteLine(number);
            }


            //============================================
            // Sắp xếp danh sách theo thứ tự giảm dần
            var descendingOrder = numbers2.OrderByDescending(x => x).Take(3);
            Console.WriteLine("Danh sach giam dan:");
            foreach (var number in descendingOrder)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

        }
    }
}