namespace Registry.IRegistry {

    public interface IRegistry<registerKey, registerValue> {

        // Gibt die Daten des gegebenen Keys zurück.
        registerValue GetObject(registerKey key);

        // Fügt ein Schlüssel-Wert-Paar der Registry hinzu.
        void PutObject(registerKey key, registerValue value);

        // Gibt alle Schlüssel der Registry zurück.
        registerKey[] GetKeys();
    }

}
