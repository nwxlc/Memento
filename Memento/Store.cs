namespace Memento;

public class Store
{
    private readonly List<IMemento> _mementos = new();
    
    public void Add(IMemento memento)
    {
        if (memento == null) 
        { 
            throw new ArgumentNullException(nameof(memento), "Недопустимое значение"); 
        }

        _mementos.Add(memento);
    }
        
    public IMemento Previous()
    {
        if (_mementos.Count > 0)
        {
            return _mementos[^1];
        }
        else
        {
            throw new InvalidOperationException("Список пуст");
        }
    }
}