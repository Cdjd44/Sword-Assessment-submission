// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Assessment;

InputFile inputFile = new InputFile();

Console.Write("Please Input path to file: ");
string filePath = Console.ReadLine();
string fileContents = inputFile.getFile(filePath);

Console.Write("Would you like the analysis to be case sensitive (true or false)? (Default is true): ");
string sensitivity = Console.ReadLine();

LetterCount letterCount = new LetterCount(fileContents);
List<KeyValuePair<string,int>> CharacterCounts = new List<KeyValuePair<string, int>>();

CaseSensitivity caseSensitivity = new CaseSensitivity(sensitivity);

CharacterCounts = letterCount.getCharacters(caseSensitivity.getValue());

int outputCounter = 0;

Console.WriteLine("Total Characters: " + letterCount.getTotalCharacters());
while (outputCounter < 10)
{
    Console.WriteLine(CharacterCounts[outputCounter].Key + "(" + CharacterCounts[outputCounter].Value + ")");
    outputCounter++;
}

