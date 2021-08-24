using System;
// Pseudocode - C#
// Main() that serves up content
// invoke Main()


// Collection of iterable strings (wishes)
string[] Wishes = { "An original eight track of William Shatner's 'Lucy in the Sky with Diamonds'",
"The ability to think of interesting wishes on short notice",
"A washtub of Skittles",
"World peace, but not the kind of world peace where all the humans are removed from existence",
"A TV that is NOT internet-capable",
"The ability to fly, but, like, really fast...not just, like, how fast I can walk, but, like, fast, you know?"
};

// Opening statement
Console.WriteLine("My wishes...");

// Logic (foreach?) wish of IWishFor to COnsole.Writeline each wish
foreach (string w in Wishes)
{
    Console.WriteLine(w);
}

// **************** original JS *************
// function main() {
//   const iWishFor = [
//     "An original eight track of William Shatner's 'Lucy in the Sky with Diamonds'",
//     "The ability to think of interesting wishes on short notice",
//     "A washtub of Skittles",
//     "World peace, but not the kind of world peace where all the humans are removed from existence",
//     "A TV that is NOT internet-capable",
//     "The ability to fly, but, like, really fast...not just, like, how fast I can walk, but, like, fast, you know?"
//   ];

//   console.log("My wishes...");
//   for (const wish of iWishFor) {
//     console.log(wish);
//   }
// }

// main();