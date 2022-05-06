using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class FamilyTree
    {

        static void Main()
        {
            FamilyTree tree = new FamilyTree();
            tree.PrintFamilydetails("Gurupavan");
            Console.WriteLine("===================================================");
            tree.PrintFamilydetails("Malliswari");
            Console.ReadLine();
        }
        public void PrintFamilydetails(string name)
        {
            Child objchaild = new Child();
            objchaild.ChildName1 = name;
            Familydetails(objchaild);

        }

        public void Familydetails(Child obj)
        {
            string result = $"Surename :{obj.Surname} \n GrandFater :{obj.GrandParentName1} ,GrandMother :{obj.GrandParentName2} \n"
                + $" Father :{obj.ParentName1} ,Mother :{obj.ParentName2} \n Chaild :{obj.ChildName1} \n"
                + $"Location :{obj.Location} , City :{obj.City}";
            Console.WriteLine(result);

        }
    }


    public class GrandParent
    {

        public string GrandParentName1 { get; set; } = "Gopaiah";
        public string GrandParentName2 { get; set; } = "Aadhilaxmi";
        public string Location { get; set; } = "1-3-79,paloncha,Kothagudem,ts";

        public string Surname { get; set; } = "Nimmala";
        public string City { get; set; } = "Kothagudem";

        
    }

    public class Parent : GrandParent
    {
        public string ParentName1 { get; set; } = "Pullaiah";
        public string ParentName2 { get; set; } = "Durga";
    }

    public class Child : Parent
    {
        public string ChildName1 { get; set; }

    }
}