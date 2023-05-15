int med = 0;
int[] numbers = new int[] { 89, 42, 65, 18, 73, 15, 6, 89, 71, 17, 11, 51, 55, 99 };
Array.Sort(numbers); //sorts the list number in ascending order
int COUNT = numbers.Count(); //counts the list
int MEAN = (int)Queryable.Average(numbers.AsQueryable()); //calculates the mean of the list
int size = numbers.Length; //takes the length if the list
int mid = size / 2; //divides the length by 2
int MEDIAN = numbers[mid - 1]; //takes the 7th number from the list
Console.WriteLine("The median is " + MEDIAN);
Console.WriteLine("The count is "+ COUNT);
Console.WriteLine("The mean is "+ MEAN);

Dictionary<int, int> counts = new Dictionary<int, int>(); //creates a new dictionary
foreach (int a in numbers)
{
    if (counts.ContainsKey(a)) //if the dictionary contains the key
        counts[a] = counts[a] + 1; //increments the counts
    else
        counts[a] = 1;
}

int MODE = int.MinValue;
int max = int.MinValue;
foreach (int key in counts.Keys) //for each key in the keys of the dictionary
{
    if (counts[key] > max) //if the key of the dictionary is greater than maxs
    {
        max = counts[key]; //sets max as the key
        MODE = key;
    }
}

Console.WriteLine("The mode is: " + MODE);

