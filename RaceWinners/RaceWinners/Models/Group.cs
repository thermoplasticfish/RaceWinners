using System.Collections.Generic;

namespace RaceWinners.Models;

/// <summary>
/// A <b>model</b> that holds the race results for one group of runners (for example, one class).
/// </summary>
/// <remarks>
/// <para>
/// A model is a simple class whose main job is to <i>hold data</i>. It has properties,
/// but very little (or no) behavior. Models live in their own <c>Models</c> folder and
/// namespace so they are easy to find and can be shared by the rest of the program.
/// </para>
/// <para>
/// Example: a group named "Class A" whose <see cref="Ranks"/> are <c>[4, 9, 11]</c> had
/// three runners, who finished 4th, 9th, and 11th in the <i>whole</i> race.
/// </para>
/// </remarks>
public class Group
{
    /// <summary>
    /// The display name of the group, such as <c>"Class A"</c>.
    /// </summary>
    /// <remarks>
    /// It starts as an empty string (<c>""</c>) instead of <c>null</c> so the program never
    /// crashes when it tries to print a name that was never set.
    /// </remarks>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// The overall finishing place of every runner in this group.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Each number is a runner's place in the <i>entire</i> race, not their place within
    /// this group. If <c>Ranks[0]</c> is <c>4</c>, then the first runner listed for this
    /// group crossed the finish line 4th out of everyone.
    /// </para>
    /// <para>
    /// Lower numbers are better (1st place is the winner). Different groups may have a
    /// different number of runners, so think about how that affects fairness!
    /// </para>
    /// </remarks>
    public List<int> Ranks { get; set; } = new List<int>();
    
    public double TotalPoints { get; set; }
    public double AveragePoints { get; set; }
}
