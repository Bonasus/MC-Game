using System.Collections;
using System.Collections.Generic;
using Registry.RegistryDefault;
using utils.RegisterIDTable;


namespace Registry.RegistryNamespaced {

    public class RegistryNamespaced<registerKey, registerValue> : RegistryDefault<registerKey, registerValue> {

        // ID-Tabelle wird erstellt.
        private RegisterIDTable<registerKey, int> IDTable = new RegisterIDTable<registerKey, int>();


        public RegistryNamespaced(registerValue defaultObject) : base(defaultObject) {}


        // Registriert einen neuen Eintrag in der Registry.
        public void Register(registerKey key, registerValue value) {
            IDTable.Add(key);        // Schlüssel wird registriert. ToDo: Fehlerausgabe, wenn es nicht funktioniert.
            PutObject(key, value);   // Schlüssel wird mit Wert registriert.
        }

        // Fügt ein Schlüssel-Wert-Paar der Registry hinzu.
        public void PutObject(registerKey key, registerValue value) {
            base.PutObject(key, value);
        }

        // Gibt die Daten eines Blockes in einem Array aus.
        // Falls der Schlüssel nicht in der Registry hinterlegt ist, wird der Defaultvalue
        // zurück gegeben.
        public registerValue GetObject(registerKey key) {
            return base.GetObject(key);
        }

        // Gibt zurück, ob der gegebene Schlüssel in der Registry vorhanden ist oder nicht.
        public bool ContainsKey(registerKey key) {
            return base.ContainsKey(key);
        }

        // Erhalte die ID des Schlüssels.
        public int GetIDForKey(registerKey key) {
            return IDTable.GetID(key);
        }

        // Erhalte den Schlüssel für die ID.
        public registerKey GetKeyForID(int ID) {
            return IDTable.GetKey(ID);
        }

        // Gibt einen Iterator für die Registry zurück.
        public Dictionary<registerKey, registerValue>.Enumerator Iterator() {
            return base.Iterator();
        }
    }
}