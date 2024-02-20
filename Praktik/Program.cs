//PRAKTIK



//string[] names = { "Hacixan", "Reshad", "Reshad", "Kamran", "Ilqar", "Fatime", "Afide", "Kamran", "Fexriyye" };

//Console.WriteLine(names[names.Length - 1]);
//Console.WriteLine(names[3]);

//for (int i = 0; i < names.Length; i++)
//{
//    Console.WriteLine(i);
//}

//for (int i = 0; i < names.Length; i++)
//{
//    Console.WriteLine(names[i]);
//}

//int[,] nums = { { 1, 2, 3 }, { 5, 6, 8 }, { 11, 22, 55 } };


//Console.WriteLine(nums.Rank);

//Console.WriteLine(nums[2, 2]);



//string[] names = { "Hacixan", "Reshad", "Reshad", "Kamran", "Ilqar", "Fatime", "Afide", "Kamran", "Fexriyye" };
//Console.WriteLine(names.Contains("Kamran"));

//var datas=names.Reverse().ToArray();

//Console.WriteLine(datas[datas.Length - 1]);


//Array.Sort(names);

//foreach (string item in names)
//{
//    Console.WriteLine(item);
//}

//int[] nums = { 3, 5, 7, 8 };

//Array.Sort(nums);

//foreach (int item in nums)
//{
//    Console.WriteLine(item);
//}



//int[] nums = { 3, 5, 7, 8 };

//Array.Sort(nums);

//var datas=nums.Reverse().ToArray();

//foreach (int item in datas)
//{
//    Console.WriteLine(item);
//}




//int[] arr1 = { 1, 2, 3 };

//int[] arr = {4, 5};

//arr1.CopyTo(arr1, 2);




//int[] arr = { 1, 2, 3 };
//Array.Resize(ref arr, 5);

//arr[3] =200;
//Console.WriteLine(arr[3]);




//int[] arr1 = { 1, 2, 3};

//int[] arr2 = { 4, 5 };

//Array.Resize(ref arr2, 5);


//arr1.CopyTo(arr2, 2);

//Array.Sort(arr2);

//foreach (int item in arr2)

//{
//    Console.WriteLine(item);
//}

//int[] arr1 = { 1, 2, 3 };

//Array.Resize(ref arr1, 1);




//string[] names = { "Hacixan", "Reshad", "Reshad", "Kamran", "Ilqar", "Fatime", "Afide", "Kamran", "Fexriyye" };
//var data = Array.Find(names, m => m == "Reshad");

//Console.WriteLine(data);


//string[] names = { "Hacixan", "Reshad", "Reshad", "Kamran", "Ilqar", "Fatime", "Afide", "Kamran", "Fexriyye" };

//var data = Array.FindAll(names, m => m == "Reshad");

//foreach (var item in data)
//{
//    Console.WriteLine(item);
//}

//string[] names = { "Hacixan", "Reshad", "Reshad", "Kamran", "Ilqar", "Fatime", "Afide", "Kamran", "Fexriyye" };


//var data = Array.FindIndex(names, m => m == "Reshad");

//Console.WriteLine(data);


//string[] names = { "Hacixan", "Reshad", "Reshad", "Kamran", "Ilqar", "Fatime", "Afide", "Kamran", "Fexriyye" };

//var data = names.LastOrDefault();

//Console.WriteLine(data);


//string[] names = { "Hacixan", "Reshad", "Reshad", "Kamran", "Ilqar", "Fatime", "Afide", "Kamran", "Fexriyye" };

//var data = names.FirstOrDefault(m=>m=="Kamran");

//Console.WriteLine(data);




//string[] names = { "Hacixan", "Reshad", "Reshad", "Kamran", "Ilqar", "Fatime", "Afide", "Kamran", "Fexriyye" };

//var data = names.Any(m => m == "Kamran");

//Console.WriteLine(data);


//string[] names = { "Hacixan", "Reshad", "Reshad", "Kamran", "Ilqar", "Fatime", "Afide", "Kamran", "Fexriyye" };

//var data = names.All(m => m == "Reshad");

//Console.WriteLine(data);




//string[] names = { "Hacixan", "Reshad", "Reshad", "Kamran", "Ilqar", "Fatime", "Afide", "Kamran", "Fexriyye" };

//var data = Array.Exists(names,m => m == "Kamran");

//Console.WriteLine(data);




//string[] names = { "Hacixan", "Reshad", "Reshad", "Kamran", "Ilqar", "Fatime", "Afide", "Kamran", "Fexriyye" };

//var data = names.Where(m => m == "Kamran").ToArray();

//foreach (var item in data)
//{
//    Console.WriteLine(item);
//}



//string[] names = { "Hacixan", "Reshad", "Reshad", "Kamran", "Ilqar", "Fatime", "Afide", "Kamran", "Fexriyye" };

//int count = 0;

//for(int i = 0; i < names.Length; i++)
//{
//    if (names[i] == "Reshad")
//    {
//        count++;
//    }

//}
//if (count == names.Length)
//{
//    Console.WriteLine(true);
//}
//else
//{
//    Console.WriteLine(false);
//}







//string[] names = {"Reshad", "Reshad", "Reshad"};

//int count = 0;

//for (int i = 0; i < names.Length; i++)
//{
//    if (names[i] == "Reshad")
//    {
//        count++;
//    }

//}
//if (count == names.Length)
//{
//    Console.WriteLine(true);
//}
//else
//{
//    Console.WriteLine(false);
//}






//string[] names = { "Reshad", "Reshad", "Reshad" };

//bool CheckAllDatas(string[] datas,string str)
//{


//    int count = 0;

//    for (int i = 0; i < names.Length; i++)
//    {
//        if (names[i] == str)
//        {
//            count++;
//        }

//    }
//    if (count == names.Length)
//    {
//        return true;
//    }
//    else
//    {
//        return false;
//    }
//}
//Console.WriteLine(CheckAllDatas(names,"Reshad"));




//DateTime data = DateTime.Now;

//Console.WriteLine(data);



//DateTime data = DateTime.Now.AddYears(10);

//Console.WriteLine(data);


//DateTime birthday = new DateTime(1997, 10, 27);
//Console.WriteLine(birthday);

//DateOnly data = new DateOnly(1997, 10, 27);
//Console.WriteLine(data);



//var date=DateTime.Now;
//Console.WriteLine(date);




//var date=DateTime.Now;

//Console.WriteLine(date.ToString("dddd,dd MMMMM yyyy"));



// var currentYear = DateTime.Now.Year;
//DateTime birthday = new DateTime(1997, 10, 27);

//var birthdayYear=birthday.Year;

//Console.WriteLine(currentYear-birthdayYear);










//2) Method yazirsiz, Method stringden ibaret array ve char qebul edir. 
//Method arrayin icerisinde gelen chardan ne qederdirse onlarin sayini geriye qaytarsin.


//void CheckAllData(string[] arr,char text)

//{

//    int count = 0;  
//    string result=string.Empty;
//    for(int i = 0; i < arr.Length; i++)
//    {

//        result =arr[i];
//        {
//            count++;
//        }

//    }
//    Console.WriteLine(count);
//}

//CheckAllData("hello",'e');



