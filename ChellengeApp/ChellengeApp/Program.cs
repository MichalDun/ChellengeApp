int number = 65375;
string numberInString = number.ToString();
char[] letters = numberInString.ToArray();

List<string> digits = new List<string> { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

List<int> numberOfDigits = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

foreach (char letter in letters)
{
    for (int i = 0; i < 10; i++)
    {
        if (letter.Equals(digits[i][0]))
        {
            numberOfDigits[i] = numberOfDigits[i] + 1;
        }
    }
}
Console.WriteLine("W przypadku liczy " + number + ":");
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Cyfr " + digits[i] + " jest " + numberOfDigits[i]);
}