Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 100){
    Console.WriteLine("Нет третьей цифры");
}
else{
    Console.WriteLine(n % 1000 / 100);
}