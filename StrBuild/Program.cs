using System.Text;
string str = "123456789";
StringBuilder sb = new StringBuilder();
foreach(char nu in str){
    int num = (int)char.GetNumericValue(nu);
    if (num % 2 == 0) 
        {
            sb.Append(num + " ");
        }
}
Console.Write("Четные числа: " + sb);


