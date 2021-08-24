// PSEUDOCODE === INSULTER ===

// 1. create collection of strings (insults)// 1.5 write method that generates a random integer to use in logic
// 2. iterate collection using logic below which
// 3. generates a new List of random index numbers that correlate to
//      the insults array, and do not have duplicates
// 4. iterate through new list, and log the corresponding insult 

// LOGIC

using System;
// using System.Collections.Generic;

int Index = Indices[i];

for (int i = 0; Indices.length < 3; i++)
{
    Console.WriteLine(Insults[Index]);
}

string[] Insults =
    {
        "You look like what morning breath smells like.",
        "If you tried to give me cpr I would probably throw myself back under water",
        "I am not a fan of you",
        "You think you're so special...and you are. The fact of your existence is nearly impossible to believe",
        "I'd rather walk than be on the same plane as you",
        "If I were given a million dollars to hang out with you...I would, but then I'd have to spend half of it on therapy",
        "Do you have to be so...like that?"
        };


// generate random number between 0-1, per MSDN
// int InsultIndex = rnd.Next(Insults.Length);



// JS SOURCE CODE ==========================
// function main() {
//   const insults = [
// "You look like what morning breath smells like.",
// "If you tried to give me cpr I would probably throw myself back under water",
// "I am not a fan of you",
// "You think you're so special...and you are. The fact of your existence is nearly impossible to believe",
// "I'd rather walk than be on the same plane as you",
// "If I were given a million dollars to hang out with you...I would, but then I'd have to spend half of it on therapy",
// "Do you have to be so...like that?"
//   ];

//   // This code ensures we don't end up with duplicate insults
//   const indexes = [];
//   while (indexes.length < 3) {
//     const candidate = getRandomInt(0, insults.length - 1);
//     if (!indexes.includes(candidate)) {
//       indexes.push(candidate);
//     }
//   }

//   for (let i=0; i<indexes.length; i++) {
//     const index = indexes[i];
//     console.log(insults[index]);
//   }
// }

// // Remember getting a random integer in C# is different
// function getRandomInt(min, max) {
//   min = Math.ceil(min);
//   max = Math.floor(max);
//   return Math.floor(Math.random() * (max - min + 1)) + min;
// }

// main();