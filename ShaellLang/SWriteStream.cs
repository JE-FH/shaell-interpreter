using System;
using ProcessLib;

namespace ShaellLang;

public class SWriteStream : BaseValue
{
    public IWriteStream WriteStream { get; }
    
    public SWriteStream(IWriteStream writeStream)
        : base("writestream")
    {
        WriteStream = writeStream;
    }

    public override bool IsEqual(IValue other)
    {
        return this == other;
    }

    public override SWriteStream ToSWriteStream()
    {
        return this;
    }
}