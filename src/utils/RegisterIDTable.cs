using System.Collections;
using System.Collections.Generic;


namespace utils.RegisterIDTable {

    public class RegisterIDTable<registerKey, Integer> {

        // Registrierschlüssel und desen ID speichern und anders herum.
        // ToDo: Alternative finden, die vllt. performanter ist und weniger
        //       Speicher benötigt als die Nutzung zweier Dictionarys.
        Dictionary<registerKey, int> registerKeyIDPairs;
        Dictionary<int, registerKey> IDRegisterKeyPairs;

        
        public RegisterIDTable() {
            registerKeyIDPairs = new Dictionary<registerKey, int>();
            IDRegisterKeyPairs = new Dictionary<int, registerKey>();
        }
        

        // Fügt dem Dictionary einen neuen Eintrag hinzu.
        // Bedingung: Key darf nicht vorhanden und nicht null sein.
        public bool Add(registerKey key) {
            if(key != null && !registerKeyIDPairs.ContainsKey(key)) {
                int ID = key.GetHashCode();     // Generiert die ID des Schlüssel
                
                // Speichert den Schlüssel und die ID
                registerKeyIDPairs.Add(key, ID);
                IDRegisterKeyPairs.Add(ID, key);
                return true;
            }
            return false;
        }
    
        // Erhalte die ID des gegebenen Schlüssels.
        public int GetID(registerKey key) {
            int ID;
            
            if(!registerKeyIDPairs.ContainsKey(key))
                ID = -1;    //ToDo: Fehlerausgabe
            else
                registerKeyIDPairs.TryGetValue(key, out ID);
                
            return ID;
        }

        // Erhalte den Schlüssel der gegebenen ID.
        public registerKey GetKey(int ID) {
            registerKey key;

            if(!IDRegisterKeyPairs.ContainsKey(ID)) {} //ToDo: Fehlerausgabe
            
            IDRegisterKeyPairs.TryGetValue(ID, out key);
            return key;
        }

        // Tabelle löschen
        public void Clear() {
            registerKeyIDPairs.Clear();
            IDRegisterKeyPairs.Clear();
        }

        // Größe der aktuellen Tabelle erhalten.
        public int Size() {
            return registerKeyIDPairs.Count;
        }

        // Gibt einen Iterator für die Key-->ID Paare zurück.
        public Dictionary<registerKey, int>.Enumerator KeyIterator() {
            return registerKeyIDPairs.GetEnumerator();
        }

        // Gibt einen Iterator für die Key-->ID Paare zurück.
        public Dictionary<int, registerKey>.Enumerator IDIterator() {
            return IDRegisterKeyPairs.GetEnumerator();
        }
    }
}
