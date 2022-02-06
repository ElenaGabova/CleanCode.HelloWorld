// See https://aka.ms/new-console-template for more information
List<string> stringList = new List<string>{
"Я хочу создавать что-то новое",
"Мне это интересно",
"Дружное комьюнити",
"Много возможностей для развития",
"Это развивает логику, и помогает принимать более правильные решения" };
string separator = "\n- ";
string output = string.Format("Я хочу стать программистом потому-что:\n{0}", separator) + 
                string.Join(separator, stringList);

Console.WriteLine(output);
Console.ReadLine();
