using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsuranceClassLibrary
{
    public class DeveloperRepo
    {
        //private field for list of developers
        private readonly List<Developer> _developerDirectory = new List<Developer>();
        private int _currentId = 0;
        //Create
        public bool AddDeveloper(string name, bool hasPluralSight)
        {
            int startingDevCount = _developerDirectory.Count;
            Developer developorToAdd = new Developer()
            {
                HasPluralSight = hasPluralSight,
                Name = name,
                Id = _currentId
            };
            _currentId++;
            _developerDirectory.Add(developorToAdd);
            return _developerDirectory.Count > startingDevCount;
        }

        //Return
        public List<Developer> ReturnDevelopers()
        {
            return _developerDirectory;
        }
        //Update
        public bool UpdateDeveloper(int id, string name, bool hasPluralSight)
        {
            foreach (var dev in _developerDirectory)
            {
                if(dev.Id == id)
                {
                    dev.Name = name;
                    dev.HasPluralSight = hasPluralSight;
                    return true;
                }
            }
            return false;
        }
        //Delete
        public bool DeleteDeveloper(int id)
        {
            foreach (var dev in _developerDirectory)
            {
                if (dev.Id == id)
                {
                    _developerDirectory.Remove(dev);
                    return true;
                }
            }
            return false;
        }

    }
}
