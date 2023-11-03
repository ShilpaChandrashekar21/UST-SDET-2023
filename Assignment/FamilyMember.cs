using Assignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

/*Create a class named FamilyMember with the following properties:

Name(the name of the family member)
Age(the age of the family member)
Children(a list of child family members)

Implement a non-linear data structure to represent a family tree. Each FamilyMember can have a list of child family members.

Create a program that allows users to build a family tree by adding family members and specifying parent-child relationships.

Implement methods for displaying the family tree, including details of each family member and their children.*/

namespace Assignment
{
    
    internal class FamilyMember
    {
        public string? Name { get; set; }
        public int Age { get; set; }
    }
}
