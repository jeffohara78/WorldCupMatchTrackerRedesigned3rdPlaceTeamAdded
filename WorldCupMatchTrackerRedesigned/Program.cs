/* Jeff O'Hara
 * 6/24/2026
 * 
 * This app is a redesigned version of the World Cup Match Tracker. It allows users to track and manage World Cup matches, 
 * including scores, teams, and match details. The app provides a user-friendly interface for easy navigation and interaction.
 */

/* 1500 hrs
 * 7/20/2026
 * 
 * The redesigned World Cup Match Tracker app includes the following features:
 * - Add, edit, and delete matches
 * - View match details and scores
 * - Filter matches by stage (group or knockout)
 * - Display match winners and scores
 * - User-friendly interface for easy navigation
 */

/* 1500 hrs
 * 7/21/2026
 * 
 * Added in functionality to add 3rd place match (which was missing in the original version) and display the winner of that match in the dashboard,
 * and, further use that match to calculate other statistics from the tournament, such as the total number of goals scored in the tournament, 
 * the average number of goals per match, and the total number of matches played in the tournament.
 */

namespace WorldCupMatchTrackerRedesigned;

internal class Program
{
    static void Main(string[] args)
    {
        AppManager app = new AppManager();
        app.Run();
    }
}