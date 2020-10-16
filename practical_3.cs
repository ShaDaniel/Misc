// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text.RegularExpressions;
// namespace ConsoleApp3
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             var input = Console.ReadLine();
//             if (input == "")
//             {
//                 Console.WriteLine("No data");
//                 return;
//             }
//             var lines = input.Split(',');
//             var error = false;
//             var none = 0;
//             var first = 0;
//             var second = 0;
//             var third = 0;
//             var fourth = 0;
//             string errorMsg = String.Empty;
//             foreach (var line in lines)
//             {
//                 if (line == "First" || line == "1")
//                     first++;
//                 else if (line == "Second" || line == "2")
//                     second++;
//                 else if (line == "Third" || line == "3")
//                     third++;
//                 else if (line == "Fourth" || line == "4")
//                     fourth++;
//                 else if (line == "None" || line == "0")
//                     none++;
//                 else
//                 {
//                     if (!error)
//                     {
//                         error = true;
//                         errorMsg = $"\nErrors:\nNot valid input strings: {line}";
//                     }
//                     errorMsg += $",{line}";
//                 }
//             }
//             Console.WriteLine($@"Input data types:
//                                     None(0)-{none}
//                                     First(1)-{first}
//                                     Second(2)-{second}
//                                     Third(3)-{third}
//                                     Fourth(4)-{fourth}");
//             Console.WriteLine(errorMsg);
//         }
//     }
// }