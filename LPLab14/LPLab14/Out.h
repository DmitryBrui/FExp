#pragma once
#include "Parm.h"

namespace Out
{
	struct OUT
	{
		wchar_t outfile[PARM_MAX_SIZE];
		std::ofstream* stream;
	};

	OUT getout(wchar_t outfile[]);
	void putout(OUT out);
	void WriteLine();
}