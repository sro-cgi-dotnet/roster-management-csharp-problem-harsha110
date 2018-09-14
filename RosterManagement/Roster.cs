using System;
using System.Linq;
using System.Collections.Generic;

namespace RosterManagement
{
    public class CodeSchool
    {
        Dictionary<int, List<string>> _roster;
        
        public CodeSchool()
        {
            _roster = new Dictionary<int, List<String>>();
        }
        
        /// <summary>
        /// Should be able to Add Student to a Particular Wave
        /// </summary>
        /// <param name="cadet">Refers to the name of the Cadet</param>
        /// <param name="wave">Refers to the Wave number</param>
        public void Add(string cadet, int wave)
        {
            if(_roster==null)
            {
                List<String> str2 = new List<String>();
                str2=list_names(cadet);
                _roster.Add(wave,str2);
            }
            else {
                

                    if(_roster.ContainsKey(wave))
                    {
                     _roster[wave].Add(cadet);
                    }
                    else{
                       List<String> str3 = new List<String>();
                str3.Add(cadet);
               _roster.Add(wave,str3);
                    }
                
            }
        }

        public List<string> list_names(string str)
        {
            List<string> s1 = new List<string>();
            s1.Add(str);
            return s1;
        }

        /// <summary>
        /// Returns all the Cadets in a given wave
        /// </summary>
        /// <param name="wave">Refers to the wave number from where cadet list is to be fetched</param>
        /// <returns>List of Cadet's Name</returns>
        public List<string> Grade(int wave)
        {
            var list = new List<string>();
            foreach(KeyValuePair<int,List<String>> d in _roster)
            {
                if(d.Key==wave)
                {
                    list=_roster[wave];
                    break;
                }
            }
            list.Sort();
          return list;
        }

        /// <summary>
        /// Return all the cadets in the CodeSchool
        /// </summary>
        /// <returns>List of Cadet's Name</returns>
        public List<string> Roster()
        {
            var cadets = new List<string>();
            var list1 = new List<int>();
            list1=_roster.Keys.ToList();
            list1.Sort();
            foreach(int i in list1)
            {
              _roster[i].Sort();
              foreach(string temp in _roster[i])
              {
                  cadets.Add(temp);
              }
            }
            return cadets;
        }
    }
}
