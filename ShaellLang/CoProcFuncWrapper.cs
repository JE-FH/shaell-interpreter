using System.Collections.Generic;

namespace ShaellLang;

public class CoProcFuncWrapper : BaseValue, IFunction
{
    private string _path;
    public CoProcFuncWrapper(string path) : base("coprocfuncwrapper")
    {
        _path = path;
    }

    public override bool IsEqual(IValue other)
    {
        return this == other;
    }

    public IValue Call(IEnumerable<IValue> args)
    {
        return new CoProc(_path, args);
    }
}