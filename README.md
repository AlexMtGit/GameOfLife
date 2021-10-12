# Game Of Life
This application simulates the game of life created by John Horton Conway. The game is based on an orthogonal grid of square cells. Each cell can be alive or dead and its state depends on the 8 neighbouring cells around it. At each time step, the following interactions take place:

    1. Any live cell with fewer than two live neighbours dies, as if by underpopulation.
    
    2. Any live cell with two or three live neighbours lives on to the next generation.
    
    3. Any live cell with more than three live neighbours dies, as if by overpopulation.
    
    4. Any dead cell with exactly three live neighbours becomes a live cell, as if by reproduction.


This GIF shows how the app works:


![Game Of Life](https://user-images.githubusercontent.com/88795626/136992748-5696daac-ab44-4c61-91ba-a31e6f37f6c4.gif)


This project has been developed using C#, Visual Studio and Windows Form (NET .5) for the GUI. 
