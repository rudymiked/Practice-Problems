using System;
using System.Collections.Generic; // needed for List

public class Prob {

public static void Main () 
    { 
        int [,]mat = { { 1, 0, 1, 0 }, 
                       { 0, 1, 1, 1 }, 
                       { 1, 1, 0, 1 }, 
                       { 0, 1, 1, 1 }}; 
  
        int p = 2, q = 2; 
  
        Console.WriteLine(numMoves(mat, p, q)); 
    } 

static int numMoves(int [,]mat, int p, int q) {

    // deminsions of matrix 
    int x = mat.GetLength(0); // p = x pos
    int y = mat.GetLength(1); //q = y pos
    
    int sum = 0; // sum of possible moves
    List<int[]> posList = new List<int[]>();
    
      for(int i = 0; i<x; ++i)  {
        for(int j = 0; j<y; ++j) {
    	if (i != p && j != q) {
    		if (mat[i,j] == 0 ) {
    		    int[] curr = {i,j};
    			if (!posList.Contains(curr)) {
        			//possible kinight moves
        
        			//x moves 2 y moves 1
        			int t = p - 2;
        			int u = p + 2;
        			int v = q + 1;
        			int w = q - 1;
        			
        			// x moves 1 y moves 2
        			int a = p - 1;
        			int b = p + 1;
        			int c = q + 2;
        			int d = q - 2;
        
        			if (t == i && w == j) { // -2,-1
        				sum++;
        				posList.Add(curr);
        			}
        			if (t == i && v == j) { // -2, 1
        				sum++;
        				posList.Add(curr);
        			}
        			if (u == i && v == j) { // 2,1
        				sum++;
        				posList.Add(curr);
        			}
        			if (u == i && w == j) { // 2,-1
        				sum++;
        				posList.Add(curr);
        			}
        
        			if (a == i && c == j) { // 1,2
        				sum++;
        				posList.Add(curr);
        			}
        			if (a == i && d == j) { // 1,-2
        				sum++;
        				posList.Add(curr);
        			}
        			if (b == i && c == j) { // -1,2
        				sum++;
        				posList.Add(curr);
        			}
        			if (b == i && d == j) { // -1,-2
        				sum++;
        				posList.Add(curr);
        			}
                }
            }
      	}
    }
  }
  return sum;
}

}
