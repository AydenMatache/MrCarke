using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strut
{
    struct pokemon
    {
        public int id;
        public string _name;
        public string description;
        public string type;
    public int level;
    }
    struct student
    {
        public string name; 
        public string description;
        public int age;
        public decimal gpa;
        public string funny;

    }
    struct happy
    {


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            pokemon pika = new pokemon();
            pika._name = "pikachu";
            pika.level = 1;
            student MrCarke = new student();
            MrCarke.age = 52;
            MrCarke.gpa = 3.96m;
            MrCarke.name = "Mr.Carke";
            MrCarke.funny = "No Funny :(";
            MrCarke.description = "Mr. Carke, at 52 years old, is a seasoned software teacher known for his extensive experience in the field. While humor may not be his forte, his expertise and dedication to teaching software development make him a reliable and knowledgeable instructor. With a wealth of industry knowledge, Mr. Carke imparts valuable insights to his students, ensuring they gain a solid understanding of software concepts. Though humor might not be his tool of choice, his seriousness and focus on the subject matter contribute to a classroom environment where students can engage deeply with the material.";


        }
    }
}
