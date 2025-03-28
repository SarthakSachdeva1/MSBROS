
int BinarySearch(int[] array, int target)
{
    int left = 0;
    int right = array.Length - 1;

    while (left <= right)
    {
        int mid = left + (right - left) / 2;

        if (array[mid] == target)
            return mid;

        if (array[mid] < target)
            left = mid + 1;
        else
            right = mid - 1;
    }

    return -1; // Target not found
}

int[] array = { 2, 3, 4, 10, 40 };
Console.WriteLine("Array: " + string.Join(", ", array));

bool continueSearch = true;
while (continueSearch)
{
    Console.Write("Enter the target value: ");
    int target = int.Parse(Console.ReadLine());

    int result = BinarySearch(array, target);

    if (result == -1)
        Console.WriteLine("Element found at index " + result);
    else
        Console.WriteLine("Element not found in array");

    Console.Write("Do you want to search for another number? (yes/no): ");
    string response = Console.ReadLine().ToLower();
    continueSearch = response == "yes";
}

Console.WriteLine("Exiting the program.");
