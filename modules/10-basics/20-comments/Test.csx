/* TODO: поправить пути поиска, чтобы не указывать относительный путь */
#load "../../../src/Init.csx"
#load "../../../src/RedirectOutput.csx"
#load "Exercise.csx"

using PowerAssert;

var output = capturedConsoleOutput.ToString().Trim();
Console.SetOut(originalStdOut);

PAssert.IsTrue(() => output == "");
