public static int binarySearch(int[] arr, int num) {
	//set initial left index to 0 and right index to arr.Length (NOT length-1)
	//iterative, for loop
		//take pivot between left and right index
		//compare arr[pivot] with numFind
			//if >, shift leftIndex to pivot
			//if <, shift rightIndex to pivot
	int pivot = (int)((arr.Length-1)/2);
	int leftIndex = 0, rightIndex = arr.Length; 
		//not arr.Length-1 because Math.Round rounds DOWN
	int lookedTimes = 0;
	
	while (num != arr[pivot] && lookedTimes < arr.Length) {
		Console.WriteLine("Checking " + leftIndex + ":" + rightIndex);
		Console.WriteLine("Pivot " + pivot);
		if (num > arr[pivot]) {
			leftIndex = pivot;
		}
		else if (num < arr[pivot]) {
			rightIndex = pivot;
		}
		pivot = (int)Math.Floor((double)((leftIndex+rightIndex)/2));
		lookedTimes++;
	}
	
	if (lookedTimes >= arr.Length) {
		Console.WriteLine("Cannot Find index");
	}
	else {
		Console.WriteLine("Found at index " + pivot);
	}

	return pivot;
}

public static void Main() {
	int[] arr = new int[7]{1, 2, 4, 8, 22, 33, 100};
	int num = 4;
	int indexFound = binarySearch(arr, num);
}