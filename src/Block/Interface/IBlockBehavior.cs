using using Block.Interface;


namespace Block.Interface : IBlockFalling {}
    
    protected interface IBlockBehavior {
        
        // Gibt an, ob der Block in irgend einer Weise aktiviert
        // werden kann.
        bool canActivate {get};

        // Gibt an, ob der Block zerstört werden kann.
        bool canBreak {get};

        // Gibt an, ob der Block brennen kann.
        bool canBearn {get};

        // Gibt an, wie stark die Resistenz des Blockes
        // gegenüber einer Explosion ist.
        float blockResitanceExplosion {get};

        // Gibt an, ob das Material des Blockes überschrieben
        // werden kann.
        // Bsp.: Schnee auf Gras.
        bool replacable {get};

        // Gibt an, ob der Block wachsen kann mit der Zeit.
        bool canGrow {get};
        
        // Gibt an, ob man durch den Block laufen kann oder nicht.
        bool isPassable {get};

        // Gibt an, mit welcher Wahrscheinlichkeit Items
        // von diesem Block gedropped werden können.
        float itemDropChance {get};

        // Gibt an, wie schnell/ langsam der Player auf dem
        // Block sich bewegt.
        float velocityOnBlock {get};

        // Gibt an, wie viel Schaden der Block bei
        // Kollision austeilt.
        byte damageOnCollision {get};

        // Gibt an, was die maximale Anzahl an Items
        // beim Drop-Vorgang ist.
        byte quantityDrop {get};


        // Funktion wird ausgeführt, wenn der Block
        // geadded wurde.
        void OnBlockAdded();

        // Funktion wird ausgeführt, wenn der Block
        // gesetzt wurde.
        void OnBlockPlaced();

        // Funktion wird ausgeführt, wenn der Block
        // aktiviert wurde.
        void OnBlockActivated();

        // Funktion wird ausgeführt, wenn der Block
        // ein Mob oder vergleichbares hinzugefügt
        // hat.
        void OnEntityAdded();

         // Lässt den Block um +1 wachsen.
        void Grow();

        // Managed den Schadenverlauf des Blockes.
        bool HitBlock();

        // Funktion wird ausgeführt, wenn der Spieler
        // oder Mob den Block berührt.
        void OnEntityCollidedWithBlock();
    }
}