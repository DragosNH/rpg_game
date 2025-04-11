using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantasy_Rpg_game.Ressources
{
    internal class CharacterResource
    {
        private ResourceType resourceType { get; set; }
        private int currentRessource {  get; set; }
        
        public CharacterResource(ResourceType resourceType, int currentRessource) 
        {
            this.resourceType = resourceType;
            this.currentRessource = currentRessource;
        }

        public override string ToString() 
        {
            return $"{resourceType}: {currentRessource}";
        }
    }
}
