using Memento;

TextEditorMemento textEditor = new("Текст");
TextEditorMemento textEditor2 = new("Текст2");

TextEditor editor = new(textEditor);
TextEditor editor2 = new(textEditor2);

IMemento editorMemento = editor.CreateMemento();
IMemento editorMemento1 = editor2.CreateMemento();

Store store = new();
store.Add(editorMemento);
IMemento previousMemento = store.Previous();
store.Add(editorMemento1);

TextEditor restoredEditor = new(previousMemento);            
Console.WriteLine(restoredEditor.GetState());