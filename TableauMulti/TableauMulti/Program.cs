// See https://aka.ms/new-console-template for more information

int[,] UnifTab = new int[3, 3]
{
    {1,2,3},
    {2,3,4},
    {3,4,5},
};

int[][] bidimensionalArray = new int[3][];

int taille_max = 3;
int elem = 0;
for (int i = 0; i < UnifTab.GetLength(0); i++)
{
    bidimensionalArray[i] = new int[taille_max];
    int index = 0;
    for (int j = elem; j < UnifTab.GetLength(0); j++)
    {

        Console.WriteLine("i"+i);
        Console.WriteLine("j"+j);
        Console.WriteLine(UnifTab[i, j]);
        bidimensionalArray[i][index] = UnifTab[i, j];
        index++;
    }
    taille_max -= 1;
    elem++;

}

for (int i = 0; i < bidimensionalArray.Length; i++)
{
    Console.Write("Element({0}): ", i + 1);
    for (int j = 0; j < bidimensionalArray[i].Length; j++)
    {
        Console.Write(bidimensionalArray[i][j] + "\t");
    }
    Console.WriteLine();
}
