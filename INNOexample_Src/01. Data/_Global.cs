using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _INNO;
using _INNO._Pattern;
using _INNO._Lang;

namespace INNOexample
{
    public class _Global : InnoSingletonAbstract<_Global>
    {
        public InnoLangCsv _Lang = null;

        private _Global()
        {
            _Lang = new InnoLangCsv();
        }

        public void Init()
        {

        }

        public void Deinit()
        {

        }
    }
}
