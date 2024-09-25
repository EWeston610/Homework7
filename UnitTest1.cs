//Eric Weston 9/24/2024 Homework 7

int[] arrayOf3 = new int[3];

Console.WriteLine("Enter three values: ");
for(int three = 0; three < 3; three++){
    arrayOf3[three] = int.Parse(Console.ReadLine());
}

Console.WriteLine($"Printed Array: {arrayFunctions.printFunction(arrayOf3)}");
Console.WriteLine($"Total: {arrayFunctions.addArray(arrayOf3)}");
Console.WriteLine($"Duplicated Array: {arrayFunctions.printFunction(arrayFunctions.duplicateEach(arrayOf3))}");

public class  arrayFunctions(){
    public static int[] duplicateEach(int[] duplicate){
        int[] dupArray = new int[duplicate.Length * 2];
        for(int x = 0; x < duplicate.Length; x++){
            dupArray[x * 2] = duplicate[x];
            dupArray[x * 2 + 1] = duplicate[x];
        }
        return dupArray;
    }

    public static int addArray(int[] addTogether){
        int total = 0;
        foreach(int place in addTogether){
            total += place;
        }
        return total;
    }

    public static string printFunction(int [] arrayToPrint){
        string printedArray = "";
        foreach(int point in arrayToPrint){
            printedArray += point + " ";
        }
        return printedArray;
    }
}




public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.Equal(arrayFunctions.duplicateEach([1,4,2]), [1,1,4,4,2,2]);
        Assert.Equal(arrayFunctions.duplicateEach([3,6,9,12]), [3,3,6,6,9,9,12,12]);
        Assert.Equal(7, arrayFunctions.addArray([1,4,2]));
        Assert.Equal(14, arrayFunctions.addArray([5,5,1,3]));
    }
}
