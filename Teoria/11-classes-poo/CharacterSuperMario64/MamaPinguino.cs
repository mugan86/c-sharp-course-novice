using System;

namespace CharacterSuperMario64
{
    class MamaPinguino : Character
    {
        // Atributos => Name, Alias, Hero
        public MamaPinguino(): base("Mama Pingüino", true, "") {
            base.ShowDetails(); // Name, Hero, Alias
        }
        // Metodos => ShowDetails, Move
    }
}
