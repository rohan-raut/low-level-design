namespace State
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DirectionService directionService = new DirectionService(new Bus());
            directionService.SetTransportationMode(new Car());
            directionService.GetETA();
            directionService.GetDirection();
        }
    }
}

/*
 * You are tasked with building a DirectionService class for a navigation app. The class calculates the estimated time of arrival (ETA) and provides
 * directions between two points. The ETA and direction differ based on the mode of transportation, which can be one of the following:
 * - Waliking
 * - Cycling
 * - Car
 * - Train
 * 
 * In the above problem, there would be too many if-else conditions based on the mode of transportation which violates the Open Closed Principle.
 * To solve this we will have a IState interface which will be implemented by concrete states.
 * 
 * The State pattern is similar to Strategy pattern, but the intent is different:
 * - In State pattern, every concrete state may be aware of other concrete states, but in Strategy Pattern concrete strategy almost never know 
 * about each other.
 * 
 * 
 * This pattern is used when the system has to deal with multiple states.
 * Eg: Document (Draft, ReadOnly, Published)
 * Button (Visible, Diabled, Hidden)
 * The buttons and switches in your smartphone behave differently depending on the current state of the device:
    When the phone is unlocked, pressing buttons leads to executing various functions.
    When the phone is locked, pressing any button leads to the unlock screen.
    When the phone’s charge is low, pressing any button shows the charging screen.
 * 
 * 
 */
