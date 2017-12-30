namespace Block.Interface {

    protected interface IBlockFalling {

        // Gibt an, ob der Block gleich bei Platzierung
        // und, wenn der Block unten drunter zerstört wird,
        // fällt.
        // Bsp.: Sand.
        bool fallInstantly {get};


        // Wird im periodischen Abstand ausgeführt.
        void UpdateTick();

        // Checkt, ob der Block nun fallen kann.
        void CheckFallable();

        // Wird ausgeführt, wenn der Block zu fallen
        // beginnt.
        void OnStartFalling();

        // Wird ausgeführt, wenn der Block aufhört zu
        // fallen.
        void OnEndFalling();
    }
}