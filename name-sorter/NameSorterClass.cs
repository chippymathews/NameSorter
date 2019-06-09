using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace name_sorter
{
    public class NameSorterClass
    {
        public string[] sortArrayString(string[] stringArray)
        {
            int outPut;
            var regex = new Regex(@"(?i)^[a-z.,\s]+$");
            List<Person> personlist = new List<Person>();
            foreach (string name in stringArray)
            {
                string firstname = string.Empty;
                string lastname = string.Empty;
                string middlename = string.Empty;
                Console.WriteLine(name);
                if (!string.IsNullOrEmpty(name) && !int.TryParse(name, out outPut) && regex.IsMatch(name))
                {
                    var arrNames = name.Trim().Split(' ');

                    if (arrNames.Length == 1)
                    {
                        if (!string.IsNullOrWhiteSpace(arrNames.FirstOrDefault()))
                        {
                            lastname = arrNames.FirstOrDefault();
                            //Console.WriteLine("lastname: " + lastname);
                        }
                    }
                    else if (arrNames.Length > 0)
                    {
                        if (!string.IsNullOrWhiteSpace(arrNames.FirstOrDefault()))
                        {
                            firstname = arrNames.FirstOrDefault();
                            //Console.WriteLine("firstname: " + firstname);
                        }
                    }
                    if (arrNames.Length > 1)
                    {
                        lastname = arrNames.LastOrDefault();
                        //Console.WriteLine("lastname: " + lastname);
                    }
                    if (arrNames.Length > 2)
                    {
                        middlename = string.Join(" ", arrNames, 1, arrNames.Length - 2);
                        //Console.WriteLine("middlename: " + middlename);
                    }
                    if (!string.IsNullOrEmpty(firstname) || !string.IsNullOrEmpty(middlename) || !string.IsNullOrEmpty(lastname))
                    {
                        Person p = new Person() { firstname = firstname, middlename = middlename, lastname = lastname, };
                        personlist.Add(p);
                    }
                }
            }
            personlist = personlist.OrderBy(p => p.lastname).ThenBy(p => p.middlename).ThenBy(p => p.firstname).ToList();
            List<string> names = new List<string>();
            foreach (Person p in personlist)
            {
                string fullname = string.Concat(p.firstname, " ", p.middlename, " ", p.lastname).Trim();
                names.Add(fullname);
            }

            string[] sortedStrArray = names.ToArray();
            return sortedStrArray;
        }
        public static void Main(string[] args)
        {
            //string path = args[0].ToString();
            string[] readText = File.ReadAllLines(@".\unsorted-names-list.txt");

            NameSorterClass sorter = new NameSorterClass();
            String[] sortedlist = sorter.sortArrayString(readText);
            Console.WriteLine("\nOUTPUT:\n");
            foreach (string str in sortedlist)
                Console.WriteLine(str);
            File.WriteAllLines(@".\sorted-names-list.txt", sortedlist, Encoding.UTF8);
            Console.ReadKey();
        }
        public class Person
        {
            public string firstname { get; set; }
            public string lastname { get; set; }
            public string middlename { get; set; }
        }
    }
}