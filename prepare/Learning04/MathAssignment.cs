using System;

public class MathAssignment : Assignment {
    private string _textbookSection;
    private string _problems;

    public MathAssignment () : base() {
        _textbookSection = "Unknown";
        _problems = "Unknown";
    }
    public MathAssignment (string name, string topic, string textbook, string problems) : base(name, topic) {
        _textbookSection = textbook;
        _problems = problems;
    }
    public string GetHomeworkList () {
        return $"Section {_textbookSection} - Problems {_problems}";
    }
}