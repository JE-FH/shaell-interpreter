using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProcessLib;

namespace ShaellLang;

public class CoProc : BaseValue
{
    private ExternalProgram _externalProgram;

    public IReadStream Out => _externalProgram.Out;
    public IReadStream Err => _externalProgram.Err;
    public IWriteStream In => _externalProgram.In;

    public CoProc(string filename, IEnumerable<IValue> arguments) 
        : base("coproc")
    {
        _externalProgram = new ExternalProgram(filename, arguments.Select(x => x.ToSString().Val));
    }

    public override bool IsEqual(IValue other)
    {
        return this == other;
    }

    public void Run()
    {
        _externalProgram.Start();
    }

    public async Task Wait()
    {
        await _externalProgram.Wait();
    }
    
    public override bool ToBool() => true;

}