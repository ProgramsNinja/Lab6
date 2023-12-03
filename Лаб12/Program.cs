using Лаб12;

class program
{
    static void Main()
    {
        var applicationHelpHandler = new ApplicationHelpHandler(null);
        var buttonHelpHandler = new ButtonHelpHandler(applicationHelpHandler);
        var intButtonHelpHandler = new IntButtonHelpHandler(buttonHelpHandler);
        var operationHelpHandler = new OperationButtonHelpHandler(buttonHelpHandler);

        Console.WriteLine(intButtonHelpHandler.HandleHelp(new HelpRequest('9')));
        Console.WriteLine(intButtonHelpHandler.HandleHelp(new HelpRequest('3')));
        Console.WriteLine(intButtonHelpHandler.HandleHelp(new HelpRequest('+')));
        Console.WriteLine(intButtonHelpHandler.HandleHelp(new HelpRequest('f')));
        Console.WriteLine(intButtonHelpHandler.HandleHelp(new HelpRequest('р')));
        Console.WriteLine(operationHelpHandler.HandleHelp(new HelpRequest('+')));
        Console.WriteLine(operationHelpHandler.HandleHelp(new HelpRequest('6')));

        Console.ReadLine();
    }
}