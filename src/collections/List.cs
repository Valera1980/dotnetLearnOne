using System.Collections.Generic;
using System.Runtime.InteropServices;

public class ListWorking
{
    private bool _isDefault = false;
    private List<int> _list;
    public ListWorking([Optional] List<int> list)
    {
        if (list == null)
        {
            this._list = new List<int> { 1, 2, 3, 4, 5 };
        }
        else
        {
            this._list = list;
        }
    }
    public void print()
    {
        System.Console.WriteLine("=== LIST ===");
        if (_isDefault == true)
        {
            System.Console.WriteLine("=== use default ===");
            _loop();
            return;
        }
        _loop();
    }
    private void _loop()
    {
        foreach (int i in _list)
        {
            System.Console.WriteLine($"item = {i}");
        }
    }
    public void addNewToCollection(int p)
    {
       this._list.Add(p);
    }
}