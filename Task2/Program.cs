int[] InputArray() {
    int [] array = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray(); 
    return array;
} 

void ReleaseArray(int[] ar1, int[] ar2) {
    for (int i = 0; i < ar1.Length; i++) {
        ar2[i] = ar1[i];
    }
}

Console.Clear(); 
int[] a = InputArray();
int[] b = new int[a.Length];  
ReleaseArray(a, b);
Console.WriteLine($"{String.Join(", ", b)}"); 