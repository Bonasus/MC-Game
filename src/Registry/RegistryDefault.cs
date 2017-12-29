using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Registry.IRegistry;


namespace Registry.RegistryDefault {

    public class RegistryDefault<registerKey, registerValue> : IRegistry<registerKey, registerValue> {

        // Speichert die Einträge in einem Dictionary ab.
        Dictionary<registerKey, registerValue> registryObjects = new Dictionary<registerKey, registerValue>();

        // Standartwert für "registerValue"
        private registerValue defaultObject;


        public RegistryDefault(registerValue value) {
            defaultObject = value;
        }


        // Gibt die Daten des gegebenen Keys zurück.
        public registerValue GetObject(registerKey key) {
            registerValue value;
            if(!registryObjects.TryGetValue(key, out value)) {}; // ToDo: Fehlerausgabe

            return value == null ? defaultObject : value;       // ToDo: Testen
        }

        // Fügt ein Schlüssel-Wert-Paar der Registry hinzu.
        public void PutObject(registerKey key, registerValue value) {
            if(key != null && value != null) {
                if(registryObjects.ContainsKey(key)) {} // ToDo: Fehlerausgabe.
                registryObjects.Add(key, value);
            } // ToDo: Fehlerausgabe bei null.
        }

        // Gibt alle Schlüssel der Registry zurück.
        public registerKey[] GetKeys() {
            return registryObjects.Keys.ToArray();
        }

        // Gibt an, ob der gegebene Schlüssel in der Registry bereits vorhanden ist.
        public bool ContainsKey(registerKey key) {
            return registryObjects.ContainsKey(key);
        }

        // Gibt einen Iterator für die Registry zurück.
        public Dictionary<registerKey, registerValue>.Enumerator Iterator() {
            return registryObjects.GetEnumerator();
        }
    }
}