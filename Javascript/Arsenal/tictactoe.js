let playGround = [
    ['-', '-', '-'],
    ['-', '-', '-'],
    ['-', '-', '-']
]
let gameOver = false;
let currMove = 'x';
let zeroBased = prompt('Are you using zero based indexing for coordinates', 'yes/no');
if(zeroBased !== 'yes' && zeroBased !== 'no') gameOver = true;
//program start
while (!gameOver) {
    currMove = currMove === 'x' ? currMove = 'o' : 'x';
    let isValid = false;
    playGround.forEach(row => console.log(row));
    let x = null, y = null;
    while (!isValid) {
        x = prompt('Enter the value of row to place the move');
        y = prompt('Enter the value of column to place the move');
        if(!x || !y) {
            gameOver = true;
            break;
        }
        if(zeroBased === 'no'){
            x = +x - 1, y = +y - 1;
        }else {
            x = +x, y = +y;
        }
        if((x <= 3) && (y <= 3) && playGround[x][y] === '-'){
            playGround[x][y] = currMove;
            isValid = true;
        }else {
            alert('Enter a valid move');
        }
    }
    if(!gameOver){
        let winner = checkWinner(x, y);
        if(winner) {
            console.log(`The winner is ${winner}`); gameOver = true;
            playGround.forEach(row => console.log(row));
        }
    }
}
function checkWinner(x, y){
  let potentialWinner = playGround[x][y];
  let checkWin = (
  playGround[x].every(a => a === potentialWinner) || 
  playGround.every(a => a[y] === potentialWinner) || 
  playGround.every((a, i) => a[i] === potentialWinner) || 
  playGround.every((a, i) => a[2 - i] === potentialWinner));
  if(checkWin) return potentialWinner;
}