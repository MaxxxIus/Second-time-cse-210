public class Journal
{
    public List<Entry> _AMBentrys = new List<Entry>();

    public void DisplayEntrys()
    {
        foreach (Entry entry in _AMBentrys)
        {
            entry.Display();
            Console.WriteLine(" ");
        }
    }

    public void AddEntry(Entry entry)
    {
        _AMBentrys.Add(entry);
    }

    public List<string> ConvertToTXTFormat()
    {
        List<string> AMBtxtList = new List<string>();
        foreach (Entry entry in _AMBentrys)
        {
            string AMBtxt = entry.ToTxTFormat();
            AMBtxtList.Add(AMBtxt);
        }
        return AMBtxtList;
    }
}