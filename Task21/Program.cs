/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

// int [] coordinate1 = new int [3];   // массив для А
// int [] A = {3,6,8};                 // присвоение массиву А координат
// int [] coordinate2 = new int [3];   // массив для В
// int [] B = {2,1,-7};                // присвоение массиву В координат
// double S = Math.Sqrt(((B[0]-A[0])*(B[0]-A[0]))+((B[1]-A[1])*(B[1]-A[1]))+((B[2]-A[2])*(B[2]-A[2]))); // вычисление рассторяния между А и В
// S = Math.Round(S,2);
// Console.WriteLine("Расстояние между точками А и В равно:{0}", S);

Console.WriteLine("Введите координаты для точки А: х=");
int Ax = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты для точки А: y=");
int Ay = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты для точки А: z=");
int Az = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты для точки B: х=");
int Bx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты для точки B: y=");
int By = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты для точки B: z=");
int Bz = Convert.ToInt32(Console.ReadLine());
double S = Math.Sqrt(((Bx-Ax)*(Bx-Ax))+((By-Ay)*(By-Ay))+((Bz-Az)*(Bz-Az)));
S = Math.Round(S,2);
Console.WriteLine("Расстояние между точками А и В равно:{0}", S);