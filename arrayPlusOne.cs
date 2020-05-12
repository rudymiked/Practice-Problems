using System;
using System.Collections;
using System.Collections.Generic;


public class Test
{
	public static void Main()
	{
		int[] num = {9,9,9,9};
		addOne(num);
	}
	
static void addOne(int[] arr) {
	int carry = 1; // for 9's
	int[] result = new int[arr.Length];

	for(int i = arr.Length-1; i>=0; --i) {
		int sum = arr[i] + carry;
		if(sum == 10) {
            carry = 1;
		}else {
            carry = 0;
            result[i] = sum % 10; // if the sum is 10, then = 0, else, the remainder
		}
	}

	if (carry == 1) {
		result = new int[arr.Length+1];
        result[0] = 1;
	}
	
	foreach(int i in result)
        Console.Write(i);
}


	
}
