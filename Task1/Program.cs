int[] InputArray() {
    int[] array = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
    // for (int i = 0; i < array.Length; i++)
    //     array[i] = new Random().Next(-9, 10); // [-9, 9] 
    return array;
} 

bool ReleaseArray(int[] array) {
    bool canBe = 
        (array[0] < array[1] + array[2]) &&
        (array[1] < array[0] + array[2]) &&
        (array[2] < array[0] + array[1]);
    return canBe;
}

Console.Clear(); 
int[] array = InputArray(); 
Console.WriteLine($"{ReleaseArray(array)}"); 