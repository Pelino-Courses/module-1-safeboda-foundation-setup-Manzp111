// using System.correction.Generics
// using SafeBoda.core 
namespace SafeBoda.Application

public interface ITripRepository
{
    IEnumerable GetActiveTrips();
    
}


// using System.Collections.Generic;
// using SafeBoda.Core; // Needed for Trip
//
// namespace SafeBoda.Application
// {
//     public interface ITripRepository
//     {
//         IEnumerable<Trip> GetActiveTrips();
//     }
// }
