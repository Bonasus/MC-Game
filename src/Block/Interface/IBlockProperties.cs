namespace Block.Interface {
    
    protected interface IBlockProperties {

        // Gibt an, ob der Block durchsichtig ist.
        bool isTranslucent {get};

        // Gibt an, ob der Block flüssig ist.
        bool isLiquid {get};
        
        // Gibt an, ob der Block ohne bestimmte Tool(s)
        // zerstört werden kann.
        bool requiresNoTool {get};

        // Gibt an, ob der Block ein ganzer 1*1 unit Block
        // ist oder nicht.
        bool isFullBlock {get};

        // Gibt an, ob der Block Mobs spawnen kann.
        bool isSpawner {get};

        // Gibt an, ob es Statistiken für diesen Block
        // gibt und wenn ja, diese dann aktiviert werden.
        bool enableStats {get};

        // Gibt an, ob dieser Block sich in einer zufälligen
        // weiter "entwickelt".
        bool needsRandomTicks {get};

        // Block durchlässig?
        // Beispiel:
        // Grasblock: True, Wasser: False
        bool isSolid {get};

        // Gibt an, ob der Spieler im Block spawnen kann.
        // Bsp.: Bett
        bool canSpawnInBlock {get};

        // Gibt die Tickrate des Blockes an.
        // Bsp.: Ein Block braucht x Ticks zum wachsen.
        int tickRate {get};

        // Gibt an, ob der Block Schaden austeilt.
        bool makeDamage {get};

        // Anzahl an Schläge, bis der Block zerstört
        // ist.
        byte lifePoints {get};

        // Aktuelle Anzahl an Schlägen, welche benötigt
        // werden, dass der Block zerstört wird.
        byte currentLifePoints {get, set};
    }
}