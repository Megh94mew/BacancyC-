List<string> listA = new List<string>
{
    "Megh", "Amit", "Riya", "Neha"
};

List<string> listB = new List<string>
{
    "Riya", "Neha", "Arjun"
};

=================task 1====================

var commonElements = listA.Intersect(listB);
var commonElements

================Task 2=========================
var onlyInFirstList = listA.Except(listB);
var onlyInFirstList

================Task 3==========================

var combinedUniqueList = listA
    .Union(listB);
var combinedUniqueList
foreach (var name in combinedUniqueList)
{
    Console.WriteLine(name);
}
