int day = new Random().Next(1,8);
System.Console.WriteLine(day);
if (day == 6 || day == 7){
    System.Console.WriteLine("Да");
}
else{
    System.Console.WriteLine("Нет");
}