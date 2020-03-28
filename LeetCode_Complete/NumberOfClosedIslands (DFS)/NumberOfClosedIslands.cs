public class Solution {
	
	// Uses DFS (Depth-First Search)
	// Run-Time: O(n*m) where n and m are the rows and columns respectively
		// Only traverse each cell once
	
    public int ClosedIsland(int[][] grid) {
        int rows = grid.Length;
        int columns = grid[0].Length;
        bool[,] traversed = new bool[rows,columns];
        List<Queue<string>> islands = new List<Queue<String>>(); // Stores all found islands
        for (int y=0; y<rows; y++) {
            for (int x=0; x<columns; x++) {
                Queue<string> currentIsland = new Queue<string>();
                bool isIsland = true;
				// Run recursive function
                Search(y, x, grid, ref traversed, ref currentIsland, ref isIsland);
                if (currentIsland.Count > 0 && isIsland) { // If island is valid
                    islands.Add(currentIsland); // add it to the list
                }
            }
        }
        return islands.Count;
    }
    
	// Summary:
		// Checks if cell is within bounds
			// If out of bounds, it is not an island
				// This applies to "land" cells located at the edge and all
				// "land" cells connected to it as well
		// Check if cell has already been traversed
			// If true, ignore the current cell
		// Check if cell is a "land" cell
			// If NOT, ignore current cell
			// Otherwise, add it to the currentIsland queue
		// If cell has passed all checks and been enqueued,
			// (Recursion) Call the same function on the 4 (Up, Right, Down, Left) adjacent cells
    public void Search(int row, int column, int[][] grid, ref bool[,] traversed, ref Queue<string> currentIsland, ref bool isIsland) {
        int rows = grid.Length;
        int columns = grid[0].Length;
        if (row >= rows || row < 0 || column >= columns || column < 0) { // Check bounds
            isIsland = false; // If land is at the edge of grid, it is NOT an island
            return;
        }
        if (traversed[row,column]) { // Check if already traversed
            return;
        }
        traversed[row,column] = true; // Mark as traversed
        if (grid[row][column] == 0) { // Check is land (== 0)
            string positionString = (row + "," + column);
            currentIsland.Enqueue(positionString);
        }
        else { // Else is water
            return;
        }
		// Traverse adjacent cells
        Search(row, column + 1, grid, ref traversed, ref currentIsland, ref isIsland);
        Search(row + 1, column, grid, ref traversed, ref currentIsland, ref isIsland);
        Search(row, column - 1, grid, ref traversed, ref currentIsland, ref isIsland);
        Search(row - 1, column, grid, ref traversed, ref currentIsland, ref isIsland);
    }
}