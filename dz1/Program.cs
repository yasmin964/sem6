// Пользователь вводит с клавиатуры M чисел.
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
void InputNumbers(int m)
{int[] n = new int[m];
for (int i = 0; i < m; i++)
  {
    Console.Write($"Введи {i+1} число: ");
    n[i] = Convert.ToInt32(Console.ReadLine());
  }
}



int  GetCount(int [] n)
{
    int res =0;
    for (int i =0;i<n.Length;i++)
    {
        if (n[i]>0)res+=1;
      
        
    
        
        
    }return res;
}
Console.WriteLine($"Введите количество чисел массива  ");


int m = Convert.ToInt32(Console.ReadLine());

int[] n = new int[m];//если ошибка- имя "n" не существует в контексте


InputNumbers(m);
Console.WriteLine($"Введено чисел больше 0 :{GetCount(n)}  ");