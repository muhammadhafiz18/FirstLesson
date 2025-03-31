// int Add( int a,  int b)
// {
//     Console.WriteLine("Add'ga kirdi");
//     return a + b;
// }
// int Ayirish( int a,  int b) 
// {
//     Console.WriteLine("Ayirish'ga kirdi");
//     return a - b;
// }
// double AddDouble( double a,  double b)
//     => a + b;

// double AyirishDouble( double a,  double b)
//     => a - b;
// QoshishAmallari<int> qoshish = Ayirish;
// QoshishAmallari<double> qoshishDouble = AddDouble;
// // qoshish += ( a,  b) => a * b;
// // qoshish += Ayirish;
// qoshish -= Ayirish;
// qoshishDouble += AyirishDouble;
// // qoshish = (a, b) => a / b;
// int a = 2;
// int b = 3;
// Console.WriteLine(qoshish( a,  b));


// // Console.WriteLine(2 / 3);



// // string name = "Mushtariy";

// // name = "bonu";

// // Console.WriteLine(name);









// Operation<int> qoshish = Add;

// qoshish(5, 10);

// int Add(int a, int b)
//     => a + b;
delegate T Operation<T>(T a, T b);

// void Print(string message)
//     => Console.WriteLine(message);

// bool IsEven(int a)
//     => true ? a % 2 == 0 : false;

// Func<int, int, int> operation = Add;
// Action<string> operation2 = Print;
// Predicate<int> operation3 = IsEven;


// operation += (a, b) => a * b;

// Console.WriteLine(operation(2, 3));


// Declare a Func variable and assign a lambda expression to the
// variable. The method takes a string and converts it to uppercase.
Func<string, string> selector = str => str.ToUpper();

// Create an array of strings.
string[] words = { "orange", "apple", "Article", "elephant" };
// Query the array and select strings according to the selector method.
IEnumerable<String> aWords = words.Select(n => n.ToUpper());

// Output the results to the console.
foreach (String word in aWords)
    Console.WriteLine(word);

/*
This code example produces the following output:

ORANGE
APPLE
ARTICLE
ELEPHANT

*/
