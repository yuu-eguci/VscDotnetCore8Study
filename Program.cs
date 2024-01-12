namespace VscDotnetCore8Study;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your name?");
        // この文字列を name という変数に格納
        string? name = Console.ReadLine();
        DateTime currentDate = DateTime.Now;
        // NewLine は、プラットフォームに依存せず、言語に依存せずに、改行を表す方法です。 これは C# の \n と同じ
        Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}!");

        // デバッグの tips
        // - 文字列はデバッグのペインで編集できるし、
        // - 下の DEBUG CONSOLE で C# のコードを実行できる。こんな感じ↓で
        //     - currentDate = DateTime.Parse("2019-11-16T17:25:00Z").ToUniversalTime()

        Console.Write($"{Environment.NewLine}Press any key to exit...");
        // コンソール ウィンドウにプロンプトを表示し、Console.ReadKey(Boolean) メソッドを呼び出してユーザーによる入力を待つ
        Console.ReadKey(true);
    }
}
