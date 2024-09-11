using System; 

class URI {

    static void Main(string[] args) { 

    double n, r, A;
    
    n = 3.14159;
    r = Convert.ToDouble(Console.ReadLine());
    A = (r * r)* n;
    
     
     Console.WriteLine("A="+Math.Round(A, 4).ToString("F4"));


    }

}