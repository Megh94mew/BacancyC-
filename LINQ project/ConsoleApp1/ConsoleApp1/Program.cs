var list = new List<int> { 1, 2, 3 };
var query = list.Select(x => x * 2);
list.Add(4);
Console.WriteLine(query.Count());