public static int binarySearch(int[] arr, int num) {
	//array must be sorted
	//get middle index of array
	//compare num to value at middle index
		//if greater, get middle index between current middle 
			//index and last index
		//if less, get middle index between first index and
			//current middle index
		//repeat process recursively
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