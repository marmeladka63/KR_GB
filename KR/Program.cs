

string[] Solve(string[] array)
{
    int len = array.Length;
    string[] result = new string[len];
    
    for (int i = 0; i < len; i++)
    {
        if (array[i].Length <= 3)
        {
            result[i] = array[i]; 
           
        }  
        

    } return result;
}


    string Print(string[] array)
    {

        string res = string.Empty;

        res = "[";
        for (int i = 0; i < array.Length; i++)
        {
            if (i != array.Length - 1)
            res += $" {array[i]}";



         else res += $" {array[i]}]";
         }
        return res;
       

    } 

System.Console.WriteLine("Введите данные массива через пробел ");

string[] array = System.Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

System.Console.WriteLine(Print(array));

string [] result =Solve(array);

System.Console.WriteLine(Print(result));










