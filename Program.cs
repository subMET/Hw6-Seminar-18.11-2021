int[] CreateRandomArray(int N, int min, int max)
{
    int[] A = new int[N];
    for (int i = 0; i < N; i++)
    {
        A[i] = new Random().Next(min, max + 1);
    }
    return A;
}

void PrintArray(int[] A)
{
    int L = A.Length;
    for (int i = 0; i < L; i++)
    {
        Console.Write($"{A[i]} ");
    }
    System.Console.WriteLine();
}

// 33. Задать массив из 12 элементов, заполненных числами из [0,9]. 
// Найти сумму положительных/отрицательных элементов массива

// int[] SumOfSign(int[] A)
// {
//     int[] B = new int[2];
//     int L = A.Length;
//     for (int i = 0; i < L; i++)
//     {
//         if (A[i] < 0) { B[0] = B[0] + A[i]; }
//     }
//     for (int i = 0; i < L; i++)
//     {
//         if (A[i] > 0) { B[1] = B[1] + A[i]; }
//     }
//     return B;
// }

// bool TestSumOfSign() //test 33
// {
//     int[] A1 = { 8, 7, 0 };
//     int[] A2 = { -1, -2, 0, 873 };
//     int[] A3 = { 0, 0, 0 };
//     int[] B1 = { 0, 15 };
//     int[] B2 = { -3, 873 };
//     int[] B3 = { 0, 0 };
//     int[] C1 = SumOfSign(A1);
//     int[] C2 = SumOfSign(A2);
//     int[] C3 = SumOfSign(A3);
//     if (C1[0] == B1[0] & C1[1] == B1[1] & C2[0] == B2[0] & C2[1] == B2[1] & C3[0] == B3[0] & C3[1] == B3[1])
//     {return true;}
//     else {return false;}
// }

// int[] A = CreateRandomArray(12, 0, 9);
// PrintArray(A);
// int[] B = SumOfSign(A);
// PrintArray(B);
// if (TestSumOfSign()) {System.Console.WriteLine("Метод успешно прошёл тест.");}
// else {System.Console.WriteLine("Метод провалил тест.");}

// 34. Написать программу замену элементов массива на противоположные
// int[] TurnArray(int[] A)
// {
//     int L = A.Length;
//     int[] B = new int[L];
//     for (int i = 0; i < L; i++)
//     {
//         B[i] = A[L - i - 1];
//     }
//     return B;
// }

// bool TestTurnArray() //test 34
// {
//     int[] A1 = { 1, 2, 0, 3, 4, 8 };
//     int[] A2 = { -1, -2, 0, 873 };
//     int[] A3 = { 0, 0, 1 };
//     int[] B1 = { 8, 4, 3, 0, 2, 1 };
//     int[] B2 = { 873, 0, -2, -1 };
//     int[] B3 = { 1, 0, 0 };
//     int[] C1 = TurnArray(A1);
//     int L1 = C1.Length;
//     int[] C2 = TurnArray(A2);
//     int L2 = C2.Length;
//     int[] C3 = TurnArray(A3);
//     int L3 = C3.Length;
//     for (int i = 0; i < L1; i++)
//     {
//         if (C1[i] != B1[i]) {return false;}
//     }
//     for (int i = 0; i < L2; i++)
//     {
//         if (C2[i] != B2[i]) {return false;}
//     }
//     for (int i = 0; i < L3; i++)
//     {
//         if (C3[i] != B3[i]) {return false;}
//     }
//     return true;
// }

// int[] A = CreateRandomArray(11, 0, 10);
// int[] B = TurnArray(A);
// PrintArray(A);
// PrintArray(B);
// if (TestTurnArray()) {System.Console.WriteLine("Метод успешно прошёл тест.");}
// else {System.Console.WriteLine("Метод провалил тест.");}

// 35. Определить, присутствует ли в заданном массиве, некоторое число
// bool IsExistNumber(int[] A, int C)
// {
//     int L = A.Length;
//     bool flag = false;
//     for (int i = 0; i < L; i++)
//     {
//         if (A[i] == C) { flag = true; }
//     }
//     return flag;
// }

// bool TestIsExistNumber() //test 35
// {
//     int[] A1 = { 3, 1, 2 };
//     int[] A2 = { 6, 3, 3, 9, 3 };
//     int[] A3 = { -2, 1, 2, -2 };
//     bool B1 = false;
//     bool B2 = true;
//     bool B3 = true;
//     bool C1 = IsExistNumber(A1, 0);
//     bool C2 = IsExistNumber(A2, 3);
//     bool C3 = IsExistNumber(A3, -2);
//     if (B1 == C1 & B2 == C2 & B3 == C3) {return true;}
//     else {return false;}
// }

// int[] A = CreateRandomArray(10, 0, 10);
// PrintArray(A);
// System.Console.WriteLine(10);
// if (IsExistNumber(A, 10)) { System.Console.WriteLine("В массиве есть это число."); }
// else { System.Console.WriteLine("В массиве нет этого числа."); }
// if (TestIsExistNumber()) {System.Console.WriteLine("Метод успешно прошёл тест.");}
// else {System.Console.WriteLine("Метод провалил тест.");}

// 36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
// int[] NumberOfEvenAndNot(int[] A)
// {
//     int[] B = { 0, 0 };
//     int L = A.Length;
//     for (int i = 0; i < L; i++)
//     {
//         if (A[i] % 2 == 0) { B[0] = B[0] + 1; }
//         else { B[1] = B[1] + 1; }
//     }
//     return B;
// }

// bool TestNumberOfEvenAndNot() //test 36
// {
//     int[] A1 = { 3, 1, 2, 1, 1 };
//     int[] A2 = { 0, 0, -1, -2, 0 };
//     int[] A3 = { -2, 2, 2, -2, 2, 222, 4, 878 };
//     int[] B1 = { 1, 4 };
//     int[] B2 = { 4, 1 };
//     int[] B3 = { 8, 0 };
//     int[] C1 = NumberOfEvenAndNot(A1);
//     int[] C2 = NumberOfEvenAndNot(A2);
//     int[] C3 = NumberOfEvenAndNot(A3);
//     if (C1[0] == B1[0] & C1[1] == B1[1] & C2[0] == B2[0] & C2[1] == B2[1] & C3[0] == B3[0] & C3[1] == B3[1])
//     {return true;}
//     else {return false;}
// }

// int[] A = CreateRandomArray(10, 100, 999);
// int[] B = NumberOfEvenAndNot(A);
// PrintArray(A);
// PrintArray(B);
// if (TestNumberOfEvenAndNot()) {System.Console.WriteLine("Метод успешно прошёл тест.");}
// else {System.Console.WriteLine("Метод провалил тест.");}

// 37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
// int NumberOfElements(int[] A, int min, int max)
// {
//     int L = A.Length;
//     int Count = 0;
//     for (int i = 0; i < L; i++)
//     {
//         if (A[i] <= max & A[i] >= min) { Count++; }
//     }
//     return Count;
// }

// bool TestNumberOfElements()
// {
//     int[] A1 = { 3, 1, 2, 1, 1, 1, 0, 4, 3 };
//     int[] A2 = { 0, 0, -1, -2, 0 };
//     int[] A3 = { 1, 3, 2, 102, 4, 9 };
//     int B1 = 3;
//     int B2 = 2;
//     int B3 = 0;
//     int C1 = NumberOfElements(A1, 2, 3);
//     int C2 = NumberOfElements(A2, -100, -1);
//     int C3 = NumberOfElements(A3, 5, 8);
//     if (B1 == C1 & B2 == C2 & B3 == C3) {return true;}
//     else {return false;}
// }

// int[] A = CreateRandomArray(123, 0, 99);
// int C = NumberOfElements(A, 10, 99);
// PrintArray(A);
// Console.WriteLine(C);
// if (TestNumberOfElements()) {System.Console.WriteLine("Метод успешно прошёл тест.");}
// else {System.Console.WriteLine("Метод провалил тест.");}

// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции
// int SumOfNotEvenPos(int[] A)
// {
//     int Sum = 0;
//     int L = A.Length;
//     for (int i = 1; i < L;)
//     {
//         Sum = Sum + A[i];
//         i = i + 2;
//     }
//     return Sum;
// }

// bool TestSumOfNotEvenPos() //test 38
// {
//     int[] A1 = { 0, 1, 0, 1, 0, 1, 0, 1, 0 };
//     int[] A2 = { 0, 0, -1, -2, 0 };
//     int[] A3 = { 1, 3, 2, 102, 4, 9 };
//     int B1 = 4;
//     int B2 = -2;
//     int B3 = 114;
//     int C1 = SumOfNotEvenPos(A1);
//     int C2 = SumOfNotEvenPos(A2);
//     int C3 = SumOfNotEvenPos(A3);
//     if (B1 == C1 & B2 == C2 & B3 == C3) { return true; }
//     else { return false; }
// }

// int[] A = CreateRandomArray(10, 0, 10);
// int S = SumOfNotEvenPos(A);
// PrintArray(A);
// System.Console.WriteLine(S);
// if (TestSumOfNotEvenPos()) { System.Console.WriteLine("Метод успешно прошёл тест."); }
// else { System.Console.WriteLine("Метод провалил тест."); }

// 39. Найти произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// int[] ProductOfPairs(int[] A)
// {
//     int L = A.Length;
//     int L2 = L / 2;
//     if (L % 2 == 1) { L2++; }
//     int[] B = new int[L2];
//     for (int i = 0; i < L2; i++)
//     {
//         B[i] = A[i] * A[L - 1 - i];
//     }
//     return B;
// }

// bool TestProductOfPairs() //test 39
// {
//     int[] A1 = { 1, 1, 1, 1, 2, 2, 2, 2, 2 };
//     int[] A2 = { -2, -3, -1, 2, 0 };
//     int[] A3 = { 1, 3, 2, 102, 4, 9 };
//     int[] B1 = { 2, 2, 2, 2, 4 };
//     int[] B2 = { 0, -6, 1 };
//     int[] B3 = { 9, 12, 204};
//     int[] C1 = ProductOfPairs(A1);
//     int L1 = C1.Length;
//     int[] C2 = ProductOfPairs(A2);
//     int L2 = C2.Length;
//     int[] C3 = ProductOfPairs(A3);
//     int L3 = C3.Length;
//     for (int i = 0; i < L1; i++)
//     {
//         if (C1[i] != B1[i]) {return false;}
//     }
//     for (int i = 0; i < L2; i++)
//     {
//         if (C2[i] != B2[i]) {return false;}
//     }
//     for (int i = 0; i < L3; i++)
//     {
//         if (C3[i] != B3[i]) {return false;}
//     }
//     return true;
// }

// int[] A = CreateRandomArray(11, 0, 10);
// int[] B = ProductOfPairs(A);
// PrintArray(A);
// PrintArray(B);
// if (TestProductOfPairs()) { System.Console.WriteLine("Метод успешно прошёл тест."); }
// else { System.Console.WriteLine("Метод провалил тест."); }

// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
// int MaxDiffOfArray(int[] A)
// {
//     int L = A.Length;
//     int max = A[0];
//     int min = A[0];
//     for (int i = 1; i < L; i++)
//     {
//         if (A[i] > max) { max = A[i]; }
//         if (A[i] < min) { min = A[i]; }
//     }
//     int dif = max - min;
//     return dif;
// }

// bool TestMaxDiffOfArray() //test 40
// {
//     int[] A1 = { 0, 1, 2, 4, 3, 6, 8, 7, 10 };
//     int[] A2 = { 0, 0, -1, -2, 0 };
//     int[] A3 = { 1, 3, 2, 102, 4, 9 };
//     int B1 = 10;
//     int B2 = 2;
//     int B3 = 101;
//     int C1 = MaxDiffOfArray(A1);
//     int C2 = MaxDiffOfArray(A2);
//     int C3 = MaxDiffOfArray(A3);
//     if (B1 == C1 & B2 == C2 & B3 == C3) { return true; }
//     else { return false; }
// }

// int[] A = CreateRandomArray(10, -10, 10);
// int D = MaxDiffOfArray(A);
// PrintArray(A);
// System.Console.WriteLine(D);
// if (TestMaxDiffOfArray()) { System.Console.WriteLine("Метод успешно прошёл тест."); }
// else { System.Console.WriteLine("Метод провалил тест."); }