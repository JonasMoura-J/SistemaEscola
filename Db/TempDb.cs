using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscola.Db
{
    sealed class SchoolTempDb
    {
        public static readonly SchoolTempDb Instanse = new SchoolTempDb();
        public int MyProperty { get; set; }

        private SchoolTempDb()
        {

        }
    }
}
