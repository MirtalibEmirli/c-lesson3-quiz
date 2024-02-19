
using System;








int select = 1;
int point = 0;
int count = 0;
int say = 0;
var next = true;
string[,] suals =
{
    { "Seatlette Harada yerlsir ?  ",                        "A)Qubada"   ,"B)Amerika" ,    "C)Fransa", "A)Qubada"},
    { "Dunyanin en tehlukeli olkesi haradir ?  ",            "A)Sinqapur" ,"B)Timor" ,       "C)Suriya", "B)Timor"},
    { "Dunyanin en bahali seheri haradir? ",                 "A)Zürih" ,   "B)Los Angeles" ,    "C)New -York", "A)Zürih"},
    { "Dunyada ordusu olmadan Natoya qatilan olke ?",        "A)CEX" ,    "B)Izlanda" ,        "C)Kipr", "B)Izlanda"},
    { "Hansi olkede 2 il mektebden sonra esgerlik var? ",    "A)Kuba" ,   "B)Isvecre" ,        "C)Israil", "C)Israil"},
    { "Japonya'nın başkenti nedir?  ",                       "A)Baku " ,    "B)Tokyo" ,          "C)Moscow",  "B)Tokyo"},
    { "İtalya'nın en yüksek dağı hangisidir? ",             "A)Monte Bianco" ,   "B)Alps" , "C)Himalays", "A)Monte Bianco"},
    { "Kanada'nın en kalabalık şehri hangisidir? ",          "A)Ottava" ,"B)Vancouver" ,       "C)Toronto", "C)Toronto"},
    { "Almanya'nın en büyük şehri hangisidir? ",             "A)Berlin" ,"B)Hamburg" ,         "C)Bremenn", "A)Berlin"},
    { "üney Afrika'nın başkenti hangi şehirdir? ",           "A)Pretoria" ,"B)Bingi" ,         "C)Doha", "A)Pretoria"} 
};


Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine(@"
Oyunda sehv cavab verende 
novbeti suala kecd olmr mutleq duz cavab ver
Her duz sual 15 xal ile
Her sehv sual -10 xal ile
deyerlenderilir !!!
Ugurlarr!


");
Console.ForegroundColor = ConsoleColor.White;


Thread.Sleep(5000);


while (count < 10)
{
    Console.Clear();
   

    
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(@"
                    ~~~~~~~~~QUIZ~~~~~~~~~~");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine(@$"
                                            Point => {point}");
    Console.ForegroundColor = ConsoleColor.White;
    Console.ForegroundColor = ConsoleColor.Magenta;

    Console.WriteLine(suals[say, 0]);
    Console.ForegroundColor = ConsoleColor.White;



    if (select == 1)
    {

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(suals[say, 1]);
        Console.ForegroundColor = ConsoleColor.White;

        Console.WriteLine(suals[say, 2]);
        Console.WriteLine(suals[say, 3]);

    }
    else if (select == 2)
    {

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(suals[say, 2]);
        Console.ForegroundColor = ConsoleColor.White;

        Console.WriteLine(suals[say, 1]);
        Console.WriteLine(suals[say, 3]);

    }
    else if (select == 3)
    {

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(suals[say, 3]);
        Console.ForegroundColor = ConsoleColor.White;

        Console.WriteLine(suals[say, 1]);
        Console.WriteLine(suals[say, 2]);
    }

    ConsoleKeyInfo key = Console.ReadKey();



    if (key.Key == ConsoleKey.UpArrow)
    {
        if (select == 1) select = 3;
        else select -= 1;

    }

    else if (key.Key == ConsoleKey.DownArrow)
    {
        if (select == 3) select = 1;
        else select += 1;
    }





    if (key.Key == ConsoleKey.Enter)
    {

        if (suals[say, select] == suals[say, 4])
        {
            say++;
            count++;
            point += 10;
        }

        else
        {
            point -= 10;
        }


    }
}
                                                            

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine(@$"
                Game finished
                Your point is {point}"); 


    Console.ForegroundColor = ConsoleColor.White;


//rectangle array
/*
int[,] arr = new int[5, 5];

arr[0,1] = Random.Shared.Next(0, 255);

for (int i = 0; i <5; i++)
{
	for (int j = 0; j <5; j++)
	{
		arr[i,j]= Random.Shared.Next(0, 255);
        Console.WriteLine(arr[i, j]);
    }
    Console.WriteLine();
}
*/
/*Random random = new Random();


for (int i = 0; i < 10; i++)
{
    Console.WriteLine(random.Next(0,3));
}*/


//jagged array
/*int[][] jj= new int[6][];

jj[0]=new int[6] { 5, 4, 6, 8, 9 ,10};
jj[1]=new int[8] { 8,9,5, 4, 6, 8, 9 ,10};
jj[2]=new int[9] { 1,22,33,5, 4, 6, 8, 9 ,10};
jj[3]=new int[14] {1,33,543,345,65,234,765,345, 5, 4, 6, 8, 9 ,10};

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 6; j++)
    {
        Console.Write(jj[i][j]); 
    }
    Console.WriteLine();
}*/
/*
string name = "aaa";
Console.WriteLine(name.IndexOf("b")); //olmayan index -1 olur*/

//MUitable => deyisken demekdir , bu stringbuilder dir
//ImMuitable => deyisken demekdir , bu string dir