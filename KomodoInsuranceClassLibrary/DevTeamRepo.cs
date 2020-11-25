using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsuranceClassLibrary
{
    public class DevTeamRepo
    {
        //private list of teams
        private List<DevTeam> _teamDirectory = new List<DevTeam>();
        private int _currentDevId = 0;
        //Create
        public bool CreateTeam(string name, List<Developer> devsOnTeam)
        {
            int startingNumberOfTeams = _teamDirectory.Count;
            DevTeam teamToAdd = new DevTeam()
            {
                Name = name,
                Developers = devsOnTeam,
                Id = _currentDevId
            };
            _currentDevId++;
            _teamDirectory.Add(teamToAdd);
            return _teamDirectory.Count > startingNumberOfTeams;

        }
        //Return
        public List<DevTeam> ReturnTeams()
        {
            return _teamDirectory;
        }
        //Update

        public bool UpdateTeam()
        {

        }

        //Delete
        public bool DeleteTeam(int id)
        {
            foreach (var team in _teamDirectory)
            {
                if(id==team.Id)
                {
                    _teamDirectory.Remove(team);
                    return true;
                }
            }
            return false;
        }
    }
}
