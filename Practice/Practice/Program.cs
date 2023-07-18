//static void  ShowNumber(int n)
//{
//	if (IsDived(n))
//	{
//        Console.WriteLine("yes");
//    }
//    else 
//    { 
//        Console.WriteLine("no"); 
//    }
//}

//static  bool IsDived(int n) 
//{
//    if (n%3==0 && n%7==0)

//        return true;


//        return false;



//}

//ShowNumber(21);


//static void GetFullData(string name, string surname, int age, string adress = "Ehmedli")
//{
//    string result = $"Name: {name} , Surname: {surname} , Age: {age} , Adress: {adress}";
//    Console.WriteLine(result);
//}

//GetFullData("Sheref", "Tenzilli", 26);

//static void GetNumsOfArray(int  number, int num, params int[] arr)
//{
//    foreach (var item in arr)
//    {
//        Console.WriteLine(item);
//    }
//}

////item[]  numbers = {2, 3, 5, 6, 7);
//GetNumsOfArray(1, 2, 3, 4, 5);


//int a = 5;
//int b = a;
//b = 100;
//Console.WriteLine(a);
//Console.WriteLine(b);


//int[] arr1 = { 1, 2, 3, 5, 6 };

//Console.WriteLine(arr1[0]);

//int[] arr2 = arr1;
//arr2[0] = 100;

//Console.WriteLine(arr1[0]);
//Console.WriteLine(arr2[0]);


//int a = 8;

//Test(ref a);

//Console.WriteLine(a);

//static void Test(ref int a)
//{
//    a = 20;
//    Console.WriteLine(a);
//}


//int a;

//Test(out a);

//Console.WriteLine(a);

//static void Test(out int a)
//{
//    a = 20;
//    Console.WriteLine(a);
//}


//static void  GetFullName(string name, string surname)
//{
//    Console.WriteLine(name + " " + surname);
//}


//using Practice;

//Class1.Test("salam", 55);

//Class1.Search(55);


//using System.Text;

//StringBuilder stringBuilder = new StringBuilder("Salam");

//stringBuilder.Append("-Azerbaycan");

//Console.WriteLine(stringBuilder);


//string name = "Samir";

//Test(name);

//Console.WriteLine(name);


//static void Test(string name)
//{
//    name = "Xeyyam";
//    Console.WriteLine(name);
//}



//string name = "Pervin";

//Console.WriteLine(name.Length);
//Console.WriteLine(name.ToUpper());
//Console.WriteLine(name.ToLower());
//Console.WriteLine(name.Trim());

//Console.WriteLine("A".ToLower()=="a".ToLower());

//Console.WriteLine(name.Replace("e","a"));


//****   Herfleri yuxaridan ashagiya siralayir.


//for (int i = 0; i < name.Length; i++)
//{
//    Console.WriteLine(name[i]);
//}


//string name = "Per vin salam";

//var arr=name.Split("");
//foreach (var item in arr)
//{
//    Console.WriteLine(item);
//}  




//*****  2 stringi birleshdirme yolu:

//string str1 = "C# ";
//string str2 = "Programming";

//string result = string.Concat(str1, str2);
//Console.WriteLine("Joined string: " + result);




//*****   Beraberliyi yoxlayir



//string str1 = "C# ";
//string str2 = "Programming";

//bool IsEqual = str1.Equals(str2);

//Console.WriteLine(IsEqual);


// Substring kesir bir deyer verende  o saydan kesir
//Iki deyer veren  hemin say arasinda olanlari goturur gosterir


//string str1 = "C# ";
//string str2 = "Programming";

//Console.WriteLine(str1.Substring(0, 10) + "...");






//StringInfo icinde "s" var ya yox (True false)



//string suname = "Filankesov";

//Console.WriteLine(suname.Contains("s"));



//static  string Test (string text)
//{
//    jdsjdjakdjka
//        return text;
//}

//string result = Test("salam");

//Console.WriteLine(result);


//****Array-a gore



//string text = "salam";

//ReplaceSpecificCharFromStr(text, 1, 't');

//static void ReplaceSpecificCharFromStr(string str, int index, char replaceChar)
//{
//    var arr=str.ToCharArray();
//    arr[index] = replaceChar;
//    arr.ToString();

//    Console.WriteLine(arr);
//}





//static char[] ReplaceSpecificCharFromStr(string str, int index, char replaceChar)
//{
//    var arr = str.ToCharArray();
//    arr[index] = replaceChar;
//    arr.ToString();

//    return arr;
//}


//string text = "salam";

//var result = ReplaceSpecificCharFromStr(text, 1, 't');

//foreach (var item in result)
//{
//    Console.WriteL
//    ine(item);
//}



