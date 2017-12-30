using Block.Interface;


namespace Block.Interface {

    public interface IBlock : IBlockBehavior, IBlockProperties {

        // Um welchen Block es sich handelt.
        BlockType blockType {get};

        // Gibt die Mobs zurück, welche der Block spawnen
        // lassen kann.
        Entity[] spawnableEntities {get};
        
        // Chunk, welchem der Block zugehört.
        Chunk owner {get, set};

        // Elternteil.
        GameObject parent {get, set};

        // Die Position des Blockes.
        Vector3 position {get, set};

        // Material des Blockes
        Material blockMaterial {get};

        // UVs des Blockes.
        Vector2[] blockUVs {get};

        // Block Identifikationsname
        string blockName {get};


        // Erstellt den Block
        void CreateQuad(Cubeside side);

        // Zeichnet den Block
        void Draw();

        // Überprüft, ob die anliegenden Blöcke
        // "solid" sind oder nicht.
        bool HasSolidNeighbour(Vector3 pos);

        // Stellt die Lifepoints des Blockes wieder
        // her und zeichnet den Block ohne Cracks.
        void Reset();

        // Gibt das Item zurück, welches nach Zerstörun
        // des Blockes gedropped wurde.
        Item GetDroppedItem();
   }
}