using System;

public class Cancelation 
{
    private Customer _name;
    private Booking _reservation;
    public Cancelation (Customer customer, Booking reservation)
    {
        _name = customer;
        _reservation = reservation;
    }
    public void DeleteFromDatabase () 
    {
        
    }
}