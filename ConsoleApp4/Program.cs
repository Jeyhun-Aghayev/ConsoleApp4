//#1.  1 ilə 25 arasında kök altısı olan ədədləri tapın.

//float i = 1;
//float j = 1;
//for ( i = 1; i <= 25; i++) 
//{
//    for (j = 1; j <= 5; j++) 
//    {
//        if (i / j == j)
//        {
//            Console.WriteLine(i + " ededinin kokaltisi " + j + " ededidir");
//        }
//    }
//}

// ==========================================================================================
//#2. Arraydaki yalnız tək ədədlərin cəmini çap edən alqoritm qurun.


//int[] arr = {1 , 5, 67, 43 , 2, 89, 88 };
//int cem = 0;
//for  (int i = 0; i < arr.Length; i++)
//{
//    if (i % 2 == 0)
//    {
//        Console.WriteLine(i + "  ededi cwt ededdir");
//    }
//    else
//    {
//        Console.WriteLine(i + "  ededi tek ededdir");
//        cem += i;
//    }

//}
//Console.WriteLine("tek ededlerin cemi = " + cem);



// ==========================================================================================
//# 3. Verilmiş massivin tək indeksində duran elementlərin cəmini tapan alqoritm yazın.
//Nəticəni konsola çıxarın. Məs. {1, 2, 1, 4, 3} => 6

//int[] arr = { 1, 5, 67, 43, 2, 89, 88 };
//int cem = 0;
//for (int i = 1; i < arr.Length; i+=2)
//{
//    Console.Write(arr[i] + " + ");
//    cem += arr[i];

//}
//Console.WriteLine("= " + cem);


// ==========================================================================================
//#4.Verilmiş sozun polindrom olub olmadigini göstərən alqoritm yazın
//(məs: "ata" sondan və baslanğıcdan eyni oxunur cavab true cixacaq)
Console.WriteLine("Sozu daxil edin");
string w = Console.ReadLine();
string revers;
char[] right = w.ToCharArray();
Array.Reverse(right);
revers = new string(right);
if (w == revers)
{
    Console.WriteLine(w + " sozu polindromdur");
}
else
{
    Console.WriteLine(w + " sozu polindrom deyil");
}