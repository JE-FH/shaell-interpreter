namespace ShaellLang;

public class RefValue : IValue
{
    private IValue _realValue;

    public RefValue(IValue val)
    {
        _realValue = val;
    }
    
    public void Set(IValue newValue)
    {
        _realValue = newValue;
    }

    public IValue Get()
    {
        if (_realValue is RefValue)
        {
            return _realValue;
        }
    }

    public IValue Unpack()
    {
        if (_realValue is RefValue realRefValue)
        {
            return realRefValue.Unpack();
        }
        else
        {
            return _realValue;
        }
    }

    public bool ToBool()
    {
        return _realValue.ToBool();
    }

    public Number ToNumber()
    {
        return _realValue.ToNumber();
    }

    public IFunction ToFunction()
    {
        return _realValue.ToFunction();
    }

    public SString ToSString()
    {
        return _realValue.ToSString();
    }

    public ITable ToTable()
    {
        return _realValue.ToTable();
    }
}