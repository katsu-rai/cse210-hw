using System;

public class WritingAssignment : Assignment {
    private string _title;

    public WritingAssignment () : base() {
        _title = "Unknown";
    }
    public WritingAssignment (string name, string topic, string title) : base(name, topic) {
        _title = title;
    }
    public string GetTitle() {
        return _title;
    }
}