﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name : Sylvere Ekponon
 * Date : July 11, 2017
 * Description : This is the Abstract Human class
 * version: 0.1 - Created the Abstract Human class
 */

namespace COMP123_S2017_LESSON9B
{
    /// <summary>
    /// This is the Abstract Human Class
    /// </summary>
    public abstract class Human
    {
        //PRIVATE INSTANCE VARIABLE (FIELDS)
        private string _name;

        //PUBLIC PROPERTIES
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }

        //CONSTRUCTORS-----------------------------------------------------
        /// <summary>
        /// This is the main constructor for the Human
        /// It takes on parameter - name(string)
        /// </summary>
        /// <param name="name"></param>
        public Human(string name)
        {
            this.Name = name;
        }

        //PRIVATE METHODS

        //PUBLIC METHODS
    }
}
