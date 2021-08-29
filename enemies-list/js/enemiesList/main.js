console.log("My Enemies List!");
console.log("________________");

const enemies = [
  {
    firstName: "Joshua",
    lastName: "Flowers",
    isReallyHated: true,
    offenses: [
      "Being a jerk to me in elementary school",
      "Not being nice to me in elementary school",
    ],
  },
  {
    firstName: "Darth",
    lastName: "Vader",
    isReallyHated: false,
    offenses: [
      "Cut off Luke's hand",
      "Murdered all those kids",
      "Unkind management practices",
    ],
  },
  {
    firstName: "Betty",
    lastName: "Rudelady",
    offenses: [
      "Phone calls in the theater",
      "Phone calls on the bus",
      "Phone calls in line at the grocery store",
      "Poor conversationalist",
    ],
    isReallyHated: true,
  },

  {
    firstName: "Leon",
    lastName: "Peck",
    offenses: ["Keeps giving me a hotplate"],
    isReallyHated: false,
  },
];

const getEnemies = () => {
  for (enemy of enemies) {
    if (enemy.isReallyHated) {
      debugger
console.log(`${enemy.firstName} ${enemy.lastName} (Really, really dislike!)` );
    } else {
      console.log(`${enemy.firstName} ${enemy.lastName}`);
    }
  }
};

getEnemies();
