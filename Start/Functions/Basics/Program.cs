using System;

// Functions are used to group re-usable code together in a single
// unit that can be customized with parameters.

// TODO: Functions have a return type, name, and optional parameters

float MilesToKm(float miles) {
    return miles * 1.6f;
}

// TODO: A function with no return value has a 'void' type
void PrintWithPrefix(string str) {
    Console.WriteLine($"::> {str}");
}

// TODO: Call first function
Console.WriteLine(MilesToKm(1));

// TODO: Call second function
PrintWithPrefix("Test string");
