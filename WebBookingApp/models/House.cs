using WebBookingApp.models;
namespace WebBookingApp.models;

public class House
{
    public int Id {get; set;}
    public int X {get; set;}
    public int Y {get; set;}
    public Booking[]? Bookings { get; set; }
    public bool IsActive {get; set;}
    public bool IsNotConfirmed {get; set;}
    public string? Name {get; set;}
    public string? Address {get; set;}
    public string? Desc {get; set;}
}