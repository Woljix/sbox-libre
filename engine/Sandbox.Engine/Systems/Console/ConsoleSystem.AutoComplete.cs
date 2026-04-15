using System;
using System.Collections.Generic;
using System.Text;

using Sandbox.Engine;

namespace Sandbox;

public static partial class ConsoleSystem
{
	public static ConCmdAttribute.AutoCompleteResult[] GetAutoComplete(string partial, int count)
	{
		return ConVarSystem.GetAutoComplete(partial, count);
	}
}
