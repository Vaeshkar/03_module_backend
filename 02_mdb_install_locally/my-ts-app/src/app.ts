import { pickRandom } from "#utils";

/* const message = "Hello from TypeScript!";
console.log(message);
 */

console.log(pickRandom([1, 2, 3, 4, 5]));
console.log(pickRandom(["apple", "orange", "banana"]));
console.log(pickRandom([]));
console.log(pickRandom([true, false, true]));
console.log(pickRandom(["red", "green", "blue", "yellow"]));
console.log(pickRandom([null, undefined, 42]));
console.log(pickRandom(["a", "b", "c", "d", "e", "f", "g", "h", "i", "j"]));
