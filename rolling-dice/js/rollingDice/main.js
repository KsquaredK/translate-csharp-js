console.log("Let's roll some dice, baby!");
console.log("---------------------------");

const rollDice = () => {  
  
  for (let i = 0; i < 10; i++) {
    const die1 = getRandomInt(1, 6);
    const die2 = getRandomInt(1, 6);
    
    const message = (`${die1} + ${die2} == ${die1 + die2}`);
    
    if (die1 == die2){
      console.log(message + " DOUBLES!")
    } else
    { console.log(message)
    }
  }
}

// random num between 1-6\
function getRandomInt(min, max) {
  min = Math.ceil(min);
  max = Math.floor(max);
  return Math.floor(Math.random() * (max - min + 1)) + min;
}

rollDice();
