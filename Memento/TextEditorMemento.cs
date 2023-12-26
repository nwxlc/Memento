namespace Memento;

public class TextEditotMemento : IMemento
{
    private string _text;
    private DateTime _date;

    public TextEditorMemento(string text)
    {
        _text = text;
        _date = DateTime.Now;
    }

    public string GetState()
    {
        return _text;
    }

    public DateTime GetDate() 
    {
        return _date;
    }
}