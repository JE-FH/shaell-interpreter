using System.Collections.Generic;
using System.Collections;

namespace ShaellLang
{
	public interface IValue
	{
		bool ToBool();

		Number ToNumber();

		IFunction ToFunction();

		SString ToSString();

		ITable ToTable();
		
		SReadStream ToSReadStream();
		
		SWriteStream ToSWriteStream();

		bool IsEqual(IValue other);

		string GetTypeName();

		IValue Unpack();
	}
}