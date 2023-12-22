using Interview;

int[] array = new[] { 4, 5, 1, 2, 9, 19 };

FirstTask.Run(array);
Console.WriteLine(string.Join(',', array));

//FifthTask
var closedList = FifthTask.CreateClosedList(10);
var fifthTaskResult = FifthTask.Run(closedList);
Console.WriteLine(fifthTaskResult ? "closed" : "not closed");
var notClosedList = FifthTask.CreateNotClosedList(10);
fifthTaskResult = FifthTask.Run(notClosedList);
Console.WriteLine(fifthTaskResult ? "closed" : "not closed");


var deviation = ThirdTask.Run(new List<int>() { 1, 4, 7, 2, 6 });
Console.WriteLine($"deviation = {deviation}");

SecondTask.Run();








