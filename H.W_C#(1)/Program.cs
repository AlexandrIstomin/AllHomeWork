Console.WriteLine("Введите число\n");
int n = Convert.ToInt32(Console.ReadLine());

void Numbers (int number, int res){
    if(res == 0){
        return;
    }
    Numbers(number, res - 1);
    Console.Write(number - res + 1 + " ");
}
Numbers(n, n);
