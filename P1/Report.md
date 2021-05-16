# Royal Game of Ur 

#### Miguel Feliciano a22002782

## Authorship

All code in this project was made by Miguel Feliciano. 

## Code Arquitecture

I organized this project in a way that you started coding the "foundation" and then expanded to the more technical aspects. 

I started by creating the board and the special spaces that exist in this board. To represent them I used ASCII characters to give the board the look I wanted. I created 2 arrays, one for the normal spaces and one for the special spaces. It will create the spaces 3 at a time and turns off the unnecessary squares.

For the dice i decided to have it choose 1 out of 4 random characters that represent each corner of a pyramid. for the top corner i decided to use a diamond (as if you where looking directly for above) and the left, right and up arrows for the other 3.

For the pieces, I was able to represent them on the board, make them move by changing their index and rolling again if they landed on a special tile. Unfortunately I was not able to make those changes appear on the board.

As for the rest of the game, I was unable to finish it due to various constraints. From doing it alone, time management and lack of knowledge this was the best I could do:

Here is the UML Diagram of my project:

![](../UML.png)
