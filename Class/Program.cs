
//static string ReverseStr(string str)
//{
//    string result = string.Empty;

//    for (int i = str.Length - 1; i >= 0; i--)
//    {
//        result += str[i];
//    }

//    return result;
//}

//Console.WriteLine(ReverseStr("Semed"));



//static string UpperStringFirstChar(string str)
//{
//    string name = char.ToUpper(str[0]) + str.Substring(1);

//    return name;
//}

//Console.WriteLine(UpperStringFirstChar("ali"));



//static string UpperStringFirstChar(string str)
//{
//    return char.ToUpper(str[0]) + str.Substring(1);

//}

//Console.WriteLine(UpperStringFirstChar("ali"));



//static string UpperStringFirstChar(string str) => char.ToUpper(str[0]) + str.Substring(1);

//Console.WriteLine(UpperStringFirstChar("ali"));



//static string FirstElementToUpper(string str)
//{
//    char[] charArray = str.ToCharArray();

//    string firstChar = charArray[0].ToString().ToUpper();

//    charArray[0] = Convert.ToChar(firstChar);

//    string result = string.Empty;

//    foreach (var item in charArray)
//    {
//        result += item;
//    }

//    return result;
//}

//Console.WriteLine(FirstElementToUpper("semed"));



//using System.Text;


//StringBuilder stringBuilder = new StringBuilder("Azer");

//stringBuilder.Append("baycan");

//Console.WriteLine(stringBuilder);



//int[] ages = { 12, 13, 55 };

//int[] ages2 = new int[5];

//int[] ints = new int[5] { 1, 2, 3, 4, 5 };




//int[] nums = { 1, 2, 3, 4, 5, 6 };

//Console.WriteLine(nums.Length);

//foreach (var item in nums)
//{
//    Console.WriteLine(item);
//}


//var result = nums.Sum(x => x);

//Console.WriteLine(result);

//var result = nums.Rank;

//Console.WriteLine(result);



//int[] nums = { 1, 2, 3, 4, 5, 6 };

//Array.Sort(nums);

//Array.Reverse(nums);

//var newArray = nums.Clone() as int[];



//int[] nums = { 1, 2, 3, 4, 5, 6 };

//int[] newArr = { 11, 14, 15 };

//int arrCount = newArr.Length;


//Array.Resize(ref newArr, nums.Length + newArr.Length);


//nums.CopyTo(newArr, arrCount);


//foreach (var item in newArr)
//{

//    Console.WriteLine(item);
//}



//static int[] CopyToArray(int[] destination, int[] source)
//{
//    int destinationLength = destination.Length;

//    Array.Resize(ref destination, source.Length + destination.Length);

//    source.CopyTo(destination, destinationLength);

//    return destination;

//}



//int[] arr1 = { 1, 4, 5, 6, 7 };

//int[] arr2 = { 5, 43, 23, 22, 3 };

//var result = CopyToArray(arr1, arr2);


//foreach (var item in result)

//{
//    Console.WriteLine(item);
//}




//int[] nums = { 1, 2, 3, 4, 5, 6, 1 };

//var result = Array.Exists(nums, x => x == 1);


//var result = Array.Find(nums, x => x == 1);

//var result = Array.FindAll(nums, x => x == 1);

//var result = Array.FindLast(nums, x => x == 1);

//var result = Array.FindIndex(nums, x => x == 1);



//Console.WriteLine(result);



//int[] nums = { 1, 2, 3, 4, 5, 6, 1 };

//var result = nums.OrderBy(m => m);

//var result = nums.OrderByDescending(m => m);


//foreach (var item in nums)

//{
//    Console.WriteLine(item);
//}



//int[] nums = { 1, 2, 3, 4, 5, 6, 1 };

//var result = nums.Contains(6);

//Console.WriteLine(result);

//var result = nums.Max();

//var result = nums.Min();

//Console.WriteLine(result);


//var result = nums.Where(x => x % 2 == 0).Sum(m => m);


//Console.WriteLine(result);


//var result = nums.Where(x => x % 2 == 0).ToArray();


//foreach (var item in nums)
//{
//    Console.WriteLine(item);
//}



//string name1 = "Tunzale";
//string surname1 = "Memmedova";
//string email1 = "tunzale@gmail.com";


//string name2 = "Arzu";
//string surname2 = "Kerimova";
//string email2 = "Arzu@gmail.com";


//string name3 = "Ilham";
//string surname3 = "Abasli";
//string email3 = "Ilham@gmail.com";



//var stu1 = new
//{
//    name = "Tunzale",
//    surname = "Memmedova",
//    mail = "tunzale@gmail.com"

//};



//var stu2 = new
//{
//    name = "Arzu",
//    surname = "Kerimova",
//    mail = "arzu@gmail.com"

//};



//var stu3 = new
//{
//    name = "Ilham",
//    surname = "Abasli",
//    mail = "ilham@gmail.com"

//};

//Console.WriteLine(stu3.name + " " + stu3.surname);



//ArrayAndClass.Student stu1 = new ArrayAndClass.Student();

//stu1.name = "Tofig";
//Console.WriteLine(stu1.name);




//ArrayAndClass.Student stu2 = new ArrayAndClass.Student();

//stu2.name = "Rufet";
//Console.WriteLine(stu2.name);


//ArrayAndClass.Student stu1 = new ArrayAndClass.Student();

//stu1.name = "Tofig";
//stu1.surname = "Nesibli";
//stu1.email = "tofig@gmail.com";
//stu1.age = 18;

////Console.WriteLine(stu1.name + " " + stu1.surname);


//ArrayAndClass.Student stu2 = new ArrayAndClass.Student();

//stu2.name = "Omer";
//stu2.surname = "Elesgerli";
//stu2.email = "omer@gmail.com";
//stu2.age = 15;

////Console.WriteLine(stu1.name + " " + stu1.surname);
////Console.WriteLine(stu2.name + " " + stu2.surname);

//stu1.GetFullName();
//stu1.GetFullData();
 
//stu2.GetFullName();
//stu2.GetFullData();



