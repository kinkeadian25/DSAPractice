using DSAPractice.GrokkingAlgorithms;

List<int> list = new() {2,4,6,16,8,10,12,1, 6, 2, 28, 11};

IEnumerable<int> answer = QuickSortRecursive.QuickSort(list);
foreach(int i in answer){
Console.WriteLine(i);
}
Console.ReadLine();