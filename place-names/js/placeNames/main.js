const names = [
  "Nashville",
  "Hong Kong",
  "The back yard",
  "Earth",
  "London",
  "The mall",
  "Ryman Auditorium",
  "The Great Wall of China",
];

console.log("All place names:");

for (const name of names) {
  console.log(name);
}

const theNames = names.filter((name) => name.includes("The"));

for (const name of theNames) {
  console.log(name);
}
