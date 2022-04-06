using ProcessLib;

namespace ShaellLang;

public class SReadStream : BaseValue
{
    public IReadStream ReadStream { get; }

    public SReadStream(IReadStream readStream)
        : base("readstream")
    {
        ReadStream = readStream;
    }
    
    public override bool IsEqual(IValue other)
    {
        return this == other;
    }
    
    public override bool ToBool() => true;

    public override SReadStream ToSReadStream() => this;
}