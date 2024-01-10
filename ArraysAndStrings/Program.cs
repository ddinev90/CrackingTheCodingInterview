// See https://aka.ms/new-console-template for more information

using ArraysAndStrings;


RotateMatrix matrix = new RotateMatrix();

int[][] toRotate = new int[3][];
toRotate[0] = new int[3] {1, 2, 3};
toRotate[1] = new int[3] {4, 5, 6};
toRotate[2] = new int [3] {7, 8, 9};


matrix.Rotate(toRotate);
Console.WriteLine("Hello, World!");
