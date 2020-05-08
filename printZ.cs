using System;
using System.Collections.Generic;

 class Z {
	public static void printZ(int[,] mat, int d) {

		// z => y = 0, x = i to d 
        // next numbers are (y+1, d-1), (y+2, d-2), etc.
        // when d = 0, z => y = d-1, x = i to d

		List<int> zShape = new List<int>();

for(int i = 0; i<d; ++i) {
			zShape.Add(mat[0,i]);
}
for(int i = 1; i<d; ++i) {
			zShape.Add(mat[i,d-i-1]);
}
for(int i = 0; i<d; ++i) {
			zShape.Add(mat[d-1,i]);
}

		foreach (int z in zShape) {
			Console.Write(z);
		}
		
}

// Driver code
public static void Main()
    {
        int[, ] mat = { { 4, 5, 6, 8 },
                        { 1, 2, 3, 1 },
                        { 7, 8, 9, 4 },
                        { 1, 8, 7, 5 } };
  
        printZ(mat, 4);
    }


}
