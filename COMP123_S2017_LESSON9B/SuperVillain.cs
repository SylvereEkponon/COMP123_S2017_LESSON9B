using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name : Sylvere Ekponon
 * Date : July 13, 2017
 * Description : This is the SuperHero class which inherits from the SuperHuman class and implements the IHasMalice Interface
 * version: 0.1 - Created the SuperVillain class
 */

namespace COMP123_S2017_LESSON9B
{

    /// <summary>
    /// This is the SuperVillain class
    /// </summary>
    public class SuperVillain : SuperHuman,IHasMalice
    {
        //PRIVATE INSTANCE VARIABLES
        private int _malice;

        //PUBLIC PROPERTIES
        public int Malice
        {
            get
            {
                return this._malice;
            }
            set
            {
                this._malice = value;
            }
        }


        //CONSTRUCTORS

        public SuperVillain(string name, int malice) : base(name)
        {
            this.Malice = malice;
        }



    }
}
