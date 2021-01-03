using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR
{
    partial class Genders
    {
        public override string ToString()
        {
            return this.Sex;
        }
    }

    partial class Statuses
    {
        public override string ToString()
        {
            return this.Status;
        }

    }

   
    partial class TypeContracts
    {
        public override string ToString()
        {

            return this.typeContract;
        }
    }
   


    partial class Positions
    {
        public override string ToString()
        {
            return this.WorkerPosition;
        }



    }

    partial class Worker
    {
        public override string ToString()
        {
            return this._Imie+_Nazwisko;
        }



    }
}
