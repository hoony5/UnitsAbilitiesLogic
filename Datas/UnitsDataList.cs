
public class UnitsDataList
{
    private readonly uint _unitsDataListCapacity = 64;
    private Dictionary<string, string> _unitsDataList;
    
    public UnitsDataList(List<RowData> rowDatas)
    {
        _unitsDataList = new Dictionary<string , string>((int)_unitsDataListCapacity);
    }
}
