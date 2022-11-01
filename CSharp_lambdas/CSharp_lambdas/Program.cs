using CSharp_lambdas;

//Event way
Console.WriteLine("################### Old-way by event ###################\n");
MathServiceByEvent mathServEvent = new MathServiceByEvent();
mathServEvent.MathPerformed += OnMathPerformed;
mathServEvent.MultiplyNumbers(57.85, 783.76);

static void OnMathPerformed(object? sender, MathPerformedEventArgs e)
{
    Console.WriteLine("Calculation result from event: " + e.Result);
}

//Delegate as anonymous function
Console.WriteLine("\n################### Delegates ###################\n");
MathServiceByDelegate mathServiceByDelegate = new MathServiceByDelegate();
mathServiceByDelegate.MathPerformed += delegate (double result)
{
    Console.WriteLine("Calculation result with delegate as anonymous function:  " + result);
};

mathServiceByDelegate.MathPerformed += (result) =>
{
    Console.WriteLine("Calculation result anonymous even nicer:  " + result);
};
mathServiceByDelegate.MultiplyNumbers(57.85, 783.76);
mathServiceByDelegate.CalculateNumbers(57.85, 783.76, (value1, value2) =>
   value1 + value2
);

//If you use MathPerformedEventArgs on MathPerformed.
//mathServ.MathPerformed +=  (sender, e) =>
//{
//    Console.WriteLine("Calculation result:  " + e.Result);
//};

//Replace delegate with Func and Action
Console.WriteLine("\n################### Replace delegate with Func and Action ###################\n");
MathServiceByFuncAction mathServiceByFuncAction = new MathServiceByFuncAction();
mathServiceByFuncAction.MathPerformed += (result) =>
{
    Console.WriteLine("Calculation result from func/action:  " + result);
};
mathServiceByFuncAction.CalculateNumbers(57.85, 783.76, (value1, value2) =>
   value1 / value2
);
