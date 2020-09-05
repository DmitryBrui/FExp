#include "stdafx.h"
#include "Error.h"
#include "Parm.h"
#include "Log.h"
#include "In.h"

int _tmain(int argc, _TCHAR* argv[])
{
	setlocale(LC_ALL, "rus");
	Log::LOG log = Log::INITLOG;
	try
	{
		Parm::PARM parm = Parm::getparm(argc, argv);
		log = Log::getlog(parm.log);
		Log::WriteLog(log);
		Log::WriteParm(log, parm);
		In::IN in = In::getin(parm.in);
		Log::WriteIn(log, in);
		Log::WriteLine(log, (char*)"\n", "");
		//Log::FstCheck(log, in);
		Log::Close(log);
	}
	catch (Error::ERROR e)
	{
		if (log.stream)
		{
			Log::WriteError(log, e);
			Log::Close(log);
		}
		std::cout << "Ошибка " << e.id << ": " << e.message;
		if (e.inext.line > 0 || e.inext.col > 0) std::cout << ", строка " << e.inext.line << ", позиция " << e.inext.col;
	}
	return 0;
}