using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace App21_GenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Collection initialization syntax");
            //Collection initialization sytntax is applicable only to classes that 
            //implements Add() method, i.e. implements ICollection<T> interface


            //init a standard array
            int[] myArrayOfInts = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //init a generic list
            List<int> myGenericList = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //init a non-generic array list
            ArrayList myArrayList = new ArrayList { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //=========================================================
            //=====           Working with List<T>          ===========
            //=========================================================
            List<Employee> empList = new List<Employee>
            {
                new Employee("Lukasz",0,1500) { Nickname = "Lucyn" },
                new Employee("Marcin",1,2500),
                new Employee("Daniel",2,1250)
            };

            empList.Add(new Employee("Kazek", 3, 1000));

            foreach (Employee emp in empList)
            {
                Console.WriteLine("Next employee in the list: ");
                emp.DisplayStatus();
                Console.WriteLine("\n");
            }

            empList.Insert(0, new Employee("Adap", 5, 800));

            foreach (Employee emp in empList)
            {
                Console.WriteLine("Next employee in the list: ");
                emp.DisplayStatus();
                Console.WriteLine("\n");
            }

            //=========================================================
            //==========      Working with Stack<T>     ===============
            //=========================================================

            //Stack does not implement ICollection<T> interface,
            //thus we can't use collection initialization syntax
            Stack<Employee> empStack = new Stack<Employee>();

            empStack.Push(new Employee("Lukasz", 0, 1500) { Nickname = "Lucyn" });
            empStack.Push(new Employee("Marcin", 1, 2500));
            empStack.Push(new Employee("Daniel", 2, 1250));


            try
            {
                Console.WriteLine("Show me the peek: {0}", empStack.Peek());
                Console.WriteLine("Stack.Pop(): {0}", empStack.Pop());
                Console.WriteLine("Show me the peek: {0}", empStack.Peek());
                Console.WriteLine("Stack.Pop(): {0}", empStack.Pop());
                Console.WriteLine("Show me the peek: {0}", empStack.Peek());
                Console.WriteLine("Stack.Pop(): {0}", empStack.Pop());
                Console.WriteLine("Show me the peek: {0}", empStack.Peek());
                Console.WriteLine("Stack.Pop(): {0}", empStack.Pop());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message); //stack is empty
            }

            //=========================================================
            //==========      Working with Queue<T>     ===============
            //=========================================================

            Queue<Employee> empQueue = new Queue<Employee>();

            empQueue.Enqueue(new Employee("Lukasz", 0, 1500) { Nickname = "Lucyn" });
            empQueue.Enqueue(new Employee("Marcin", 1, 2500));
            empQueue.Enqueue(new Employee("Daniel", 2, 1250));

            while (empQueue.Count > 0)
            {

                Console.WriteLine(empQueue.Dequeue().ToString());
            }

            //=========================================================
            //==========      Working with SortedSet<T>   =============
            //=========================================================

            SortedSet<Employee> empSS = new SortedSet<Employee>(new EmployeeComparer())
            {
                new Employee("Lukasz",0,1500) { Nickname = "Lucyn" },
                new Employee("Marcin",1,2500),
                new Employee("Daniel",2,1250)
            };

            foreach (Employee emp in empSS)
                Console.WriteLine(emp.ToString());

            //=========================================================
            //=========      Working with Dictionary<T>   =============
            //=========================================================

            Dictionary<int, Employee> empDic = new Dictionary<int, Employee>
            {
                {0, new Employee("Lukasz",0,1500) { Nickname = "Lucyn" } },
                {1,  new Employee("Marcin",1,2500) },
                {3, new Employee("Daniel",3,1250) }
            };

            //RUNTIME EXCEPTION !! You can't add entry with existing key
            try
            {
                empDic.Add(3, new Employee("Kazek", 3, 1000));
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("It seems entry with that key already exists, here are details:");
                Console.WriteLine("Exception type: {0}", e.GetType().ToString());
                Console.WriteLine("Exception message: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception Catched!!!");
                Console.WriteLine("Exception type: {0}", e.GetType().ToString());
                Console.WriteLine("Exception message: " + e.Message);
            }

            Employee tempEmp = empDic[3];
            tempEmp.Pay += 200;

            Console.WriteLine("Daniel's salary is now: {0}", empDic[3].Pay);

            foreach (KeyValuePair<int, Employee> emp in empDic)
                Console.WriteLine("Key: {0}, Value: {1}", emp.Key, emp.Value);

            //Dictionary initialization
            Dictionary<string, Employee> empDic2 = new Dictionary<string, Employee>
            {
                ["Lucyn"] = new Employee("Lukasz", 0, 1500),
                ["Ptaku"] = new Employee("Marcin", 1, 2500),
                ["Danio"] = new Employee("Daniel", 3, 1250)
            };

            foreach (KeyValuePair<string, Employee> emp in empDic2)
                Console.WriteLine("Key: {0}, Value: {1}", emp.Key, emp.Value);

            //=========================================================
            //========= Working with SortedDictionary<T>   ============
            //=========================================================


            Console.ReadLine();
        }
    }
}
