int[] numbers = { 38, 27, 43, 3, 9, 82, 10 };

Console.WriteLine("Vorher: " + string.Join(", ", numbers));
MergeSort(numbers, 0, numbers.Length - 1);
Console.WriteLine("Nachher:  " + string.Join(", ", numbers));

static void MergeSort(int[] arr, int left, int right)
{
    if (left >= right) return;

    int mid = (left + right) / 2;
    MergeSort(arr, left, mid);
    MergeSort(arr, mid + 1, right);
    Merge(arr, left, mid, right);
}

static void Merge(int[] arr, int left, int mid, int right)
{
    int[] leftHalf  = arr[left..(mid + 1)];
    int[] rightHalf = arr[(mid + 1)..(right + 1)];

    int i = 0, j = 0, k = left;
    while (i < leftHalf.Length && j < rightHalf.Length)
        arr[k++] = leftHalf[i] <= rightHalf[j] ? leftHalf[i++] : rightHalf[j++];

    while (i < leftHalf.Length)  arr[k++] = leftHalf[i++];
    while (j < rightHalf.Length) arr[k++] = rightHalf[j++];
}
