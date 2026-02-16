//List<string> listA = new List<string>
//{
//    "Megh", "Amit", "Riya", "Neha"
//};

//List<string> listB = new List<string>
//{
//    "Riya", "Neha", "Arjun"
//};

//=================task 1====================

//var commonElements = listA.Intersect(listB);
//var commonElements

//================Task 2=========================
//var onlyInFirstList = listA.Except(listB);
//var onlyInFirstList

//================Task 3==========================

//var combinedUniqueList = listA
//    .Union(listB);
//var combinedUniqueList
//foreach (var name in combinedUniqueList)
//{
//    Console.WriteLine(name);
//}



// Intersect keyword is used to find the common element between two list.
// Except keyword is used to find element present in one list but missing in another .
// Union Keyword is used for merging two collection automatically and removes the duplicate.
// Deferred keyword is query executes only when iterated 
// Default equality was mattering at time of for string -> it co pares values
                     //                      for object -> it compares refrences unless it is overridden to the data.
