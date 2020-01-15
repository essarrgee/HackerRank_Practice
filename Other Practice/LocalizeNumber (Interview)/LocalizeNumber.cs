using System;
					
public class Program
{
	//NOTE: I rewrote the code since I couldn't get it back from
	//coderpad before it closed.
	//A problem I noticed with the old code was that the commas
	//would get misplaced past the first comma, so I fixed that here
	//too.
	
	//convert input number to string 'numString'
	//create variable 'decimalIndex' that stores index of decimal
		//iterate through numString to find index
		//default to numString.Length so if decimal doesn't exist don't change
		//replace char at decimalIndex with decimalChar
	//iterate numString backwards starting from decimalIndex
		//for every 3rd index, insert a commaChar

	static string localizeNumber(double number, string style) {

		string numString = number.ToString();
		int decimalIndex = numString.Length;
		string commaChar = ",";
		char decimalChar = '.';
		switch (style) {
			case "en-en":
				break;
			case "de-de":
				commaChar = " ";
				break;
			case "es-es":
				commaChar = ".";
				decimalChar = ',';
				break;
			default:
				break;
		}

		for (int i=0; i<numString.Length; i++) {
			if (numString[i] == '.') {
				char[] newString = numString.ToCharArray();
				newString[i] = decimalChar;
				numString = new string(newString);
				decimalIndex = i;
			}
		}

		int digitCount = 0;
		int commaCount = 0;

		for (int i=decimalIndex; i>=-1; i--) {
			digitCount++;
			if ((digitCount%4) == 0) {
				//insert new comma for every 3rd index
				numString = numString.Insert(i+commaCount, commaChar);
				commaCount++; //add one to commaCount to account for increased numString length
			}
		}

		return numString;
		
	}

	public static void Main() {
		string[] input = Console.ReadLine().Split(' ');
		double number = Convert.ToDouble(input[0]);
		string style = input[1];
		Console.WriteLine(localizeNumber(number, style));
	}
}
