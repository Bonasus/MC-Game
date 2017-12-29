using System.Collections;
using System.Collections.Generic;
using Registry.RegistryNamespaced;


namespace Registry.RegistryNamespaceDefaulted {

    public class RegistryNamespaceDefaulted<registerKey, registerValue> : RegistryNamespaced<registerKey, registerValue> {

        // Schlüssel für den Standardwert
        private registerKey defaultKey;

        // Standardwert für die Registry, zurückgegeben anstelle von null.
        private registerValue defaultValue;


        public RegistryNamespaceDefaulted(registerKey defaultKey, registerValue defaultValue) : base(defaultValue) {
            defaultKey = defaultKey;        // Standardschlüssel wird gesetzt.
            defaultValue = defaultValue;    // Standardwert wird gesetzt.
        }


        // Registriert einen neuen Schlüssel-Wert-Paar.
        public void Register(registerKey key, registerValue value) {
            base.Register(key, value);
        }

        // Validiert den Schlüssel.
        public bool ValidateKey(registerKey key) {
            return key == null ? false : true;  // ToDo: Fehlerausgabe
        }

        // Erhalte die ID des Schlüssels, falls dieser vorhanden ist.
        // Ist dieser nicht vorhanden wird die ID des Standardschlüssels
        // zurück gegeben.
        public int GetIDForKey(registerKey key) {
            int ID = base.GetIDForKey(key);
            return ID == -1 ? base.GetIDForKey(defaultKey) : ID;
        }

        // Erhalte den Schlüssel für die ID.
        public registerKey GetKeyForID(int ID) {
            return base.GetKeyForID(ID); // ToDo: Fehlerabhandlung wie Funk. GetIDForKey
        }

        // Gibt die Daten eines Schlüssels in einem Array aus.
        // Falls keine Daten vorhanden sind wird die Standardwerte ausgegeben.
        public registerValue GetObject(registerKey key) {
            registerValue value = base.GetObject(key);
            return value == null ? defaultValue : value;    // ToDo: Fehlerausgabe
        }

        // Gibt einen Iterator für die Registry zurück.
        public Dictionary<registerKey, registerValue>.Enumerator Iterator() {
            return base.Iterator();
        }
    }
}