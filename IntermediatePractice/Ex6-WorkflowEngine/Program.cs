using Ex6_WorkflowEngine;

var workFlow = new Workflow();

var act1 = new Cooking() { Description = "Fried Chicken with fries" };
var act2 = new Cleaning() { Description = "Wash clothes" };

workFlow.AddToList(act1);
workFlow.AddToList(act2);

Console.WriteLine(workFlow.Run());