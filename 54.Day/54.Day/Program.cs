using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _54.Day
{
    class Program
    {
        static void Main(string[] args)
        {
			string[] input = { "fg.r.u.uzj+o.pw@kziczvh.com","r.cyo.g+d.h+b.ja@tgsg.z.com","fg.r.u.uzj+o.f.d@kziczvh.com","r.cyo.g+ng.r.iq@tgsg.z.com","fg.r.u.uzj+lp.k@kziczvh.com","r.cyo.g+n.h.e+n.g@tgsg.z.com","fg.r.u.uzj+k+p.j@kziczvh.com","fg.r.u.uzj+w.y+b@kziczvh.com","r.cyo.g+x+d.c+f.t@tgsg.z.com","r.cyo.g+x+t.y.l.i@tgsg.z.com","r.cyo.g+brxxi@tgsg.z.com","r.cyo.g+z+dr.k.u@tgsg.z.com","r.cyo.g+d+l.c.n+g@tgsg.z.com","fg.r.u.uzj+vq.o@kziczvh.com","fg.r.u.uzj+uzq@kziczvh.com","fg.r.u.uzj+mvz@kziczvh.com","fg.r.u.uzj+taj@kziczvh.com","fg.r.u.uzj+fek@kziczvh.com" };

			Console.WriteLine(NumUniqueEmails(input));
		}

		static int NumUniqueEmails(string[] emails)
		{

			StringBuilder add = new StringBuilder();
			List<string> output = new List<string>();

			for (int P = 0; P < emails.Length; P++)
			{

				bool wasAt = false;
				bool wasPlus = false;

				for (int O = 0; O < emails[P].Length; O++)
				{
					if (emails[P][O] == '@')
					{
						wasAt = true;
					}

					if (emails[P][O] == '+')
					{
						wasPlus = true;
					}

					if (!wasPlus || wasAt)
					{
						if (emails[P][O] != '.' || wasAt)
						{
							add.Append(emails[P][O]);
						}

					}
				}
				

				if (output.Count == 0)
                {
					output.Add(add.ToString());
				}

				bool wasThere = false;

				for (int C = 0; C < output.Count; C++)
				{

					if (output[C] == add.ToString())
                    {
						wasThere = true;
					}
				}

				if (!wasThere)
                {
					output.Add(add.ToString());
				}

				add.Clear();

			}
			return output.Count;
		}
	}
}
