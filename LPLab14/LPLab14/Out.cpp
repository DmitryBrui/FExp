#include "Out.h"
#include "stdafx.h"
#include "Error.h"

namespace Out
{
	OUT getout(wchar_t outfile[])
	{
		OUT re = {};
		re.stream = new std::ofstream(outfile);
		wcscpy_s(re.outfile, outfile);

		if (!re.stream->is_open()) throw ERROR_THROW(112);

		return re;
	}
}