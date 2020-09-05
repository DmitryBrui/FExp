#include <fstream>
#include "stdafx.h"
#include "Error.h"
#include "In.h"
#include "Log.h"

namespace In
{
	IN getin(wchar_t infile[])
	{
		std::ifstream fin(infile);
		if (!fin.is_open()) throw ERROR_THROW(110);
		
		IN ri = {};
		unsigned char symb;

		fin.seekg(0, fin.end);
		int fileSize = fin.tellg();
		fin.seekg(0, fin.beg);

		int curCol  = 0,
			curLine = 0;

		if (fileSize)
		{
			curLine = 1; 
			curCol =  1;
		}


		if (fileSize < IN_MAX_LEN_TEXT) ri.text = new unsigned char[fileSize];
		else
		{
			ri.text = new unsigned char[IN_MAX_LEN_TEXT];
			std::cout << "\nВнимание, обьём исходного кода больше допустимого. Возможна потеря данных.\n";
		}
		ri.size  = 0;
		ri.ignor = 0;

		while (fin.tellg() < fileSize && ri.size < IN_MAX_LEN_TEXT)
		{
			symb = fin.get();

			switch (ri.code[(int)symb])
			{
				case ri.T:
					ri.text[ri.size] = symb;
					ri.size++;
					break;
				case ri.F:
					throw ERROR_THROW_IN(111, curLine, curCol);
					break;
				case ri.I:
					ri.ignor++; 
					break;
				default:
					ri.text[ri.size] = (char)ri.code[(int)symb];
					ri.size++;
					break;
			}

			if (symb == IN_CODE_ENDL)
			{
				curCol = 1;
				curLine++;
			}
			else curCol++;
		}
		ri.text[ri.size] = '\0';
		fin.close();
		ri.lines = curLine;
		return ri;
	}
}