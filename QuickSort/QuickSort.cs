//quickSort
	//while loop
		//pick random pivot (or middle index)
		//iterate through array forward and back using two pointers
			//swap elements smaller and larger than pivot

static int[] quickSort(int[] arr, int leftIndex, int rightIndex) {
	
	int pivotIndex = (int)Math.Floor((double)(leftIndex+rightIndex)/2);
	int newLeftIndex = leftIndex, newRightIndex = rightIndex;
	
	if (leftIndex >= rightIndex) {
		return arr;
	}
	
	while (newLeftIndex <= newRightIndex) {
		while (arr[newLeftIndex] < arr[pivotIndex]) {
			newLeftIndex++;
		}
		while (arr[newRightIndex] > arr[pivotIndex]) {
			newRightIndex--;
		}
		if (newLeftIndex <= newRightIndex) {
			int temp = arr[newLeftIndex];
			arr[newLeftIndex] = arr[newRightIndex];
			arr[newRightIndex] = temp;
			newLeftIndex++;
			newRightIndex--;
		}
	}
	
	/*
	Console.WriteLine("New Array: "+leftIndex+" "+rightIndex);
	foreach (var item in arr) {
		Console.Write(item.ToString() + " ");
	}
	Console.WriteLine("");
	*/
	
	arr = quickSort(arr, leftIndex, newLeftIndex-1);
	arr = quickSort(arr, newLeftIndex, rightIndex);
	
	return arr;
	
}

public static void Main() {
	int[] arr = new int[5]{2,5,10,4,3,6,1};

	int[] result = quickSort(arr, 0, arr.Length-1);

	for (int i=0; i<result.Length; i++) {
		Console.WriteLine(result[i]);
	}
}