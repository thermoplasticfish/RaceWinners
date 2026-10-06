using System;
using System.Linq;
using System.Threading.Tasks;

namespace RaceWinners;

/// <summary>
/// The starting point of the application.
/// </summary>
public class Program
{
    /// <summary>
    /// The first method that runs when the program starts.
    /// </summary>
    /// <remarks>
    /// <para>
    /// <c>Main</c> is marked <c>async Task</c> so that it can <c>await</c> other async
    /// methods, such as <see cref="DataService.GetGroupRanksAsync"/>.
    /// </para>
    /// <para>
    /// Notice that <c>Main</c> does not know <i>where</i> the race data comes from. It asks
    /// its dependency, the <see cref="DataService"/>, for the data and then works with
    /// whatever comes back.
    /// </para>
    /// </remarks>
    /// <param name="args">Command-line arguments (not used by this program).</param>
    static async Task Main(string[] args)
    {
        // Create the service this program depends on.
        DataService dataService = new DataService();

        // Ask the service for the data. "await" pauses here until the data is ready.
        var groups = await dataService.GetGroupRanksAsync();

        // Print each group and its runners' overall finishing places.
        foreach (var group in groups)
        {
            // string.Join glues the numbers together with ", " between them.
            var ranks = string.Join(", ", group.Ranks);

            Console.WriteLine($"{group.Name} - [{ranks}]");
        }
        
        // YOUR TURN: Rank each group from first to last place.
        // Decide what "fair" means before you start writing code!
    }
}
