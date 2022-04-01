﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    [Serializable]
    [DataContract]
    internal class Publisher :ICloneable
    {
        [DataMember]
        public string _name { get; set; }
        [DataMember]
        public string _country { get; set; }
        [DataMember]
        public string _city { get; set; }

        [DataMember] private int _foundationYear { get; set; }

        [DataMember] private Type _type { get; set; }

        public enum Type
        {
            state,privat
        }

        public int PubType
        {
            get
            {
                switch (_type)
                {
                    case Type.state: return 0;
                    case Type.privat: return 1;
                }

                throw new Exception("wrong PubType");
            }
            set
            {
                switch (value)
                {
                    case 0: _type = Type.state;
                        break;
                    case 1: _type = Type.privat;
                        break;
                }
            }
        }

        public int FoundationYear
        {
            get { return _foundationYear; }
            set
            {
                if (value < DateTime.Now.Year && value > 0)
                {
                    _foundationYear = value;
                }
                else
                {
                    throw new Exception("Publisher:Wrong foundation year");
                }

            }
        }

        public Publisher(string name, string country, string city, int year, int type)
        {
            _name = name;
            _country = country;
            _city = city;
            FoundationYear = year;
            switch (type)
            {
                case 0: _type = Type.state; break;
                case 1: _type = Type.privat; break;
            }
        }

        public Publisher()
        {
        }


        public object Clone() => new Publisher(_name, _country, _city, FoundationYear, PubType);

    }
}
