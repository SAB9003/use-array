// See https://aka.ms/new-console-template for more information
Console.WriteLine("Input number!");
try {
    int number = int.Parse(Console.ReadLine());
    int new_day = (number  % 7) + 1;
    DayOfWeek dayofweek = (DayOfWeek)new_day;

    switch (dayofweek) {
        
        case DayOfWeek.Monday:
            Console.WriteLine($"Input parameter: {number} Expected output: Monday");
            break;
        case DayOfWeek.Tuesday:
            Console.WriteLine($"Input parameter: {number} Expected output: Tuesday");
            break;
        case DayOfWeek.Wednesday:
            Console.WriteLine($"Input parameter: {number} Expected output: Wednesday");
            break;
        case DayOfWeek.Thursday:
            Console.WriteLine($"Input parameter: {number} Expected output: Thursday");
            break;
        case DayOfWeek.Friday:
            Console.WriteLine($"Input parameter: {number} Expected output: Friday");
            break;
        case DayOfWeek.Saturday:
            Console.WriteLine($"Input parameter: {number} Expected output: Saturday");
            break;
        case DayOfWeek.Sunday:
            Console.WriteLine($"Input parameter: {number} Expected output: Sunday");
            break;
    }
}
catch
{
    Console.WriteLine("Error");
}
enum DayOfWeek
{
    Monday = 1,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday = 7
}