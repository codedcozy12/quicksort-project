// 1. write an algorithm to find all elements in an array that are greater than a given value
int[] ints = { 6, 7, 8, 9, 10 };
int target = 1;

int[] result = GreaterValue(ints, target);

if (result[0] != -1)
{
    Console.WriteLine("Numbers greater than " + target + " in the collection are:");
    foreach (int num in result)
    {
        Console.Write(num + " ");
    }
}
else
{
    Console.WriteLine("No numbers greater than " + target + " were found.");
}


int[] GreaterValue(int[] array, int target)
{
    List<int> result = new List<int>();
    foreach (int num in array)
    {
        if (num > target)
        {
            result.Add(num);
        }
    }
    if (result.Count == 0)
    {
        result.Add(-1);
        return result.ToArray();
    }
    return result.ToArray();
}

// 2a. write an algorithm to find a target value in a list of integer 
// b.  Return the count of times the target value appears in the list
// int[] myArray = { 2, 2, 4, 5, 6, 7 };
// int target = 4;

// if (TimeOfAppearance(myArray, target) != 0)
// {
//     Console.WriteLine($"Target: {target} appear {TimeOfAppearance(myArray, target)} time(s)");
// }
// else
//     Console.WriteLine(target + " not found");



// int TimeOfAppearance(int[] array, int target)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (target == array[i])
//         {
//             count++;
//         }
//     }
//     return count;
// }


// 3. Given a string (i) search for a character in the string (ii) sort the characters of the string in descending order

// 4. write an algorithm to find the second smallest element in a data set, modify the algorithm to be able 
//   to search for the third smallest, fourth smallest and any other smallest value you want to search for
// 5. implement quicksort using for loop and not recursion

int a = 10;
Console.WriteLine(a);