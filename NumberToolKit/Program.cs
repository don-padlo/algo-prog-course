Console.WriteLine("Введите первое число:");
string g = Console.ReadLine();
while (check(g) == false){
    g = Console.ReadLine();
}
int G = int.Parse(g);

Console.WriteLine();

Console.WriteLine("Введите второе число:");
string h = Console.ReadLine();
while (check(h) == false){
    h = Console.ReadLine();
}
int H = int.Parse(h);

Console.WriteLine();

Console.WriteLine("Введите третье число:");
string j = Console.ReadLine();
while (check(j) == false){
    j = Console.ReadLine();
}
int J = int.Parse(j);

Console.WriteLine();

Console.WriteLine($"{G} простое {isPrime(H)}");
Console.WriteLine($"{H} простое {isPrime(H)}");
Console.WriteLine($"{J} простое {isPrime(J)}");

Console.WriteLine();

Console.WriteLine($"Максимум из трёх: {FindMax(G,H,J)}");
Console.WriteLine($"Максимум из первых двух: {FindMax(G,H,0)}");

Console.WriteLine();

Console.WriteLine($"Среднее арифметическое: {CalculateAverage(G,H,J)}");




bool isPrime(int number){
    bool cnt = false;
    for (int i = 2; i < number; i--) {
        if (number % 2 == 0) {
            continue;
        } else {
            cnt = true; break;
        }
    }
    return cnt;
}


int FindMax(int a,int b,int c){
    int m = a;
    if (m<b){
        m = b;
    }if(m<c){
        m = c;
    }
    return m;
}

double CalculateAverage(int d,int e,int f){
    return (double)(d+e+f)/3;
}

bool check (string chk){
    bool chk1 = int.TryParse(chk, out int CHK);
    if (chk1==true){
        return true;
    }else{
        Console.WriteLine("Попробуй ещё");return false;
    }
}

