using System;
using System.Collections.Generic;
using System.Text;

namespace affectation_des_options
{
    class options
    {
		public string nomoption;
		public int opmaxplace;
		public int placedisponible;

		public options(string nomop, int maxinop)
		{
			this.nomoption = nomop;
			this.opmaxplace = maxinop;
			this.placedisponible = maxinop;
		}
	}
}
